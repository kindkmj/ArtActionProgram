using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtActionProject.Properties;


namespace ArtActionProject
{
    public partial class MainForm : Form
    {
        Socket client;
        IPEndPoint ipep;

        NetworkStream ns;
        StreamWriter sw;

        Thread tRecv;
        bool isRecv = true;

        delegate void AddMsgData(string data);

        AddMsgData addMsgData = null;

        private int roomTimer1 = 0;
        private int roomTimer2 = 0;
        private int roomTimer3 = 0;
        private int roomTimer4 = 0;
        private int roomTimer5 = 0;
        private int roomTimer6 = 0;

        List<Resources> imageName1;
        List<string> imageName2;
        List<string> imageName3;

        private int iroomNumber = 0;
        private int counter = 0;

        static string userRoomNumber;

        private Point mousePoint;


        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            imageList1.Images.Add(Properties.Resources.GOGH);
            imageList1.Images.Add(Properties.Resources.GOGH2);
            imageList1.Images.Add(Properties.Resources.GOGH3);
            imageList2.Images.Add(Properties.Resources.Piccaso);
            imageList2.Images.Add(Properties.Resources.piccaso2);
            imageList2.Images.Add(Properties.Resources.piccaso3);
            imageList3.Images.Add(Properties.Resources.d);
            imageList3.Images.Add(Properties.Resources.d2);
            imageList3.Images.Add(Properties.Resources.d3);
            btnViewImageMainForm1.Image = imageList1.Images[0];
            btnViewImageMainForm2.Image = imageList2.Images[0];
            btnViewImageMainForm3.Image = imageList3.Images[0];

            ///김보라
            ///MainForm 시작하는 부분 사이즈 seting 값
            /// 
            this.Size = LoginForm.sUID.Trim().ToUpper() == "ADMIN" ? new Size(1504, 636) : new Size(640, 650);
            addMsgData = AddtbChattingRoomMainForm;
        }


        void AddtbChattingRoomMainForm(string data)
        {
            if (lbChattingRoomMainForm.InvokeRequired)
            {
                Invoke(addMsgData, new object[] {data});
            }

            else
            {
                lbChattingRoomMainForm.Items.Add(data);
                lbChattingRoomMainForm.SelectedIndex = lbChattingRoomMainForm.Items.Count - 1;
            }
        }

        void ThreadRecv()
        {
            StreamReader sr = new StreamReader(ns);

            while (isRecv)
            {
                try
                {
                    //보냄
                    string data = sr.ReadLine();
                    //                    AddtbChattingRoomMainForm(data);
                    lbChattingRoomMainForm.Items.Add(data);
                    lbChattingRoomMainForm.SelectedIndex = lbChattingRoomMainForm.Items.Count - 1;
                }
                catch (Exception ex)
                {
                    AddtbChattingRoomMainForm("Exception :" + ex.Message);
                    btnEnabled(2); //방 입장 버튼 활성화
                    break;
                }
            }
        }

        private void btnEnabled(int type)
        {
            if (type == 1)
            {
                btnExitChattingMainForm.Enabled = true;
                pbEnterViewImageMainForm1.Enabled = false;
                pbEnterViewImageMainForm2.Enabled = false;
                pbEnterViewImageMainForm3.Enabled = false;
                pbEnterViewImageMainForm4.Enabled = false;
                pbEnterViewImageMainForm5.Enabled = false;
                pbEnterViewImageMainForm6.Enabled = false;
            }
            else if (type == 2)
            {
                btnExitChattingMainForm.Enabled = false;
                pbEnterViewImageMainForm1.Enabled = true;
                pbEnterViewImageMainForm2.Enabled = true;
                pbEnterViewImageMainForm3.Enabled = true;
                pbEnterViewImageMainForm4.Enabled = true;
                pbEnterViewImageMainForm5.Enabled = true;
                pbEnterViewImageMainForm6.Enabled = true;
            }
        }

        private void clientConnect(string portN)
        {
            try
            {
                timer2.Enabled = true;
                isRecv = true;
                client = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                ipep = new IPEndPoint(IPAddress.Parse("192.168.0.230"),
                    Int32.Parse(portN));
                client.Connect(ipep);
                ns = new NetworkStream(client);
                sw = new StreamWriter(ns);
                tRecv = new Thread(new ThreadStart(ThreadRecv));
                tRecv.Start();
                btnEnabled(1); //다른 방 버튼 비활성화
                MessageBox.Show(LoginForm.sUID+"님은 현재 "+ iroomNumber + "번방에 입장하셨습니다");
                userRoomNumber = iroomNumber.ToString();
            }
            catch (Exception ex)
            {
                timer2.Enabled = false;
                MessageBox.Show(ex.Message);
            }

        }

        //종료버튼
        private void PbExitMainForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료시키겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
        }

        //CustomerInfroForm이랑 연결되는 버튼
        //사용하고 있는 고객 본인의 데이터를 DB에서 SELECT해 보여줌
        private void BtnCheckInfoMainForm_Click(object sender, EventArgs e)
        {
            CustomerInfoForm CIF = new CustomerInfoForm();
            CIF.Show();
        }

        //첫번째 이미지 박스
        private void BtnViewImageMainForm1_Click(object sender, EventArgs e)
        {



        }

        private void BtnViewImageMainForm2_Click(object sender, EventArgs e)
        {

        }

        private void BtnViewImageMainForm3_Click(object sender, EventArgs e)
        {

        }

        //김보라
        //밑으로는 채팅방 접속하는 pictureBox Button 입니다
        //pc버튼을 입력할때 채팅방에 client가 접속 할 수 있게
        private void PbEnterViewImageMainForm1_Click(object sender, EventArgs e)
        {
            iroomNumber = 1;
            clientConnect("9000");
            this.Size = LoginForm.sUID == "Admin" ? new Size(1504, 636) : new Size(1130, 650);
            try
            {
                noticeAuctionUsersAndAmount(iroomNumber.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PbEnterViewImageMainForm2_Click(object sender, EventArgs e)
        {
            iroomNumber = 2;
            clientConnect("9001");
            this.Size = LoginForm.sUID == "Admin" ? new Size(1504, 636) : new Size(1130, 650);
            try
            {
                noticeAuctionUsersAndAmount(iroomNumber.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PbEnterViewImageMainForm3_Click(object sender, EventArgs e)
        {
            iroomNumber = 3;
            clientConnect("9002");
            this.Size = LoginForm.sUID == "Admin" ? new Size(1504, 636) : new Size(1130, 650);
            try
            {
                noticeAuctionUsersAndAmount(iroomNumber.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PbEnterViewImageMainForm4_Click(object sender, EventArgs e)
        {
            iroomNumber = 4;
            clientConnect("9003");
            this.Size = LoginForm.sUID == "Admin" ? new Size(1504, 636) : new Size(1130, 650);
            try
            {
                noticeAuctionUsersAndAmount(iroomNumber.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void PbEnterViewImageMainForm5_Click(object sender, EventArgs e)
        {
            iroomNumber = 5;
            clientConnect("9004");
            this.Size = LoginForm.sUID == "Admin" ? new Size(1504, 636) : new Size(1130, 650);
            try
            {
                noticeAuctionUsersAndAmount(iroomNumber.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PbEnterViewImageMainForm6_Click(object sender, EventArgs e)
        {
            iroomNumber = 6;
            clientConnect("9005");
            this.Size = LoginForm.sUID == "Admin" ? new Size(1504, 636) : new Size(1130, 650);
            try
            {
                noticeAuctionUsersAndAmount(iroomNumber.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //김보라
        //pbEnterViewImageMainForm(1~6)을 클릭해 채팅방에 사용자가 입장하게 되면
        //lbNoticeForm에 사용자가 입장했다는 것을 알리고 사용자가 배팅을 하게 되면
        //배팅을 한 사용자와 사용자의 배팅금액이 얼마인지를 알리는 메서드
        private void noticeAuctionUsersAndAmount(string iroomNumber)
        {
            Entity.DmlCase("I", "AUCTION", "CHARECTERISTIC_ROOM", "USER_NAME", "CONFIRMED_AMOUNT",iroomNumber,
                      LoginForm.sUID, "0");
            string checkedUser = "";
            checkedUser = LoginForm.sUID + "님은 현재" + userRoomNumber + "번 Auction방에 입장중 입니다.";

            lbRoomNumInfoMainForm.Text = checkedUser;
            lbNoticeMainForm.Items.Add(checkedUser);
        }
        


        //김보라
        //Server Disconnect 
        //채팅방을 나감과 동시에 화면이 다시 기본 세팅으로 작아지는 버튼 
        private void BtnExitChattingMainForm_Click(object sender, EventArgs e)
        {
            

            iroomNumber = 0;

            //Admin 아이디로 방 나가기 버튼을 눌렀을 경우에만
            //listbox가 지워지게
//            if (LoginForm.sUID == "Admin")
//            {
//                lbNoticeMainForm.Items.Clear();
//            }
            timer2.Enabled = false;
            try
            {
                DialogResult dialogResult = MessageBox.Show(LoginForm.sUID+"님"+ userRoomNumber + "번 방을 나가시겠습니까?", "", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (LoginForm.sUID != "Admin")
                    {
                        this.Size = new Size(640, 650);
                    }

                    isRecv = false;
                    if (client != null && client.Connected)
                        client.Close();
                    Console.WriteLine("접속이 끊겼습니다");
                    lbChattingRoomMainForm.Text = "";
                }

            }
            catch (Exception ex)
            {
                AddtbChattingRoomMainForm("Exception:" + ex.Message);
            }
            finally
            {
                btnEnabled(1);
            }

            try
            {
                Entity.Delete("AUCTION", "USER_NAME", LoginForm.sUID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            dateTimePicker1.Text = "00:00";
            lblRoom1.Text = "1번방 경매 남은 시각 :" + roomTimer1.ToString()+"초";
            lblRoom2.Text = "2번방 경매 남은 시각 :" + roomTimer2.ToString()+"초";
            lblRoom3.Text = "3번방 경매 남은 시각 :" + roomTimer3.ToString()+"초";
            lblRoom4.Text = "4번방 경매 남은 시각 :" + roomTimer4.ToString()+"초";
            lblRoom5.Text = "5번방 경매 남은 시각 :" + roomTimer5.ToString()+"초";
            lblRoom6.Text = "6번방 경매 남은 시각 :" + roomTimer6.ToString()+"초";            
        }

        //마우스 클릭시 먼저 선언된 mousePoint변수에 현재 마우스 위치값이 들어갑니다.
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        //클릭상태로 마우스를 이동시 이동한 만큼에서 윈도우 위치값을 뺴게됩니다
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter = counter + 1;
            //            Image image1 = Image.FromFile(imageName1[counter]);
            btnViewImageMainForm1.Image = imageList1.Images[counter];
//            btnViewImageMainForm1.Size = PictureBoxSizeMode.AutoSize;

//            Image image2 = Image.FromFile(imageName2[counter]);
            btnViewImageMainForm2.Image = imageList2.Images[counter];

//            Image image3 = Image.FromFile(imageName3[counter]);
            btnViewImageMainForm3.Image = imageList3.Images[counter];

//            if (counter == imageList1.Images.Count- 1 || counter == imageList2.Images.Count - 1 || counter == imageName3.Count - 1)
//            {
//                counter = -1;
//            }
            if (counter == 2)
            {
                counter = -1;
            }
        }

        private void TbSendingTextMainForm_TextChanged(object sender, EventArgs e)
        {
            //채팅입력창
        }

        private void TbSendingTextMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    string data = tbSendingTextMainForm.Text;
                    sw.WriteLine(LoginForm.sUID + ": " + data);
                    sw.Flush(); //즉시 발송한다.
//                    AddtbChattingRoomMainForm(LoginForm.sUID +": "+ data);
                    tbSendingTextMainForm.Clear();
                    break;
            }
        }

        //한번 클릭 할때 마다 80만원씩 
        private void BtnAmountMainForm_Click(object sender, EventArgs e)
        {
            int num = 0;
         
            try
            {
                num = Int32.Parse(label9.Text.Remove(0, 9)) + 80;

                Entity.DmlCase("U", "AUCTION", "CONFIRMED_AMOUNT", num.ToString(), "USER_NAME", LoginForm.sUID,
                    "CHARECTERISTIC_ROOM", iroomNumber.ToString(), 1);

                //김보라
                string test2 = Entity.Select("USER_NAME", "AUCTION", "CHARECTERISTIC_ROOM", iroomNumber.ToString());
                string test3 = Entity.Select("CONFIRMED_AMOUNT", "AUCTION", "CHARECTERISTIC_ROOM", iroomNumber.ToString());

                string result = test2 + "님이" + test3 + "가격으로 구매 결정하셨습니다";

                lbNoticeMainForm.Items.Add(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LbNoticeMainForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string test = Entity.Select("max(confirmed_amount)", "AUCTION", "CHARECTERISTIC_ROOM",
                   iroomNumber.ToString());
            // Entity.Select1("USER_NAME", "CONFIRMED_AMOUNT", "AUCTION");

            lbNoticeMainForm.BeginUpdate();
            lbNoticeMainForm.Items.Clear();

            timer3.Tick += Timer3_Tick;
            timer3.Interval = 2000;           
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
           
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                string test = Entity.Select("max(confirmed_amount)", "AUCTION", "CHARECTERISTIC_ROOM",
                    iroomNumber.ToString());
              
               

                label9.Text = "현재 최고가 = " + test;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            minTime();
            timerCheck();
        }

        private void timerCheck()
        {
            lblRoom1.Text = "1번방 경매 남은 시각 :"+roomTimer1.ToString();
            lblRoom2.Text = "2번방 경매 남은 시각 :"+roomTimer2.ToString();
            lblRoom3.Text = "3번방 경매 남은 시각 :"+roomTimer3.ToString();
            lblRoom4.Text = "4번방 경매 남은 시각 :"+roomTimer4.ToString();
            lblRoom5.Text = "5번방 경매 남은 시각 :"+roomTimer5.ToString();
            lblRoom6.Text = "6번방 경매 남은 시각 :" + roomTimer6.ToString();
        }
        private void minTime()
        {
            if (0<roomTimer1)
            {
                roomTimer1--;
            }
            else 
            {
                pbEnterViewImageMainForm1.BackgroundImage = null;
            }
            if (0 < roomTimer2)
            {
                roomTimer2--;
            }
            if (0 < roomTimer2)
            {
                roomTimer2--;
            }
            if (0 < roomTimer3)
            {
                roomTimer3--;
            }
            if (0 < roomTimer4)
            {
                roomTimer4--;
            }
            if (0 < roomTimer5)
            {
                roomTimer5--;
            }
            if (0 < roomTimer6)
            {
                roomTimer6--;
            }
        }

        private string setFileLocation()
        {
            string file_path = null;
            try
            {
                openFileDialog1.InitialDirectory = "C:\\"; //시작위치 c드라이브
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if (openFileDialog1.FileName.EndsWith("png") || openFileDialog1.FileName.EndsWith("jpg") ||
                        openFileDialog1.FileName.EndsWith("ico"))
                    {
                        file_path = openFileDialog1.FileName;
                    }
                    else
                    {
                        file_path = "찾지못함";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(file_path);
            }
            return file_path;
        }

        private void setBtinImage(int type ,string file_path)
        {
            if (file_path.EndsWith("png")!=true && !file_path.EndsWith("jpg")!=true &&
                !file_path.EndsWith("ico")!=true)
            {
                MessageBox.Show("지정된 경로가 "+file_path+ "이므로 이미지를 저장할 수 없습니다.");
                return;
            }
            if (type == 1)
            {
                string timer = dateTimePicker1.Text;
                string min;
                string sec;
                sec = timer.Remove(0, 3);
                min = timer.Remove(1, 3);
                roomTimer1 = (Int32.Parse(min)*60 + (Int32.Parse(sec)));
                pbEnterViewImageMainForm1.BackgroundImage = Image.FromFile(file_path);
            }
            else if (type == 2)
            {
                string timer = dateTimePicker1.Text;
                string min;
                string sec;
                sec = timer.Remove(0, 3);
                min = timer.Remove(1, 3);
                roomTimer2 = (Int32.Parse(min) * 60 + (Int32.Parse(sec)));
                pbEnterViewImageMainForm2.BackgroundImage = Image.FromFile(file_path);
            }
            else if (type == 3)
            {
                string timer = dateTimePicker1.Text;
                string min;
                string sec;
                sec = timer.Remove(0, 3);
                min = timer.Remove(1, 3);
                roomTimer3 = (Int32.Parse(min) * 60 + (Int32.Parse(sec)));
                pbEnterViewImageMainForm3.BackgroundImage = Image.FromFile(file_path);
            }
            else if (type == 4)
            {
                string timer = dateTimePicker1.Text;
                string min;
                string sec;
                sec = timer.Remove(0, 3);
                min = timer.Remove(1, 3);
                roomTimer4 = (Int32.Parse(min) * 60 + (Int32.Parse(sec)));
                pbEnterViewImageMainForm4.BackgroundImage = Image.FromFile(file_path);
            }
            else if (type == 5)
            {
                string timer = dateTimePicker1.Text;
                string min;
                string sec;
                sec = timer.Remove(0, 3);
                min = timer.Remove(1, 3);
                roomTimer5 = (Int32.Parse(min) * 60 + (Int32.Parse(sec)));
                pbEnterViewImageMainForm5.BackgroundImage = Image.FromFile(file_path);
            }
            else if (type == 6)
            {
                string timer = dateTimePicker1.Text;
                string min;
                string sec;
                sec = timer.Remove(0, 3);
                min = timer.Remove(1, 3);
                roomTimer6 = (Int32.Parse(min) * 60 + (Int32.Parse(sec)));
                pbEnterViewImageMainForm6.BackgroundImage = Image.FromFile(file_path);
            }
        }

       
        private void BtnOpenDialog_Click(object sender, EventArgs e)
        {
            if (clbRoomCheck.SelectedItem.ToString().Trim().ToUpper() == "ROOM1")
            {
                string file_path =setFileLocation();
                setBtinImage(1, file_path);
            }
            else if (clbRoomCheck.SelectedItem.ToString().Trim().ToUpper() == "ROOM2")
            {
             
                string file_path = null;
                file_path = setFileLocation();
                setBtinImage(2, file_path);
            }
            else if (clbRoomCheck.SelectedItem.ToString().Trim().ToUpper() == "ROOM3")
            {
               
                string file_path = null;
                file_path = setFileLocation();
                setBtinImage(3, file_path);
            }
            else if (clbRoomCheck.SelectedItem.ToString().Trim().ToUpper() == "ROOM4")
            {
                string file_path = null;
                file_path = setFileLocation();
                setBtinImage(4, file_path);
            }
            else if (clbRoomCheck.SelectedItem.ToString().Trim().ToUpper() == "ROOM5")
            {
                string file_path = null;
                file_path = setFileLocation();
                setBtinImage(5, file_path);
            }
            else if (clbRoomCheck.SelectedItem.ToString().Trim().ToUpper() == "ROOM6")
            {
                string file_path = null;
                file_path = setFileLocation();
                setBtinImage(6, file_path);
            }
        }

        private void LbRoomNumInfoMainForm_Click(object sender, EventArgs e)
        {

        }
    }
}
