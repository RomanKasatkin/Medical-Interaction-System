namespace KPO.Admin
{
    partial class DoctorClientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorClientInfo));
            this.BackButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.History = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Analyse = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.TabControl.SuspendLayout();
            this.History.SuspendLayout();
            this.Analyse.SuspendLayout();
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
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.History);
            this.TabControl.Controls.Add(this.Analyse);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControl.ItemSize = new System.Drawing.Size(70, 30);
            this.TabControl.Location = new System.Drawing.Point(103, 13);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1093, 570);
            this.TabControl.TabIndex = 1;
            // 
            // History
            // 
            this.History.Controls.Add(this.listBox1);
            this.History.Location = new System.Drawing.Point(4, 34);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(1085, 532);
            this.History.TabIndex = 0;
            this.History.Text = "История";
            this.History.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 2);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1076, 504);
            this.listBox1.TabIndex = 0;
            // 
            // Analyse
            // 
            this.Analyse.Controls.Add(this.listBox2);
            this.Analyse.Location = new System.Drawing.Point(4, 34);
            this.Analyse.Name = "Analyse";
            this.Analyse.Padding = new System.Windows.Forms.Padding(3);
            this.Analyse.Size = new System.Drawing.Size(1085, 532);
            this.Analyse.TabIndex = 1;
            this.Analyse.Text = "Анализы";
            this.Analyse.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1079, 520);
            this.listBox2.TabIndex = 0;
            // 
            // DoctorClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.BackButton);
            this.Name = "DoctorClientInfo";
            this.Text = "DoctorClientInfo";
            this.TabControl.ResumeLayout(false);
            this.History.ResumeLayout(false);
            this.Analyse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage Analyse;
        private System.Windows.Forms.ListBox listBox2;
    }
}