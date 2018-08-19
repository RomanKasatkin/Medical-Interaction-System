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
    public partial class StartWindow : Form
    {
       
        
        public StartWindow()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Enabled = true;
            timer1.Start();                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoginWindow W = new LoginWindow(this);
            W.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
