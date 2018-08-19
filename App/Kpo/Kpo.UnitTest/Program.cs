using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo.BL;
using Kpo.BL.Filter;
using Kpo.Entity;

namespace Kpo.UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Initializer.Init();
           
            FilterCondition filter3 = new FilterCondition();
            filter3.Field = "Job_Id";
            filter3.Value = "3";
            filter3.Type = ConditionType.Equal;
            List<FilterCondition> filt = new List<FilterCondition>();
            filt.Add(filter3);

            ProcType proctype = new ProcType();
            List<ProcTypeModel> collection = proctype.List(filt);
            foreach (ProcTypeModel P in collection)
            {
                Console.WriteLine(P);
            }
            
            /*Proc proc = new Proc();
            Client client= new Client();
            User user = new User();
            ProcType proctype = new ProcType();
            Date date = new Date();
            List<DateModel> collection = date.List();

            FilterCondition filter1 = new FilterCondition();
            filter1.Field = "Personal_Id";
            filter1.Value = "3";
            filter1.Type = ConditionType.Equal;

            FilterCondition filter2 = new FilterCondition();
            filter2.Field = "Date_Id";
            filter2.Value = "2";
            filter2.Type = ConditionType.Equal;

            FilterCondition filter3 = new FilterCondition();
            filter3.Field = "Proc_Type_Id";
            filter3.Value = "2";
            filter3.Type = ConditionType.Equal;
            List<FilterCondition> filt = new List<FilterCondition>();
            filt.Add(filter1);
            filt.Add(filter2);
            filt.Add(filter3);
            DateModel selected_client_date = new DateModel();
            DateTime datetime = new DateTime(2016,10,10,12,57,30);
            List<DateModel> date_List = date.List("Get_Id", datetime);
            selected_client_date = date_List.Single();

            Console.WriteLine(proc.Get_Item("Date_Id", selected_client_date.Id.ToString(), ConditionType.Equal).Client_Id.ToString());

           /* foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            DateTime datetime = new DateTime(2016,10,10,0,0,0);
            Console.WriteLine(datetime);
            collection = date.List("Day", datetime);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }*/
           /* List<ProcModel> collection1 = proc.List(filt);    
            foreach (ProcModel item in collection1)
            {
                Console.WriteLine(item);
                Console.WriteLine(date.Get_Item("Id", item.Date_Id.ToString(), ConditionType.Equal).Time.TimeOfDay.ToString());
                Console.WriteLine(client.Get_Item("Id", item.Client_Id.ToString(), ConditionType.Equal).Name);
            }
            */
            
  
           

            /*collection = date.List("Day","2016.12.30");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }*/
           // DateTime date = new DateTime(1976, 10, 2);
            /*ClientModel model = new ClientModel();
             model.Name="Иван";
                   model.Surname="Петров";
                   model.Patronymic="Семёнович";
                   model.Date=date.Date;
                   model.Pasport=1234567890;
                   model.Gender=0;
                   model.Adress="Moskva";
                   model.Insurance = 1234567890123456;
                   client.Add(model);

                   collection = client.List();
                   foreach (var item in collection)
                   {
                       Console.WriteLine(item);
                   }
            List<UserModel> login = user.List(filt);
            Console.ReadLine();

            foreach (var item in login)
            {
                Console.WriteLine(item.Password);
            }
            Console.ReadLine();

          //  Console.WriteLine(user.Get_Item("Login","",ConditionType.Equal).Password);

            Job job = new Job();
            List<JobModel> JobCollection = job.List();
            foreach (var item in JobCollection)
            {
                Console.WriteLine(item);
            }
          //Console.WriteLine(job.Get_Item("Login","3",ConditionType.Equal));
            //user.Delete(user.Get_Item("Login","Ann",ConditionType.Equal).Id);*/


            
        }        
    }
}
