﻿namespace ArtActionProject
{
    partial class CustomerInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInfoForm));
            this.pbBackGuideForm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.ListBox();
            this.EMAIL = new System.Windows.Forms.ListBox();
            this.CARD_NUMBER = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGuideForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackGuideForm
            // 
            this.pbBackGuideForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBackGuideForm.BackgroundImage")));
            this.pbBackGuideForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBackGuideForm.Location = new System.Drawing.Point(12, 299);
            this.pbBackGuideForm.Name = "pbBackGuideForm";
            this.pbBackGuideForm.Size = new System.Drawing.Size(43, 43);
            this.pbBackGuideForm.TabIndex = 10;
            this.pbBackGuideForm.TabStop = false;
            this.pbBackGuideForm.Click += new System.EventHandler(this.PbBackGuideForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.label1.Location = new System.Drawing.Point(146, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "고객정보";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ID
            // 
            this.ID.FormattingEnabled = true;
            this.ID.ItemHeight = 12;
            this.ID.Location = new System.Drawing.Point(90, 142);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(182, 28);
            this.ID.TabIndex = 12;
            // 
            // EMAIL
            // 
            this.EMAIL.FormattingEnabled = true;
            this.EMAIL.ItemHeight = 12;
            this.EMAIL.Location = new System.Drawing.Point(90, 176);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(182, 28);
            this.EMAIL.TabIndex = 12;
            // 
            // CARD_NUMBER
            // 
            this.CARD_NUMBER.FormattingEnabled = true;
            this.CARD_NUMBER.ItemHeight = 12;
            this.CARD_NUMBER.Location = new System.Drawing.Point(90, 210);
            this.CARD_NUMBER.Name = "CARD_NUMBER";
            this.CARD_NUMBER.Size = new System.Drawing.Size(182, 28);
            this.CARD_NUMBER.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(50, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 340);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 39);
            this.label3.TabIndex = 20;
            this.label3.Text = "USERINFO";
            // 
            // CustomerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(367, 354);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CARD_NUMBER);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.pbBackGuideForm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerInfoForm";
            this.Load += new System.EventHandler(this.CustomerInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGuideForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackGuideForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ID;
        private System.Windows.Forms.ListBox EMAIL;
        private System.Windows.Forms.ListBox CARD_NUMBER;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}