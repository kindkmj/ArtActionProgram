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
    public partial class PWFindForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public PWFindForm()
        {
            InitializeComponent();
        }

        private void TbFindPWFindPWForm_Enter(object sender, EventArgs e) 
        {
            tbIDPWForm.Text = string.Empty;
        }

        private void TbEnterEmailFindIDForm_Enter(object sender, EventArgs e)
        {
            tbEmailFindIDForm.Text = string.Empty;
        }

    

        private void BtnConnectFindLDPWForm_Click(object sender, EventArgs e)
        {
            IDFindForm iDFind = new IDFindForm(); //ID폼 띄우는 버튼
            iDFind.ShowDialog();
            this.Close();
        }

        private void PWFindForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void PWFindForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void PWFindForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void PbBackFindPWForm_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void BtnEnterValueFindPWForm_Click(object sender, EventArgs e)
        {
            if (tbIDPWForm.Text.Trim() == "ID" || tbEmailFindIDForm.Text.Trim() =="E-Mail")
            {
                MessageBox.Show("아이디 혹은 이메일 값을 확인해주세요.");
                return;
            }
            string email = "";
            string id = "";
            //processCase 이름 다시 짓기.
            id = Entity.Select("C", "S", "ID", "CUSTOMER_INFO", "ID", tbIDPWForm.Text.Trim());
            email=Entity.Select("C", "S", "EMAIL", "CUSTOMER_INFO", "EMAIL", tbEmailFindIDForm.Text.Trim());
            if (tbEmailFindIDForm.Text.Trim() == email&&tbIDPWForm.Text.Trim()==id)
            {
                //메일 전송하는시스템 사용
            }
            else if (tbEmailFindIDForm.Text.Trim() != email)
            {
                MessageBox.Show("등록된 이메일이 없습니다.");
            }
        }
    }
}
