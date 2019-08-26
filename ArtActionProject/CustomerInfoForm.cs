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

        private void CustomerInfoForm_Load(object sender, EventArgs e)
        {
            string test2 = Entity.Select("ID", "CUSTOMER_INFO", "EMAIL");
            string test3 = Entity.Select("EMAIL", "CUSTOMER_INFO", "ID");

            lbIDCustomerInfoForm.Text = test2;
            lbEmailCustomerInfoForm.Text = test3;
               


        }

    }
}
