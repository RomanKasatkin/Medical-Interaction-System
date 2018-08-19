using Kpo.BL.Filter;
using Kpo.Dal;
using Kpo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;

namespace Kpo.BL
{
    public class Proc
    {
        private IQueryable<ProcModel> MakeSelect(MainDb db)
        {
            var query = from proc in db.Proc
                        select new ProcModel
                        {
                            Id = proc.Id,
                            Date_Id = proc.Date_Id,
                            Personal_Id = proc.Personal_Id,
                            Proc_Type_Id = proc.Proc_Type_Id,
                            Client_Id = proc.Client_Id

                        };

            return query;
        }

        /// <summary>
        /// Получить список всех процедуры
        /// </summary>
        /// <returns></returns>
        public List<ProcModel> List()
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                return query.ToList();
            }
        }

        public long Add(ProcModel model)
        {
            //TODO: валидация модели 

            //Сохранение 
            using (var db = new MainDb())
            {
                long id = Convert.ToInt64(db.Proc.InsertWithIdentity(() => new Kpo.Dal.MainDb.ProcDataModel
                {
                    Client_Id=model.Client_Id,
                    Proc_Type_Id=model.Proc_Type_Id,
                    Personal_Id = model.Personal_Id,
                    Date_Id = model.Date_Id                    
                }));

                return id;
            }
        }

        /// <summary>
        /// Получить список процедур по фильтру
        /// </summary>
        /// <param name="filters"></param>
        /// <returns></returns>
        public List<ProcModel> List(List<FilterCondition> filters)
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);

                if (filters != null)
                {
                    foreach (var item in filters)
                    {
                        if (item.Field.Equals("Id", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Id.Equals(item.Value));
                            }
                           
                        }
                        if (item.Field.Equals("Personal_Id", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Personal_Id.Equals(item.Value));
                            }
                        }
                        if (item.Field.Equals("Date_Id", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Date_Id.Equals(item.Value));
                            }

                        }
                        if (item.Field.Equals("Proc_Type_Id", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Proc_Type_Id.Equals(item.Value));
                            }

                        }
                        if (item.Field.Equals("Proc_Client_Id", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Client_Id.Equals(item.Value));
                            }

                        }
                    }
                }

                return query.ToList();
            }
        }

        /// <summary>
        /// Получить элемент по заданным параметрам
        /// </summary>
        /// <returns></returns>

        public ProcModel Get_Item(string field, string value, ConditionType type)
        {
            FilterCondition filter = new FilterCondition(field, value, type);
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                if (filter != null)
                {

                    if (filter.Field.Equals("Id", StringComparison.CurrentCultureIgnoreCase) && filter.Value != null)
                    {
                        if (filter.Type == ConditionType.Equal)
                        {
                            query = query.Where(q => q.Id.Equals(filter.Value));
                        }

                    }
                    if (filter.Field.Equals("Date_Id", StringComparison.CurrentCultureIgnoreCase) && filter.Value != null)
                    {
                        if (filter.Type == ConditionType.Equal)
                        {
                            query = query.Where(q => q.Date_Id.Equals(filter.Value));
                        }
                    }
                    if (filter.Field.Equals("Personal_Id", StringComparison.CurrentCultureIgnoreCase) && filter.Value != null)
                    {
                        if (filter.Type == ConditionType.Equal)
                        {
                            query = query.Where(q => q.Personal_Id.Equals(filter.Value));
                        }
                    }
                }
                ProcModel Result = new ProcModel();
                try
                {
                    Result = query.Single();
                    return Result;
                }
                catch
                {
                    ProcModel NullResult = new ProcModel();
                    NullResult.Id = 0;
                    NullResult.Date_Id = 0;
                    NullResult.Personal_Id = 0;
                    NullResult.Client_Id = 0;
                    NullResult.Client_Id = 0;
                    return NullResult;
                }
            }
        }

        /// <summary>
        /// Удалить процедуру
        /// </summary>
        /// <param name="filters"></param>
        /// <returns></returns>
        public void Delete(long id)
        {
            using (var db = new MainDb())
            {
                db.Proc.Delete(q => q.Id == id);
            }
        }
    }
}
