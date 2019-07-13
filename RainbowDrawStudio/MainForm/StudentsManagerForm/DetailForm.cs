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
        private StudentInfo _studentInfo;
        public DetailForm(StudentInfo arg, WindowsModel wm)
        {
            InitializeComponent();
            ViewInit(wm);
            SetWindwosText(arg);
            _studentInfo = arg;
        }

        private void ViewInit(WindowsModel wm)
        {
            switch (wm)
            {
                case WindowsModel.AddNew:
                    edit_simpleButton.Hide();
                    updata_simpleButton.Show();
                    updata_simpleButton.Text = @"新建(&N)";
                    update_linkLabel.Hide();

                    /*学生信息*/
                    name_textEdit.ReadOnly = false;
                    sex_comboBoxEdit.ReadOnly = false;
                    parents_textEdit.ReadOnly = false;
                    contacts_textEdit.ReadOnly = false;
                    address_textEdit.ReadOnly = false;
                    /*缴费信息*/
                    tuition_textEdit.ReadOnly = false;
                    classHours_textEdit.ReadOnly = false;
                    remaining_textEdit.ReadOnly = false;
                    last_dateEdit.ReadOnly = false;
                    yes_checkEdit.ReadOnly = false;
                    no_checkEdit.ReadOnly = false;
                    notPay_textEdit.ReadOnly = false;    
                    break;
                case WindowsModel.Modify:
                    edit_simpleButton.Hide();
                    updata_simpleButton.Show();
                    updata_simpleButton.Text = @"更新(&U)";
                    update_linkLabel.Show();

                    /*学生信息*/
                    name_textEdit.ReadOnly = false;
                    sex_comboBoxEdit.ReadOnly = false;
                    parents_textEdit.ReadOnly = false;
                    contacts_textEdit.ReadOnly = false;
                    address_textEdit.ReadOnly = false;
                    /*缴费信息*/
                    tuition_textEdit.ReadOnly = true;
                    classHours_textEdit.ReadOnly = true;
                    remaining_textEdit.ReadOnly = true;
                    last_dateEdit.ReadOnly = true;
                    yes_checkEdit.ReadOnly = true;
                    no_checkEdit.ReadOnly = true;
                    notPay_textEdit.ReadOnly = true;
                    break;
                case WindowsModel.Display:
                    edit_simpleButton.Show();
                    edit_simpleButton.Location = updata_simpleButton.Location;
                    updata_simpleButton.Hide();
                    update_linkLabel.Hide();

                    /*学生信息*/
                    name_textEdit.ReadOnly = true;
                    sex_comboBoxEdit.ReadOnly = true;
                    parents_textEdit.ReadOnly = true;
                    contacts_textEdit.ReadOnly = true;
                    address_textEdit.ReadOnly = true;
                    /*缴费信息*/
                    tuition_textEdit.ReadOnly = true;
                    classHours_textEdit.ReadOnly = true;
                    remaining_textEdit.ReadOnly = true;
                    last_dateEdit.ReadOnly = true;
                    yes_checkEdit.ReadOnly = true;
                    no_checkEdit.ReadOnly = true;
                    notPay_textEdit.ReadOnly = true;
                    break;
                default: break;
            }
        }

        protected void SetWindwosText(StudentInfo stu)
        {
            sn_textEdit.Text = stu.SerialNum;
            name_textEdit.Text = stu.Name;
            sex_comboBoxEdit.Text = stu.Sex;
            parents_textEdit.Text = stu.Parents;
            contacts_textEdit.Text = stu.Contacts;
            address_textEdit.Text = stu.Address;

            tuition_textEdit.Text = stu.Tuition.ToString();
            classHours_textEdit.Text = stu.ClassHours.ToString();
            remaining_textEdit.Text = stu.Remaining.ToString();
            last_dateEdit.Text = DateTime.Compare(stu.LastPayDate, new DateTime(1970, 1, 1)) <= 0
                ? string.Empty
                : stu.LastPayDate.ToString();
            if (stu.Pay)
            {
                no_checkEdit.Checked = true;
            }
            else
            {
                yes_checkEdit.Checked = true;
            }
            notPay_textEdit.Text = stu.NotPay.ToString();
        }

        private void DetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XtraMessageBoxArgs args  = ControlHelper.XtraMessageBoxArgs("消息", "确认退出吗", 
                new DialogResult[] {DialogResult.Yes, DialogResult.No});
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

        private void edit_simpleButton_Click(object sender, EventArgs e)
        {
            ViewInit(WindowsModel.Modify);
        }

        private void updata_simpleButton_Click(object sender, EventArgs e)
        {
            if (StudentInfo.CreateStudentInfo(GetWindowsText()) <= 0)
            {
                XtraMessageBox.Show("新建学生失败", "消息");
                return;
            }
            else
            {
                XtraMessageBox.Show("新建学生成功", "消息");
                this.Close();
            }
        }

        protected StudentInfo GetWindowsText()
        {
            StudentInfo stu = new StudentInfo();
            stu.SerialNum = sn_textEdit.Text.Trim();
            stu.Name = name_textEdit.Text.Trim();
            stu.Sex = sex_comboBoxEdit.Text.Trim();
            stu.Parents = parents_textEdit.Text.Trim();
            stu.Contacts = contacts_textEdit.Text.Trim();
            stu.Address = address_textEdit.Text.Trim();

            stu.Tuition = string.IsNullOrEmpty(tuition_textEdit.Text.Trim())
                ? 0
                : decimal.Parse(tuition_textEdit.Text.Trim());
            stu.ClassHours = string.IsNullOrEmpty(classHours_textEdit.Text.Trim())
                ? 0
                : int.Parse(classHours_textEdit.Text.Trim());
            stu.Remaining = string.IsNullOrEmpty(remaining_textEdit.Text.Trim())
                ? 0
                : int.Parse(remaining_textEdit.Text.Trim());
            stu.Pay = yes_checkEdit.Checked ? true : false;
            stu.NotPay = string.IsNullOrEmpty(notPay_textEdit.Text.Trim())
                ? 0
                : decimal.Parse(notPay_textEdit.Text.Trim());
            stu.LastPayDate = string.IsNullOrEmpty(last_dateEdit.Text.Trim())
                ? new DateTime(1970, 1, 1)
                : last_dateEdit.DateTime;
            return stu;
        }

        private void close_simpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void update_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PayDetailForm form = new PayDetailForm(_studentInfo);
            if(form.ShowDialog() == DialogResult.Yes)
                this.Close();
            else
            {
                _studentInfo = form.Result;
            }
        }
    }
}