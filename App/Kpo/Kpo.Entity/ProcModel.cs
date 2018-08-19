using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo.Entity
{
    public class ProcModel: IModel
    {
        public long Id { get; set; }
        public long Personal_Id { get; set; }
        public long Date_Id { get; set; }
        public long Proc_Type_Id { get; set; }
        public long Client_Id { get; set; }


        public override string ToString()
        {
            return string.Format("ID:{0}; Personal_Id: {1}; Date_Id: {2}; Proc_Type_Id{3}; Proc_Client_Id{4}" , Id, Personal_Id, Date_Id, Proc_Type_Id, Client_Id);
        }
    }
}
