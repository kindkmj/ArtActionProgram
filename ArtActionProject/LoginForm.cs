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
       public static string sUID="";
   

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public LoginForm()
        {
            InitializeComponent();
        }

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

            GuidForm GF = new GuidForm();

            try
            {
                string test = "";
                test= Entity.Select("C", "S", "ID", "CUSTOMER_INFO", "ID", tbIDLogInForm.Text.Trim());
                sUID = tbIDLogInForm.Text;

                if (tbIDLogInForm.Text.Trim() != test)
                {
                    MessageBox.Show("존재하지 않는 아이디 입니다");
                }
                else
                {
                   
                    MessageBox.Show(sUID.ToString()+"로그인에 성공하셨습니다.");
                    this.Visible = false;
                    if (LoginForm.sUID.Trim().ToUpper() == "ADMIN")
                    {
                        MainForm mf = new MainForm();
                        mf.Show();
                    }
                    else
                    {
                        GF.Show();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            if(dragging)
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

        private void TbIDLogInForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
