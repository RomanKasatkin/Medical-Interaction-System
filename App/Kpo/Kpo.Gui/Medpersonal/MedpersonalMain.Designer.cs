namespace KPO.Admin
{
    partial class MedpersonalMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedpersonalMain));
            this.BackButton = new System.Windows.Forms.Button();
            this.AddAnalyse = new System.Windows.Forms.Button();
            this.Client_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client_Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client_Patronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView = new System.Windows.Forms.ListView();
            this.Client_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Analyse_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Coment = new System.Windows.Forms.TextBox();
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
            // AddAnalyse
            // 
            this.AddAnalyse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAnalyse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAnalyse.Location = new System.Drawing.Point(621, 519);
            this.AddAnalyse.Name = "AddAnalyse";
            this.AddAnalyse.Size = new System.Drawing.Size(124, 76);
            this.AddAnalyse.TabIndex = 5;
            this.AddAnalyse.Text = "Сохранить";
            this.AddAnalyse.UseVisualStyleBackColor = true;
            this.AddAnalyse.Click += new System.EventHandler(this.AddAnalyse_Click_1);
            // 
            // Client_name
            // 
            this.Client_name.Text = "Имя";
            this.Client_name.Width = 231;
            // 
            // Client_Surname
            // 
            this.Client_Surname.Text = "Фамилия";
            this.Client_Surname.Width = 280;
            // 
            // Client_Patronymic
            // 
            this.Client_Patronymic.Text = "Отчество";
            this.Client_Patronymic.Width = 248;
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Client_Id,
            this.Client_Surname,
            this.Client_name,
            this.Client_Patronymic});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListView.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListView.Location = new System.Drawing.Point(163, 240);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(920, 273);
            this.ListView.TabIndex = 4;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // Client_Id
            // 
            this.Client_Id.Text = "№ карты";
            this.Client_Id.Width = 157;
            // 
            // Analyse_Type
            // 
            this.Analyse_Type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Analyse_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Analyse_Type.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Analyse_Type.FormattingEnabled = true;
            this.Analyse_Type.Location = new System.Drawing.Point(383, 31);
            this.Analyse_Type.Name = "Analyse_Type";
            this.Analyse_Type.Size = new System.Drawing.Size(700, 31);
            this.Analyse_Type.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(216, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тип анализа:";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(163, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(688, 31);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(857, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Поиск пациента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(405, 200);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(151, 27);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По фамилии";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(208, 200);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(195, 27);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По номеру карты";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ResultText
            // 
            this.ResultText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResultText.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultText.Location = new System.Drawing.Point(382, 71);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(309, 31);
            this.ResultText.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(244, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Результат:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(201, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Комментарий:";
            // 
            // Coment
            // 
            this.Coment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Coment.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Coment.Location = new System.Drawing.Point(382, 115);
            this.Coment.Name = "Coment";
            this.Coment.Size = new System.Drawing.Size(701, 27);
            this.Coment.TabIndex = 15;
            // 
            // MedpersonalMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.Coment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Analyse_Type);
            this.Controls.Add(this.AddAnalyse);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.BackButton);
            this.Name = "MedpersonalMain";
            this.Text = "MedpersonalMain";
            this.Load += new System.EventHandler(this.MedpersonalMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddAnalyse;
        private System.Windows.Forms.ColumnHeader Client_name;
        private System.Windows.Forms.ColumnHeader Client_Surname;
        private System.Windows.Forms.ColumnHeader Client_Patronymic;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader Client_Id;
        private System.Windows.Forms.ComboBox Analyse_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Coment;
    }
}