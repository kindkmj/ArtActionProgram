using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtActionServer
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Program.IP = tbIP.Text.Trim();
            Program.PORT = tbPort.Text.Trim();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            tbPort.Text = Program.PORT;
            tbIP.Text = Program.IP;
        }
    }
}
