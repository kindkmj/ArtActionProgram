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
    public partial class IDFindForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public IDFindForm()
        {
            InitializeComponent();
        }

        private void PbBackFindIDForm_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void TbFindIDFindIDForm_Enter(object sender, EventArgs e)
        {
            tbFindIDFindIDForm.Text = string.Empty;
        }

        private void IDFindForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;   
        }

        private void IDFindForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));    


            }
        }

        private void IDFindForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void BtnEnterValueFindIDForm_Click(object sender, EventArgs e)
        {
            if (tbFindIDFindIDForm.Text.Trim() == "E-MAIL"|| tbFindIDFindIDForm.Text.Trim()==string.Empty)
            {
                MessageBox.Show("이메일 을 입력해주세요");
                return;
            }
            string email = "";
            email= Entity.Select("C","S","EMAIL", "CUSTOMER_INFO","EMAIL", tbFindIDFindIDForm.Text.Trim());
            if (tbFindIDFindIDForm.Text.Trim() == email)
            {
                //메일 전송하는시스템 사용
            }
            else if (tbFindIDFindIDForm.Text.Trim() != email)
            {
                MessageBox.Show("등록된 이메일이 없습니다.");
            }
        }

        private void TbFindIDFindIDForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
