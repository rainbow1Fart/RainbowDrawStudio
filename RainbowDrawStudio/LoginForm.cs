using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RainbowDrawStudio.Public;
using RDS_Controller;
using RDS_Model;

namespace RainbowDrawStudio
{
    public partial class LoginForm : XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            //连接Sqlite数据库
            if (!SQLiteControl.ConnectToDatabase(@"./DataBase/database.sqlite"))
            {
                XtraMessageBoxArgs args =
                    ControlHelper.XtraMessageBoxArgs("消息", "连接数据库失败", new DialogResult[] {DialogResult.Yes});
                XtraMessageBox.Show(args);
                Application.Exit();
            }

            account_textEdit.Focus();
        }

        /// <summary>
        /// 退出button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_simpleButton_Click(object sender, EventArgs e)
        {
            XtraMessageBoxArgs args = ControlHelper.XtraMessageBoxArgs("消息", "是否退出程序",
                new DialogResult[] {DialogResult.Yes, DialogResult.No}, 5000);
            if (XtraMessageBox.Show(args) == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        /// <summary>
        /// 密码框KeyPress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void password_textEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(account_textEdit.Text.Trim()))
                {
                    XtraMessageBox.Show("请输入账号！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    account_textEdit.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(password_textEdit.Text.Trim()))
                {
                    XtraMessageBox.Show("请输入密码！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    password_textEdit.Focus();
                    return;
                }

                if (Login(account_textEdit.Text.Trim(), password_textEdit.Text.Trim()))
                {
                    MainForm.MainForm form = new MainForm.MainForm();
                    Program.ApplicationContext.MainForm = form;
                    this.Close();
                    form.Show();
                }
            }
        }

        /// <summary>
        /// 注册账号label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void register_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Text = "注册账号";
            form.Show();
        }

        /// <summary>
        /// 忘记密码label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forget_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        /// <summary>
        /// 登录button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_simpleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(account_textEdit.Text.Trim()))
            {
                XtraMessageBox.Show( "请输入账号！", "消息", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                account_textEdit.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password_textEdit.Text.Trim()))
            {
                XtraMessageBox.Show("请输入密码！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password_textEdit.Focus();
                return;
            }

            if (Login(account_textEdit.Text.Trim(), password_textEdit.Text.Trim()))
            {
                MainForm.MainForm form = new MainForm.MainForm();
                Program.ApplicationContext.MainForm = form;
                this.Close();
                form.Show();
            }
        }

        /// <summary>
        /// 登录函数
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        protected bool Login(string Account, string Password)
        {
            Password = Encryption.EncryptBase64(Password);
            //验证账号
            if (!AccountInfo.AccountChecked(Account))
            {
                XtraMessageBox.Show("输入的账号有误,请重新输入", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //验证密码
            if (!AccountInfo.AccountFullChecked(Account, Password))
            {
                XtraMessageBox.Show("输入的密码有误,请重新输入!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}