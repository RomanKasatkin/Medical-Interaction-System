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
    public partial class ReseptionEditClient : Form
    {
        ReseptionMain back;
        ClientModel model = new ClientModel();
        Client client = new Client();
        long Id;
        public ReseptionEditClient(ReseptionMain F, long Id)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            back = F;
            this.Id = Id;

            model = client.Get_Item("Id", Id.ToString(), Kpo.BL.Filter.ConditionType.Equal);

            NameText.Text = model.Name;
            SurnameText.Text = model.Surname;
            PatronymicText.Text = model.Patronymic;
            DayText.Text = model.Date.Day.ToString();
            MounthText.Text = model.Date.Month.ToString();
            YearText.Text = model.Date.Year.ToString();
            PasportSeriesText.Text = model.Pasport.ToString().Substring(0,4);
            PasportNumberText.Text = model.Pasport.ToString().Substring(3, 6);
            AdressText.Text = model.Adress;
            InshuranceText.Text = model.Insurance.ToString();
            if (model.Gender == 0)
                Male.Checked = true;
            if (model.Gender == 1)
                Female.Checked = true;
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            try
            {
                ClientModel changemodel = new ClientModel();
                if ((client.Get_Item("Pasport", PasportSeriesText.Text + PasportNumberText.Text, ConditionType.Equal) == null) || (client.Get_Item("Pasport", PasportSeriesText.Text + PasportNumberText.Text, ConditionType.Equal).Pasport == model.Pasport))
                {

                    changemodel.Id = Id;
                    DateTime date = new DateTime(int.Parse(YearText.Text), int.Parse(MounthText.Text), int.Parse(DayText.Text));
                    changemodel.Name = NameText.Text;
                    changemodel.Surname = SurnameText.Text;
                    changemodel.Patronymic = PatronymicText.Text;
                    changemodel.Date = date.Date;
                    changemodel.Pasport = long.Parse(PasportSeriesText.Text + PasportNumberText.Text);
                    if (Male.Checked == true)
                        changemodel.Gender = 0;
                    if (Female.Checked == true)
                        changemodel.Gender = 1;
                    changemodel.Adress = AdressText.Text;
                    changemodel.Insurance = long.Parse(InshuranceText.Text);
                    client.Edit(changemodel);
                    MessageBox.Show("Изменения приняты");

                }

                else
                {
                    MessageBox.Show("Этот паспорт уже зарегистрирован!\nВыберите другой.");
                    PasportNumberText.Clear();
                    PasportSeriesText.Clear();

                }
            }
            catch
            {
                MessageBox.Show("Не все поля введены");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("К сожалению, в текущей версии данная функция не доступна.\nОжидайте обновлений");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }
    }
}
