using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo.Entity
{
    public class HistoryModel
    {
        public long Id { get; set; }
        public long Date_Id { get; set; }
        public long Client_Id { get; set; }
        public long Personal_Id { get; set; }
        public string Diagnosis { get; set; }
        public string Symptoms { get; set; }
        public override string ToString()
        {
            return string.Format("ID:{0}; Date_Id:{1}; Client_Id: {2}; Personal_Id: {3}; Диагноз {4}; Симптомы {5};", Id, Date_Id, Client_Id, Personal_Id, Diagnosis, Symptoms);
        }


    }
}
