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
            this.btnBackRegisterForm = new System.Windows.Forms.Button();
            this.btnChecKedIDRegisterForm = new System.Windows.Forms.Button();
            this.btnSignRegisterForm = new System.Windows.Forms.Button();
            this.btnIDRegisterForm = new System.Windows.Forms.TextBox();
            this.tbEmailRegisterForm = new System.Windows.Forms.TextBox();
            this.btnPWChecKedRegisterForm = new System.Windows.Forms.TextBox();
            this.btnPWRegisterForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackRegisterForm
            // 
            this.btnBackRegisterForm.Location = new System.Drawing.Point(12, 129);
            this.btnBackRegisterForm.Name = "btnBackRegisterForm";
            this.btnBackRegisterForm.Size = new System.Drawing.Size(120, 108);
            this.btnBackRegisterForm.TabIndex = 0;
            this.btnBackRegisterForm.Text = "back";
            this.btnBackRegisterForm.UseVisualStyleBackColor = true;
            this.btnBackRegisterForm.Click += new System.EventHandler(this.BtnBackRegisterForm_Click);
            // 
            // btnChecKedIDRegisterForm
            // 
            this.btnChecKedIDRegisterForm.Location = new System.Drawing.Point(138, 129);
            this.btnChecKedIDRegisterForm.Name = "btnChecKedIDRegisterForm";
            this.btnChecKedIDRegisterForm.Size = new System.Drawing.Size(120, 108);
            this.btnChecKedIDRegisterForm.TabIndex = 1;
            this.btnChecKedIDRegisterForm.Text = "CheckedID";
            this.btnChecKedIDRegisterForm.UseVisualStyleBackColor = true;
            this.btnChecKedIDRegisterForm.Click += new System.EventHandler(this.BtnChecKedIDRegisterForm_Click);
            // 
            // btnSignRegisterForm
            // 
            this.btnSignRegisterForm.Location = new System.Drawing.Point(264, 129);
            this.btnSignRegisterForm.Name = "btnSignRegisterForm";
            this.btnSignRegisterForm.Size = new System.Drawing.Size(120, 108);
            this.btnSignRegisterForm.TabIndex = 2;
            this.btnSignRegisterForm.Text = "SignRegister";
            this.btnSignRegisterForm.UseVisualStyleBackColor = true;
            this.btnSignRegisterForm.Click += new System.EventHandler(this.BtnSignRegisterForm_Click);
            // 
            // btnIDRegisterForm
            // 
            this.btnIDRegisterForm.ForeColor = System.Drawing.Color.DarkGray;
            this.btnIDRegisterForm.Location = new System.Drawing.Point(38, 15);
            this.btnIDRegisterForm.Name = "btnIDRegisterForm";
            this.btnIDRegisterForm.Size = new System.Drawing.Size(204, 21);
            this.btnIDRegisterForm.TabIndex = 3;
            this.btnIDRegisterForm.Text = "ID";
            this.btnIDRegisterForm.TextChanged += new System.EventHandler(this.BtnIDRegisterForm_TextChanged);
            this.btnIDRegisterForm.Enter += new System.EventHandler(this.BtnIDRegisterForm_Enter);
            this.btnIDRegisterForm.Leave += new System.EventHandler(this.BtnIDRegisterForm_Leave);
            // 
            // tbEmailRegisterForm
            // 
            this.tbEmailRegisterForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEmailRegisterForm.Location = new System.Drawing.Point(38, 96);
            this.tbEmailRegisterForm.Name = "tbEmailRegisterForm";
            this.tbEmailRegisterForm.Size = new System.Drawing.Size(204, 21);
            this.tbEmailRegisterForm.TabIndex = 4;
            this.tbEmailRegisterForm.Text = "E.Mail";
            this.tbEmailRegisterForm.Enter += new System.EventHandler(this.TbEmailRegisterForm_Enter);
            this.tbEmailRegisterForm.Leave += new System.EventHandler(this.TbEmailRegisterForm_Leave);
            // 
            // btnPWChecKedRegisterForm
            // 
            this.btnPWChecKedRegisterForm.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPWChecKedRegisterForm.Location = new System.Drawing.Point(38, 69);
            this.btnPWChecKedRegisterForm.Name = "btnPWChecKedRegisterForm";
            this.btnPWChecKedRegisterForm.Size = new System.Drawing.Size(204, 21);
            this.btnPWChecKedRegisterForm.TabIndex = 5;
            this.btnPWChecKedRegisterForm.Text = "Checked PassWord";
            this.btnPWChecKedRegisterForm.Enter += new System.EventHandler(this.BtnPWChecKedRegisterForm_Enter);
            this.btnPWChecKedRegisterForm.Leave += new System.EventHandler(this.BtnPWChecKedRegisterForm_Leave);
            // 
            // btnPWRegisterForm
            // 
            this.btnPWRegisterForm.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPWRegisterForm.Location = new System.Drawing.Point(38, 42);
            this.btnPWRegisterForm.Name = "btnPWRegisterForm";
            this.btnPWRegisterForm.Size = new System.Drawing.Size(204, 21);
            this.btnPWRegisterForm.TabIndex = 6;
            this.btnPWRegisterForm.Text = "PassWord";
            this.btnPWRegisterForm.Enter += new System.EventHandler(this.BtnPWRegisterForm_Enter);
            this.btnPWRegisterForm.Leave += new System.EventHandler(this.BtnPWRegisterForm_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btnPWRegisterForm);
            this.Controls.Add(this.btnPWChecKedRegisterForm);
            this.Controls.Add(this.tbEmailRegisterForm);
            this.Controls.Add(this.btnIDRegisterForm);
            this.Controls.Add(this.btnSignRegisterForm);
            this.Controls.Add(this.btnChecKedIDRegisterForm);
            this.Controls.Add(this.btnBackRegisterForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackRegisterForm;
        private System.Windows.Forms.Button btnChecKedIDRegisterForm;
        private System.Windows.Forms.Button btnSignRegisterForm;
        private System.Windows.Forms.TextBox btnIDRegisterForm;
        private System.Windows.Forms.TextBox tbEmailRegisterForm;
        private System.Windows.Forms.TextBox btnPWChecKedRegisterForm;
        private System.Windows.Forms.TextBox btnPWRegisterForm;
    }
}