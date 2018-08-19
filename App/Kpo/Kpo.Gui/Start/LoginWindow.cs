using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Kpo.BL;
using Kpo.BL.Filter;

namespace KPO.Admin
{
    public partial class LoginWindow : Form
    {
        Session_control session = new Session_control();
        Form start;
        public LoginWindow(StartWindow F)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            start = F;
        }
        private void LogIn_Click(object sender, EventArgs e)
        {

            User user = new User();
            if (LogInField.Text == "")
            {
                MessageBox.Show("Доступ запрещён!");
                PasswordField.Clear();
            }
            else
                if (user.Get_Item("Login", LogInField.Text, ConditionType.Equal) == null)
                {
                    MessageBox.Show("Несуществующий логин");
                    LogInField.Clear();
                    PasswordField.Clear();
                }
                else
                    if ((user.Get_Item("Login", LogInField.Text, ConditionType.Equal).Password == PasswordField.Text) && (user.Get_Item("Login", LogInField.Text, ConditionType.Equal) != null))
                    {
                        switch (user.Get_Item("Login", LogInField.Text, ConditionType.Equal).Permition_Level)
                        {
                            case 0:
                                {
                                    ReseptionMain F = new ReseptionMain(this);
                                    F.Show();
                                    this.Visible = false;
                                    break;
                                }
                            case 1:
                                {
                                    DoctorMain F = new DoctorMain(this, user.Get_Item("Login", LogInField.Text, ConditionType.Equal).Id);
                                    F.Show();
                                    this.Visible = false;
                                    break;
                                }
                            case 2:
                                {
                                    MedpersonalMain F = new MedpersonalMain(this);
                                    F.Show();
                                    this.Visible = false;
                                    break;
                                }
                            case 3:
                                {
                                    AdminMainForm F = new AdminMainForm(this);
                                    F.Show();
                                    this.Visible = false;
                                    break;
                                }
                            case 6:
                                {
                                    MessageBox.Show("Совпадений не найдено");
                                    break;
                                }
                        }
                        LogInField.Clear();
                        PasswordField.Clear();
                    }
                    else
                        if ((user.Get_Item("Login", LogInField.Text, ConditionType.Equal).Password != PasswordField.Text))
                        {
                            MessageBox.Show("Неправильный пароль");
                            PasswordField.Clear();

                        }










        }

        private void Exit_Click(object sender, EventArgs e)
        {
            start.Close();
        }
    }
}
