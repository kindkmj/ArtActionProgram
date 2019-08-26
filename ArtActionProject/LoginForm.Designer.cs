namespace ArtActionProject
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogInForm = new System.Windows.Forms.Button();
            this.tbIDLogInForm = new System.Windows.Forms.TextBox();
            this.tbPWLogInForm = new System.Windows.Forms.TextBox();
            this.pbExitLogInForm = new System.Windows.Forms.PictureBox();
            this.btnOpenResisterFormLogInForm = new System.Windows.Forms.Button();
            this.btnFindIDLogInForm = new System.Windows.Forms.Button();
            this.btnFindPWLogInForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbExitLogInForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogInForm
            // 
            this.btnLogInForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogInForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogInForm.BackgroundImage")));
            this.btnLogInForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogInForm.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInForm.Location = new System.Drawing.Point(449, 116);
            this.btnLogInForm.Name = "btnLogInForm";
            this.btnLogInForm.Size = new System.Drawing.Size(180, 63);
            this.btnLogInForm.TabIndex = 3;
            this.btnLogInForm.Text = "LOGIN";
            this.btnLogInForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogInForm.UseVisualStyleBackColor = false;
            this.btnLogInForm.Click += new System.EventHandler(this.BtnLogInForm_Click);
            // 
            // tbIDLogInForm
            // 
            this.tbIDLogInForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbIDLogInForm.Location = new System.Drawing.Point(170, 131);
            this.tbIDLogInForm.Name = "tbIDLogInForm";
            this.tbIDLogInForm.Size = new System.Drawing.Size(200, 21);
            this.tbIDLogInForm.TabIndex = 1;
            this.tbIDLogInForm.Text = "ID";
            this.tbIDLogInForm.Enter += new System.EventHandler(this.TbIDLogInForm_Enter);
            // 
            // tbPWLogInForm
            // 
            this.tbPWLogInForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPWLogInForm.Location = new System.Drawing.Point(170, 168);
            this.tbPWLogInForm.Name = "tbPWLogInForm";
            this.tbPWLogInForm.PasswordChar = '*';
            this.tbPWLogInForm.Size = new System.Drawing.Size(200, 21);
            this.tbPWLogInForm.TabIndex = 2;
            this.tbPWLogInForm.Text = "PASSWORD";
            this.tbPWLogInForm.Enter += new System.EventHandler(this.TbPWLogInForm_Enter);
            this.tbPWLogInForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPWLogInForm_KeyDown);
            // 
            // pbExitLogInForm
            // 
            this.pbExitLogInForm.Location = new System.Drawing.Point(543, 231);
            this.pbExitLogInForm.Name = "pbExitLogInForm";
            this.pbExitLogInForm.Size = new System.Drawing.Size(62, 70);
            this.pbExitLogInForm.TabIndex = 3;
            this.pbExitLogInForm.TabStop = false;
            this.pbExitLogInForm.Click += new System.EventHandler(this.PbExitLogInForm_Click);
            // 
            // btnOpenResisterFormLogInForm
            // 
            this.btnOpenResisterFormLogInForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnOpenResisterFormLogInForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenResisterFormLogInForm.BackgroundImage")));
            this.btnOpenResisterFormLogInForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenResisterFormLogInForm.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenResisterFormLogInForm.Location = new System.Drawing.Point(319, 260);
            this.btnOpenResisterFormLogInForm.Name = "btnOpenResisterFormLogInForm";
            this.btnOpenResisterFormLogInForm.Size = new System.Drawing.Size(143, 41);
            this.btnOpenResisterFormLogInForm.TabIndex = 6;
            this.btnOpenResisterFormLogInForm.Text = "Register";
            this.btnOpenResisterFormLogInForm.UseVisualStyleBackColor = false;
            this.btnOpenResisterFormLogInForm.Click += new System.EventHandler(this.BtnOpenRegisterFormLogInForm_Click);
            // 
            // btnFindIDLogInForm
            // 
            this.btnFindIDLogInForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnFindIDLogInForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindIDLogInForm.BackgroundImage")));
            this.btnFindIDLogInForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindIDLogInForm.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindIDLogInForm.Location = new System.Drawing.Point(95, 267);
            this.btnFindIDLogInForm.Name = "btnFindIDLogInForm";
            this.btnFindIDLogInForm.Size = new System.Drawing.Size(85, 26);
            this.btnFindIDLogInForm.TabIndex = 4;
            this.btnFindIDLogInForm.Text = "Forgot ID";
            this.btnFindIDLogInForm.UseVisualStyleBackColor = false;
            this.btnFindIDLogInForm.Click += new System.EventHandler(this.BtnFindIDLogInForm_Click);
            // 
            // btnFindPWLogInForm
            // 
            this.btnFindPWLogInForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnFindPWLogInForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindPWLogInForm.BackgroundImage")));
            this.btnFindPWLogInForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindPWLogInForm.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPWLogInForm.Location = new System.Drawing.Point(186, 267);
            this.btnFindPWLogInForm.Name = "btnFindPWLogInForm";
            this.btnFindPWLogInForm.Size = new System.Drawing.Size(85, 27);
            this.btnFindPWLogInForm.TabIndex = 5;
            this.btnFindPWLogInForm.Text = "Forgot PW";
            this.btnFindPWLogInForm.UseVisualStyleBackColor = false;
            this.btnFindPWLogInForm.Click += new System.EventHandler(this.BtnFindPWLogInForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(144, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 133);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(105, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "IF YOU LOST YOUR ID OR PW\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(292, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "OR, IF YOU ARE OUR FIRST CUSTOMER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 39);
            this.label3.TabIndex = 15;
            this.label3.Text = "Online Art Gallery";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(666, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbExitLogInForm);
            this.Controls.Add(this.btnOpenResisterFormLogInForm);
            this.Controls.Add(this.btnFindIDLogInForm);
            this.Controls.Add(this.btnFindPWLogInForm);
            this.Controls.Add(this.tbIDLogInForm);
            this.Controls.Add(this.btnLogInForm);
            this.Controls.Add(this.tbPWLogInForm);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbExitLogInForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogInForm;
        private System.Windows.Forms.TextBox tbIDLogInForm;
        private System.Windows.Forms.TextBox tbPWLogInForm;
        private System.Windows.Forms.PictureBox pbExitLogInForm;
        private System.Windows.Forms.Button btnOpenResisterFormLogInForm;
        private System.Windows.Forms.Button btnFindIDLogInForm;
        private System.Windows.Forms.Button btnFindPWLogInForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

