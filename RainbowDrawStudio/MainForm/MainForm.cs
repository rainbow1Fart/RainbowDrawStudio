﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RDS_Model;
using RainbowDrawStudio.MainForm.GroupClassForm;
using RainbowDrawStudio.MainForm.CheckinRecordForm;

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

            notifyIcon.Visible = false;
            //非管理员用户
            if (AccountInfo.AccountSession.Power != -1)
            {
                main_navigationPane.Pages.Remove(account_navigationPage);
                main_navigationPane.Pages.Remove(restore_navigationPage);
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
                    AccountManagerForm.AccountManagerControl ctrl = child as AccountManagerForm.AccountManagerControl;
                    if (ctrl != null)
                    {
                        ctrl.Visible = true;
                        return;
                    }
                }
                AccountManagerForm.AccountManagerControl form = new AccountManagerForm.AccountManagerControl();
                form.Parent = account_navigationPage;
                form.Dock = DockStyle.Fill;
                form.Show();
                return;
            }

            //学生管理
            if (main_navigationPane.SelectedPage == student_navigationPage)
            {
                foreach (Control child in student_navigationPage.Controls)
                {
                    StudentsManagerForm.StudentUserControl ctrl = child as StudentsManagerForm.StudentUserControl;
                    if (ctrl != null)
                    {
                        ctrl.Visible = true;
                        return;
                    }
                }
                StudentsManagerForm.StudentUserControl form = new StudentsManagerForm.StudentUserControl();
                form.Parent = student_navigationPage;
                form.Dock = DockStyle.Fill;
                form.Show();
                return;
            }
            //学生回收站
            if (main_navigationPane.SelectedPage == restore_navigationPage)
            {
                foreach (Control child in student_navigationPage.Controls)
                {
                    RecordStudentManagerForm.RecordStudentUserControl ctrl = child as RecordStudentManagerForm.RecordStudentUserControl;
                    if (ctrl != null)
                    {
                        ctrl.Visible = true;
                        return;
                    }
                }
                RecordStudentManagerForm.RecordStudentUserControl form = new RecordStudentManagerForm.RecordStudentUserControl();
                form.Parent = restore_navigationPage;
                form.Dock = DockStyle.Fill;
                form.Show();
                return;
            }
            //缴费记录
            if (main_navigationPane.SelectedPage == payRecord_navigationPage)
            {
                foreach (Control child in payRecord_navigationPage.Controls)
                {
                    PayRecordForm.PayRecordControl ctrl = child as PayRecordForm.PayRecordControl;
                    if (ctrl != null)
                    {
                        ctrl.Visible = true;
                        return;
                    }
                }
                PayRecordForm.PayRecordControl form = new PayRecordForm.PayRecordControl();
                form.Parent = payRecord_navigationPage;
                form.Dock = DockStyle.Fill;
                form.Show();
                return;
            }
            //班级&签到
            if (main_navigationPane.SelectedPage == checkin_navigationPage)
            {
                foreach (Control child in checkin_navigationPage.Controls)
                {
                    GroupClassUserControl ctrl = child as GroupClassUserControl;
                    if (ctrl != null)
                    {
                        ctrl.Visible = true;
                        return;
                    }
                }
                GroupClassUserControl form = new GroupClassUserControl();
                form.Parent = checkin_navigationPage;
                form.Dock = DockStyle.Fill;
                form.Show();
                return;
            }
            //签到历史
            if (main_navigationPane.SelectedPage == checkinHistory_navigationPage)
            {
                foreach (Control child in checkinHistory_navigationPage.Controls)
                {
                    CheckinUserControl ctrl = child as CheckinUserControl;
                    if (ctrl != null)
                    {
                        ctrl.Visible = true;
                        return;
                    }
                }
                CheckinUserControl form = new CheckinUserControl();
                form.Parent = checkinHistory_navigationPage;
                form.Dock = DockStyle.Fill;
                form.Show();
                return;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = false;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon.ShowBalloonTip(2000, string.Empty, "程序已经最小化到此处", ToolTipIcon.Info);
                notifyIcon.Text = string.Format("姓名: {0} \r\n 账号: {1}",AccountInfo.AccountSession.Person, AccountInfo.AccountSession.Account);
                notifyIcon.Visible = true;
                this.Hide();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XtraMessageBoxArgs args = ControlHelper.XtraMessageBoxArgs("消息", "确认退出吗",
                new DialogResult[] { DialogResult.Yes, DialogResult.No }, 5000, 1);
            if (XtraMessageBox.Show(args) == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}