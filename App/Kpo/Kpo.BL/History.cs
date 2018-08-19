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
    public class History
    {
        private IQueryable<HistoryModel> MakeSelect(MainDb db)
        {
            var query = from history in db.History
                        select new HistoryModel
                        {
                            Id = history.Id,
                            Date_Id= history.Date_Id,
                            Personal_Id = history.Personal_Id,
                            Client_Id = history.Client_Id,
                            Symptoms = history.Symptoms,
                            Diagnosis = history.Diagnosis
                        };

            return query;
        }

        public long Add(HistoryModel model)
        {
            using (var db = new MainDb())
            {
                long id = Convert.ToInt64(db.History.InsertWithIdentity(() => new Kpo.Dal.MainDb.HistoryDataModel
                {
                    Date_Id = model.Date_Id,
                    Personal_Id = model.Personal_Id,
                    Client_Id = model.Client_Id,
                    Symptoms = model.Symptoms,
                    Diagnosis = model.Diagnosis
                }));

                return id;
            }
        }

        public List<HistoryModel> List()
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                return query.ToList();
            }
        }

        public List<HistoryModel> List(List<FilterCondition> filters)
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
