using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo.Entity
{
    public class AnalyseModel
    {
        public long Id { get; set; }        
        public long Date_Id { get; set; }        
        public long Client_Id { get; set; }
        public long Type_Id { get; set; }
        public long Result { get; set; }
        public string Coment { get; set; }


        public override string ToString()
        {
            return string.Format("ID:{0}; Date_Id: {1}; Client_Id: {2}; Type_Id{3}; Result{4}, Coment{5}", Id, Date_Id, Client_Id, Type_Id, Result, Coment);
        }
    }
}
