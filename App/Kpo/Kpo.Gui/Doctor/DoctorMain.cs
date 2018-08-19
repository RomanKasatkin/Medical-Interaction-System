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
    public partial class DoctorMain : Form
    {
        Client client = new Client();
        Proc proc = new Proc();
        ProcType proctype = new ProcType();
        Date date = new Date();
        Form back;
        public long Current_Id;
        public void Refresh_list()
        {
            ListView.Items.Clear();

            ListView.FullRowSelect = true;
            ListView.GridLines = true;

            List<DateModel> datecollection = date.List("Day", Program.Current_Date.Date);
            datecollection.Reverse();
            foreach (DateModel dateItem in datecollection)
            {
                FilterCondition filter1 = new FilterCondition();
                filter1.Field = "Personal_Id";
                filter1.Value = Current_Id;
                filter1.Type = ConditionType.Equal;

                FilterCondition filter2 = new FilterCondition();
                filter2.Field = "Date_Id";
                filter2.Value = dateItem.Id.ToString();
                filter2.Type = ConditionType.Equal;


                List<FilterCondition> filt = new List<FilterCondition>();
                filt.Add(filter1);
                filt.Add(filter2);

                

               
                List<ProcModel>  collection = new List<ProcModel>();
                collection = proc.List(filt);
                
                foreach (var item in collection)
                {

                    ListViewItem Item = new ListViewItem(new string[] 
                    { 
                        date.Get_Item("Id", item.Date_Id.ToString(), ConditionType.Equal).Time.TimeOfDay.ToString(), 
                        client.Get_Item("Id", item.Client_Id.ToString(), ConditionType.Equal).Name, 
                        client.Get_Item("Id", item.Client_Id.ToString(), ConditionType.Equal).Surname, 
                        client.Get_Item("Id", item.Client_Id.ToString(), ConditionType.Equal).Patronymic, 
                        proctype.Get_Item("Id",item.Proc_Type_Id.ToString(),ConditionType.Equal).Name 
                    });

                    /*Item.Text=i.ToString();
                    Item.SubItems.Add(SubItem);
                    SubItem.Text=item.Name;
                    Item.SubItems.Add(SubItem);
                    SubItem.Text=item.Surname;
                    Item.SubItems.Add(SubItem);
                    SubItem.Text=item.Patronymic;
                    Item.SubItems.Add(SubItem);
                    SubItem.Text=item.Job_Id.ToString();
                    Item.SubItems.Add(SubItem);
                    SubItem.Text = item.Login;
                    Item.SubItems.Add(SubItem);
                    SubItem.Text = item.Password;
                    Item.SubItems.Add(SubItem);*/
                    ListView.Items.Add(Item);

                }
                
            }
        }
        public DoctorMain(LoginWindow F, long id)
        {
            InitializeComponent();
            Time.Text = Program.Current_Date.TimeOfDay.ToString();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            back = F;
            Current_Id = id;
            // ListViewItem str = new ListViewItem("13.30");
            //Button start = new Button();
            //str.SubItems.Add("Иван");
            //str.SubItems.Add(start);
            //listView1.Items.Add(str);
            this.Refresh_list();
            // MessageBox.Show(Program.Current_Date.Date.ToString("d"));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartWork_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = ListView.SelectedIndices[0];

                DateTime datetime = new DateTime(Program.Current_Date.Year, Program.Current_Date.Month, Program.Current_Date.Day, DateTime.Parse(ListView.Items[selected].SubItems[0].Text).Hour, DateTime.Parse(ListView.Items[selected].SubItems[0].Text).Minute, DateTime.Parse(ListView.Items[selected].SubItems[0].Text).Second);
                //MessageBox.Show(ListView.Items[selected].SubItems[0].Text.ToString());

                //MessageBox.Show(datetime.ToString());
                DateModel selected_client_date = new DateModel();
                List<DateModel> date_List = date.List("Get_Id", datetime);
                selected_client_date = date_List.Single();
                //MessageBox.Show(datetime.ToString());

                FilterCondition filter1 = new FilterCondition();
                filter1.Field = "Personal_Id";
                filter1.Value = Current_Id;
                filter1.Type = ConditionType.Equal;

                FilterCondition filter2 = new FilterCondition();
                filter2.Field = "Date_Id";
                filter2.Value = selected_client_date.Id.ToString();
                filter2.Type = ConditionType.Equal;

                List<FilterCondition> filt = new List<FilterCondition>();
                filt.Add(filter1);
                filt.Add(filter2);

                List<ProcModel> collection = proc.List(filt);

                long Id = collection.Single().Client_Id;
                long Proc_Id = collection.Single().Id;
                // MessageBox.Show(Id.ToString());
                DoctorStartWork F = new DoctorStartWork(this, Id, Proc_Id);

                F.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Ничего не выбрано");
            }
            this.Refresh_list();
        }
    }
}
