using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ArtActionProject
{
    public partial class RegisterForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        string ids = "aaaa";
        private Boolean flag = false;


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BtnIDRegisterForm_Enter(object sender, EventArgs e)
        {
            btnIDRegisterForm.Text = string.Empty;
        }

        private void BtnPWRegisterForm_Enter(object sender, EventArgs e)
        {
            btnPWRegisterForm.Text = string.Empty;
        }

        private void BtnPWChecKedRegisterForm_Enter(object sender, EventArgs e)
        {
            btnPWChecKedRegisterForm.Text = string.Empty;
        }

        private void TbEmailRegisterForm_Enter(object sender, EventArgs e)
        {
            tbEmailRegisterForm.Text = string.Empty;
        }

        private void BtnBackRegisterForm_Click(object sender, EventArgs e) //회원가입 창에서 로그인 창으로 돌아가는버튼
        {
            this.Close();
        }

        //void checkedId()
        //{
        //    if (btnIDRegisterForm.Text == "ID")
        //    {
        //        MessageBox.Show("아이디를 입력하세요");
        //    }
        //    else if (btnIDRegisterForm.Text != ids)
        //    {
        //        flag = true;
        //        MessageBox.Show("사용할수 있는 아이디 입니다");

        //    }
        //    else if (flag == false)
        //    {
        //        MessageBox.Show("중복된 아이디 입니다");
        //    }
        //}
        private void BtnChecKedIDRegisterForm_Click(object sender, EventArgs e) //아이디 중복 체크 버튼
        {
            string test = "";
                try
                {
                    test = Entity.Select(tableState: "C", processCase: "S", 
                        COLUMN_DATA0: "ID",
                        COLUMN_DATA1: "CUSTOMER_INFO",
                        COLUMN_DATA2: "ID",
                        COLUMN_DATA3: btnIDRegisterForm.Text.Trim());
                    if (btnIDRegisterForm.Text.Trim() != test)
                    {
                        MessageBox.Show(text: "없는 아이디");
                        flag = true;
                    }
                    else
                    {
                        MessageBox.Show(text: "중복되었다");
                    }
                    //this.Visible = false;

                }
                catch (Exception)
                {
                }
            //if (btnIDRegisterForm.Text == "ID")
            //{
            //    MessageBox.Show("아이디를 입력하세요");
            //}
            //else if (btnIDRegisterForm.Text != ids)
            //{
            //    flag = true;
            //    MessageBox.Show("사용할수 있는 아이디 입니다");
            //}
            //else
            //{
            //    MessageBox.Show("중복된 아이디 입니다");
            //}
        }

        private void BtnSignRegisterForm_Click(object sender, EventArgs e)//회원가입 하는 버튼
        {
            //string test = "";
            //try
            //{
            //    test = Entity.Select(tableState: "C", processCase: "S", COLUMN_DATA0: "PW", COLUMN_DATA1: "CUSTOMER_INFO", COLUMN_DATA2: "PW", COLUMN_DATA3: btnPWRegisterForm.Text.Trim());
            //    if (btnPWRegisterForm.Text.Trim() != test)
            //    {
            //        MessageBox.Show(text: "사용가능한 비밀번호 입니다");
            //    }
            //    else
            //    {
            //        MessageBox.Show(text: "비밀번호중복");
            //    }
            //}
            //catch (Exception)
            //{
            //}

            bool test = true;
            if(btnPWChecKedRegisterForm.Text != btnPWRegisterForm.Text)
            {
                MessageBox.Show("비밀번호가 다릅니다");
            }
           else if (btnIDRegisterForm.Text == "ID")
            {
                MessageBox.Show("아이디를 입력하세요");
                MessageBox.Show("아이디 중복 체크를 해주세요");
            }
            else if (btnPWRegisterForm.Text == "PassWord")
            {
                MessageBox.Show("비밀번호를 입력하세요");
            }
            else if (btnPWChecKedRegisterForm.Text == "Checked PassWord")
            {
                MessageBox.Show("비밀번호를 확인하세요");
            }
            else if (tbEmailRegisterForm.Text == "E.Mail")
            {
                MessageBox.Show("이메일을 입력하세요");
            }
            //아무것도 입력안한 기본 값이 있을때는 사용자가 아무 동작을 한 상태가 아니기 때문에
            //아무것도 동작을 하지 않고 버튼을 누를 경우 사용자에게 액션을 한 다음 버튼을 눌러달라고 요청

            //boolean flag 생성한뒤 defalut값을 false로 저장 이후
            //중복체크버튼을 눌러서 중복된 아이디가 없으면 flag를 true로 바꾸고 회원가입창을 눌렀을때는 flag가 true여야만 다음으로 진행하고
            //flag가 false면 중복체크부터 하라고 메시지를 보여주면 될거 같음.
            else if (flag == true)
            {
                test = Entity.DmlCase(processCase: "I", tableName: "CUSTOMER_INFO",
                    COLUMN_DATA0: "ID", 
                    COLUMN_DATA1: "PW", 
                    COLUMN_DATA2: "EMAIL", 
                    COLUMN_DATA3: btnIDRegisterForm.Text.Trim(),
                    COLUMN_DATA4: btnPWRegisterForm.Text.Trim(),
                    COLUMN_DATA5: tbEmailRegisterForm.Text.Trim());
                MessageBox.Show("가입되었습니다");
             
                this.Close();
            }
            else if (flag == false)
            {
                MessageBox.Show("아이디 중복 체크를 해주세요");
                //checkedId();

            }
            


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
        private void TbEmailRegisterForm_Leave(object sender, EventArgs e)
        {
            //if (tbEmailRegisterForm.Text == "")
            //{
            //    tbEmailRegisterForm.Text = "E-Mail";
            //}
        }
        private void BtnPWChecKedRegisterForm_Leave(object sender, EventArgs e)
        {
            //if (btnPWChecKedRegisterForm.Text == "")
            //{
            //    btnPWChecKedRegisterForm.Text = "Checked PassWord";
            //}
        }
        private void BtnPWRegisterForm_Leave(object sender, EventArgs e)
        {
            //if (btnPWRegisterForm.Text == "")
            //{
            //    btnPWRegisterForm.Text = "PassWord";
            //}
        }
        private void BtnIDRegisterForm_Leave(object sender, EventArgs e)
        {
            //if (btnIDRegisterForm.Text == "")
            //{
            //    btnIDRegisterForm.Text = "ID";
            //}
        }
        private void BtnIDRegisterForm_TextChanged(object sender, EventArgs e)
        {
            flag = false;
        }
    }
}
