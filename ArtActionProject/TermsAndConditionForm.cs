﻿using System;
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
    public partial class TermsAndConditionForm : Form
    {
        bool bClicked = false;
        int iCheckedAllClicked = 0;
        public TermsAndConditionForm()
        {
            InitializeComponent();
        }

        private void PbBackTermsAndConditionsForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이용약관동의를 중도 중지하겠습니다");
            Application.Exit();
        }

        //checkedBox_모두 동의 하는 칸
        private void CkTermsAndConditionsFormAll_CheckedChanged(object sender, EventArgs e)
        {
            ///김보라
            //ckTermsAndConditionsFormAll이 check되었을 경우 그외의 
            //나머지 ckBox가 다 true가 되게 하는 부분
            try
            {
                if (ckTermsAndConditionsFormAll.Checked = true)
                {
                    ckTermsAndConditionForm1.Checked = true;
                    ckTermsAndConditionForm2.Checked = true;
                    ckTermsAndConditionForm3.Checked = true;
                    ckTermsAndConditionForm4.Checked = true;
                    bClicked = true;

                }
                else if (ckTermsAndConditionsFormAll.Checked = false)
                {
                    ckTermsAndConditionForm1.Checked = false;
                    ckTermsAndConditionForm2.Checked = false;
                    ckTermsAndConditionForm3.Checked = false;
                    ckTermsAndConditionForm4.Checked = false;
                    bClicked = false;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("시스템에 문제가 있습니다."+ex.Message);
            }
        }

        private void BtnAgreeTermsAndConditionForm_Click(object sender, EventArgs e)
        {
            ///김보라
            ///btnAgreeTermsAndConditionsForm의 버튼을 눌렀을때
            ///ckBox가 한개라도 안되어 있을 경우 messageBox를 생성해
            ///사용자에게 오류를 알려주고 TermsAndConditionForm이 사라지는
            ///이벤트를 진행되지 않게 한다
            if(ckTermsAndConditionForm1.Checked == false)
            {
                MessageBox.Show("필수 1번째 조항에 동의해주세요");
            }
            if (ckTermsAndConditionForm2.Checked == false)
            {
                MessageBox.Show("필수 2번째 조항에 동의해주세요");
            }
            if (ckTermsAndConditionForm3.Checked == false)
            {
                MessageBox.Show("필수 3번째 조항에 동의해주세요");
            }
            if (ckTermsAndConditionForm4.Checked == false)
            {
                MessageBox.Show("필수 4번째 조항에 동의해주세요");
            }
            else if(ckTermsAndConditionForm1.Checked == true ||
                ckTermsAndConditionForm2.Checked == true ||
                ckTermsAndConditionForm3.Checked == true ||
                ckTermsAndConditionForm4.Checked == true)
            {
                MessageBox.Show("이용약관 동의 감사드립니다");
                this.Close();
            }
        }
    }
}
