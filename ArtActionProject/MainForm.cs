using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



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

        ConnectClientForm CCF = new ConnectClientForm();

        List<string> imageName1;
        List<string> imageName2;
        List<string> imageName3;

        int startW = 500;
        int startH = 600;

        private int counter = 0;
        bool bChange = true;

        private Point mousePoint;

        public MainForm()
        {
           
            InitializeComponent();
            this.Load += MainForm_Load;
          
            imageName1 = new List<string>

            {
                @"C:\Users\bitcamp\Desktop\GOGH.jpg",
                @"C:\Users\bitcamp\Desktop\GOGH2.png",
                @"C:\Users\bitcamp\Desktop\GOGH3.png"
            };

            imageName2 = new List<string>

            {
                 @"C:\Users\bitcamp\Desktop\piccaso2.jpg",
                @"C:\Users\bitcamp\Desktop\piccaso3.jpg",
                @"C:\Users\bitcamp\Desktop\Piccaso.jpg"
            };

            imageName3 = new List<string>
            {
                 @"C:\Users\bitcamp\Desktop\d.jpg",
                @"C:\Users\bitcamp\Desktop\d2.jpg",
                @"C:\Users\bitcamp\Desktop\d3.jpg"
            };

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            var image1 = Image.FromFile(imageName1[0]);
            var image2 = Image.FromFile(imageName2[0]);
            var image3 = Image.FromFile(imageName3[0]);

            btnViewImageMainForm1.Image = image1;
            btnViewImageMainForm2.Image = image2;
            btnViewImageMainForm3.Image = image3;

            ///김보라
            ///MainForm 시작하는 부분 사이즈 seting 값
            this.Size = new Size(640,650);

        }

        void ProcessPacket(string recvData)
        {
            string[] datas = recvData.Split(new char[] { '|' });

            switch(datas[0])
            {
                case "C":
                    AddtbChattingRoomMainForm("<채팅수신>:" + recvData);
                    AddtbChattingRoomMainForm(datas[1]);
                    break;                    
            }
        }

        void AddtbChattingRoomMainForm(string data)
        {
            if(lbChattingRoomMainForm.InvokeRequired)
            {
                Invoke(addMsgData, new object[] { data });
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

            while(isRecv)
            {
                try
                {
                    string data = sr.ReadLine();
                    ProcessPacket(data);
                }catch(Exception ex)
                {
                    AddtbChattingRoomMainForm("Exception :" + ex.Message);
                    btnExitChattingMainForm.Enabled = false;
                    pbEnterViewImageMainForm1.Enabled = true;
                    pbEnterViewImageMainForm2.Enabled = true;
                    pbEnterViewImageMainForm3.Enabled = true;
                    pbEnterViewImageMainForm4.Enabled = true;
                    pbEnterViewImageMainForm5.Enabled = true;
                    pbEnterViewImageMainForm6.Enabled = true;
                    break;
                }
            }
        }

        private void clientConnect(string portN, int num)
        {

                isRecv = true;
                client =
                    new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                ipep =
                    new IPEndPoint(IPAddress.Parse("192.168.0.230"),
                    Int32.Parse(portN));
                Console.WriteLine("서버 접속 시도 ...");
                client.Connect(ipep);
                Console.WriteLine("서버 접속 완료");
                ns = new NetworkStream(client);
                sw = new StreamWriter(ns);

                tRecv = new Thread(new ThreadStart(ThreadRecv));
                tRecv.Start();

                


                btnExitChattingMainForm.Enabled = true;
                pbEnterViewImageMainForm1.Enabled = false;
                pbEnterViewImageMainForm2.Enabled = false;
                pbEnterViewImageMainForm3.Enabled = false;
                pbEnterViewImageMainForm4.Enabled = false;
                pbEnterViewImageMainForm5.Enabled = false;
                pbEnterViewImageMainForm6.Enabled = false;

                MessageBox.Show(num + "번방에 입장하셨습니다");
            

        }




        //종료버튼
        private void PbExitMainForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램을 종료시키겠습니다");
            Application.Exit();
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
            
            clientConnect("9000",1);
            this.Size = new Size(1130, 650);

        }

        private void PbEnterViewImageMainForm2_Click(object sender, EventArgs e)
        {
            
            clientConnect("9001",2);
        }

        private void PbEnterViewImageMainForm3_Click(object sender, EventArgs e)
        {
          
            clientConnect("9002",3);
        }

        private void PbEnterViewImageMainForm4_Click(object sender, EventArgs e)
        {
            
            clientConnect("9003",4);
        }

        private void PbEnterViewImageMainForm5_Click(object sender, EventArgs e)
        {
        
            clientConnect("9004",5);
        }

        private void PbEnterViewImageMainForm6_Click(object sender, EventArgs e)
        {

            clientConnect("9005",6);
        }


        //김보라
        //Server Disconnect 
        //채팅방을 나감과 동시에 화면이 다시 기본 세팅으로 작아지는 버튼 
        private void BtnExitChattingMainForm_Click(object sender, EventArgs e)
        {
            this.Size = new Size(640, 650);

            try
            {
                isRecv = false;
                if (client != null && client.Connected)
                    client.Close();
                Console.WriteLine("접속이 끊겼습니다");
            }catch(Exception ex)
            {
                AddtbChattingRoomMainForm("Exception:"+ex.Message);
            }
            finally
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

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        //마우스 클릭시 먼저 선언된 mousePoint변수에 현재 마우스 위치값이 들어갑니다.
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        //클릭상태로 마우스를 이동시 이동한 만큼에서 윈도우 위치값을 뺴게됩니다
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter = counter + 1;

            Image image1 = Image.FromFile(imageName1[counter]);
            btnViewImageMainForm1.Image = image1;

            Image image2 = Image.FromFile(imageName2[counter]);
            btnViewImageMainForm2.Image = image2;

            Image image3 = Image.FromFile(imageName3[counter]);
            btnViewImageMainForm3.Image = image3;

            if (counter == imageName2.Count - 1 || counter == imageName1.Count - 1 || counter == imageName3.Count - 1)
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
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    string data = tbSendingTextMainForm.Text;
                    sw.WriteLine(data);
                    sw.Flush();  //즉시 발송한다.
                    AddtbChattingRoomMainForm("<송신>:" + data);
                    tbSendingTextMainForm.Clear();
                    break;
            }
        }
    }
}
