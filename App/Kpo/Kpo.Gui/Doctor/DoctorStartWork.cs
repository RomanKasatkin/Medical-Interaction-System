using Kpo.BL;
using Kpo.BL.Filter;
using Kpo.Entity;
using KPO.Admin.Doctor;
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
    public partial class DoctorStartWork : Form
    {
        public DoctorMain back;
        User user = new User();
        Date date = new Date();
        Proc proc = new Proc();
        History history = new History();
        Client client = new Client();
        ProcType proctype = new ProcType();
        public long Client_Id;
        public long Proc_Id;
        public DoctorStartWork(DoctorMain F, long Client_Id, long Proc_Id)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            back = F;
            this.Proc_Id = Proc_Id;
            this.Client_Id = Client_Id;
            ClientName.Text = client.Get_Item("Id", Client_Id.ToString(), ConditionType.Equal).Surname + " " + client.Get_Item("Id", Client_Id.ToString(), ConditionType.Equal).Name + " " + client.Get_Item("Id", Client_Id.ToString(), ConditionType.Equal).Patronymic;

        }

        public long AddHistory(string diagnosis, string symptoms)
        {
            HistoryModel addmodel = new HistoryModel();
            addmodel.Client_Id = Client_Id;
            addmodel.Personal_Id = back.Current_Id;
            addmodel.Symptoms = SymtomsText.Text;
            addmodel.Diagnosis = DiagnosysText.Text;
            addmodel.Date_Id = proc.Get_Item("Id", Proc_Id.ToString(), ConditionType.Equal).Date_Id;
            return history.Add(addmodel);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            back.Show();
            back.Refresh_list();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Назначить следующую консультацию?", "Следущая консультация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                //History
                back.Refresh_list();
                AddHistory(DiagnosysText.Text, SymtomsText.Text);
                DoctorNewProc F = new DoctorNewProc(this, Client_Id, back.Current_Id, Proc_Id);
                F.Show();
                this.Hide();

            }
            if (DialogResult.No == result)
            {
                AddHistory(DiagnosysText.Text, SymtomsText.Text);
                proc.Delete(Proc_Id);
                back.Refresh_list();
                back.Show();
                this.Close();

            }
            if (DialogResult.Cancel == result)
            {

            }

        }

        private void ShowMaterials_Click(object sender, EventArgs e)
        {
            DoctorClientInfo F = new DoctorClientInfo(this, Client_Id);
            F.Show();
            this.Hide();
        }
    }
}
