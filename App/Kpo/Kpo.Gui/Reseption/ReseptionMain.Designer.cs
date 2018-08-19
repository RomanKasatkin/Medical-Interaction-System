namespace KPO.Admin
{
    partial class ReseptionMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReseptionMain));
            this.Search = new System.Windows.Forms.Button();
            this.FilterPasport = new System.Windows.Forms.RadioButton();
            this.FilterSurname = new System.Windows.Forms.RadioButton();
            this.FilterClient_Id = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.AddCard = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.Switch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.ListView = new System.Windows.Forms.ListView();
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Patronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pasport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NewProcedure = new System.Windows.Forms.Button();
            this.EditCard = new System.Windows.Forms.Button();
            this.ClientInfo = new System.Windows.Forms.Button();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(918, 131);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(152, 33);
            this.Search.TabIndex = 23;
            this.Search.Text = "Поиск пациента";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // FilterPasport
            // 
            this.FilterPasport.AutoSize = true;
            this.FilterPasport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterPasport.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterPasport.Location = new System.Drawing.Point(474, 169);
            this.FilterPasport.Name = "FilterPasport";
            this.FilterPasport.Size = new System.Drawing.Size(151, 22);
            this.FilterPasport.TabIndex = 21;
            this.FilterPasport.Text = "По номеру паспорт";
            this.FilterPasport.UseVisualStyleBackColor = true;
            // 
            // FilterSurname
            // 
            this.FilterSurname.AutoSize = true;
            this.FilterSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterSurname.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterSurname.Location = new System.Drawing.Point(319, 169);
            this.FilterSurname.Name = "FilterSurname";
            this.FilterSurname.Size = new System.Drawing.Size(110, 22);
            this.FilterSurname.TabIndex = 20;
            this.FilterSurname.Text = "По фамилии";
            this.FilterSurname.UseVisualStyleBackColor = true;
            // 
            // FilterClient_Id
            // 
            this.FilterClient_Id.AutoSize = true;
            this.FilterClient_Id.Checked = true;
            this.FilterClient_Id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterClient_Id.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterClient_Id.Location = new System.Drawing.Point(127, 169);
            this.FilterClient_Id.Name = "FilterClient_Id";
            this.FilterClient_Id.Size = new System.Drawing.Size(139, 22);
            this.FilterClient_Id.TabIndex = 19;
            this.FilterClient_Id.TabStop = true;
            this.FilterClient_Id.Text = "По номеру карты";
            this.FilterClient_Id.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FilterClient_Id.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1091, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 16;
            this.monthCalendar1.TodayDate = new System.DateTime(2016, 10, 10, 0, 0, 0, 0);
            // 
            // AddCard
            // 
            this.AddCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCard.Location = new System.Drawing.Point(918, 199);
            this.AddCard.Name = "AddCard";
            this.AddCard.Size = new System.Drawing.Size(139, 76);
            this.AddCard.TabIndex = 15;
            this.AddCard.Text = "Завести карту";
            this.AddCard.UseVisualStyleBackColor = true;
            this.AddCard.Click += new System.EventHandler(this.AddCard_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(1199, 183);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(56, 20);
            this.Time.TabIndex = 13;
            this.Time.Text = "Время";
            // 
            // Switch
            // 
            this.Switch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Switch.Location = new System.Drawing.Point(12, 12);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(70, 40);
            this.Switch.TabIndex = 12;
            this.Switch.Text = "Выкл";
            this.Switch.UseVisualStyleBackColor = true;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBar.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBar.Location = new System.Drawing.Point(87, 131);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(819, 31);
            this.SearchBar.TabIndex = 24;
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Surname,
            this.Name,
            this.Patronymic,
            this.Pasport});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListView.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListView.Location = new System.Drawing.Point(89, 199);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(823, 348);
            this.ListView.TabIndex = 26;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.Visible = false;
            // 
            // Surname
            // 
            this.Surname.Text = "Фамилия";
            this.Surname.Width = 241;
            // 
            // Name
            // 
            this.Name.Text = "Имя";
            this.Name.Width = 186;
            // 
            // Patronymic
            // 
            this.Patronymic.Text = "Отчество";
            this.Patronymic.Width = 194;
            // 
            // Pasport
            // 
            this.Pasport.Text = "Паспорт";
            this.Pasport.Width = 137;
            // 
            // NewProcedure
            // 
            this.NewProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewProcedure.Location = new System.Drawing.Point(918, 291);
            this.NewProcedure.Name = "NewProcedure";
            this.NewProcedure.Size = new System.Drawing.Size(139, 76);
            this.NewProcedure.TabIndex = 27;
            this.NewProcedure.Text = "Записать на приём";
            this.NewProcedure.UseVisualStyleBackColor = true;
            this.NewProcedure.Visible = false;
            this.NewProcedure.Click += new System.EventHandler(this.NewProcedure_Click);
            // 
            // EditCard
            // 
            this.EditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCard.Location = new System.Drawing.Point(918, 471);
            this.EditCard.Name = "EditCard";
            this.EditCard.Size = new System.Drawing.Size(139, 76);
            this.EditCard.TabIndex = 28;
            this.EditCard.Text = "Редактировать карту";
            this.EditCard.UseVisualStyleBackColor = true;
            this.EditCard.Visible = false;
            this.EditCard.Click += new System.EventHandler(this.EditCard_Click);
            // 
            // ClientInfo
            // 
            this.ClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientInfo.Location = new System.Drawing.Point(918, 382);
            this.ClientInfo.Name = "ClientInfo";
            this.ClientInfo.Size = new System.Drawing.Size(139, 76);
            this.ClientInfo.TabIndex = 29;
            this.ClientInfo.Text = "Посмотреть карту";
            this.ClientInfo.UseVisualStyleBackColor = true;
            this.ClientInfo.Visible = false;
            this.ClientInfo.Click += new System.EventHandler(this.ClientInfo_Click_1);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // ReseptionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.ClientInfo);
            this.Controls.Add(this.EditCard);
            this.Controls.Add(this.NewProcedure);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.FilterPasport);
            this.Controls.Add(this.FilterSurname);
            this.Controls.Add(this.FilterClient_Id);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.AddCard);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Switch);
            
            this.Text = "ReseptionMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.RadioButton FilterPasport;
        private System.Windows.Forms.RadioButton FilterSurname;
        private System.Windows.Forms.RadioButton FilterClient_Id;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button AddCard;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button Switch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Button NewProcedure;
        private System.Windows.Forms.Button EditCard;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Patronymic;
        private System.Windows.Forms.ColumnHeader Pasport;
        private System.Windows.Forms.Button ClientInfo;
        private System.Windows.Forms.ColumnHeader Id;
    }
}