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
            this.tbIDRegisterForm = new System.Windows.Forms.TextBox();
            this.tbEmailRegisterForm = new System.Windows.Forms.TextBox();
            this.tbPWChecKedRegisterForm = new System.Windows.Forms.TextBox();
            this.tbPWRegisterForm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackRegisterForm
            // 
            this.btnBackRegisterForm.Location = new System.Drawing.Point(12, 129);
            this.btnBackRegisterForm.Name = "btnBackRegisterForm";
            this.btnBackRegisterForm.Size = new System.Drawing.Size(120, 108);
            this.btnBackRegisterForm.TabIndex = 7;
            this.btnBackRegisterForm.Text = "back";
            this.btnBackRegisterForm.UseVisualStyleBackColor = true;
            this.btnBackRegisterForm.Click += new System.EventHandler(this.BtnBackRegisterForm_Click);
            // 
            // btnChecKedIDRegisterForm
            // 
            this.btnChecKedIDRegisterForm.Location = new System.Drawing.Point(138, 129);
            this.btnChecKedIDRegisterForm.Name = "btnChecKedIDRegisterForm";
            this.btnChecKedIDRegisterForm.Size = new System.Drawing.Size(120, 108);
            this.btnChecKedIDRegisterForm.TabIndex = 5;
            this.btnChecKedIDRegisterForm.Text = "CheckedID";
            this.btnChecKedIDRegisterForm.UseVisualStyleBackColor = true;
            this.btnChecKedIDRegisterForm.Click += new System.EventHandler(this.BtnChecKedIDRegisterForm_Click);
            // 
            // btnSignRegisterForm
            // 
            this.btnSignRegisterForm.Location = new System.Drawing.Point(264, 129);
            this.btnSignRegisterForm.Name = "btnSignRegisterForm";
            this.btnSignRegisterForm.Size = new System.Drawing.Size(120, 108);
            this.btnSignRegisterForm.TabIndex = 6;
            this.btnSignRegisterForm.Text = "SignRegister";
            this.btnSignRegisterForm.UseVisualStyleBackColor = true;
            this.btnSignRegisterForm.Click += new System.EventHandler(this.BtnSignRegisterForm_Click);
            // 
            // tbIDRegisterForm
            // 
            this.tbIDRegisterForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbIDRegisterForm.Location = new System.Drawing.Point(38, 15);
            this.tbIDRegisterForm.Name = "tbIDRegisterForm";
            this.tbIDRegisterForm.Size = new System.Drawing.Size(204, 21);
            this.tbIDRegisterForm.TabIndex = 1;
            this.tbIDRegisterForm.Text = "ID";
            this.tbIDRegisterForm.Enter += new System.EventHandler(this.BtnIDRegisterForm_Enter);
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
            // 
            // tbPWChecKedRegisterForm
            // 
            this.tbPWChecKedRegisterForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPWChecKedRegisterForm.Location = new System.Drawing.Point(38, 69);
            this.tbPWChecKedRegisterForm.Name = "tbPWChecKedRegisterForm";
            this.tbPWChecKedRegisterForm.Size = new System.Drawing.Size(204, 21);
            this.tbPWChecKedRegisterForm.TabIndex = 3;
            this.tbPWChecKedRegisterForm.Text = "Checked PassWord";
            this.tbPWChecKedRegisterForm.Enter += new System.EventHandler(this.BtnPWChecKedRegisterForm_Enter);
            // 
            // tbPWRegisterForm
            // 
            this.tbPWRegisterForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPWRegisterForm.Location = new System.Drawing.Point(38, 42);
            this.tbPWRegisterForm.Name = "tbPWRegisterForm";
            this.tbPWRegisterForm.Size = new System.Drawing.Size(204, 21);
            this.tbPWRegisterForm.TabIndex = 2;
            this.tbPWRegisterForm.Text = "PassWord";
            this.tbPWRegisterForm.TextChanged += new System.EventHandler(this.TbPWRegisterForm_TextChanged);
            this.tbPWRegisterForm.Enter += new System.EventHandler(this.BtnPWRegisterForm_Enter);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.tbPWRegisterForm);
            this.Controls.Add(this.tbPWChecKedRegisterForm);
            this.Controls.Add(this.tbEmailRegisterForm);
            this.Controls.Add(this.tbIDRegisterForm);
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
        private System.Windows.Forms.TextBox tbIDRegisterForm;
        private System.Windows.Forms.TextBox tbEmailRegisterForm;
        private System.Windows.Forms.TextBox tbPWChecKedRegisterForm;
        private System.Windows.Forms.TextBox tbPWRegisterForm;
    }
}