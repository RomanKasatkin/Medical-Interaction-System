using Kpo.BL.Filter;
using Kpo.Dal;
using Kpo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
namespace Kpo.BL
{
   public class Job
    {

        private IQueryable<JobModel> MakeSelect(MainDb db)
        {
            var query = from job in db.Job
                        select new JobModel
                        {
                            Id = job.Id,
                            Name = job.Name,
                            
                        };

            return query;
        }
       
        /// <summary>
        /// Получить элемент по заданным параметрам
        /// </summary>
        /// <returns></returns>

        public JobModel Get_Item(string field, string value, ConditionType type)
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
                    if (filter.Field.Equals("Name", StringComparison.CurrentCultureIgnoreCase) && filter.Value != null)
                    {
                        if (filter.Type == ConditionType.Equal)
                        {
                            query = query.Where(q => q.Name.Equals(filter.Value));
                        }

                    }
                }
                JobModel Result = new JobModel();
                try
                {
                    Result = query.Single();
                    return Result;
                }
                catch
                {
                    JobModel NullResult = new JobModel();
                    NullResult.Id = 0;
                    NullResult.Name = "Не определено";
                    return NullResult;
                }
            }
        }

        /// <summary>
        /// Получить список всех должностей
        /// </summary>
        /// <returns></returns>
        public List<JobModel> List()
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                return query.ToList();
            }
        }

        public long Add(JobModel model)
        {
            //TODO: валидация модели 

            //Сохранение 
            using (var db = new MainDb())
            {
                long id = Convert.ToInt64(db.Job.InsertWithIdentity(() => new Kpo.Dal.MainDb.JobDataModel
                {

                    Name = model.Name,
                    
                }));

                return id;
            }
        }
    }
}
