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
    public partial class DoctorClientInfo : Form
    {
        DoctorStartWork back;
        Client client = new Client();
        User user = new User();
        History history = new History();
        Analyse analyse = new Analyse();
        AnalyseType analysetype = new AnalyseType();
        Date date = new Date();

        long Id;
        public DoctorClientInfo(DoctorStartWork F, long Id)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            this.Id = Id;
            back = F;
            FilterCondition filter = new FilterCondition("Client_Id", Id, ConditionType.Equal);
            //MessageBox.Show(Id.ToString());
            List<FilterCondition> filt = new List<FilterCondition>();
            filt.Add(filter);
            List<HistoryModel> collection = history.List(filt);
            /*foreach (HistoryModel H in collection)
            {
                //MessageBox.Show(H.ToString());
            }*/

            foreach (HistoryModel H in collection)
            {

                listBox1.Items.Add(
                    "Диагноз:  "
                    + H.Diagnosis
                    + "\t Запись от "
                    + date.Get_Item("Id", H.Date_Id.ToString(), ConditionType.Equal).Day.Year + "."
                    + date.Get_Item("Id", H.Date_Id.ToString(), ConditionType.Equal).Day.Month + "."
                    + date.Get_Item("Id", H.Date_Id.ToString(), ConditionType.Equal).Day.Day
                    + ".   Врач "
                    + user.Get_Item("Id", H.Personal_Id.ToString(), ConditionType.Equal).Name
                    + " "
                    + user.Get_Item("Id", H.Personal_Id.ToString(), ConditionType.Equal).Surname
                    );
                listBox1.Items.Add("Симптомы: " + H.Symptoms);
            }

            List<AnalyseModel> ancollection = analyse.List(filt);
            foreach (AnalyseModel H in ancollection)
            {

                listBox2.Items.Add(
                    date.Get_Item("Id", H.Date_Id.ToString(), ConditionType.Equal).Day.Year + "."
                    + date.Get_Item("Id", H.Date_Id.ToString(), ConditionType.Equal).Day.Month + "."
                    + date.Get_Item("Id", H.Date_Id.ToString(), ConditionType.Equal).Day.Day
                    + "\tАнализ: "
                    + analysetype.Get_Item("Id", H.Type_Id.ToString(), ConditionType.Equal).Name
                    + "\t Значение: "
                    + H.Result
                    + "\t Комментарий: "
                    + H.Coment
                    );
            }




        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }
    }
}
