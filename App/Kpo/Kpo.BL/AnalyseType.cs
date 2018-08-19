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
    public class AnalyseType
    {
        private IQueryable<AnalyseTypeModel> MakeSelect(MainDb db)
        {
            var query = from analysetype in db.AnalyseType
                        select new AnalyseTypeModel
                        {
                            Id = analysetype.Id,
                            Name = analysetype.Name

                        };

            return query;
        }


        public List<AnalyseTypeModel> List()
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                return query.ToList();
            }
        }

        public AnalyseTypeModel Get_Item(string field, string value, ConditionType type)
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
                AnalyseTypeModel Result = new AnalyseTypeModel();
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
    }
}
