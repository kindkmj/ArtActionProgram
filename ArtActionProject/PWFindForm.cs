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
            tbFindPWFindPWForm.Text = string.Empty;
        }

        private void TbEnterEmailFindIDForm_Enter(object sender, EventArgs e)
        {
            tbEnterEmailFindIDForm.Text = string.Empty;
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
    }
}
