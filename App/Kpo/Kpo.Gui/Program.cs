using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Kpo.BL;

namespace KPO.Admin
{
    public static class Program
    {
        public static DateTime Current_Date = new DateTime(2016,10,10,14,10,00);
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        
        static void Main()
        {           
            //MySqlCommand z1 = new MySqlCommand("SELECT CLIENT_NAME FROM client", conn);
            // string znachenie = z1.ExecuteScalar().ToString();
            //MessageBox.Show(znachenie);
            Initializer.Init();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartWindow());
           

           

        }
    }
}
