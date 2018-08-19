using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kpo.BL;
using Kpo.Entity;
using Kpo.BL.Filter;
using KPO.Admin.Admin;

namespace KPO.Admin
{
    public partial class AdminMainForm : Form
    {
        public void Refresh_list()
        {
            ListView.Items.Clear();

            List<UserModel> collection = user.List();            
            int i = 1;
            ListView.FullRowSelect = true;
            ListView.GridLines = true;
            ListViewItem.ListViewSubItem SubItem = new ListViewItem.ListViewSubItem();
            foreach (var item in collection)
            {
                if (item.Login != "")
                {
                    ListViewItem Item = new ListViewItem(new string[] { i.ToString(), item.Surname, item.Name, item.Patronymic, job.Get_Item("ID", item.Job_Id.ToString(), ConditionType.Equal).Name.ToString(), item.Login, item.Password });

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
                i++;

            }
        }
        Form back;
        FreeTime freetime = new FreeTime();
        User user = new User();
        Job job = new Job();
        public AdminMainForm()
        {

        }
        public AdminMainForm(LoginWindow F)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            back = F;
            this.Refresh_list();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }

        private void DeleteUser_Click_1(object sender, EventArgs e)
        {
            try
            {
                int selected = ListView.SelectedIndices[0];


                DialogResult result = MessageBox.Show("Вы действительно хотите удалить записи?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                // MessageBox.Show(this.DialogResult.ToString());
                 if (result == DialogResult.Yes)
                {
                    // MessageBox.Show(selected.ToString());
                    // MessageBox.Show(ListView.Items[selected].SubItems[5].Text.ToString());
                    // MessageBox.Show(user.Get_Item("Login", ListView.Items[selected].SubItems[5].Text.ToString(), ConditionType.Equal).Id.ToString());
                    List<FreeTimeModel> freetimecollection = freetime.List("Personal_Id", user.Get_Item("Login", ListView.Items[selected].SubItems[5].Text.ToString(), ConditionType.Equal).Id.ToString());
                    foreach (FreeTimeModel M in freetimecollection)
                    {
                        freetime.Delete(M.Id);
                    }
                    
                    UserModel changemodel = new UserModel();
                    changemodel=user.Get_Item("Login", ListView.Items[selected].SubItems[5].Text.ToString(), ConditionType.Equal);


                    if (changemodel.Login != "Admin")
                    {
                        changemodel.Login = "";
                        changemodel.Password = "";
                    }
                    else
                    {
                        MessageBox.Show("Ключевая запись. Удаление невозможно");
                    }
                    user.Edit(changemodel);

                    


                }
            }
            catch
            {
                MessageBox.Show("Ничего не выбрано");
            }
       
            this.Refresh_list();
        }

        private void ChangeUser_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = ListView.SelectedIndices[0];
                //MessageBox.Show(user.Get_Item("Login", ListView.Items[selected].SubItems[5].Text.ToString(), ConditionType.Equal).Id.ToString());
                long Id = user.Get_Item("Login", ListView.Items[selected].SubItems[5].Text.ToString(), ConditionType.Equal).Id;
                //MessageBox.Show(Id.ToString());
                AdminChangeUser F = new AdminChangeUser(this, Id);

                F.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Ничего не выбрано");
            }
            this.Refresh_list();

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AdminAddUser F = new AdminAddUser(this);
            F.Show();
            this.Hide();
        }

        private void AddProc_Click(object sender, EventArgs e)
        {
           
        }

        private void AddJob_Click(object sender, EventArgs e)
        {
           
        }

        private void AddJob_Click_1(object sender, EventArgs e)
        {
            AdminAddJob F = new AdminAddJob(this);
            F.Show();
            this.Hide();
        }

        private void AddProc_Click_1(object sender, EventArgs e)
        {
            AdminAddProc F = new AdminAddProc(this);
            F.Show();
            this.Hide();
        }
    }
}
