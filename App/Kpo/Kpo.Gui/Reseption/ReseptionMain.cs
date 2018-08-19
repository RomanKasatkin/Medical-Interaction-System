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

    public partial class ReseptionMain : Form
    {
        Form formtoopen;
        Client client = new Client();
        public void Refresh_list(int filter)
        {

            switch (filter)
            {
                case 1:
                    {
                        FilterCondition filter1 = new FilterCondition();
                        filter1.Field = "Id";
                        filter1.Value = SearchBar.Text;
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
                            ListViewItem Item = new ListViewItem(new string[] { item.Id.ToString(), item.Surname, item.Name, item.Patronymic, item.Pasport.ToString() });
                            ListView.Items.Add(Item);


                        }
                        break;
                    }
                case 2:
                    {
                        FilterCondition filter1 = new FilterCondition();
                        filter1.Field = "Surname";
                        filter1.Value = SearchBar.Text;
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
                            ListViewItem Item = new ListViewItem(new string[] { item.Id.ToString(), item.Surname, item.Name, item.Patronymic, item.Pasport.ToString() });
                            ListView.Items.Add(Item);


                        }
                        break;
                    }
                case 3:
                    {
                        FilterCondition filter1 = new FilterCondition();
                        filter1.Field = "Pasport";
                        filter1.Value = SearchBar.Text;
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
                            ListViewItem Item = new ListViewItem(new string[] { item.Id.ToString(), item.Surname, item.Name, item.Patronymic, item.Pasport.ToString() });
                            ListView.Items.Add(Item);


                        }
                        break;
                    }
            }
        }
        public ReseptionMain(LoginWindow F)
        {
            InitializeComponent();
            Time.Text = Program.Current_Date.TimeOfDay.ToString();
            monthCalendar1.TodayDate = Program.Current_Date.Date;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            formtoopen = F;
            FilterClient_Id.Checked = true;
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            this.Close();

        }

        private void Bodycheck_Click(object sender, EventArgs e)
        {


            this.Hide();
        }

        private void AddCard_Click(object sender, EventArgs e)
        {
            ReseptionAddPatient F = new ReseptionAddPatient(this);
            F.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (FilterClient_Id.Checked == true)
            {
                this.Refresh_list(1);
                ListView.Visible = true;
                ClientInfo.Visible = true;
                EditCard.Visible = true;
                NewProcedure.Visible = true;

            }
            if (FilterSurname.Checked == true)
            {
                this.Refresh_list(2);
                ListView.Visible = true;
                ClientInfo.Visible = true;
                EditCard.Visible = true;
                NewProcedure.Visible = true;

            }
            if (FilterPasport.Checked == true)
            {
                this.Refresh_list(3);
                ListView.Visible = true;
                ClientInfo.Visible = true;
                EditCard.Visible = true;
                NewProcedure.Visible = true;

            }
        }

        private void EditCard_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = ListView.SelectedIndices[0];
                //MessageBox.Show(user.Get_Item("Login", ListView.Items[selected].SubItems[5].Text.ToString(), ConditionType.Equal).Id.ToString());
                long Id = client.Get_Item("Pasport", ListView.Items[selected].SubItems[4].Text.ToString(), ConditionType.Equal).Id;
                //MessageBox.Show(Id.ToString());

                ReseptionEditClient F = new ReseptionEditClient(this, Id);
                ListView.Visible = false;
                ClientInfo.Visible = false;
                EditCard.Visible = false;

                NewProcedure.Visible = false;
                F.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Ничего не выбрано");
            }


        }

        private void NewProcedure_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = ListView.SelectedIndices[0];
                //MessageBox.Show(user.Get_Item("Login", ListView.Items[selected].SubItems[5].Text.ToString(), ConditionType.Equal).Id.ToString());
                long Id = client.Get_Item("Pasport", ListView.Items[selected].SubItems[4].Text.ToString(), ConditionType.Equal).Id;
                //MessageBox.Show(Id.ToString());

                ReseptionNewProc F = new ReseptionNewProc(this, Id);
                ListView.Visible = false;
                ClientInfo.Visible = false;
                EditCard.Visible = false;

                NewProcedure.Visible = false;
                F.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Ничего не выбрано");
            }
        }

        private void ClientInfo_Click(object sender, EventArgs e)
        {
        }
           

        private void ClientInfo_Click_1(object sender, EventArgs e)
        {
             try
            {
                int selected = ListView.SelectedIndices[0];
                //MessageBox.Show(user.Get_Item("Login", ListView.Items[selected].SubItems[5].Text.ToString(), ConditionType.Equal).Id.ToString());
                long Id = client.Get_Item("Pasport", ListView.Items[selected].SubItems[4].Text.ToString(), ConditionType.Equal).Id;
                //MessageBox.Show(Id.ToString());

                ReseptionClientInfo F = new ReseptionClientInfo(this, Id);
                ListView.Visible = false;
                ClientInfo.Visible = false;
                EditCard.Visible = false;

                NewProcedure.Visible = false;
                F.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Ничего не выбрано");
            }
        }
        }
    }

