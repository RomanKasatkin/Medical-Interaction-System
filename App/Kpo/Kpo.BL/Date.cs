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
    public class Date
    {
        private IQueryable<DateModel> MakeSelect(MainDb db)
        {
            var query = from date in db.Date
                        select new DateModel
                        {
                            Id = date.Id,
                            Day=date.Day,
                            Time=date.Time


                        };

            return query;
        }

        /// <summary>
        /// Получить список всех дат
        /// </summary>
        /// <returns></returns>
        public List<DateModel> List()
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                return query.ToList();
            }
        }

        public long Add(DateModel model)
        {
            //TODO: валидация модели 

            //Сохранение 
            using (var db = new MainDb())
            {
                Date date = new Date();
                DateTime datetime = new DateTime(model.Day.Year,model.Day.Month,model.Day.Day,model.Time.Hour,model.Time.Minute,model.Time.Second);

                long id=0;
                try
                {
                   id= date.List("Get_Id", datetime).Single().Id;
                }
                catch
                {
                    id = Convert.ToInt64(db.Date.InsertWithIdentity(() => new Kpo.Dal.MainDb.DateDataModel
                    {

                        Day = model.Day,
                        Time = model.Time
                    }));

                    
                }
                return id;
            }
        }

        public long SwapFreeTime (FreeTimeModel freetime)
        {
            long id;
            DateModel datemodel=new DateModel();
            Date date = new Date();
            FreeTime ftime = new FreeTime();
            DateTime datetime = new DateTime(freetime.Day.Year, freetime.Day.Month, freetime.Day.Day, freetime.Time.Hour,freetime.Time.Minute,freetime.Time.Second);
            
           
            using (var db = new MainDb())
            {
                try
                { 
                      datemodel= date.List("Get_id",datetime).Single();
                     
                    id=datemodel.Id;
                }
               catch
                {
                    
                    datemodel.Day = freetime.Day;
                    datemodel.Time = freetime.Time;
                    id=date.Add(datemodel);
                    
                }
                Console.WriteLine(freetime.Id);
                ftime.Delete(freetime.Id);
                return id;
                
            }

        }

        /// <summary>
        /// Получить список всех дат по времени или времён по дате
        /// </summary>
        /// <returns></returns>
        public List<DateModel> List(string field, DateTime value)
        {
            //FilterCondition filter = new FilterCondition(field, value, ConditionType.Equal);
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                if (field.Equals("Day", StringComparison.CurrentCultureIgnoreCase) )
                {
                   
                        query = query.Where(q => q.Day.Equals(value.Date));
                    

                }
                if (field.Equals("Time", StringComparison.CurrentCultureIgnoreCase))
                {
                   
                        query = query.Where(q => q.Time.Equals(value.TimeOfDay));
                   

                }
                if (field.Equals("Get_Id", StringComparison.CurrentCultureIgnoreCase))
                {

                    query = query.Where(q => q.Day.Equals(value.Date));
                    query = query.Where(q => q.Time.Equals(value.TimeOfDay));


                }
                return query.ToList();
            }
        }

        /// <summary>
        /// Получить элемент по заданным параметрам
        /// </summary>
        /// <returns></returns>

        public DateModel Get_Item(string field, string value, ConditionType type)
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
                   
                   
                }
                DateModel Result = new DateModel();
                try
                {
                    Result = query.Single();
                    return Result;
                }
                catch
                {
                    DateModel NullResult = new DateModel();
                    NullResult.Id = 0;
                    NullResult.Day = DateTime.Parse("0000.00.00");
                    NullResult.Time = DateTime.Parse("00.00.00");
                    return NullResult;
                }


            }
        }
    }
}
