using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo.DAL
{    
    public class DbManagerBase : IDisposable
    {                
        // Управление коннектом
        private bool _isOuterManager = false;

        public DbManagerBase()
            : this(true)
        {

        }

        public DbManagerBase(bool useOuterConnection)
        {
            if (ConnectionsStack.Count == 0 || !useOuterConnection)
            {
                _isOuterManager = true;
                var conn = new DataConnection();
                
                ConnectionsStack.Push(conn);
            }
            else
            {
                _isOuterManager = false;
            }
        }

        public void Dispose()
        {
            if (_isOuterManager && ConnectionsStack.Count > 0)
            {
                var connection = ConnectionsStack.Pop();
                connection.Dispose();                
            }
        }

        [ThreadStatic] // В каждом потоке свой набор коннектов
        private static Stack<DataConnection> _connectionsStack;

        // Поскольку _connectionsStack имеет атрибут ThreadStatic, нам необходима логика ручной инициализации
        private Stack<DataConnection> ConnectionsStack
        {
            get
            {
                // не используем синхронизацию, т.к. _connectionsStack локален для каждого потока, и многопоточный доступ к ней отсутствует
                if (_connectionsStack == null)
                    _connectionsStack = new Stack<DataConnection>();

                return _connectionsStack;
            }
        }

        private DataConnection Connection
        {
            get { return ConnectionsStack.Peek(); }
        }

        // Управление транзакциями
        private bool _isOuterTransaction = false;
        private bool _isTransactionAborted = false;

        public void BeginTransaction()
        {
            ThrowIfTransactionAborded(_isTransactionAborted);

            if (Connection.Transaction == null)
            {
                _isOuterTransaction = true;
                _isTransactionAborted = false;
                Connection.BeginTransaction();
            }
        }

        public void BeginTransaction(IsolationLevel level)
        {
            ThrowIfTransactionAborded(_isTransactionAborted);

            if (Connection.Transaction == null)
            {
                _isOuterTransaction = true;
                _isTransactionAborted = false;
                Connection.BeginTransaction(level);
            }
        }

        public void CommitTransaction()
        {
            bool wasAborted = _isTransactionAborted;

            if (_isOuterTransaction)
            {
                try
                {
                    if (_isTransactionAborted)
                        Connection.RollbackTransaction();
                    else
                        Connection.CommitTransaction();
                }
                finally
                {
                    CleanupTransactionState();
                }
            }

            ThrowIfTransactionAborded(wasAborted);
        }

        public void RollbackTransaction()
        {
            if (_isOuterTransaction)
            {
                try
                {
                    Connection.RollbackTransaction();
                }
                finally
                {
                    CleanupTransactionState();
                }
            }
            else
            {
                _isTransactionAborted = true;
            }
        }

        private void CleanupTransactionState()
        {
            _isOuterTransaction = false;
            _isTransactionAborted = false;
        }

        private void ThrowIfTransactionAborded(bool aborted)
        {
            if (aborted)
                throw new Exception("Transaction was aborted");
        }
        
        // Методы для доступа к даным
        public ITable<T> GetTable<T>() where T : class
        {
            return Connection.GetTable<T>();
        }

        public int Execute(string sql)
        {
            return Connection.Execute(sql);
        }

        public DataReader ExecuteReader(string sql)
        {
            return Connection.ExecuteReader(sql);
        }
        
        public BulkCopyRowsCopied BulkCopy<T>(BulkCopyOptions options, IEnumerable<T> source)
        {
            return Connection.BulkCopy(options, source);
        }

        public BulkCopyRowsCopied BulkCopy<T>(IEnumerable<T> source)
        {
            return Connection.BulkCopy(source);
        }        
    }
}
