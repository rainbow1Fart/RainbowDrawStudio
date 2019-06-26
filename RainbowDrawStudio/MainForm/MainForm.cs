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
    }
}