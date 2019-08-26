namespace ArtActionProject
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.btnBackRegisterForm = new System.Windows.Forms.Button();
            this.btnChecKedIDRegisterForm = new System.Windows.Forms.Button();
            this.btnSignRegisterForm = new System.Windows.Forms.Button();
            this.tbIDRegisterForm = new System.Windows.Forms.TextBox();
            this.tbEmailRegisterForm = new System.Windows.Forms.TextBox();
            this.tbPWChecKedRegisterForm = new System.Windows.Forms.TextBox();
            this.tbPWRegisterForm = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbResisterForm = new System.Windows.Forms.CheckBox();
            this.btnTermAndConditionResisterForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackRegisterForm
            // 
            this.btnBackRegisterForm.BackColor = System.Drawing.Color.LightGray;
            this.btnBackRegisterForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackRegisterForm.BackgroundImage")));
            this.btnBackRegisterForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackRegisterForm.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackRegisterForm.Location = new System.Drawing.Point(385, 259);
            this.btnBackRegisterForm.Name = "btnBackRegisterForm";
            this.btnBackRegisterForm.Size = new System.Drawing.Size(120, 46);
            this.btnBackRegisterForm.TabIndex = 9;
            this.btnBackRegisterForm.Text = "back";
            this.btnBackRegisterForm.UseVisualStyleBackColor = false;
            this.btnBackRegisterForm.Click += new System.EventHandler(this.BtnBackRegisterForm_Click);
            // 
            // btnChecKedIDRegisterForm
            // 
            this.btnChecKedIDRegisterForm.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChecKedIDRegisterForm.Location = new System.Drawing.Point(417, 114);
            this.btnChecKedIDRegisterForm.Name = "btnChecKedIDRegisterForm";
            this.btnChecKedIDRegisterForm.Size = new System.Drawing.Size(120, 22);
            this.btnChecKedIDRegisterForm.TabIndex = 2;
            this.btnChecKedIDRegisterForm.Text = "CheckedID";
            this.btnChecKedIDRegisterForm.UseVisualStyleBackColor = true;
            this.btnChecKedIDRegisterForm.Click += new System.EventHandler(this.BtnChecKedIDRegisterForm_Click);
            // 
            // btnSignRegisterForm
            // 
            this.btnSignRegisterForm.BackColor = System.Drawing.Color.LightGray;
            this.btnSignRegisterForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignRegisterForm.BackgroundImage")));
            this.btnSignRegisterForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignRegisterForm.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignRegisterForm.Location = new System.Drawing.Point(258, 259);
            this.btnSignRegisterForm.Name = "btnSignRegisterForm";
            this.btnSignRegisterForm.Size = new System.Drawing.Size(120, 48);
            this.btnSignRegisterForm.TabIndex = 7;
            this.btnSignRegisterForm.Text = "SignRegister";
            this.btnSignRegisterForm.UseVisualStyleBackColor = false;
            this.btnSignRegisterForm.Click += new System.EventHandler(this.BtnSignRegisterForm_Click);
            // 
            // tbIDRegisterForm
            // 
            this.tbIDRegisterForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbIDRegisterForm.Location = new System.Drawing.Point(207, 114);
            this.tbIDRegisterForm.Name = "tbIDRegisterForm";
            this.tbIDRegisterForm.Size = new System.Drawing.Size(204, 21);
            this.tbIDRegisterForm.TabIndex = 1;
            this.tbIDRegisterForm.Text = "ID";
            this.tbIDRegisterForm.Enter += new System.EventHandler(this.BtnIDRegisterForm_Enter);
            // 
            // tbEmailRegisterForm
            // 
            this.tbEmailRegisterForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEmailRegisterForm.Location = new System.Drawing.Point(207, 195);
            this.tbEmailRegisterForm.Name = "tbEmailRegisterForm";
            this.tbEmailRegisterForm.Size = new System.Drawing.Size(204, 21);
            this.tbEmailRegisterForm.TabIndex = 5;
            this.tbEmailRegisterForm.Text = "E.Mail";
            this.tbEmailRegisterForm.Enter += new System.EventHandler(this.TbEmailRegisterForm_Enter);
            // 
            // tbPWChecKedRegisterForm
            // 
            this.tbPWChecKedRegisterForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPWChecKedRegisterForm.Location = new System.Drawing.Point(207, 168);
            this.tbPWChecKedRegisterForm.Name = "tbPWChecKedRegisterForm";
            this.tbPWChecKedRegisterForm.Size = new System.Drawing.Size(204, 21);
            this.tbPWChecKedRegisterForm.TabIndex = 4;
            this.tbPWChecKedRegisterForm.Text = "Checked PassWord";
            this.tbPWChecKedRegisterForm.Enter += new System.EventHandler(this.BtnPWChecKedRegisterForm_Enter);
            // 
            // tbPWRegisterForm
            // 
            this.tbPWRegisterForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPWRegisterForm.Location = new System.Drawing.Point(207, 141);
            this.tbPWRegisterForm.Name = "tbPWRegisterForm";
            this.tbPWRegisterForm.Size = new System.Drawing.Size(204, 21);
            this.tbPWRegisterForm.TabIndex = 3;
            this.tbPWRegisterForm.Text = "PassWord";
            this.tbPWRegisterForm.TextChanged += new System.EventHandler(this.TbPWRegisterForm_TextChanged);
            this.tbPWRegisterForm.Enter += new System.EventHandler(this.BtnPWRegisterForm_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 206);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "RESISTER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "회원가입";
            // 
            // cbResisterForm
            // 
            this.cbResisterForm.AutoSize = true;
            this.cbResisterForm.Font = new System.Drawing.Font("Segoe Script", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResisterForm.Location = new System.Drawing.Point(219, 235);
            this.cbResisterForm.Name = "cbResisterForm";
            this.cbResisterForm.Size = new System.Drawing.Size(182, 18);
            this.cbResisterForm.TabIndex = 6;
            this.cbResisterForm.Text = "이용약관을 읽어 보신후 동의해주세요";
            this.cbResisterForm.UseVisualStyleBackColor = true;
            this.cbResisterForm.CheckedChanged += new System.EventHandler(this.CbResisterForm_CheckedChanged);
            // 
            // btnTermAndConditionResisterForm
            // 
            this.btnTermAndConditionResisterForm.BackColor = System.Drawing.Color.LightGray;
            this.btnTermAndConditionResisterForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTermAndConditionResisterForm.BackgroundImage")));
            this.btnTermAndConditionResisterForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTermAndConditionResisterForm.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.btnTermAndConditionResisterForm.Location = new System.Drawing.Point(132, 259);
            this.btnTermAndConditionResisterForm.Name = "btnTermAndConditionResisterForm";
            this.btnTermAndConditionResisterForm.Size = new System.Drawing.Size(120, 48);
            this.btnTermAndConditionResisterForm.TabIndex = 8;
            this.btnTermAndConditionResisterForm.Text = "Terms And Conditions";
            this.btnTermAndConditionResisterForm.UseVisualStyleBackColor = false;
            this.btnTermAndConditionResisterForm.Click += new System.EventHandler(this.BtnTermAndConditionResisterForm_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(666, 320);
            this.Controls.Add(this.cbResisterForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPWRegisterForm);
            this.Controls.Add(this.tbPWChecKedRegisterForm);
            this.Controls.Add(this.tbEmailRegisterForm);
            this.Controls.Add(this.tbIDRegisterForm);
            this.Controls.Add(this.btnTermAndConditionResisterForm);
            this.Controls.Add(this.btnSignRegisterForm);
            this.Controls.Add(this.btnChecKedIDRegisterForm);
            this.Controls.Add(this.btnBackRegisterForm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KLJ";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackRegisterForm;
        private System.Windows.Forms.Button btnChecKedIDRegisterForm;
        private System.Windows.Forms.Button btnSignRegisterForm;
        private System.Windows.Forms.TextBox tbIDRegisterForm;
        private System.Windows.Forms.TextBox tbEmailRegisterForm;
        private System.Windows.Forms.TextBox tbPWChecKedRegisterForm;
        private System.Windows.Forms.TextBox tbPWRegisterForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbResisterForm;
        private System.Windows.Forms.Button btnTermAndConditionResisterForm;
    }
}