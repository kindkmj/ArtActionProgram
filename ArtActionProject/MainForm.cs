using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtActionProject
{
    public partial class MainForm : Form
    {
        List<string> imageName;

        private int counter = 0;
        bool bChange = true;

        public MainForm()
        {
           

            InitializeComponent();
            this.Load += MainForm_Load;
          

            imageName = new List<string>

            {
                @"C:\Users\bitcamp\Desktop\GOGH.jpg",
                @"C:\Users\bitcamp\Desktop\GOGH2.png",
                @"C:\Users\bitcamp\Desktop\GOGH3.png"
            };

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            var image = Image.FromFile(imageName[0]);

            btnViewImageMainForm1.Image = image;

            Timer t = new Timer();
            t.Interval = 600;
            t.Tick += new EventHandler(PlayTime);
            t.Start();
        }

        private void PlayTime(object sender, EventArgs e)
        {
            counter = counter + 1;
            Image image = Image.FromFile(imageName[counter]);
            btnViewImageMainForm1.Image = image;
            if (counter == imageName.Count - 1)
            {
                counter = -1;
            }
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
    }
}
