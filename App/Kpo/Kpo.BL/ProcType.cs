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
    public class ProcType
    {
        private IQueryable<ProcTypeModel> MakeSelect(MainDb db)
        {
            var query = from proctype in db.ProcType
                        select new ProcTypeModel
                        {
                            Id = proctype.Id,
                            Name = proctype.Name,
                            Job_Id = proctype.Job_Id

                        };

            return query;
        }


        /// <summary>
        /// Получить элемент по заданным параметрам
        /// </summary>
        /// <returns></returns>

        public ProcTypeModel Get_Item(string field, string value, ConditionType type)
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
                ProcTypeModel Result = new ProcTypeModel();
                try
                {
                    Result = query.Single();
                    return Result;
                }
                catch
                {
                    ProcTypeModel NullResult = new ProcTypeModel();
                    NullResult.Id = 0;
                    NullResult.Name = "Не определено";
                    return NullResult;
                }


            }
        }

        public List<ProcTypeModel> List(List<FilterCondition> filters)
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);

                if (filters != null)
                {
                    foreach (var item in filters)
                    {
                        if (item.Field.Equals("Job_Id", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Job_Id.Equals(item.Value));
                            }
                           
                        }
                        
                       
                        
                    }
                }

                return query.ToList();
            }
        }
        /// <summary>
        /// Получить список всех типов
        /// </summary>
        /// <returns></returns>
        public List<ProcTypeModel> List()
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                return query.ToList();
            }
        }

        public long Add(ProcTypeModel model)
        {
            //TODO: валидация модели 

            //Сохранение 
            using (var db = new MainDb())
            {
                long id = Convert.ToInt64(db.ProcType.InsertWithIdentity(() => new Kpo.Dal.MainDb.ProcTypeDataModel
                {
                    Job_Id=model.Job_Id,
                    Name = model.Name

                }));

                return id;
            }
        }

    }
}
