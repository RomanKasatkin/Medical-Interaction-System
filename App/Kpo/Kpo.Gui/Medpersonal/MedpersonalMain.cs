using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kpo.Entity;
using Kpo.BL;
using Kpo.BL.Filter;


namespace KPO.Admin
{
    public partial class MedpersonalMain : Form
    {
        Form back;
        Analyse analyse = new Analyse();
        AnalyseType analysetype = new AnalyseType();
        Client client = new Client();
        Date date = new Date();

        public void Refresh_list(int filter)
        {

            switch (filter)
            {
                case 1:
                    {
                        FilterCondition filter1 = new FilterCondition();
                        filter1.Field = "Id";
                        filter1.Value = textBox1.Text;
                        filter1.Type = ConditionType.StartsWith;
                        ListView.Items.Clear();

                        List<FilterCondition> filt = new List<FilterCondition>();
                        filt.Add(filter1);

                        List<ClientModel> collection = client.List(filt);
                        ListView.FullRowSelect = true;
                        ListView.GridLines = true;
                        ListViewItem.ListViewSubItem SubItem = new ListViewItem.ListViewSubItem();
                        foreach (var item in collection)
                        {
                            ListViewItem Item = new ListViewItem(new string[] { item.Id.ToString(), item.Name, item.Surname, item.Patronymic });
                            ListView.Items.Add(Item);


                        }
                        break;
                    }
                case 2:
                    {
                        FilterCondition filter1 = new FilterCondition();
                        filter1.Field = "Surname";
                        filter1.Value = textBox1.Text;
                        filter1.Type = ConditionType.StartsWith;
                        ListView.Items.Clear();

                        List<FilterCondition> filt = new List<FilterCondition>();
                        filt.Add(filter1);

                        List<ClientModel> collection = client.List(filt);
                        ListView.FullRowSelect = true;
                        ListView.GridLines = true;
                        ListViewItem.ListViewSubItem SubItem = new ListViewItem.ListViewSubItem();
                        foreach (var item in collection)
                        {
                            ListViewItem Item = new ListViewItem(new string[] { item.Id.ToString(), item.Name, item.Surname, item.Patronymic });
                            ListView.Items.Add(Item);


                        }
                        break;
                    }
            }
        }

        public MedpersonalMain(LoginWindow F)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            radioButton2.Checked = true;

            List<AnalyseTypeModel> collection = analysetype.List();
            foreach (AnalyseTypeModel A in collection)
            {
                Analyse_Type.Items.Add(A.Name);
            }

            this.Refresh_list(2);

            back = F;
        }

        private void MedpersonalMain_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }

        private void AddAnalyse_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void AddAnalyse_Click_1(object sender, EventArgs e)
        {
            AnalyseModel addmodel = new AnalyseModel();
            DateModel datemodel = new DateModel();
            datemodel.Day = Program.Current_Date.Date;
            datemodel.Time += Program.Current_Date.TimeOfDay;

            addmodel.Date_Id = date.Add(datemodel);
            try
            {
                int selected = ListView.SelectedIndices[0];
                addmodel.Type_Id = Analyse_Type.SelectedIndex + 1;
                addmodel.Client_Id = long.Parse(ListView.Items[selected].SubItems[0].Text);
                addmodel.Result = long.Parse(ResultText.Text);
                addmodel.Coment = Coment.Text;
                analyse.Add(addmodel);
                Coment.Clear();
                ResultText.Clear();
                MessageBox.Show("Данные внесены");
            }
            catch
            {
                MessageBox.Show("Некоторые поля не выбраны");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                Refresh_list(1);
            if (radioButton1.Checked == true)
                Refresh_list(2);
            textBox1.Clear();
        }
    }
}
