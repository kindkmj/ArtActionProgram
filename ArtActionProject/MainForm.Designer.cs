namespace ArtActionProject
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbNoticeMainForm = new System.Windows.Forms.ListBox();
            this.tbSendingTextMainForm = new System.Windows.Forms.TextBox();
            this.btnSendingTextMainForm = new System.Windows.Forms.Button();
            this.btnAmountMainForm = new System.Windows.Forms.Button();
            this.btnViewImageMainForm1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnViewImageMainForm2 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnViewImageMainForm3 = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.pbEnterViewImageMainForm1 = new System.Windows.Forms.PictureBox();
            this.pbEnterViewImageMainForm2 = new System.Windows.Forms.PictureBox();
            this.pbEnterViewImageMainForm3 = new System.Windows.Forms.PictureBox();
            this.pbEnterViewImageMainForm4 = new System.Windows.Forms.PictureBox();
            this.pbEnterViewImageMainForm6 = new System.Windows.Forms.PictureBox();
            this.pbEnterViewImageMainForm5 = new System.Windows.Forms.PictureBox();
            this.pbExitMainForm = new System.Windows.Forms.PictureBox();
            this.btnCheckInfoMainForm = new System.Windows.Forms.Button();
            this.btnStartAuctionMainForm = new System.Windows.Forms.Button();
            this.tbSettingAuctionAmountMainForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExitChattingMainForm = new System.Windows.Forms.Button();
            this.lblRoom1 = new System.Windows.Forms.Label();
            this.lblRoom2 = new System.Windows.Forms.Label();
            this.lblRoom3 = new System.Windows.Forms.Label();
            this.lblRoom4 = new System.Windows.Forms.Label();
            this.lblRoom5 = new System.Windows.Forms.Label();
            this.lblRoom6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbChattingRoomMainForm = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clbRoomCheck = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNoticeMainForm
            // 
            this.lbNoticeMainForm.FormattingEnabled = true;
            this.lbNoticeMainForm.ItemHeight = 12;
            this.lbNoticeMainForm.Location = new System.Drawing.Point(645, 59);
            this.lbNoticeMainForm.Name = "lbNoticeMainForm";
            this.lbNoticeMainForm.Size = new System.Drawing.Size(466, 208);
            this.lbNoticeMainForm.TabIndex = 0;
            this.lbNoticeMainForm.SelectedIndexChanged += new System.EventHandler(this.LbNoticeMainForm_SelectedIndexChanged);
            // 
            // tbSendingTextMainForm
            // 
            this.tbSendingTextMainForm.Location = new System.Drawing.Point(645, 559);
            this.tbSendingTextMainForm.Name = "tbSendingTextMainForm";
            this.tbSendingTextMainForm.Size = new System.Drawing.Size(339, 21);
            this.tbSendingTextMainForm.TabIndex = 2;
            this.tbSendingTextMainForm.TextChanged += new System.EventHandler(this.TbSendingTextMainForm_TextChanged);
            this.tbSendingTextMainForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSendingTextMainForm_KeyDown);
            // 
            // btnSendingTextMainForm
            // 
            this.btnSendingTextMainForm.Location = new System.Drawing.Point(1000, 549);
            this.btnSendingTextMainForm.Name = "btnSendingTextMainForm";
            this.btnSendingTextMainForm.Size = new System.Drawing.Size(113, 31);
            this.btnSendingTextMainForm.TabIndex = 3;
            this.btnSendingTextMainForm.Text = "보내기";
            this.btnSendingTextMainForm.UseVisualStyleBackColor = true;
            // 
            // btnAmountMainForm
            // 
            this.btnAmountMainForm.Location = new System.Drawing.Point(1000, 588);
            this.btnAmountMainForm.Name = "btnAmountMainForm";
            this.btnAmountMainForm.Size = new System.Drawing.Size(113, 31);
            this.btnAmountMainForm.TabIndex = 3;
            this.btnAmountMainForm.Text = "금액보내기";
            this.btnAmountMainForm.UseVisualStyleBackColor = true;
            this.btnAmountMainForm.Click += new System.EventHandler(this.BtnAmountMainForm_Click);
            // 
            // btnViewImageMainForm1
            // 
            this.btnViewImageMainForm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewImageMainForm1.ImageList = this.imageList1;
            this.btnViewImageMainForm1.Location = new System.Drawing.Point(35, 63);
            this.btnViewImageMainForm1.Name = "btnViewImageMainForm1";
            this.btnViewImageMainForm1.Size = new System.Drawing.Size(175, 155);
            this.btnViewImageMainForm1.TabIndex = 5;
            this.btnViewImageMainForm1.UseVisualStyleBackColor = true;
            this.btnViewImageMainForm1.Click += new System.EventHandler(this.BtnViewImageMainForm1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(175, 155);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnViewImageMainForm2
            // 
            this.btnViewImageMainForm2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewImageMainForm2.ImageList = this.imageList2;
            this.btnViewImageMainForm2.Location = new System.Drawing.Point(238, 63);
            this.btnViewImageMainForm2.Name = "btnViewImageMainForm2";
            this.btnViewImageMainForm2.Size = new System.Drawing.Size(175, 155);
            this.btnViewImageMainForm2.TabIndex = 5;
            this.btnViewImageMainForm2.UseVisualStyleBackColor = true;
            this.btnViewImageMainForm2.Click += new System.EventHandler(this.BtnViewImageMainForm2_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(175, 155);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnViewImageMainForm3
            // 
            this.btnViewImageMainForm3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewImageMainForm3.ImageList = this.imageList3;
            this.btnViewImageMainForm3.Location = new System.Drawing.Point(443, 63);
            this.btnViewImageMainForm3.Name = "btnViewImageMainForm3";
            this.btnViewImageMainForm3.Size = new System.Drawing.Size(175, 155);
            this.btnViewImageMainForm3.TabIndex = 5;
            this.btnViewImageMainForm3.UseVisualStyleBackColor = true;
            this.btnViewImageMainForm3.Click += new System.EventHandler(this.BtnViewImageMainForm3_Click);
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(175, 155);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbEnterViewImageMainForm1
            // 
            this.pbEnterViewImageMainForm1.BackColor = System.Drawing.Color.RosyBrown;
            this.pbEnterViewImageMainForm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnterViewImageMainForm1.Location = new System.Drawing.Point(35, 243);
            this.pbEnterViewImageMainForm1.Name = "pbEnterViewImageMainForm1";
            this.pbEnterViewImageMainForm1.Size = new System.Drawing.Size(175, 155);
            this.pbEnterViewImageMainForm1.TabIndex = 6;
            this.pbEnterViewImageMainForm1.TabStop = false;
            this.pbEnterViewImageMainForm1.Click += new System.EventHandler(this.PbEnterViewImageMainForm1_Click);
            // 
            // pbEnterViewImageMainForm2
            // 
            this.pbEnterViewImageMainForm2.BackColor = System.Drawing.Color.LightSalmon;
            this.pbEnterViewImageMainForm2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnterViewImageMainForm2.Location = new System.Drawing.Point(238, 243);
            this.pbEnterViewImageMainForm2.Name = "pbEnterViewImageMainForm2";
            this.pbEnterViewImageMainForm2.Size = new System.Drawing.Size(175, 155);
            this.pbEnterViewImageMainForm2.TabIndex = 6;
            this.pbEnterViewImageMainForm2.TabStop = false;
            this.pbEnterViewImageMainForm2.Click += new System.EventHandler(this.PbEnterViewImageMainForm2_Click);
            // 
            // pbEnterViewImageMainForm3
            // 
            this.pbEnterViewImageMainForm3.BackColor = System.Drawing.Color.Tomato;
            this.pbEnterViewImageMainForm3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnterViewImageMainForm3.Location = new System.Drawing.Point(443, 243);
            this.pbEnterViewImageMainForm3.Name = "pbEnterViewImageMainForm3";
            this.pbEnterViewImageMainForm3.Size = new System.Drawing.Size(175, 155);
            this.pbEnterViewImageMainForm3.TabIndex = 6;
            this.pbEnterViewImageMainForm3.TabStop = false;
            this.pbEnterViewImageMainForm3.Click += new System.EventHandler(this.PbEnterViewImageMainForm3_Click);
            // 
            // pbEnterViewImageMainForm4
            // 
            this.pbEnterViewImageMainForm4.BackColor = System.Drawing.Color.SaddleBrown;
            this.pbEnterViewImageMainForm4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnterViewImageMainForm4.Location = new System.Drawing.Point(35, 425);
            this.pbEnterViewImageMainForm4.Name = "pbEnterViewImageMainForm4";
            this.pbEnterViewImageMainForm4.Size = new System.Drawing.Size(175, 155);
            this.pbEnterViewImageMainForm4.TabIndex = 6;
            this.pbEnterViewImageMainForm4.TabStop = false;
            this.pbEnterViewImageMainForm4.Click += new System.EventHandler(this.PbEnterViewImageMainForm4_Click);
            // 
            // pbEnterViewImageMainForm6
            // 
            this.pbEnterViewImageMainForm6.BackColor = System.Drawing.Color.Chocolate;
            this.pbEnterViewImageMainForm6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnterViewImageMainForm6.Location = new System.Drawing.Point(443, 425);
            this.pbEnterViewImageMainForm6.Name = "pbEnterViewImageMainForm6";
            this.pbEnterViewImageMainForm6.Size = new System.Drawing.Size(175, 155);
            this.pbEnterViewImageMainForm6.TabIndex = 6;
            this.pbEnterViewImageMainForm6.TabStop = false;
            this.pbEnterViewImageMainForm6.Click += new System.EventHandler(this.PbEnterViewImageMainForm6_Click);
            // 
            // pbEnterViewImageMainForm5
            // 
            this.pbEnterViewImageMainForm5.BackColor = System.Drawing.Color.DarkSalmon;
            this.pbEnterViewImageMainForm5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnterViewImageMainForm5.Location = new System.Drawing.Point(238, 425);
            this.pbEnterViewImageMainForm5.Name = "pbEnterViewImageMainForm5";
            this.pbEnterViewImageMainForm5.Size = new System.Drawing.Size(175, 155);
            this.pbEnterViewImageMainForm5.TabIndex = 6;
            this.pbEnterViewImageMainForm5.TabStop = false;
            this.pbEnterViewImageMainForm5.Click += new System.EventHandler(this.PbEnterViewImageMainForm5_Click);
            // 
            // pbExitMainForm
            // 
            this.pbExitMainForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbExitMainForm.BackgroundImage")));
            this.pbExitMainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbExitMainForm.Location = new System.Drawing.Point(35, 12);
            this.pbExitMainForm.Name = "pbExitMainForm";
            this.pbExitMainForm.Size = new System.Drawing.Size(43, 43);
            this.pbExitMainForm.TabIndex = 7;
            this.pbExitMainForm.TabStop = false;
            this.pbExitMainForm.Click += new System.EventHandler(this.PbExitMainForm_Click);
            // 
            // btnCheckInfoMainForm
            // 
            this.btnCheckInfoMainForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnCheckInfoMainForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckInfoMainForm.BackgroundImage")));
            this.btnCheckInfoMainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckInfoMainForm.Font = new System.Drawing.Font("Segoe Script", 7F);
            this.btnCheckInfoMainForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckInfoMainForm.Location = new System.Drawing.Point(84, 12);
            this.btnCheckInfoMainForm.Name = "btnCheckInfoMainForm";
            this.btnCheckInfoMainForm.Size = new System.Drawing.Size(126, 43);
            this.btnCheckInfoMainForm.TabIndex = 8;
            this.btnCheckInfoMainForm.Text = "고객정보";
            this.btnCheckInfoMainForm.UseVisualStyleBackColor = false;
            this.btnCheckInfoMainForm.Click += new System.EventHandler(this.BtnCheckInfoMainForm_Click);
            // 
            // btnStartAuctionMainForm
            // 
            this.btnStartAuctionMainForm.Location = new System.Drawing.Point(1312, 270);
            this.btnStartAuctionMainForm.Name = "btnStartAuctionMainForm";
            this.btnStartAuctionMainForm.Size = new System.Drawing.Size(122, 53);
            this.btnStartAuctionMainForm.TabIndex = 9;
            this.btnStartAuctionMainForm.Text = "경매시작";
            this.btnStartAuctionMainForm.UseVisualStyleBackColor = true;
            // 
            // tbSettingAuctionAmountMainForm
            // 
            this.tbSettingAuctionAmountMainForm.Location = new System.Drawing.Point(1130, 287);
            this.tbSettingAuctionAmountMainForm.Name = "tbSettingAuctionAmountMainForm";
            this.tbSettingAuctionAmountMainForm.Size = new System.Drawing.Size(172, 21);
            this.tbSettingAuctionAmountMainForm.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.label1.Location = new System.Drawing.Point(1127, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "경매시작 금액을 입력해주세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(735, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "한번 입력할때 마다 10만원씩 올라갑니다.\r\n";
            // 
            // btnExitChattingMainForm
            // 
            this.btnExitChattingMainForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnExitChattingMainForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitChattingMainForm.BackgroundImage")));
            this.btnExitChattingMainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitChattingMainForm.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.btnExitChattingMainForm.Location = new System.Drawing.Point(1000, 12);
            this.btnExitChattingMainForm.Name = "btnExitChattingMainForm";
            this.btnExitChattingMainForm.Size = new System.Drawing.Size(111, 42);
            this.btnExitChattingMainForm.TabIndex = 13;
            this.btnExitChattingMainForm.Text = "채팅방나가기";
            this.btnExitChattingMainForm.UseVisualStyleBackColor = false;
            this.btnExitChattingMainForm.Click += new System.EventHandler(this.BtnExitChattingMainForm_Click);
            // 
            // lblRoom1
            // 
            this.lblRoom1.AutoSize = true;
            this.lblRoom1.Font = new System.Drawing.Font("Segoe Script", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom1.Location = new System.Drawing.Point(60, 401);
            this.lblRoom1.Name = "lblRoom1";
            this.lblRoom1.Size = new System.Drawing.Size(42, 14);
            this.lblRoom1.TabIndex = 14;
            this.lblRoom1.Text = "Room1";
            // 
            // lblRoom2
            // 
            this.lblRoom2.AutoSize = true;
            this.lblRoom2.Font = new System.Drawing.Font("Segoe Script", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRoom2.Location = new System.Drawing.Point(260, 401);
            this.lblRoom2.Name = "lblRoom2";
            this.lblRoom2.Size = new System.Drawing.Size(42, 14);
            this.lblRoom2.TabIndex = 15;
            this.lblRoom2.Text = "Room2";
            // 
            // lblRoom3
            // 
            this.lblRoom3.AutoSize = true;
            this.lblRoom3.Font = new System.Drawing.Font("Segoe Script", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRoom3.Location = new System.Drawing.Point(468, 401);
            this.lblRoom3.Name = "lblRoom3";
            this.lblRoom3.Size = new System.Drawing.Size(42, 14);
            this.lblRoom3.TabIndex = 16;
            this.lblRoom3.Text = "Room3";
            // 
            // lblRoom4
            // 
            this.lblRoom4.AutoSize = true;
            this.lblRoom4.Font = new System.Drawing.Font("Segoe Script", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom4.Location = new System.Drawing.Point(60, 583);
            this.lblRoom4.Name = "lblRoom4";
            this.lblRoom4.Size = new System.Drawing.Size(42, 14);
            this.lblRoom4.TabIndex = 17;
            this.lblRoom4.Text = "Room4";
            // 
            // lblRoom5
            // 
            this.lblRoom5.AutoSize = true;
            this.lblRoom5.Font = new System.Drawing.Font("Segoe Script", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRoom5.Location = new System.Drawing.Point(260, 583);
            this.lblRoom5.Name = "lblRoom5";
            this.lblRoom5.Size = new System.Drawing.Size(42, 14);
            this.lblRoom5.TabIndex = 18;
            this.lblRoom5.Text = "Room5";
            // 
            // lblRoom6
            // 
            this.lblRoom6.AutoSize = true;
            this.lblRoom6.Font = new System.Drawing.Font("Segoe Script", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRoom6.Location = new System.Drawing.Point(468, 583);
            this.lblRoom6.Name = "lblRoom6";
            this.lblRoom6.Size = new System.Drawing.Size(42, 14);
            this.lblRoom6.TabIndex = 19;
            this.lblRoom6.Text = "Room6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbChattingRoomMainForm
            // 
            this.lbChattingRoomMainForm.FormattingEnabled = true;
            this.lbChattingRoomMainForm.ItemHeight = 12;
            this.lbChattingRoomMainForm.Location = new System.Drawing.Point(647, 276);
            this.lbChattingRoomMainForm.Name = "lbChattingRoomMainForm";
            this.lbChattingRoomMainForm.Size = new System.Drawing.Size(464, 256);
            this.lbChattingRoomMainForm.TabIndex = 20;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(644, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 21;
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Location = new System.Drawing.Point(1130, 461);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(122, 53);
            this.btnOpenDialog.TabIndex = 22;
            this.btnOpenDialog.Text = "경로설정및 저장";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.BtnOpenDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clbRoomCheck
            // 
            this.clbRoomCheck.CheckOnClick = true;
            this.clbRoomCheck.FormattingEnabled = true;
            this.clbRoomCheck.Items.AddRange(new object[] {
            "Room1",
            "Room2",
            "Room3",
            "Room4",
            "Room5",
            "Room6"});
            this.clbRoomCheck.Location = new System.Drawing.Point(1130, 357);
            this.clbRoomCheck.Name = "clbRoomCheck";
            this.clbRoomCheck.Size = new System.Drawing.Size(120, 84);
            this.clbRoomCheck.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(1256, 357);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(69, 21);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(2019, 8, 23, 16, 36, 3, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(135, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1114, 645);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1504, 636);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.clbRoomCheck);
            this.Controls.Add(this.btnOpenDialog);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbChattingRoomMainForm);
            this.Controls.Add(this.lblRoom6);
            this.Controls.Add(this.lblRoom5);
            this.Controls.Add(this.lblRoom4);
            this.Controls.Add(this.lblRoom3);
            this.Controls.Add(this.lblRoom2);
            this.Controls.Add(this.lblRoom1);
            this.Controls.Add(this.btnExitChattingMainForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSettingAuctionAmountMainForm);
            this.Controls.Add(this.btnStartAuctionMainForm);
            this.Controls.Add(this.btnCheckInfoMainForm);
            this.Controls.Add(this.pbExitMainForm);
            this.Controls.Add(this.pbEnterViewImageMainForm6);
            this.Controls.Add(this.pbEnterViewImageMainForm3);
            this.Controls.Add(this.pbEnterViewImageMainForm4);
            this.Controls.Add(this.pbEnterViewImageMainForm5);
            this.Controls.Add(this.pbEnterViewImageMainForm2);
            this.Controls.Add(this.pbEnterViewImageMainForm1);
            this.Controls.Add(this.btnViewImageMainForm3);
            this.Controls.Add(this.btnViewImageMainForm2);
            this.Controls.Add(this.btnViewImageMainForm1);
            this.Controls.Add(this.btnAmountMainForm);
            this.Controls.Add(this.btnSendingTextMainForm);
            this.Controls.Add(this.tbSendingTextMainForm);
            this.Controls.Add(this.lbNoticeMainForm);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterViewImageMainForm5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNoticeMainForm;
        private System.Windows.Forms.TextBox tbSendingTextMainForm;
        private System.Windows.Forms.Button btnSendingTextMainForm;
        private System.Windows.Forms.Button btnAmountMainForm;
        private System.Windows.Forms.Button btnViewImageMainForm1;
        private System.Windows.Forms.Button btnViewImageMainForm2;
        private System.Windows.Forms.Button btnViewImageMainForm3;
        private System.Windows.Forms.PictureBox pbEnterViewImageMainForm1;
        private System.Windows.Forms.PictureBox pbEnterViewImageMainForm2;
        private System.Windows.Forms.PictureBox pbEnterViewImageMainForm3;
        private System.Windows.Forms.PictureBox pbEnterViewImageMainForm4;
        private System.Windows.Forms.PictureBox pbEnterViewImageMainForm6;
        private System.Windows.Forms.PictureBox pbEnterViewImageMainForm5;
        private System.Windows.Forms.PictureBox pbExitMainForm;
        private System.Windows.Forms.Button btnCheckInfoMainForm;
        private System.Windows.Forms.Button btnStartAuctionMainForm;
        private System.Windows.Forms.TextBox tbSettingAuctionAmountMainForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExitChattingMainForm;
        private System.Windows.Forms.Label lblRoom1;
        private System.Windows.Forms.Label lblRoom2;
        private System.Windows.Forms.Label lblRoom3;
        private System.Windows.Forms.Label lblRoom4;
        private System.Windows.Forms.Label lblRoom5;
        private System.Windows.Forms.Label lblRoom6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbChattingRoomMainForm;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckedListBox clbRoomCheck;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}