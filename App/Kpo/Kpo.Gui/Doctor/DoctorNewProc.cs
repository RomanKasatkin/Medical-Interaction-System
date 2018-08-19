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

namespace KPO.Admin.Doctor
{
    public partial class DoctorNewProc : Form
    {
        Job job = new Job();
        User user = new User();

        Date date = new Date();
        Proc proc = new Proc();
        ProcType proctype = new ProcType();
        FreeTime freetime = new FreeTime();
        List<FreeTimeModel> freetimecollection = new List<FreeTimeModel>();
        DoctorStartWork back;
        long Client_Id;
        long Doctor_Id;
        long Proc_Id;
        public DoctorNewProc(DoctorStartWork F, long Client_Id, long Doctor_Id, long Proc_Id)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            back = F;
            this.Client_Id = Client_Id;
            this.Doctor_Id = Doctor_Id;
            this.Proc_Id = Proc_Id;
            List<DateTime> datecollection = new List<DateTime>();
            freetimecollection = freetime.List("Personal_Id", Doctor_Id.ToString());
            foreach (FreeTimeModel free in freetimecollection)
            {
                datecollection.Add(free.Day);
            }
            IEnumerable<DateTime> dateday = datecollection.Distinct();
            foreach (DateTime D in dateday)
            {
                DayBox.Items.Add(D);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime day = new DateTime(DateTime.Parse(DayBox.SelectedItem.ToString()).Year, DateTime.Parse(DayBox.SelectedItem.ToString()).Month, DateTime.Parse(DayBox.SelectedItem.ToString()).Day);
            DateTime time = new DateTime(1, 1, 1, TimeSpan.Parse(TimeBox.SelectedItem.ToString()).Hours, TimeSpan.Parse(TimeBox.SelectedItem.ToString()).Minutes, TimeSpan.Parse(TimeBox.SelectedItem.ToString()).Seconds);
            //MessageBox.Show(day.ToString());
            //MessageBox.Show(time.ToString());

            ProcModel procmodel = new ProcModel();

            FreeTimeModel freetimemodel = new FreeTimeModel();
            freetimemodel.Day = day;
            freetimemodel.Time = time;
            freetimemodel.Personal_Id = Doctor_Id;
            freetimemodel.Id = freetime.Get_Item(freetimemodel.Day, freetimemodel.Time, freetimemodel.Personal_Id).Id;
            procmodel.Client_Id = Client_Id;
            procmodel.Personal_Id = Doctor_Id;
            procmodel.Proc_Type_Id = proctype.Get_Item("Name", ProcTypeBox.SelectedItem.ToString(), ConditionType.Equal).Id;
            procmodel.Date_Id = date.SwapFreeTime(freetimemodel);



            //MessageBox.Show(procmodel.ToString());
            proc.Add(procmodel);
            MessageBox.Show("Сохранено");
            proc.Delete(Proc_Id);
            back.back.Refresh_list();
            back.back.Show();
            back.Close();
            this.Close();

        }

        private void DayBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            label2.Visible = true;
            TimeBox.Items.Clear();
            TimeBox.Visible = true;

            FilterCondition filter1 = new FilterCondition("Personal_Id", Doctor_Id.ToString(), ConditionType.Equal);
            FilterCondition filter2 = new FilterCondition("Day", DateTime.Parse(DayBox.SelectedItem.ToString()), ConditionType.Equal);
            List<FilterCondition> filt = new List<FilterCondition>();
            filt.Add(filter1);
            filt.Add(filter2);

            freetimecollection = freetime.List(filt);
            foreach (FreeTimeModel F in freetimecollection)
            {
                TimeBox.Items.Add(F.Time.TimeOfDay);
            }
        }

        private void TimeBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            label3.Visible = true;
            ProcTypeBox.Items.Clear();
            ProcTypeBox.Visible = true;
            List<ProcTypeModel> proctypecollection = new List<ProcTypeModel>();

            //MessageBox.Show(job.Get_Item("Name", JobBox.SelectedItem.ToString(), ConditionType.Equal).Id.ToString());

            FilterCondition filter = new FilterCondition();
            filter.Field = "Job_Id";
            filter.Value = user.Get_Item("Id", Doctor_Id.ToString(), ConditionType.Equal).Job_Id.ToString();
            filter.Type = ConditionType.Equal;
            List<FilterCondition> filt = new List<FilterCondition>();
            filt.Add(filter);

            proctypecollection = proctype.List(filt);
            ProcTypeBox.Items.Add(proctype.Get_Item("Id", "2", ConditionType.Equal).Name);
            foreach (ProcTypeModel P in proctypecollection)
            {
                ProcTypeBox.Items.Add(P.Name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            back.back.Refresh_list();
            back.back.Show();
            back.Close();
            this.Close();
        }
    }
}
