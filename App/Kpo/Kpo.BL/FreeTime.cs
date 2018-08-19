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
    public class FreeTime
    {
        private IQueryable<FreeTimeModel> MakeSelect(MainDb db)
        {
            var query = from freetime in db.FreeTime
                        select new FreeTimeModel
                        {
                            Id = freetime.Id,
                            Personal_Id=freetime.Personal_Id,
                            Day = freetime.Day,
                            Time = freetime.Time


                        };

            return query;
        }
        public List<FreeTimeModel> List()
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                return query.ToList();
            }
        }

        public List<FreeTimeModel> List(string field, string value)
        {
            //FilterCondition filter = new FilterCondition(field, value, ConditionType.Equal);
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                if (field.Equals("Personal_Id", StringComparison.CurrentCultureIgnoreCase))
                {
                    query = query.Where(q => q.Personal_Id.Equals(value.ToString()));
                }
                
                
                return query.ToList();
            }
        }

        public List<FreeTimeModel> List(List<FilterCondition> filters)
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);

                if (filters != null)
                {
                    foreach (var item in filters)
                    {
                        if (item.Field.Equals("Personal_Id", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Personal_Id.Equals(item.Value));
                            }                           
                        }
                        if (item.Field.Equals("Day", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Day.Equals(item.Value));
                            }

                        }                         
                    }
                }

                return query.ToList();
            }
        }


        public FreeTimeModel Get_Item(DateTime day, DateTime time, long Id)
        {
            
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
               
                   
                
                            query = query.Where(q => q.Personal_Id.Equals(Id));
                       
                            query = query.Where(q => q.Day.Equals(day));
                        
                            query = query.Where(q => q.Time.Equals(time));
                       
                    
                
                FreeTimeModel Result = new FreeTimeModel();
                try
                {
                    Result = query.Single();
                    return Result;
                }
                catch
                {
                    FreeTimeModel NullResult = new FreeTimeModel();
                    NullResult.Id = 0;
                    NullResult.Personal_Id = 0;
                                       
                    return NullResult;
                }
            }
        }
        public long Add(FreeTimeModel model)
        {
            //TODO: валидация модели 

            //Сохранение 
            using (var db = new MainDb())
            {
                long id = Convert.ToInt64(db.FreeTime.InsertWithIdentity(() => new Kpo.Dal.MainDb.FreeTimeDataModel
                {


                    Personal_Id = model.Personal_Id,
                    Day = model.Day,
                    Time = model.Time
                }));

                return id;
            }
        }
        public void Delete(long id)
        {
            using (var db = new MainDb())
            {
                db.FreeTime.Delete(q => q.Id == id);
            }
        }

    }
}
