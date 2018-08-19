using Kpo.BL;
using Kpo.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPO.Admin
{
    public partial class AdminAddFreeTime : Form
    {
        AdminAddUser back;
        FreeTimeModel model = new FreeTimeModel();
        FreeTime freetime = new FreeTime();
        User user = new User();
        public AdminAddFreeTime(AdminAddUser F)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            back = F;

        }
        public bool Add(int i)
        {
            long id = 0;

            if (CB9.Checked == true)
            {
                DateTime time = new DateTime(Program.Current_Date.Year, Program.Current_Date.Month, Program.Current_Date.Day + i, 9, 0, 0);
                model.Day = time.Date;
                model.Time += time.TimeOfDay;
                id = freetime.Add(model);
                model.Time -= time.TimeOfDay;
            }

            if (CB10.Checked == true)
            {
                DateTime time = new DateTime(Program.Current_Date.Year, Program.Current_Date.Month, Program.Current_Date.Day + i, 10, 0, 0);
                model.Day = time.Date;
                model.Time += time.TimeOfDay;
                id = freetime.Add(model);
                model.Time -= time.TimeOfDay;
            }
            if (CB11.Checked == true)
            {
                DateTime time = new DateTime(Program.Current_Date.Year, Program.Current_Date.Month, Program.Current_Date.Day + i, 11, 0, 0);
                model.Day = time.Date;
                model.Time += time.TimeOfDay;
                id = freetime.Add(model);
                model.Time -= time.TimeOfDay;
            }
            if (CB12.Checked == true)
            {
                DateTime time = new DateTime(Program.Current_Date.Year, Program.Current_Date.Month, Program.Current_Date.Day + i, 12, 0, 0);
                model.Day = time.Date;
                model.Time += time.TimeOfDay;
                id = freetime.Add(model);
                model.Time -= time.TimeOfDay;
            }
            if (CB14.Checked == true)
            {
                DateTime time = new DateTime(Program.Current_Date.Year, Program.Current_Date.Month, Program.Current_Date.Day + i, 14, 0, 0);
                model.Day = time.Date;
                model.Time += time.TimeOfDay;
                id = freetime.Add(model);
                model.Time -= time.TimeOfDay;
            }
            if (CB15.Checked == true)
            {
                DateTime time = new DateTime(Program.Current_Date.Year, Program.Current_Date.Month, Program.Current_Date.Day + i, 15, 0, 0);
                model.Day = time.Date;
                model.Time += time.TimeOfDay;
                id = freetime.Add(model);
                model.Time -= time.TimeOfDay;
            }
            if (CB16.Checked == true)
            {
                DateTime time = new DateTime(Program.Current_Date.Year, Program.Current_Date.Month, Program.Current_Date.Day + i, 16, 0, 0);
                model.Day = time.Date;
                model.Time += time.TimeOfDay;
                id = freetime.Add(model);
                model.Time -= time.TimeOfDay;
            }
            if (CB17.Checked == true)
            {
                DateTime time = new DateTime(Program.Current_Date.Year, Program.Current_Date.Month, Program.Current_Date.Day + i, 17, 0, 0);
                model.Day = time.Date;
                model.Time += time.TimeOfDay;
                id = freetime.Add(model);
                model.Time -= time.TimeOfDay;
            }
            if (id != 0)
            {
                return true;
            }
            else
            {
                return false;
            }




        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            model.Personal_Id = back.user.Add(back.AddModel);
            bool flag = false;
            for (int i = 0; i < 20; i++)
            {

                if ((Program.Current_Date.AddDays(i).DayOfWeek != DayOfWeek.Sunday) && (Program.Current_Date.AddDays(i).DayOfWeek != DayOfWeek.Saturday))
                    if (!this.Add(i))
                    {
                        MessageBox.Show("Выберите хотя бы одну позицию");
                        user.Delete(model.Personal_Id);
                        break;
                    }
                flag = true;
            }
            if (flag)
            {
                MessageBox.Show("Пользователь добавлен");
                back.back.Show();
                back.back.Refresh_list();
                back.Close();
                this.Close();
            }






        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }
    }
}
