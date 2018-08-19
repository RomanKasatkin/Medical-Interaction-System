using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo.Entity
{
    public class AnalyseTypeModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
       


        public override string ToString()
        {
            return string.Format("ID:{0}; Name: {1}", Id, Name);
        }
    }
}
