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
    public partial class RegisterForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BtnIDRegisterForm_Enter(object sender, EventArgs e)
        {
            tbIDRegisterForm.Text = string.Empty;
        }

        private void BtnPWRegisterForm_Enter(object sender, EventArgs e)
        {
            tbPWRegisterForm.Text = string.Empty;
        }

        private void BtnPWChecKedRegisterForm_Enter(object sender, EventArgs e)
        {
            tbPWChecKedRegisterForm.Text = string.Empty;
        }

        private void TbEmailRegisterForm_Enter(object sender, EventArgs e)
        {
            tbEmailRegisterForm.Text = string.Empty;
        }

        private void BtnBackRegisterForm_Click(object sender, EventArgs e) //회원가입 창에서 로그인 창으로 돌아가는버튼
        {
            this.Close();
        }

        private void BtnChecKedIDRegisterForm_Click(object sender, EventArgs e) //아이디 중복 체크 버튼
        {
            if (tbIDRegisterForm.Text.Trim() == "ID"||tbIDRegisterForm.Text.Trim()==string.Empty)
            {
                MessageBox.Show("값을 입력해주세요");
                return;
            }
            string test = "";
            try
            {
                test =Entity.Select("C", "S", "ID", "CUSTOMER_INFO", "ID", tbIDRegisterForm.Text.Trim());
                if (test.Trim() == tbIDRegisterForm.Text.Trim())
                {
                    MessageBox.Show("아이디가 중복됩니다.");
                }
                else if (test.Trim() != tbIDRegisterForm.Text.Trim())
                {
                    MessageBox.Show("사용 가능한 아이디 입니다.");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSignRegisterForm_Click(object sender, EventArgs e)//회원가입 하는 버튼
        {
            try
            {//수정 및 보안 필요
                if (tbIDRegisterForm.Text == "ID" || tbEmailRegisterForm.Text == "E.MAIL" ||
                    tbPWRegisterForm.Text == "PassWord")
                {
                    MessageBox.Show("값을 입력해주세요");
                    return;
                }
                

                if (Entity.DmlCase("I", "CUSTOMER_INFO", "ID", "PW", "EMAIL", tbIDRegisterForm.Text, tbPWRegisterForm.Text, tbEmailRegisterForm.Text) == true)
                {
                    MessageBox.Show("가입되었습니다");

                    if (tbPWChecKedRegisterForm.Text == tbPWRegisterForm.Text)
                    {
                        MessageBox.Show("비밀번호를 같게 입력해주세요.");
                    }
                }
                else
                {
                    MessageBox.Show("가입 실패.");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void RegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));


            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void TbPWRegisterForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
