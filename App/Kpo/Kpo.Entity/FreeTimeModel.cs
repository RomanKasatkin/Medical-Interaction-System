using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo.Entity
{
    public class FreeTimeModel
    {
        public long Id { get; set; }
        public long Personal_Id { get; set; }

        public DateTime Day { get; set; }
        public DateTime Time { get; set; }

        public override string ToString()
        {
            return string.Format("ID:{0}; Personal_Id:{1}; Day: {2}; Time: {3}", Id, Personal_Id, Day, Time);
        }
    }
}
