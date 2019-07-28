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

namespace RainbowDrawStudio.MainForm.StudentsManagerForm
{
    public partial class PayDetailForm : DevExpress.XtraEditors.XtraForm
    {
        private StudentInfo _studentInfo;
        public PayDetailForm(StudentInfo arg, WindowsModel wm)
        {
            InitializeComponent();
            _studentInfo = arg;
            SetWindwosText(arg);
            ViewInit(wm);
        }

        public PayDetailForm(PayRecordInfo arg, WindowsModel wm)
        {
            InitializeComponent();
            SetWindwosText(arg);
            ViewInit(wm);
        }

        public StudentInfo Result
        {
            get { return _studentInfo; }
        }

        private void close_simpleButton_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("确定关闭吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
            {
                DialogResult = DialogResult.No;
                return;
            }
            this.DialogResult = DialogResult.Yes;
            Close();
        }

        private void ok_simpleButton_Click(object sender, EventArgs e)
        {
            if (no_checkEdit.Checked && yes_checkEdit.Checked)
            {
                XtraMessageBox.Show("请选择缴费状态", "消息");
                no_checkEdit.Checked = true;
                return;
            }
            if (string.IsNullOrEmpty(last_dateEdit.Text.Trim()))
            {
                last_dateEdit.DateTime = DateTime.Today;
                last_dateEdit.Focus();
                XtraMessageBox.Show("请选择正确的追缴日期", "消息");
                return;
            }

            if (XtraMessageBox.Show("确认更改以上信息吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
                return;

            Public.VerificationForm form = new Public.VerificationForm();
            form.ShowDialog();
            if (!form.Result)
                return;

            DialogResult = DialogResult.No;
            _studentInfo = GetWindowsText(_studentInfo);
            if (StudentInfo.Updata(_studentInfo) <= 0)
            {
                XtraMessageBox.Show("修改失败！");
                return;
            }
            PayRecordInfo pr = new PayRecordInfo()
            {
                StudentID = _studentInfo.ID,
                StudentName = _studentInfo.Name,
                Tuition = _studentInfo.Tuition,
                ClassHours = _studentInfo.ClassHours,
                Remaining = _studentInfo.Remaining,
                Pay = _studentInfo.Pay,
                NotPay = _studentInfo.NotPay,
                Remark = remark_memoEdit.Text,
                LastDateTime = last_dateEdit.DateTime,
                OperationID = AccountInfo.AccountSession.ID,
                OperationPerson = AccountInfo.AccountSession.Person,
            };
            int result = PayRecordInfo.CreateRecord(pr);
            if (result <= 0)
            {
                XtraMessageBox.Show("添加历史修改记录失败", "消息");
                return;
            }

            XtraMessageBox.Show("更新成功");
            Close();
            return;
        }

        protected void SetWindwosText(StudentInfo stu)
        {
            tuition_textEdit.Text = stu.Tuition.ToString();
            classHours_textEdit.Text = stu.ClassHours.ToString();
            remaining_textEdit.Text = stu.Remaining.ToString();
            last_dateEdit.Text = DateTime.Compare(stu.LastPayDate, new DateTime(1970, 1, 1)) <= 0
                ? string.Empty
                : stu.LastPayDate.ToString();
            if (stu.Pay)
            {
                yes_checkEdit.Checked = true;
                no_checkEdit.Checked = false;
            }
            else
            {
                no_checkEdit.Checked = true;
                yes_checkEdit.Checked = false;
            }

            notPay_textEdit.Text = stu.NotPay.ToString();
        }
        protected void SetWindwosText(PayRecordInfo arg)
        {
            tuition_textEdit.Text = arg.Tuition.ToString();
            classHours_textEdit.Text = arg.ClassHours.ToString();
            remaining_textEdit.Text = arg.Remaining.ToString();
            last_dateEdit.Text = DateTime.Compare(arg.LastDateTime, new DateTime(1970, 1, 1)) <= 0
                ? string.Empty
                : arg.LastDateTime.ToString();
            if (arg.Pay)
            {
                yes_checkEdit.Checked = true;
                no_checkEdit.Checked = false;
            }
            else
            {
                no_checkEdit.Checked = true;
                yes_checkEdit.Checked = false;
            }

            notPay_textEdit.Text = arg.NotPay.ToString();
            remark_memoEdit.Text = arg.Remark;
        }

        private void ViewInit(WindowsModel wm)
        {
            switch (wm)
            {
                case WindowsModel.Modify:
                    ok_simpleButton.Enabled = true;
                    ok_simpleButton.Show();

                    /*缴费信息*/
                    tuition_textEdit.ReadOnly = false;
                    classHours_textEdit.ReadOnly = false;
                    remaining_textEdit.ReadOnly = false;
                    last_dateEdit.ReadOnly = false;
                    yes_checkEdit.ReadOnly = false;
                    no_checkEdit.ReadOnly = false;
                    notPay_textEdit.ReadOnly = false;
                    remark_memoEdit.ReadOnly = false;
                    break;
               default:
                    ok_simpleButton.Enabled = false;
                    ok_simpleButton.Hide();

                    /*缴费信息*/
                    tuition_textEdit.ReadOnly = true;
                    classHours_textEdit.ReadOnly = true;
                    remaining_textEdit.ReadOnly = true;
                    last_dateEdit.ReadOnly = true;
                    yes_checkEdit.ReadOnly = true;
                    no_checkEdit.ReadOnly = true;
                    notPay_textEdit.ReadOnly = true;
                    remark_memoEdit.ReadOnly = true;
                    break;
            }
        }

        protected StudentInfo GetWindowsText(StudentInfo arg)
        {
            StudentInfo stu = arg;
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

        private void yes_checkEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit ce = sender as CheckEdit;
            if (ce.Checked)
            {
                no_checkEdit.Checked = false;
                notPay_textEdit.Text = "0";
                notPay_textEdit.Properties.ReadOnly = true;

            }
            else
            {
                no_checkEdit.Checked = true;
                notPay_textEdit.Text = "0";
                notPay_textEdit.Properties.ReadOnly = false;
            }
        }

        private void no_checkEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit ce = sender as CheckEdit;
            if (ce.Checked)
            {
                yes_checkEdit.Checked = false;
                notPay_textEdit.Text = "0";
                notPay_textEdit.Properties.ReadOnly = false;
            }
            else
            {
                yes_checkEdit.Checked = true;
                notPay_textEdit.Text = "0";
                notPay_textEdit.Properties.ReadOnly = true;
            }
        }
    }
}