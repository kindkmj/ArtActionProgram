using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtActionProject
{
    static class Program
    {
        // Version 1.9
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new MainForm());
            //Application.Run(new CustomerInfoForm());
            //Application.Run(new GuidForm());
            //Application.Run(new IDFindForm());
            //Application.Run(new PWFindForm());
            //Application.Run(new RegisterForm());
            //Application.Run(new TermsAndConditionForm());
        }
    }
}
