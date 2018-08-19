using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Kpo.Entity;
using Kpo.BL;

namespace KPO.Admin
{
    public partial class ReseptionAddPatient : Form
    {
        ReseptionMain back;
        Client client = new Client();
        public ReseptionAddPatient(ReseptionMain F)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            Male.Checked = true;
            back = F;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ReseptionAddPatient_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            if ((NameText.Text != "") &&
                        (SurnameText.Text != "") &&
                        (YearText.Text != "") &&
                       (YearText.Text != "") &&
                (MounthText.Text != "") &&
                (PasportSeriesText.Text != "") &&
                (PasportNumberText.Text != "") &&
                (AdressText.Text != "") &&
                (InshuranceText.Text != ""))
            {
                DateTime date = new DateTime(int.Parse(YearText.Text), int.Parse(MounthText.Text), int.Parse(DayText.Text));
                ClientModel model = new ClientModel();
                model.Name = NameText.Text;
                model.Surname = SurnameText.Text;
                model.Patronymic = PatronymicText.Text;
                model.Date = date.Date;
                model.Pasport = long.Parse(PasportSeriesText.Text+PasportNumberText.Text);

                if (Male.Checked == true)
                    model.Gender = 0;
                if (Female.Checked == true)
                    model.Gender = 1;
                model.Adress = AdressText.Text;
                model.Insurance = long.Parse(InshuranceText.Text);
                client.Add(model);
                back.Show();
                this.Close();
            }
            else
                MessageBox.Show("Не все поля введены");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("К сожалению, в текущей версии данная функция не доступна.\nОжидайте обновлений");
        }
    }
}
