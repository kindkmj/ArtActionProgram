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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PWFindForm));
            this.tbIDPWForm = new System.Windows.Forms.TextBox();
            this.btnFindPWForm = new System.Windows.Forms.Button();
            this.btnFindIDPWForm = new System.Windows.Forms.Button();
            this.tbEmailFindIDForm = new System.Windows.Forms.TextBox();
            this.pbBackFindPWForm = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFindPWForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIDPWForm
            // 
            this.tbIDPWForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbIDPWForm.Location = new System.Drawing.Point(212, 139);
            this.tbIDPWForm.Name = "tbIDPWForm";
            this.tbIDPWForm.Size = new System.Drawing.Size(192, 21);
            this.tbIDPWForm.TabIndex = 1;
            this.tbIDPWForm.Text = "ID";
            this.tbIDPWForm.Enter += new System.EventHandler(this.TbFindPWFindPWForm_Enter);
            // 
            // btnFindPWForm
            // 
            this.btnFindPWForm.BackColor = System.Drawing.Color.LightGray;
            this.btnFindPWForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindPWForm.BackgroundImage")));
            this.btnFindPWForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindPWForm.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPWForm.Location = new System.Drawing.Point(177, 240);
            this.btnFindPWForm.Name = "btnFindPWForm";
            this.btnFindPWForm.Size = new System.Drawing.Size(125, 48);
            this.btnFindPWForm.TabIndex = 3;
            this.btnFindPWForm.Text = "Enter";
            this.btnFindPWForm.UseVisualStyleBackColor = false;
            this.btnFindPWForm.Click += new System.EventHandler(this.BtnEnterValueFindPWForm_Click);
            // 
            // btnFindIDPWForm
            // 
            this.btnFindIDPWForm.BackColor = System.Drawing.Color.LightGray;
            this.btnFindIDPWForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindIDPWForm.BackgroundImage")));
            this.btnFindIDPWForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindIDPWForm.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindIDPWForm.Location = new System.Drawing.Point(335, 240);
            this.btnFindIDPWForm.Name = "btnFindIDPWForm";
            this.btnFindIDPWForm.Size = new System.Drawing.Size(125, 48);
            this.btnFindIDPWForm.TabIndex = 4;
            this.btnFindIDPWForm.Text = "Forgot ID";
            this.btnFindIDPWForm.UseVisualStyleBackColor = false;
            this.btnFindIDPWForm.Click += new System.EventHandler(this.BtnConnectFindLDPWForm_Click);
            // 
            // tbEmailFindIDForm
            // 
            this.tbEmailFindIDForm.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEmailFindIDForm.Location = new System.Drawing.Point(212, 189);
            this.tbEmailFindIDForm.Name = "tbEmailFindIDForm";
            this.tbEmailFindIDForm.Size = new System.Drawing.Size(192, 21);
            this.tbEmailFindIDForm.TabIndex = 2;
            this.tbEmailFindIDForm.Text = "E.Mail";
            this.tbEmailFindIDForm.Enter += new System.EventHandler(this.TbEnterEmailFindIDForm_Enter);
            // 
            // pbBackFindPWForm
            // 
            this.pbBackFindPWForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbBackFindPWForm.Location = new System.Drawing.Point(581, 26);
            this.pbBackFindPWForm.Name = "pbBackFindPWForm";
            this.pbBackFindPWForm.Size = new System.Drawing.Size(82, 58);
            this.pbBackFindPWForm.TabIndex = 5;
            this.pbBackFindPWForm.TabStop = false;
            this.pbBackFindPWForm.Click += new System.EventHandler(this.PbBackFindPWForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(94, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 204);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "FIND FW";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "비밀번호 찾기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 6.5F);
            this.label2.Location = new System.Drawing.Point(209, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "고객님의 아이디를 입력해주세요.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 6.5F);
            this.label4.Location = new System.Drawing.Point(209, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "고객님이 등록하신 이메일을 입력해주세요";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(314, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "IF YOU LOST YOUR ID AS WELL";
            // 
            // PWFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(675, 315);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbBackFindPWForm);
            this.Controls.Add(this.tbEmailFindIDForm);
            this.Controls.Add(this.btnFindIDPWForm);
            this.Controls.Add(this.btnFindPWForm);
            this.Controls.Add(this.tbIDPWForm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PWFindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PWFindForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PWFindForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PWFindForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PWFindForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFindPWForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIDPWForm;
        private System.Windows.Forms.Button btnFindPWForm;
        private System.Windows.Forms.Button btnFindIDPWForm;
        private System.Windows.Forms.TextBox tbEmailFindIDForm;
        private System.Windows.Forms.PictureBox pbBackFindPWForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}