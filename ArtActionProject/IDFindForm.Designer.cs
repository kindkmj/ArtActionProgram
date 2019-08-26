namespace ArtActionProject
{
    partial class IDFindForm
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
            this.btnEnterValueFindIDForm = new System.Windows.Forms.Button();
            this.tbFindIDFindIDForm = new System.Windows.Forms.TextBox();
            this.pbBackFindIDForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFindIDForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterValueFindIDForm
            // 
            this.btnEnterValueFindIDForm.Location = new System.Drawing.Point(51, 115);
            this.btnEnterValueFindIDForm.Name = "btnEnterValueFindIDForm";
            this.btnEnterValueFindIDForm.Size = new System.Drawing.Size(97, 70);
            this.btnEnterValueFindIDForm.TabIndex = 0;
            this.btnEnterValueFindIDForm.Text = "E-Mail Me";
            this.btnEnterValueFindIDForm.UseVisualStyleBackColor = true;
            this.btnEnterValueFindIDForm.Click += new System.EventHandler(this.BtnEnterValueFindIDForm_Click);
            // 
            // tbFindIDFindIDForm
            // 
            this.tbFindIDFindIDForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbFindIDFindIDForm.Location = new System.Drawing.Point(51, 42);
            this.tbFindIDFindIDForm.Name = "tbFindIDFindIDForm";
            this.tbFindIDFindIDForm.Size = new System.Drawing.Size(220, 21);
            this.tbFindIDFindIDForm.TabIndex = 3;
            this.tbFindIDFindIDForm.Text = "E-Mail";
            this.tbFindIDFindIDForm.Enter += new System.EventHandler(this.TbFindIDFindIDForm_Enter);
            // 
            // pbBackFindIDForm
            // 
            this.pbBackFindIDForm.BackColor = System.Drawing.Color.Black;
            this.pbBackFindIDForm.Location = new System.Drawing.Point(196, 119);
            this.pbBackFindIDForm.Name = "pbBackFindIDForm";
            this.pbBackFindIDForm.Size = new System.Drawing.Size(87, 66);
            this.pbBackFindIDForm.TabIndex = 4;
            this.pbBackFindIDForm.TabStop = false;
            this.pbBackFindIDForm.Click += new System.EventHandler(this.PbBackFindIDForm_Click);
            // 
            // IDFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.pbBackFindIDForm);
            this.Controls.Add(this.tbFindIDFindIDForm);
            this.Controls.Add(this.btnEnterValueFindIDForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IDFindForm";
            this.Text = "IDFindForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IDFindForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IDFindForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IDFindForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFindIDForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterValueFindIDForm;
        private System.Windows.Forms.TextBox tbFindIDFindIDForm;
        private System.Windows.Forms.PictureBox pbBackFindIDForm;
    }
}