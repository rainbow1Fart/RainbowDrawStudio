using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainbowDrawStudio
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        public static ApplicationContext ApplicationContext;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm form = new LoginForm();
            form.Show();
            ApplicationContext = new ApplicationContext();
            ApplicationContext.MainForm = form;
            Application.Run(ApplicationContext);
        }
    }
}
