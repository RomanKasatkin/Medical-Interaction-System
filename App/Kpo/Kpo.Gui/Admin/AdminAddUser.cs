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
    public partial class AdminAddUser : Form
    {
        public AdminMainForm back;
        public User user = new User();
        Job job = new Job();
        public UserModel AddModel = new UserModel();
        public AdminAddUser(AdminMainForm F)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            back = F;
            List<JobModel> joblist = job.List();
            foreach (var j in joblist)
                JobBox.Items.Add(j.Name.ToString());
            LevelBox.Items.Add("0. Регистратор");
            LevelBox.Items.Add("1. Врач");
            LevelBox.Items.Add("2. Медработник");
            LevelBox.Items.Add("3. Администратор");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            back.Show();
            back.Refresh_list();
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(user.Get_Item("Login", LoginText.Text, ConditionType.Equal).ToString());
            if (user.Get_Item("Login", LoginText.Text, ConditionType.Equal) == null)
            {
                // MessageBox.Show(JobBox.Text);
                if ((NameText.Text != "") &&
                    (SurnameText.Text != "") &&
                    (JobBox.Text != "") &&
                   (LoginText.Text != ""))
                {
                    AddModel.Job_Id = job.Get_Item("Name", JobBox.Text, ConditionType.Equal).Id;
                    AddModel.Name = NameText.Text;
                    AddModel.Surname = SurnameText.Text;
                    AddModel.Patronymic = PatronymicText.Text;
                    AddModel.Permition_Level = LevelBox.SelectedIndex;
                    AddModel.Login = LoginText.Text;
                    AddModel.Password = PasswordText.Text;
                    AdminAddFreeTime F = new AdminAddFreeTime(this);
                    F.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Не все поля введены");
            }
            else
            {
                MessageBox.Show("Этот логин уже занят!\nВыберите другой.");
                LoginText.Clear();
                back.Refresh_list();
            }


        }
    }
}
