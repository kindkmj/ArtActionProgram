namespace ArtActionProject
{
    partial class GuidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuidForm));
            this.btnEnterGuideForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBackGuideForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGuideForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterGuideForm
            // 
            this.btnEnterGuideForm.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterGuideForm.Location = new System.Drawing.Point(470, 398);
            this.btnEnterGuideForm.Name = "btnEnterGuideForm";
            this.btnEnterGuideForm.Size = new System.Drawing.Size(323, 91);
            this.btnEnterGuideForm.TabIndex = 0;
            this.btnEnterGuideForm.Text = "사용방법을 이해했습니다";
            this.btnEnterGuideForm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(565, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "이용가이드";
            // 
            // pbBackGuideForm
            // 
            this.pbBackGuideForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBackGuideForm.BackgroundImage")));
            this.pbBackGuideForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBackGuideForm.Location = new System.Drawing.Point(40, 22);
            this.pbBackGuideForm.Name = "pbBackGuideForm";
            this.pbBackGuideForm.Size = new System.Drawing.Size(43, 43);
            this.pbBackGuideForm.TabIndex = 9;
            this.pbBackGuideForm.TabStop = false;
            this.pbBackGuideForm.Click += new System.EventHandler(this.PbBackGuideForm_Click);
            // 
            // GuidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1241, 618);
            this.Controls.Add(this.pbBackGuideForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnterGuideForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuidForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGuideForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterGuideForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBackGuideForm;
    }
}