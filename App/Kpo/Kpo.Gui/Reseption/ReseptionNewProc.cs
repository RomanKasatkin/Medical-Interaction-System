using Kpo.BL;
using Kpo.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kpo.BL.Filter;

namespace KPO.Admin
{
    public partial class ReseptionNewProc : Form
    {
        ReseptionMain back;
        long Id;


        Job job = new Job();
        User user = new User();
        Date date = new Date();
        Proc proc = new Proc();
        ProcType proctype = new ProcType();
        FreeTime freetime = new FreeTime();

        List<UserModel> usercollection = new List<UserModel>();
        List<FreeTimeModel> freetimecollection = new List<FreeTimeModel>();
        public ReseptionNewProc(ReseptionMain F, long id)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            back = F;
            this.Id = id;
            List<JobModel> jobcollection = job.List();
            foreach (JobModel j in jobcollection)
            {
                if ((j.Id != 1) && (j.Id != 4) && (j.Id != 5))
                    JobBox.Items.Add(j.Name);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ReseptionNewProc_Load(object sender, EventArgs e)
        {

        }

        private void Switch_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Close();
        }
        private void JobBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //MessageBox.Show(JobBox.SelectedItem.ToString());
            DoctorBox.Items.Clear();
            Doctor.Visible = true;
            DoctorBox.Visible = true;
            FilterCondition filter = new FilterCondition("Job_Id", job.Get_Item("Name", JobBox.SelectedItem.ToString(), ConditionType.Equal).Id, ConditionType.Equal);
            List<FilterCondition> filt = new List<FilterCondition>();
            filt.Add(filter);
            usercollection = user.List(filt);
            foreach (UserModel U in usercollection)
            {
                DoctorBox.Items.Add(U.Name + " " + U.Surname + " " + U.Patronymic);
            }
        }
        private void DoctorBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Day.Visible = true;
            DayBox.Items.Clear();
            DayBox.Visible = true;
            List<DateTime> datecollection = new List<DateTime>();
            freetimecollection = freetime.List("Personal_Id", usercollection[DoctorBox.SelectedIndex].Id.ToString());
            foreach (FreeTimeModel F in freetimecollection)
            {
                datecollection.Add(F.Day);
            }
            IEnumerable<DateTime> dateday = datecollection.Distinct();
            foreach (DateTime D in dateday)
            {
                DayBox.Items.Add(D);
            }
        }

        private void DayBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Time.Visible = true;
            TimeBox.Items.Clear();
            TimeBox.Visible = true;

            FilterCondition filter1 = new FilterCondition("Personal_Id", usercollection[DoctorBox.SelectedIndex].Id.ToString(), ConditionType.Equal);
            FilterCondition filter2 = new FilterCondition("Day", DateTime.Parse(DayBox.SelectedItem.ToString()), ConditionType.Equal);
            List<FilterCondition> filt = new List<FilterCondition>();
            filt.Add(filter1);
            filt.Add(filter2);

            freetimecollection = freetime.List(filt);
            foreach (FreeTimeModel F in freetimecollection)
            {
                if((F.Time.TimeOfDay>Program.Current_Date.TimeOfDay)||(F.Day.Date>Program.Current_Date.Date))
                TimeBox.Items.Add(F.Time.TimeOfDay);
            }
        }

        private void TimeBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ProcType.Visible = true;
            ProcTypeBox.Items.Clear();
            ProcTypeBox.Visible = true;
            List<ProcTypeModel> proctypecollection = new List<ProcTypeModel>();

            //MessageBox.Show(job.Get_Item("Name", JobBox.SelectedItem.ToString(), ConditionType.Equal).Id.ToString());

            FilterCondition filter = new FilterCondition();
            filter.Field = "Job_Id";
            filter.Value = job.Get_Item("Name", JobBox.SelectedItem.ToString(), ConditionType.Equal).Id;
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
        private void ProcTypeBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            NewProc.Visible = true;
        }

        private void NewProc_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Parse(DayBox.SelectedItem.ToString()).Year.ToString());
            //MessageBox.Show(DateTime.Parse(DayBox.SelectedItem.ToString()).Month.ToString());
            //MessageBox.Show(DateTime.Parse(DayBox.SelectedItem.ToString()).Day.ToString());

            DateTime day = new DateTime(DateTime.Parse(DayBox.SelectedItem.ToString()).Year, DateTime.Parse(DayBox.SelectedItem.ToString()).Month, DateTime.Parse(DayBox.SelectedItem.ToString()).Day);
            DateTime time = new DateTime(1, 1, 1, TimeSpan.Parse(TimeBox.SelectedItem.ToString()).Hours, TimeSpan.Parse(TimeBox.SelectedItem.ToString()).Minutes, TimeSpan.Parse(TimeBox.SelectedItem.ToString()).Seconds);
            //MessageBox.Show(day.ToString());
            //MessageBox.Show(time.ToString());

            ProcModel procmodel = new ProcModel();

            FreeTimeModel freetimemodel = new FreeTimeModel();
            freetimemodel.Day = day;
            freetimemodel.Time = time;
            freetimemodel.Personal_Id = usercollection[DoctorBox.SelectedIndex].Id;
            freetimemodel.Id = freetime.Get_Item(freetimemodel.Day, freetimemodel.Time, freetimemodel.Personal_Id).Id;
            procmodel.Client_Id = Id;
            procmodel.Personal_Id = usercollection[DoctorBox.SelectedIndex].Id;
            procmodel.Proc_Type_Id = proctype.Get_Item("Name", ProcTypeBox.SelectedItem.ToString(), ConditionType.Equal).Id;
            procmodel.Date_Id = date.SwapFreeTime(freetimemodel);

            //MessageBox.Show(procmodel.ToString());
            proc.Add(procmodel);
            MessageBox.Show("Сохранено");
            back.Show();
            this.Close();






        }

    }
}
