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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUserInfoGuideForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterGuideForm
            // 
            this.btnEnterGuideForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnEnterGuideForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnterGuideForm.BackgroundImage")));
            this.btnEnterGuideForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnterGuideForm.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.btnEnterGuideForm.Location = new System.Drawing.Point(255, 253);
            this.btnEnterGuideForm.Name = "btnEnterGuideForm";
            this.btnEnterGuideForm.Size = new System.Drawing.Size(139, 50);
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
            this.pictureBox1.Size = new System.Drawing.Size(1009, 197);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(203, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "APPLICATION GUIDE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(193, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "님 저희 프로그램은 사용자님이 시간과 장소에 한정되지 않고\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(79, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 3);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(134, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "좋은 작품들을 만나기 위한 기회를 제공하는 아트 옥션 프로그램입니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(134, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "안녕하세요. \r\n";
            // 
            // lbUserInfoGuideForm
            // 
            this.lbUserInfoGuideForm.AutoSize = true;
            this.lbUserInfoGuideForm.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.lbUserInfoGuideForm.ForeColor = System.Drawing.Color.Black;
            this.lbUserInfoGuideForm.Location = new System.Drawing.Point(151, 177);
            this.lbUserInfoGuideForm.Name = "lbUserInfoGuideForm";
            this.lbUserInfoGuideForm.Size = new System.Drawing.Size(47, 17);
            this.lbUserInfoGuideForm.TabIndex = 27;
            this.lbUserInfoGuideForm.Text = "사용자\r\n";
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(675, 315);
            this.Controls.Add(this.lbUserInfoGuideForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnterGuideForm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuideForm";
            this.Load += new System.EventHandler(this.GuideForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterGuideForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUserInfoGuideForm;
    }
}