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
            this.btnLogInForm = new System.Windows.Forms.Button();
            this.tbIDLogInForm = new System.Windows.Forms.TextBox();
            this.tbPWLogInForm = new System.Windows.Forms.TextBox();
            this.pbExitLogInForm = new System.Windows.Forms.PictureBox();
            this.btnOpenResisterFormLogInForm = new System.Windows.Forms.Button();
            this.btnFindIDLogInForm = new System.Windows.Forms.Button();
            this.btnFindPWLogInForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitLogInForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogInForm
            // 
            this.btnLogInForm.Location = new System.Drawing.Point(243, 209);
            this.btnLogInForm.Name = "btnLogInForm";
            this.btnLogInForm.Size = new System.Drawing.Size(81, 63);
            this.btnLogInForm.TabIndex = 0;
            this.btnLogInForm.Text = "LogIn";
            this.btnLogInForm.UseVisualStyleBackColor = true;
            this.btnLogInForm.Click += new System.EventHandler(this.BtnLogInForm_Click);
            // 
            // tbIDLogInForm
            // 
            this.tbIDLogInForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbIDLogInForm.Location = new System.Drawing.Point(145, 94);
            this.tbIDLogInForm.Name = "tbIDLogInForm";
            this.tbIDLogInForm.Size = new System.Drawing.Size(200, 21);
            this.tbIDLogInForm.TabIndex = 1;
            this.tbIDLogInForm.Text = "ID";
            this.tbIDLogInForm.TextChanged += new System.EventHandler(this.TbIDLogInForm_TextChanged);
            this.tbIDLogInForm.Enter += new System.EventHandler(this.TbIDLogInForm_Enter);
            // 
            // tbPWLogInForm
            // 
            this.tbPWLogInForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPWLogInForm.Location = new System.Drawing.Point(145, 132);
            this.tbPWLogInForm.Name = "tbPWLogInForm";
            this.tbPWLogInForm.Size = new System.Drawing.Size(200, 21);
            this.tbPWLogInForm.TabIndex = 2;
            this.tbPWLogInForm.Text = "PASSWORD";
            this.tbPWLogInForm.Enter += new System.EventHandler(this.TbPWLogInForm_Enter);
            // 
            // pbExitLogInForm
            // 
            this.pbExitLogInForm.Location = new System.Drawing.Point(376, 83);
            this.pbExitLogInForm.Name = "pbExitLogInForm";
            this.pbExitLogInForm.Size = new System.Drawing.Size(62, 70);
            this.pbExitLogInForm.TabIndex = 3;
            this.pbExitLogInForm.TabStop = false;
            this.pbExitLogInForm.Click += new System.EventHandler(this.PbExitLogInForm_Click);
            // 
            // btnOpenResisterFormLogInForm
            // 
            this.btnOpenResisterFormLogInForm.Location = new System.Drawing.Point(351, 209);
            this.btnOpenResisterFormLogInForm.Name = "btnOpenResisterFormLogInForm";
            this.btnOpenResisterFormLogInForm.Size = new System.Drawing.Size(87, 62);
            this.btnOpenResisterFormLogInForm.TabIndex = 4;
            this.btnOpenResisterFormLogInForm.Text = "Register";
            this.btnOpenResisterFormLogInForm.UseVisualStyleBackColor = true;
            this.btnOpenResisterFormLogInForm.Click += new System.EventHandler(this.BtnOpenRegisterFormLogInForm_Click);
            // 
            // btnFindIDLogInForm
            // 
            this.btnFindIDLogInForm.Location = new System.Drawing.Point(118, 198);
            this.btnFindIDLogInForm.Name = "btnFindIDLogInForm";
            this.btnFindIDLogInForm.Size = new System.Drawing.Size(85, 26);
            this.btnFindIDLogInForm.TabIndex = 5;
            this.btnFindIDLogInForm.Text = "Forgot ID";
            this.btnFindIDLogInForm.UseVisualStyleBackColor = true;
            this.btnFindIDLogInForm.Click += new System.EventHandler(this.BtnFindIDLogInForm_Click);
            // 
            // btnFindPWLogInForm
            // 
            this.btnFindPWLogInForm.Location = new System.Drawing.Point(118, 244);
            this.btnFindPWLogInForm.Name = "btnFindPWLogInForm";
            this.btnFindPWLogInForm.Size = new System.Drawing.Size(85, 27);
            this.btnFindPWLogInForm.TabIndex = 6;
            this.btnFindPWLogInForm.Text = "Forgot PW";
            this.btnFindPWLogInForm.UseVisualStyleBackColor = true;
            this.btnFindPWLogInForm.Click += new System.EventHandler(this.BtnFindPWLogInForm_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 433);
            this.Controls.Add(this.btnFindPWLogInForm);
            this.Controls.Add(this.btnFindIDLogInForm);
            this.Controls.Add(this.btnOpenResisterFormLogInForm);
            this.Controls.Add(this.pbExitLogInForm);
            this.Controls.Add(this.tbPWLogInForm);
            this.Controls.Add(this.tbIDLogInForm);
            this.Controls.Add(this.btnLogInForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbExitLogInForm)).EndInit();
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
    }
}

