using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mime;
using System.Net.Mail;

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
            if(tbFindIDFindIDForm.Text =="")
            {
                tbFindIDFindIDForm.Text = "E-Mail";
                tbFindIDFindIDForm.Text = string.Empty;
                tbFindIDFindIDForm.ForeColor = Color.DarkGray;
            }
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
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("kismet1023@gmail.com", "dkfqkcjsrnr1");
                MailMessage msg = new MailMessage();
                msg.To.Add("kismet1023@gmail.com");
                msg.From = new MailAddress("kismet1023@gmail.com");
                msg.Subject = "ArtAction";
                msg.Body = "입력: AWEsd11T";
                client.Send(msg);
                MessageBox.Show("메일이 보내졌습니다.");
            }
            catch (Exception)
            {
            }
        }
    }
}
