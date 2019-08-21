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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //종료버튼
        private void PbExitMainForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램을 종료시키겠습니다");
            Application.Exit();
        }
    }
}
