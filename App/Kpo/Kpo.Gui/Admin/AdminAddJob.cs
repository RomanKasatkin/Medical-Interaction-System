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
using Kpo.BL.Filter;

namespace KPO.Admin
{
    public partial class AdminAddJob : Form
    {
        AdminMainForm back;
        Job job = new Job();
        public AdminAddJob(AdminMainForm F)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            back = F;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           
        }

        private void AddJob_Click(object sender, EventArgs e)
        {
            
        }

        private void AddJob_Click_1(object sender, EventArgs e)
        {
            JobModel jmodel = new JobModel();
           if(0 != job.Get_Item("Name", JobText.Text, ConditionType.Equal).Id)
           {
                MessageBox.Show("Такая должность уже существует");
                JobText.Clear();
            }
            else
            {
                JobModel model = new JobModel();
                model.Name = JobText.Text;
                job.Add(model);
                MessageBox.Show("Запись внесена");
                JobText.Clear();
            }
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }
    }
}
