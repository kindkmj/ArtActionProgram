namespace ArtActionProject
{
    partial class GuideForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuideForm));
            this.btnEnterGuideForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterGuideForm
            // 
            this.btnEnterGuideForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnEnterGuideForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnterGuideForm.BackgroundImage")));
            this.btnEnterGuideForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnterGuideForm.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.btnEnterGuideForm.Location = new System.Drawing.Point(393, 492);
            this.btnEnterGuideForm.Name = "btnEnterGuideForm";
            this.btnEnterGuideForm.Size = new System.Drawing.Size(207, 77);
            this.btnEnterGuideForm.TabIndex = 1;
            this.btnEnterGuideForm.Text = "확인했습니다";
            this.btnEnterGuideForm.UseVisualStyleBackColor = false;
            this.btnEnterGuideForm.Click += new System.EventHandler(this.BtnEnterGuideForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1009, 521);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 34F);
            this.label3.Location = new System.Drawing.Point(313, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 57);
            this.label3.TabIndex = 20;
            this.label3.Text = "APPLICATION GUIDE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(270, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(451, 57);
            this.label4.TabIndex = 23;
            this.label4.Text = "안녕하세요. \r\n사용자님 저희 프로그램은 아트 셀러들이 시간과 장소에 한정 되지 않고\r\n작품의 감상과 이해가 가능한 상황을 목적으로 한 플랫폼 입" +
    "니다.";
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(991, 581);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnterGuideForm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuideForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterGuideForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}