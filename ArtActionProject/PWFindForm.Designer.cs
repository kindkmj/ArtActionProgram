namespace ArtActionProject
{
    partial class PWFindForm
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
            this.tbIDPWForm = new System.Windows.Forms.TextBox();
            this.btnFindPWForm = new System.Windows.Forms.Button();
            this.btnFindIDPWForm = new System.Windows.Forms.Button();
            this.tbEmailFindIDForm = new System.Windows.Forms.TextBox();
            this.pbBackFindPWForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFindPWForm)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIDPWForm
            // 
            this.tbIDPWForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbIDPWForm.Location = new System.Drawing.Point(69, 50);
            this.tbIDPWForm.Name = "tbIDPWForm";
            this.tbIDPWForm.Size = new System.Drawing.Size(192, 21);
            this.tbIDPWForm.TabIndex = 0;
            this.tbIDPWForm.Text = "ID";
            this.tbIDPWForm.Enter += new System.EventHandler(this.TbFindPWFindPWForm_Enter);
            // 
            // btnFindPWForm
            // 
            this.btnFindPWForm.Location = new System.Drawing.Point(12, 134);
            this.btnFindPWForm.Name = "btnFindPWForm";
            this.btnFindPWForm.Size = new System.Drawing.Size(94, 60);
            this.btnFindPWForm.TabIndex = 1;
            this.btnFindPWForm.Text = "Enter";
            this.btnFindPWForm.UseVisualStyleBackColor = true;
            this.btnFindPWForm.Click += new System.EventHandler(this.BtnEnterValueFindPWForm_Click);
            // 
            // btnFindIDPWForm
            // 
            this.btnFindIDPWForm.Location = new System.Drawing.Point(112, 134);
            this.btnFindIDPWForm.Name = "btnFindIDPWForm";
            this.btnFindIDPWForm.Size = new System.Drawing.Size(94, 60);
            this.btnFindIDPWForm.TabIndex = 2;
            this.btnFindIDPWForm.Text = "Forgot ID";
            this.btnFindIDPWForm.UseVisualStyleBackColor = true;
            this.btnFindIDPWForm.Click += new System.EventHandler(this.BtnConnectFindLDPWForm_Click);
            // 
            // tbEmailFindIDForm
            // 
            this.tbEmailFindIDForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEmailFindIDForm.Location = new System.Drawing.Point(69, 80);
            this.tbEmailFindIDForm.Name = "tbEmailFindIDForm";
            this.tbEmailFindIDForm.Size = new System.Drawing.Size(192, 21);
            this.tbEmailFindIDForm.TabIndex = 4;
            this.tbEmailFindIDForm.Text = "E.Mail";
            this.tbEmailFindIDForm.Enter += new System.EventHandler(this.TbEnterEmailFindIDForm_Enter);
            // 
            // pbBackFindPWForm
            // 
            this.pbBackFindPWForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbBackFindPWForm.Location = new System.Drawing.Point(283, 134);
            this.pbBackFindPWForm.Name = "pbBackFindPWForm";
            this.pbBackFindPWForm.Size = new System.Drawing.Size(82, 58);
            this.pbBackFindPWForm.TabIndex = 5;
            this.pbBackFindPWForm.TabStop = false;
            this.pbBackFindPWForm.Click += new System.EventHandler(this.PbBackFindPWForm_Click);
            // 
            // PWFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.pbBackFindPWForm);
            this.Controls.Add(this.tbEmailFindIDForm);
            this.Controls.Add(this.btnFindIDPWForm);
            this.Controls.Add(this.btnFindPWForm);
            this.Controls.Add(this.tbIDPWForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PWFindForm";
            this.Text = "PWFindForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PWFindForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PWFindForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PWFindForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFindPWForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIDPWForm;
        private System.Windows.Forms.Button btnFindPWForm;
        private System.Windows.Forms.Button btnFindIDPWForm;
        private System.Windows.Forms.TextBox tbEmailFindIDForm;
        private System.Windows.Forms.PictureBox pbBackFindPWForm;
    }
}