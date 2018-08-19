using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo.BL.Filter
{
    public class FilterCondition
    {
        /// <summary>
        /// Поле в БД
        /// </summary>
        public string Field { get; set; }
        /// <summary>
        /// Значение 
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// Тип сравнения
        /// </summary>
        public ConditionType Type { get; set; }
        public FilterCondition()
        {

        }
        public FilterCondition(string field, object value, ConditionType type)
        {
            this.Field = field;
            this.Value = value;
            this.Type = type;

        }
    }
}
