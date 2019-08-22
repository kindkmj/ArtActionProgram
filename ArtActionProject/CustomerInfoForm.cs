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
    public partial class CustomerInfoForm : Form
    {
        public CustomerInfoForm()
        {
            InitializeComponent();
        }

        //중간에 종료시키는 부분
        private void PbBackGuideForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
