using Kpo.BL;
using Kpo.BL.Filter;
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
    public partial class AdminAddProc : Form
    {
        AdminMainForm back;
        Job job = new Job();
        ProcType proctype = new ProcType();
        public AdminAddProc(AdminMainForm F)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            back = F;
            List<JobModel> joblist = job.List();
            foreach (var j in joblist)
                JobBox.Items.Add(j.Name.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void AdminAddProc_Load(object sender, EventArgs e)
        {

        }
        private void BackButton_Click(object sender, System.EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ProcTypeModel pmodel = new ProcTypeModel();

            if (0 != proctype.Get_Item("Name", ProcNameText.Text, ConditionType.Equal).Id) 
            {
                MessageBox.Show("Такая процедура уже существует");
                ProcNameText.Clear();
            }
            else
            {
            ProcTypeModel model = new ProcTypeModel();
            model.Name = ProcNameText.Text;
            model.Job_Id = job.Get_Item("Name", JobBox.SelectedItem.ToString(), ConditionType.Equal).Id;
            proctype.Add(model);
            MessageBox.Show("Запись внесена");
            ProcNameText.Clear();
            }
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }
    }
}
