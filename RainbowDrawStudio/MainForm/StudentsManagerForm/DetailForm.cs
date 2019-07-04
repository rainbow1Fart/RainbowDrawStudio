using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RDS_Controller;
using RDS_Model;

namespace RainbowDrawStudio.MainForm.StudentsManagerForm
{

    public partial class DetailForm : DevExpress.XtraEditors.XtraForm
    {
        public static ThreadDelegate.CustomerEvent OnWindowClosed;
        public DetailForm(StudentsInfo arg, WindowsModel wm)
        {
            InitializeComponent();
            ViewInit(wm);
        }

        private void ViewInit(WindowsModel wm)
        {
            switch (wm)
            {
                
            }
        }

        private void DetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XtraMessageBoxArgs args  = ControlHelper.XtraMessageBoxArgs("确认退出吗", "消息", new DialogResult[] {DialogResult.Yes, DialogResult.No});
            if (XtraMessageBox.Show(args) == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void DetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnWindowClosed?.Invoke();
        }

        private void DetailForm_SizeChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Width = this.Width / 2;
            splitContainer1.Panel2.Width = this.Width / 2;
        }
    }
}