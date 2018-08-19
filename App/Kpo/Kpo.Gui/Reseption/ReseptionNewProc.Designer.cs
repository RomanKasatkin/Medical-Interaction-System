namespace KPO.Admin
{
    partial class ReseptionNewProc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReseptionNewProc));
            this.Switch = new System.Windows.Forms.Button();
            this.JobBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Doctor = new System.Windows.Forms.Label();
            this.DoctorBox = new System.Windows.Forms.ComboBox();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.Time = new System.Windows.Forms.Label();
            this.ProcType = new System.Windows.Forms.Label();
            this.ProcTypeBox = new System.Windows.Forms.ComboBox();
            this.NewProc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Switch
            // 
            this.Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Switch.Location = new System.Drawing.Point(12, 12);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(70, 40);
            this.Switch.TabIndex = 13;
            this.Switch.Text = "Назад";
            this.Switch.UseVisualStyleBackColor = true;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // JobBox
            // 
            this.JobBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JobBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JobBox.FormattingEnabled = true;
            this.JobBox.Location = new System.Drawing.Point(589, 131);
            this.JobBox.Name = "JobBox";
            this.JobBox.Size = new System.Drawing.Size(420, 31);
            this.JobBox.TabIndex = 14;
            this.JobBox.SelectedIndexChanged += new System.EventHandler(this.JobBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(314, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Специальность врача:";
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Doctor.Location = new System.Drawing.Point(419, 180);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(137, 26);
            this.Doctor.TabIndex = 16;
            this.Doctor.Text = "ФИО врача:";
            this.Doctor.Visible = false;
            // 
            // DoctorBox
            // 
            this.DoctorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoctorBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorBox.FormattingEnabled = true;
            this.DoctorBox.Location = new System.Drawing.Point(589, 180);
            this.DoctorBox.Name = "DoctorBox";
            this.DoctorBox.Size = new System.Drawing.Size(420, 31);
            this.DoctorBox.TabIndex = 17;
            this.DoctorBox.Visible = false;
            this.DoctorBox.SelectedIndexChanged += new System.EventHandler(this.DoctorBox_SelectedIndexChanged);
            // 
            // DayBox
            // 
            this.DayBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(589, 230);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(116, 31);
            this.DayBox.TabIndex = 18;
            this.DayBox.Visible = false;
            this.DayBox.SelectedIndexChanged += new System.EventHandler(this.DayBox_SelectedIndexChanged);
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Day.Location = new System.Drawing.Point(490, 230);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(66, 26);
            this.Day.TabIndex = 19;
            this.Day.Text = "Дата:";
            this.Day.Visible = false;
            // 
            // TimeBox
            // 
            this.TimeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Location = new System.Drawing.Point(589, 280);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(121, 31);
            this.TimeBox.TabIndex = 20;
            this.TimeBox.Visible = false;
            this.TimeBox.SelectedIndexChanged += new System.EventHandler(this.TimeBox_SelectedIndexChanged);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(474, 280);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(82, 26);
            this.Time.TabIndex = 21;
            this.Time.Text = "Время:";
            this.Time.Visible = false;
            // 
            // ProcType
            // 
            this.ProcType.AutoSize = true;
            this.ProcType.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcType.Location = new System.Drawing.Point(373, 341);
            this.ProcType.Name = "ProcType";
            this.ProcType.Size = new System.Drawing.Size(183, 26);
            this.ProcType.TabIndex = 22;
            this.ProcType.Text = "Тип процедуры:";
            this.ProcType.Visible = false;
            this.ProcType.Click += new System.EventHandler(this.label4_Click);
            // 
            // ProcTypeBox
            // 
            this.ProcTypeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProcTypeBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcTypeBox.FormattingEnabled = true;
            this.ProcTypeBox.Location = new System.Drawing.Point(589, 341);
            this.ProcTypeBox.Name = "ProcTypeBox";
            this.ProcTypeBox.Size = new System.Drawing.Size(420, 31);
            this.ProcTypeBox.TabIndex = 23;
            this.ProcTypeBox.Visible = false;
            this.ProcTypeBox.SelectedIndexChanged += new System.EventHandler(this.ProcTypeBox_SelectedIndexChanged);
            // 
            // NewProc
            // 
            this.NewProc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewProc.Location = new System.Drawing.Point(621, 465);
            this.NewProc.Name = "NewProc";
            this.NewProc.Size = new System.Drawing.Size(124, 76);
            this.NewProc.TabIndex = 24;
            this.NewProc.Text = "Записать";
            this.NewProc.UseVisualStyleBackColor = true;
            this.NewProc.Visible = false;
            this.NewProc.Click += new System.EventHandler(this.NewProc_Click);
            // 
            // ReseptionNewProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.NewProc);
            this.Controls.Add(this.ProcTypeBox);
            this.Controls.Add(this.ProcType);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.DoctorBox);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JobBox);
            this.Controls.Add(this.Switch);
            this.Name = "ReseptionNewProc";
            this.Text = "ReseptionNewProc";
            this.Load += new System.EventHandler(this.ReseptionNewProc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        

     
        

        

        #endregion

        private System.Windows.Forms.Button Switch;
        private System.Windows.Forms.ComboBox JobBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Doctor;
        private System.Windows.Forms.ComboBox DoctorBox;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.ComboBox TimeBox;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label ProcType;
        private System.Windows.Forms.ComboBox ProcTypeBox;
        private System.Windows.Forms.Button NewProc;
    }
}