﻿namespace KPO.Admin
{
    partial class AdminAddJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddJob));
            this.BackButton = new System.Windows.Forms.Button();
            this.JobText = new System.Windows.Forms.TextBox();
            this.AddJob = new System.Windows.Forms.Button();
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
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // JobText
            // 
            this.JobText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JobText.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JobText.Location = new System.Drawing.Point(657, 239);
            this.JobText.Name = "JobText";
            this.JobText.Size = new System.Drawing.Size(311, 31);
            this.JobText.TabIndex = 1;
            // 
            // AddJob
            // 
            this.AddJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddJob.Location = new System.Drawing.Point(621, 465);
            this.AddJob.Name = "AddJob";
            this.AddJob.Size = new System.Drawing.Size(124, 76);
            this.AddJob.TabIndex = 2;
            this.AddJob.Text = "Добавить";
            this.AddJob.UseVisualStyleBackColor = true;
            this.AddJob.Click += new System.EventHandler(this.AddJob_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(403, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название должности:";
            // 
            // AdminAddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddJob);
            this.Controls.Add(this.JobText);
            this.Controls.Add(this.BackButton);
            this.Name = "AdminAddJob";
            this.Text = "AdminAddJob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox JobText;
        private System.Windows.Forms.Button AddJob;
        private System.Windows.Forms.Label label1;
    }
}