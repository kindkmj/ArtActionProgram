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
    public partial class GuideForm : Form
    {
        public GuideForm()
        {
            InitializeComponent();
        }
       

        private void BtnEnterGuideForm_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            MainForm MF = new MainForm();
            this.Close(); 
            MF.Show();
           
        }

        private void GuideForm_Load(object sender, EventArgs e)
        {
            lbUserInfoGuideForm.Text = LoginForm.sUID;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
