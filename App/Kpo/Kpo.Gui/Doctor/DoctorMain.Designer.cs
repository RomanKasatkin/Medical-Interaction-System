namespace KPO.Admin
{
    partial class DoctorMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorMain));
            this.BackButton = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.ListView = new System.Windows.Forms.ListView();
            this.Visit_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client_Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client_Patronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proc_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartWork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(70, 40);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Выход";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(94, 18);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(35, 13);
            this.Time.TabIndex = 1;
            this.Time.Text = "label1";
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Visit_time,
            this.Client_name,
            this.Client_Surname,
            this.Client_Patronymic,
            this.Proc_Type});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListView.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListView.Location = new System.Drawing.Point(117, 127);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(1078, 332);
            this.ListView.TabIndex = 2;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Visit_time
            // 
            this.Visit_time.Text = "Время приёма";
            this.Visit_time.Width = 163;
            // 
            // Client_name
            // 
            this.Client_name.DisplayIndex = 2;
            this.Client_name.Text = "Имя";
            this.Client_name.Width = 195;
            // 
            // Client_Surname
            // 
            this.Client_Surname.DisplayIndex = 1;
            this.Client_Surname.Text = "Фамилия";
            this.Client_Surname.Width = 251;
            // 
            // Client_Patronymic
            // 
            this.Client_Patronymic.Text = "Отчество";
            this.Client_Patronymic.Width = 235;
            // 
            // Proc_Type
            // 
            this.Proc_Type.Text = "Процедура";
            this.Proc_Type.Width = 230;
            // 
            // StartWork
            // 
            this.StartWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartWork.Location = new System.Drawing.Point(621, 465);
            this.StartWork.Name = "StartWork";
            this.StartWork.Size = new System.Drawing.Size(124, 76);
            this.StartWork.TabIndex = 3;
            this.StartWork.Text = "Начать работу";
            this.StartWork.UseVisualStyleBackColor = true;
            this.StartWork.Click += new System.EventHandler(this.StartWork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(120, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите пациента из списка:";
            // 
            // DoctorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartWork);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.BackButton);
            this.Name = "DoctorMain";
            this.Text = "DoctorMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader Visit_time;
        private System.Windows.Forms.ColumnHeader Client_name;
        private System.Windows.Forms.ColumnHeader Client_Surname;
        private System.Windows.Forms.ColumnHeader Client_Patronymic;
        private System.Windows.Forms.Button StartWork;
        private System.Windows.Forms.ColumnHeader Proc_Type;
        private System.Windows.Forms.Label label1;
    }
}