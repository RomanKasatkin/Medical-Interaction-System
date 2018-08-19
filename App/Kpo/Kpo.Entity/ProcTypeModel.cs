using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo.Entity
{
   public class ProcTypeModel:IModel
    {
        public long Id { get; set; }
      public long Job_Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("ID:{0}; Job_Id:{1} Name: {2}", Id, Job_Id, Name);
        }
    }
}
