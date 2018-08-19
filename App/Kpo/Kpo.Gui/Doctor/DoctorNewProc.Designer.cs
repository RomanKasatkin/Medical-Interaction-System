namespace KPO.Admin.Doctor
{
    partial class DoctorNewProc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorNewProc));
            this.button1 = new System.Windows.Forms.Button();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.ProcTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DayBox
            // 
            this.DayBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(592, 273);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(121, 31);
            this.DayBox.TabIndex = 1;
            this.DayBox.SelectedIndexChanged += new System.EventHandler(this.DayBox_SelectedIndexChanged);
            // 
            // TimeBox
            // 
            this.TimeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Location = new System.Drawing.Point(592, 327);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(121, 31);
            this.TimeBox.TabIndex = 2;
            this.TimeBox.Visible = false;
            this.TimeBox.SelectedIndexChanged += new System.EventHandler(this.TimeBox_SelectedIndexChanged);
            // 
            // ProcTypeBox
            // 
            this.ProcTypeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProcTypeBox.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcTypeBox.FormattingEnabled = true;
            this.ProcTypeBox.Location = new System.Drawing.Point(592, 209);
            this.ProcTypeBox.Name = "ProcTypeBox";
            this.ProcTypeBox.Size = new System.Drawing.Size(369, 31);
            this.ProcTypeBox.TabIndex = 3;
            this.ProcTypeBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(517, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(504, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(452, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип услуги:";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(621, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 76);
            this.button2.TabIndex = 7;
            this.button2.Text = "Записать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoctorNewProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcTypeBox);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.button1);
            this.Name = "DoctorNewProc";
            this.Text = "DoctorNewProc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.ComboBox TimeBox;
        private System.Windows.Forms.ComboBox ProcTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}