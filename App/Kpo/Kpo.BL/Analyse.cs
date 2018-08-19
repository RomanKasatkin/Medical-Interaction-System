using Kpo.Dal;
using Kpo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using Kpo.BL.Filter;

namespace Kpo.BL
{
    public class Analyse
    {

        private IQueryable<AnalyseModel> MakeSelect(MainDb db)
        {
            var query = from analyse in db.Analyse
                        select new AnalyseModel
                        {
                            Id = analyse.Id,
                            Type_Id = analyse.Type_Id,
                            Result = analyse.Result,
                            Client_Id = analyse.Client_Id,
                            Coment = analyse.Coment,
                            Date_Id = analyse.Date_Id
                            
                        };

            return query;
        }
        public long Add(AnalyseModel model)
        {
            //TODO: валидация модели 

            //Сохранение 
            using (var db = new MainDb())
            {
                long id = Convert.ToInt64(db.Analyse.InsertWithIdentity(() => new Kpo.Dal.MainDb.AnalyseDataModel
                {


                    Type_Id = model.Type_Id,
                    Result = model.Result,
                    Client_Id = model.Client_Id,
                    Coment = model.Coment,
                    Date_Id = model.Date_Id
                }));

                return id;
            }
        }

        public List<AnalyseModel> List()
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                return query.ToList();
            }
        }

        public AnalyseModel Get_Item(string field, string value, ConditionType type)
        {
            FilterCondition filter = new FilterCondition(field, value, type);
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);

                if (filter != null)
                {           
                    
                    if (filter.Field.Equals("ID", StringComparison.CurrentCultureIgnoreCase) && filter.Value != null)
                    {
                        if (filter.Type == ConditionType.Equal)
                        {
                            query = query.Where(q => q.Id.Equals(filter.Value));
                        }

                    }
                    
                }
                AnalyseModel Result = new AnalyseModel();
                try
                {
                    Result = query.Single();
                    return Result;
                }
                catch
                {
                    return null;
                }


            }
        }

        public List<AnalyseModel> List(List<FilterCondition> filters)
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);

                if (filters != null)
                {
                    foreach (var item in filters)
                    {
                        if (item.Field.Equals("Client_Id", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
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
    }
}
