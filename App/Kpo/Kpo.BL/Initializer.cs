using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo.BL;

namespace Kpo.BL
{
    public static class Initializer
    {
        public static void Init()
        {
            //TODO: выполняешь инициализацию которую тебе надо сделать в момент запуска приложения
            ConfigDataProvider();
        }

        //Инициализация провайдера БД MySql
        private static void ConfigDataProvider()
        {
            DataConnection.AddDataProvider("DP", new LinqToDB.DataProvider.MySql.MySqlDataProvider());
        }
    }
}
