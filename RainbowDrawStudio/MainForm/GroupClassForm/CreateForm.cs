using System;
using DevExpress.XtraEditors;
using RDS_Controller;
using RDS_Model;
using System.Windows.Forms;

namespace RainbowDrawStudio.MainForm.GroupClassForm
{
    public partial class CreateForm : DevExpress.XtraEditors.XtraForm
    {
        public static ThreadDelegate.CustomerEvent OnWindowClosed;

        public GroupClassInfo GroupClass
        {
            get { return _groupClass; }
        }
        private GroupClassInfo _groupClass;
        public CreateForm(GroupClassInfo arg, WindowsModel wm)
        {
            InitializeComponent();
            _groupClass = arg;
            ViewInit(wm);
        }

        private void ViewInit(RDS_Model.WindowsModel wm)
        {
            var temps = AccountInfo.GetAll();
            string[] persons = new string[temps.Count];
            for (int i = 0; i < temps.Count; i++)
            {
                persons[i] = temps[i].Person;
            }
            classTeacher_comboBoxEdit.Properties.Items.AddRange(persons);

            className_textEdit.Text = _groupClass.GroupName;
            classTeacher_comboBoxEdit.Text = _groupClass.ClassTeacher;

            switch (wm)
            {
                case WindowsModel.AddNew:
                    this.Text = "创建班级";
                    edit_simpleButton.Hide();
                    ok_simpleButton.Show();
                    className_textEdit.Properties.ReadOnly = false;
                    classTeacher_comboBoxEdit.Properties.ReadOnly = false;
                    break;
                case WindowsModel.Modify:
                    this.Text = "修改班级信息";
                    edit_simpleButton.Show();
                    edit_simpleButton.Location = ok_simpleButton.Location;
                    ok_simpleButton.Hide();
                    className_textEdit.Properties.ReadOnly = false;
                    classTeacher_comboBoxEdit.Properties.ReadOnly = false;
                    break;
                default:
                    this.Text = "浏览";
                    edit_simpleButton.Hide();
                    ok_simpleButton.Hide();
                    className_textEdit.Properties.ReadOnly = true;
                    classTeacher_comboBoxEdit.Properties.ReadOnly = true;
                    break;
            }
        }
        private void CreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("确认关闭当前窗口吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            e.Cancel = false;
        }

        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnWindowClosed?.Invoke();
        }

        private void ok_simpleButton_Click(object sender, System.EventArgs e)
        {
            _groupClass.ClassTeacher = classTeacher_comboBoxEdit.Text.Trim();
            _groupClass.CreateDate = DateTime.Now;
            _groupClass.CreatePerson = AccountInfo.AccountSession.Person;
            _groupClass.PersonID = AccountInfo.AccountSession.ID;
            _groupClass.GroupName = className_textEdit.Text.Trim();

            int result = GroupClassInfo.CreateGroup(_groupClass);
            if (result <= 0)
            {
                XtraMessageBox.Show("创建班级失败","消息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            XtraMessageBox.Show("创建班级成功", "消息", MessageBoxButtons.OK);
            this.Close();
            return;
        }

        private void edit_simpleButton_Click(object sender, EventArgs e)
        {
            _groupClass.ClassTeacher = classTeacher_comboBoxEdit.Text.Trim();
            _groupClass.GroupName = className_textEdit.Text.Trim();
            int result = GroupClassInfo.ModifyGroup(_groupClass);
            if (result <= 0)
            {
                XtraMessageBox.Show("更新班级失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            XtraMessageBox.Show("更新班级成功", "消息", MessageBoxButtons.OK);
            this.Close();
            return;
        }

        private void cloase_simpleButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}