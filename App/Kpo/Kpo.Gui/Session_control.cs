using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace KPO.Admin
{
    class Session_control
    {
       public int Current_session=6;
        public void Start_session(string log,string pass)
        {
           /* Database DB = new Database();
            MySqlConnection conn = new MySqlConnection(DB.connStr);
            conn.Open();
            try
            {
                MySqlCommand z1 = new MySqlCommand("SELECT personal_password FROM personal WHERE PERSONAL_LOGIN='" + log + "'", conn);
                
                if (z1!=null)
                {
                   
                MySqlCommand z2 = new MySqlCommand(DB.LogIn1 + log + DB.LogIn2 + pass + "'", conn);
                string permition = z2.ExecuteScalar().ToString();
                this.Current_session = int.Parse(permition.ToString());
                }
                else
                     this.Current_session = 6;
            }
            catch 
            {
               
            }
            
            

               
                   
               
               
                    
               
            conn.Close();    */      
        }
        public void Close_session()
        {

        }
    }
}
