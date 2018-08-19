using Kpo.BL;
using Kpo.Entity;
using Kpo.BL.Filter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPO.Admin.Admin
{
    public partial class AdminChangeUser : Form
    {
        AdminMainForm back;
        UserModel model = new UserModel();
        User user = new User();
        Job job = new Job();
        public long Id;
        public AdminChangeUser(AdminMainForm F, long Id)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            back = F;
            this.Id = Id;

            List<JobModel> joblist = job.List();
            foreach (var j in joblist)
                JobBox.Items.Add(j.Name.ToString());
            string[] Level = new string[] { "0. Регистратор", "1. Врач", "2. Медработник", "3. Администратор" };
            foreach (string lv in Level)
            {
                LevelBox.Items.Add(lv);
            }

            model = user.Get_Item("Id", Id.ToString(), Kpo.BL.Filter.ConditionType.Equal);

            NameText.Text = model.Name;
            SurnameText.Text = model.Surname;
            PatronymicText.Text = model.Patronymic;
            LoginText.Text = model.Login;
            PasswordText.Text = model.Password;
            LevelBox.SelectedIndex = (int)model.Permition_Level;
            JobBox.SelectedItem = job.Get_Item("Id", model.Job_Id.ToString(), ConditionType.Equal).Name;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            back.Show();
            back.Refresh_list();
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            UserModel changemodel = new UserModel();
            if ((user.Get_Item("Login", LoginText.Text, ConditionType.Equal) == null) || (user.Get_Item("Login", LoginText.Text, ConditionType.Equal).Login == model.Login))
            {
                if ((NameText.Text != "") &&
                        (SurnameText.Text != "") &&
                        (JobBox.Text != "") &&
                       (LoginText.Text != ""))
                {
                    changemodel.Id = Id;
                    changemodel.Job_Id = job.Get_Item("Name", JobBox.Text, ConditionType.Equal).Id;
                    changemodel.Name = NameText.Text;
                    changemodel.Surname = SurnameText.Text;
                    changemodel.Patronymic = PatronymicText.Text;
                    changemodel.Permition_Level = LevelBox.SelectedIndex;
                    changemodel.Login = LoginText.Text;
                    changemodel.Password = PasswordText.Text;
                    user.Edit(changemodel);
                    MessageBox.Show("Изменения приняты");
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

        private void button1_Click(object sender, EventArgs e)
        {
            AdminEditScedule F = new AdminEditScedule(this);
            F.Show();
            this.Hide();
        }
    }
}
