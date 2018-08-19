namespace KPO.Admin
{
    partial class DoctorStartWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorStartWork));
            this.Cancel = new System.Windows.Forms.Button();
            this.SymtomsText = new System.Windows.Forms.TextBox();
            this.ShowMaterials = new System.Windows.Forms.Button();
            this.DiagnosysText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(12, 12);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(79, 40);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SymtomsText
            // 
            this.SymtomsText.BackColor = System.Drawing.Color.PapayaWhip;
            this.SymtomsText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SymtomsText.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SymtomsText.Location = new System.Drawing.Point(281, 114);
            this.SymtomsText.Multiline = true;
            this.SymtomsText.Name = "SymtomsText";
            this.SymtomsText.Size = new System.Drawing.Size(653, 166);
            this.SymtomsText.TabIndex = 1;
            // 
            // ShowMaterials
            // 
            this.ShowMaterials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowMaterials.Location = new System.Drawing.Point(953, 64);
            this.ShowMaterials.Name = "ShowMaterials";
            this.ShowMaterials.Size = new System.Drawing.Size(124, 76);
            this.ShowMaterials.TabIndex = 2;
            this.ShowMaterials.Text = "Показать карту";
            this.ShowMaterials.UseVisualStyleBackColor = true;
            this.ShowMaterials.Click += new System.EventHandler(this.ShowMaterials_Click);
            // 
            // DiagnosysText
            // 
            this.DiagnosysText.BackColor = System.Drawing.Color.PapayaWhip;
            this.DiagnosysText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiagnosysText.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiagnosysText.Location = new System.Drawing.Point(281, 286);
            this.DiagnosysText.Multiline = true;
            this.DiagnosysText.Name = "DiagnosysText";
            this.DiagnosysText.Size = new System.Drawing.Size(653, 276);
            this.DiagnosysText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Симптомы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(171, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Диагноз:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(165, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пациент:";
            // 
            // ClientName
            // 
            this.ClientName.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientName.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientName.Location = new System.Drawing.Point(281, 64);
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Size = new System.Drawing.Size(653, 31);
            this.ClientName.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(953, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoctorStartWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiagnosysText);
            this.Controls.Add(this.ShowMaterials);
            this.Controls.Add(this.SymtomsText);
            this.Controls.Add(this.Cancel);
            this.Name = "DoctorStartWork";
            this.Text = "DoctorStartWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox SymtomsText;
        private System.Windows.Forms.Button ShowMaterials;
        private System.Windows.Forms.TextBox DiagnosysText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Button button1;
    }
}