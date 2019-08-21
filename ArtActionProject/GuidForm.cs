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
    public partial class GuidForm : Form
    {
        public GuidForm()
        {
            InitializeComponent();
        }

        private void PbBackGuideForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이용약관 가이드를 중도 중지시키겠습니다");
            Application.Exit();
        }
    }
}
