﻿using System;
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

        private void BtnChecKedIDRegisterForm_Click(object sender, EventArgs e) //아이디 중복 체크 버튼
        {
            
        }

        private void BtnSignRegisterForm_Click(object sender, EventArgs e)//회원가입 하는 버튼
        {
            try
            {
                MessageBox.Show("가입되었습니다");
            
            }
            catch (Exception )
            {
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
    }
}
