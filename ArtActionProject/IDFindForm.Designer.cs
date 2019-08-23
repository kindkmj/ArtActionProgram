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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDFindForm));
            this.btnEnterValueFindIDForm = new System.Windows.Forms.Button();
            this.tbFindIDFindIDForm = new System.Windows.Forms.TextBox();
            this.pbBackFindIDForm = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFindIDForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterValueFindIDForm
            // 
            this.btnEnterValueFindIDForm.BackColor = System.Drawing.Color.LightGray;
            this.btnEnterValueFindIDForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnterValueFindIDForm.BackgroundImage")));
            this.btnEnterValueFindIDForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnterValueFindIDForm.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterValueFindIDForm.Location = new System.Drawing.Point(261, 227);
            this.btnEnterValueFindIDForm.Name = "btnEnterValueFindIDForm";
            this.btnEnterValueFindIDForm.Size = new System.Drawing.Size(143, 41);
            this.btnEnterValueFindIDForm.TabIndex = 0;
            this.btnEnterValueFindIDForm.Text = "E-Mail Me";
            this.btnEnterValueFindIDForm.UseVisualStyleBackColor = false;
            this.btnEnterValueFindIDForm.Click += new System.EventHandler(this.BtnEnterValueFindIDForm_Click);
            // 
            // tbFindIDFindIDForm
            // 
            this.tbFindIDFindIDForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbFindIDFindIDForm.Location = new System.Drawing.Point(223, 184);
            this.tbFindIDFindIDForm.Name = "tbFindIDFindIDForm";
            this.tbFindIDFindIDForm.Size = new System.Drawing.Size(220, 21);
            this.tbFindIDFindIDForm.TabIndex = 3;
            this.tbFindIDFindIDForm.Text = "E-Mail";
            this.tbFindIDFindIDForm.TextChanged += new System.EventHandler(this.TbFindIDFindIDForm_TextChanged);
            this.tbFindIDFindIDForm.Enter += new System.EventHandler(this.TbFindIDFindIDForm_Enter);
            // 
            // pbBackFindIDForm
            // 
            this.pbBackFindIDForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbBackFindIDForm.Location = new System.Drawing.Point(568, 12);
            this.pbBackFindIDForm.Name = "pbBackFindIDForm";
            this.pbBackFindIDForm.Size = new System.Drawing.Size(87, 66);
            this.pbBackFindIDForm.TabIndex = 4;
            this.pbBackFindIDForm.TabStop = false;
            this.pbBackFindIDForm.Click += new System.EventHandler(this.PbBackFindIDForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(93, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 175);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "아이디 찾기";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 39);
            this.label3.TabIndex = 19;
            this.label3.Text = "FIND ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 6.5F);
            this.label2.Location = new System.Drawing.Point(261, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "고객님의 이메일을 입력해주세요.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 6F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(147, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "고객님이 회원가입 하셨을때 등록해주신 이메일로 고객님의 아이디를 보내드립니다.";
            // 
            // IDFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(667, 328);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbBackFindIDForm);
            this.Controls.Add(this.tbFindIDFindIDForm);
            this.Controls.Add(this.btnEnterValueFindIDForm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IDFindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDFindForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IDFindForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IDFindForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IDFindForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFindIDForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterValueFindIDForm;
        private System.Windows.Forms.TextBox tbFindIDFindIDForm;
        private System.Windows.Forms.PictureBox pbBackFindIDForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}