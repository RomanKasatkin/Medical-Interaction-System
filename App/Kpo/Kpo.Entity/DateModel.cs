using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo.Entity
{
   public class DateModel: IModel
    {
        public long Id { get; set; }
        public DateTime Day { get; set; }
        public DateTime Time { get; set; }


        public override string ToString()
        {
            return string.Format("ID:{0}; Day: {1}; Time: {2}", Id, Day, Time);
        }
    }
}
