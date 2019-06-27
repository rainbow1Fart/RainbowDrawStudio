using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RDS_Model;

namespace RainbowDrawStudio.MainForm
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();

            //启动计时器
            timer.Start();
            timer.Interval = 100;
            labelControl1.Text = string.Format("欢迎你: {0}", AccountInfo.AccountSession.Person);

            //非管理员用户
            if (AccountInfo.AccountSession.Power != -1)
            {
                main_navigationPane.Pages.Remove(account_navigationPage);
            }
        }

        ~MainForm()
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer_labelControl.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Random ran = new Random();
            int red = ran.Next(0, 255);
            int green = ran.Next(0, 255);
            int blue = ran.Next(0, 255);
            //花里胡哨的
            labelControl1.ForeColor = Color.FromArgb(red, green, blue);
            timer_labelControl.ForeColor = Color.FromArgb(red, green, blue);
        }

        private void navigationPane1_Click(object sender, EventArgs e)
        {
            //账号管理
            if (main_navigationPane.SelectedPage == account_navigationPage)
            {
                foreach (Control child in account_navigationPage.Controls)
                {
                    StudentManager.StudentManagerControl ctrl = child as StudentManager.StudentManagerControl;
                    if (ctrl != null)
                    {
                        ctrl.Visible = true;
                        return;
                    }
                }

                StudentManager.StudentManagerControl form = new StudentManager.StudentManagerControl();
                form.Parent = account_navigationPage;
                form.Dock = DockStyle.Fill;
            }
        }
    }
}