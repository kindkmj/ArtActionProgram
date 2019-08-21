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
            this.tbFindPWFindPWForm = new System.Windows.Forms.TextBox();
            this.btnEnterValueFindPWForm = new System.Windows.Forms.Button();
            this.btnConnectFindLDPWForm = new System.Windows.Forms.Button();
            this.tbEnterEmailFindIDForm = new System.Windows.Forms.TextBox();
            this.pbBackFindPWForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFindPWForm)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFindPWFindPWForm
            // 
            this.tbFindPWFindPWForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbFindPWFindPWForm.Location = new System.Drawing.Point(69, 50);
            this.tbFindPWFindPWForm.Name = "tbFindPWFindPWForm";
            this.tbFindPWFindPWForm.Size = new System.Drawing.Size(192, 21);
            this.tbFindPWFindPWForm.TabIndex = 0;
            this.tbFindPWFindPWForm.Text = "ID";
            this.tbFindPWFindPWForm.Enter += new System.EventHandler(this.TbFindPWFindPWForm_Enter);
            // 
            // btnEnterValueFindPWForm
            // 
            this.btnEnterValueFindPWForm.Location = new System.Drawing.Point(12, 134);
            this.btnEnterValueFindPWForm.Name = "btnEnterValueFindPWForm";
            this.btnEnterValueFindPWForm.Size = new System.Drawing.Size(94, 60);
            this.btnEnterValueFindPWForm.TabIndex = 1;
            this.btnEnterValueFindPWForm.Text = "Enter";
            this.btnEnterValueFindPWForm.UseVisualStyleBackColor = true;
            // 
            // btnConnectFindLDPWForm
            // 
            this.btnConnectFindLDPWForm.Location = new System.Drawing.Point(112, 134);
            this.btnConnectFindLDPWForm.Name = "btnConnectFindLDPWForm";
            this.btnConnectFindLDPWForm.Size = new System.Drawing.Size(94, 60);
            this.btnConnectFindLDPWForm.TabIndex = 2;
            this.btnConnectFindLDPWForm.Text = "Forgot ID";
            this.btnConnectFindLDPWForm.UseVisualStyleBackColor = true;
            this.btnConnectFindLDPWForm.Click += new System.EventHandler(this.BtnConnectFindLDPWForm_Click);
            // 
            // tbEnterEmailFindIDForm
            // 
            this.tbEnterEmailFindIDForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEnterEmailFindIDForm.Location = new System.Drawing.Point(69, 80);
            this.tbEnterEmailFindIDForm.Name = "tbEnterEmailFindIDForm";
            this.tbEnterEmailFindIDForm.Size = new System.Drawing.Size(192, 21);
            this.tbEnterEmailFindIDForm.TabIndex = 4;
            this.tbEnterEmailFindIDForm.Text = "E.Mail";
            this.tbEnterEmailFindIDForm.Enter += new System.EventHandler(this.TbEnterEmailFindIDForm_Enter);
            // 
            // pbBackFindPWForm
            // 
            this.pbBackFindPWForm.Location = new System.Drawing.Point(256, 135);
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
            this.Controls.Add(this.tbEnterEmailFindIDForm);
            this.Controls.Add(this.btnConnectFindLDPWForm);
            this.Controls.Add(this.btnEnterValueFindPWForm);
            this.Controls.Add(this.tbFindPWFindPWForm);
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

        private System.Windows.Forms.TextBox tbFindPWFindPWForm;
        private System.Windows.Forms.Button btnEnterValueFindPWForm;
        private System.Windows.Forms.Button btnConnectFindLDPWForm;
        private System.Windows.Forms.TextBox tbEnterEmailFindIDForm;
        private System.Windows.Forms.PictureBox pbBackFindPWForm;
    }
}