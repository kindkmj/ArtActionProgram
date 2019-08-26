using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtActionProject
{
    public partial class LoginForm : Form
    {
        //김보라
        public static string sUID = "";


        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public LoginForm()
        {
            InitializeComponent();
        }

        //LoginForm LF = new LoginForm();
        GuideForm GF = new GuideForm();

        private void PbExitLogInForm_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
            }
        }

        private void TbIDLogInForm_Enter(object sender, EventArgs e)
        {
            tbIDLogInForm.Text = string.Empty;

        }

        private void TbPWLogInForm_Enter(object sender, EventArgs e)
        {
            tbPWLogInForm.Text = string.Empty;
        }

        private void BtnLogInForm_Click(object sender, EventArgs e)
        {
            ;
            //GuideForm GF = new GuideForm();

            try
            {
                string test = "";
                string test1 = "";

                test = Entity.Select("C", "S", "ID", "CUSTOMER_INFO", "ID", tbIDLogInForm.Text.Trim());
                test1 = Entity.Select("C", "S", "PW", "CUSTOMER_INFO", "PW", tbPWLogInForm.Text.Trim());
                sUID = tbIDLogInForm.Text;
                if (tbIDLogInForm.Text.Trim() != test)   //아이디 틀림
                {
                    MessageBox.Show("존재하지 않는 아이디 입니다");

                    if (tbPWLogInForm.Text.Trim() != test1)  //아이디 비번 둘다 틀림
                    {
                        MessageBox.Show("비밀 번호가 잘못 되었습니다");
                    }

                }
                else if (tbIDLogInForm.Text.Trim() == test)  //아이디 맞음
                {
                    if (tbPWLogInForm.Text.Trim() == test1) //아이디 비번 둘다 맞음
                    {
                        if (LoginForm.sUID.Trim().ToUpper() == "ADMIN")
                        {
                            MessageBox.Show(sUID.ToString() + "로그인에 성공하셨습니다.");

                            MainForm mf = new MainForm();
                            mf.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show(sUID.ToString() + "님 로그인에 성공하셨습니다.");
                            GF.Show();
                            timer1.Start();
                            timer1.Tick += Timer1_Tick;
                            timer2.Tick += Timer2_Tick;
                            this.Visible = true;
                        }
                    }
                    else  //아이디 맞고 비번 안맞음
                    {
                        MessageBox.Show("비밀 번호가 잘못 되었습니다");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            GF.Left -= 10;
            if (GF.Left <= 630)
            {
                timer2.Stop();
                this.Visible = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            GF.Left += 10;
            if (GF.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                GF.TopMost = true;
                timer2.Start();
            }
        }



        private void BtnOpenRegisterFormLogInForm_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BtnFindIDLogInForm_Click(object sender, EventArgs e)
        {
            IDFindForm iDFind = new IDFindForm();
            iDFind.ShowDialog();

        }

        private void BtnFindPWLogInForm_Click(object sender, EventArgs e)
        {
            PWFindForm pwFind = new PWFindForm();
            pwFind.ShowDialog();

        }
    }
}
