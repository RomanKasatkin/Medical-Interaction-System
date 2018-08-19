namespace KPO.Admin
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Patrontmic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChangeUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.AddJob = new System.Windows.Forms.Button();
            this.AddProc = new System.Windows.Forms.Button();
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
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Surname,
            this.Name,
            this.Patrontmic,
            this.Job,
            this.Login,
            this.Password});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListView.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListView.Location = new System.Drawing.Point(135, 74);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(875, 434);
            this.ListView.TabIndex = 1;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "№";
            this.Number.Width = 33;
            // 
            // Name
            // 
            this.Name.Text = "Имя";
            this.Name.Width = 115;
            // 
            // Surname
            // 
            this.Surname.Text = "Фамилия";
            this.Surname.Width = 164;
            // 
            // Patrontmic
            // 
            this.Patrontmic.Text = "Отчество";
            this.Patrontmic.Width = 161;
            // 
            // Job
            // 
            this.Job.Text = "Должность";
            this.Job.Width = 157;
            // 
            // Login
            // 
            this.Login.Text = "Логин";
            this.Login.Width = 124;
            // 
            // Password
            // 
            this.Password.Text = "Пароль";
            this.Password.Width = 115;
            // 
            // ChangeUser
            // 
            this.ChangeUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeUser.Location = new System.Drawing.Point(1061, 183);
            this.ChangeUser.Name = "ChangeUser";
            this.ChangeUser.Size = new System.Drawing.Size(142, 76);
            this.ChangeUser.TabIndex = 2;
            this.ChangeUser.Text = "Редактировать пользователя";
            this.ChangeUser.UseVisualStyleBackColor = true;
            this.ChangeUser.Click += new System.EventHandler(this.ChangeUser_Click);
            // 
            // AddUser
            // 
            this.AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUser.Location = new System.Drawing.Point(1061, 101);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(142, 76);
            this.AddUser.TabIndex = 3;
            this.AddUser.Text = "Добавить нового пользователя";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteUser.Location = new System.Drawing.Point(1061, 265);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(142, 76);
            this.DeleteUser.TabIndex = 4;
            this.DeleteUser.Text = "Удалить пользователя";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click_1);
            // 
            // AddJob
            // 
            this.AddJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddJob.Location = new System.Drawing.Point(1061, 347);
            this.AddJob.Name = "AddJob";
            this.AddJob.Size = new System.Drawing.Size(142, 76);
            this.AddJob.TabIndex = 5;
            this.AddJob.Text = "Добавить должность";
            this.AddJob.UseVisualStyleBackColor = true;
            this.AddJob.Click += new System.EventHandler(this.AddJob_Click_1);
            // 
            // AddProc
            // 
            this.AddProc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProc.Location = new System.Drawing.Point(1061, 429);
            this.AddProc.Name = "AddProc";
            this.AddProc.Size = new System.Drawing.Size(142, 76);
            this.AddProc.TabIndex = 6;
            this.AddProc.Text = "Добавить тип процедуры";
            this.AddProc.UseVisualStyleBackColor = true;
            this.AddProc.Click += new System.EventHandler(this.AddProc_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список существующих пользователей:";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddProc);
            this.Controls.Add(this.AddJob);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.ChangeUser);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.BackButton);
            
            this.RightToLeftLayout = true;
            this.Text = "AdminMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Patrontmic;
        private System.Windows.Forms.ColumnHeader Job;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.Button ChangeUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button AddJob;
        private System.Windows.Forms.Button AddProc;
        private System.Windows.Forms.Label label1;

    }
}