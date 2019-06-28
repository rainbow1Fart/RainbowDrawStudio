using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;
using RainbowDrawStudio.Public;
using RDS_Controller;
using RDS_Model;

namespace RainbowDrawStudio
{
    public partial class RegisterForm : DevExpress.XtraEditors.XtraForm
    {
        public static ThreadDelegate.CustomerEvent OnWindowClosed;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void close_simpleButton_Click(object sender, EventArgs e)
        {
            XtraMessageBoxArgs args = ControlHelper.XtraMessageBoxArgs("消息", "确认关闭当前窗口吗？",
                new DialogResult[] { DialogResult.Yes, DialogResult.No });
            if (XtraMessageBox.Show(args) == DialogResult.No)
            {
                return;
            }

            this.Close();
        }

        private void register_simpleButton_Click(object sender, EventArgs e)
        {
            if (!FullCheck())
            {
                return;
            }

            AccountInfo account = new AccountInfo();
            account.Account = account_textEdit.Text.Trim();
            account.Person = person_textEdit.Text.Trim();
            account.Password = Encryption.EncryptBase64(password_textEdit.Text.Trim());
            account.Key = Encryption.EncryptBase64(key_textEdit.Text.Trim());
            if (AccountInfo.RegisterAccount(account))
            {
                XtraMessageBox.Show(
                    "注册成功！请牢记以下信息：\r\n" + string.Format("账号：{0}\r\n密码：{1}\r\n安全码：{2}\r\n", account.Account,
                        Encryption.DecryptBase64(account.Password), Encryption.DecryptBase64(account.Key)), "消息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                XtraMessageBox.Show("注册失败！","消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// 内容检查
        /// </summary>
        protected bool FullCheck()
        {
            if (string.IsNullOrEmpty(person_textEdit.Text.Trim()))
            {
                XtraMessageBox.Show("请填写姓名", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                person_textEdit.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(account_textEdit.Text.Trim()))
            {
                XtraMessageBox.Show("请填写用户名", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                account_textEdit.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(password_textEdit.Text.Trim()))
            {
                XtraMessageBox.Show("请填写密码", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password_textEdit.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(pwdAgain_textEdit.Text.Trim()))
            {
                XtraMessageBox.Show("请填写密码", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pwdAgain_textEdit.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(key_textEdit.Text.Trim()))
            {
                XtraMessageBox.Show("请填写安全码", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                key_textEdit.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(keyAgain_textEdit.Text.Trim()))
            {
                XtraMessageBox.Show("请填写安全码", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                keyAgain_textEdit.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// password失去焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void password_textEdit_Leave(object sender, EventArgs e)
        {
            if (password_textEdit.Text.Length < 6 && !string.IsNullOrEmpty(password_textEdit.Text.Trim()))
            {
                labelControl9.ForeColor = Color.Red;
                labelControl9.Text = "密码长度小于6位数";
                password_textEdit.Focus();
                return;
            }

            labelControl9.Text = "请输入6位数以上的密码";
            labelControl9.ForeColor = System.Drawing.SystemColors.ControlDark;
        }

        /// <summary>
        /// psswordAgain失去焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pwdAgain_textEdit_Leave(object sender, EventArgs e)
        {
            if (pwdAgain_textEdit.Text.Length < 6 && !string.IsNullOrEmpty(pwdAgain_textEdit.Text.Trim()))
            {
                labelControl10.ForeColor = Color.Red;
                labelControl10.Text = "密码长度小于6位数";
                pwdAgain_textEdit.Focus();
                return;
            }
            if (pwdAgain_textEdit.Text.Trim() != password_textEdit.Text.Trim())
            {
                XtraMessageBox.Show("两次输入的密码不一致，请重新输入", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password_textEdit.Text = string.Empty;
                pwdAgain_textEdit.Text = string.Empty;
                password_textEdit.Focus();
                return;
            }
            labelControl10.Text = "请再次输入密码";
            labelControl10.ForeColor = System.Drawing.SystemColors.ControlDark;
        }

        private void key_textEdit_Leave(object sender, EventArgs e)
        {
            if (key_textEdit.Text.Length < 6&&!string.IsNullOrEmpty(key_textEdit.Text.Trim()))
            {
                labelControl11.ForeColor = Color.Red;
                labelControl11.Text = "安全码长度小于6位数";
                key_textEdit.Focus();
                return;
            }

            labelControl11.Text = "请输入安全码";
            labelControl11.ForeColor = System.Drawing.SystemColors.ControlDark;
        }

        private void keyAgain_textEdit_Leave(object sender, EventArgs e)
        {
            if (keyAgain_textEdit.Text.Length < 6 && !string.IsNullOrEmpty(key_textEdit.Text.Trim()))
            {
                labelControl12.ForeColor = Color.Red;
                labelControl12.Text = "安全码长度小于6位数";
                keyAgain_textEdit.Focus();
                return;
            }

            labelControl12.Text = "请再次输入安全码";
            labelControl12.ForeColor = System.Drawing.SystemColors.ControlDark;
        }

        private void password_textEdit_MouseEnter(object sender, EventArgs e)
        {
            password_textEdit.Properties.PasswordChar = '\0';
            pwdAgain_textEdit.Properties.PasswordChar = '\0';
        }

        private void key_textEdit_MouseEnter(object sender, EventArgs e)
        {
            key_textEdit.Properties.PasswordChar = '\0';
            keyAgain_textEdit.Properties.PasswordChar = '\0';
        }

        private void password_textEdit_MouseLeave(object sender, EventArgs e)
        {
            password_textEdit.Properties.PasswordChar = '*';
            pwdAgain_textEdit.Properties.PasswordChar = '*';
        }

        private void key_textEdit_MouseLeave(object sender, EventArgs e)
        {
            key_textEdit.Properties.PasswordChar = '*';
            keyAgain_textEdit.Properties.PasswordChar = '*';
        }
        private void account_textEdit_Leave(object sender, EventArgs e)
        {
            if (AccountInfo.AccountChecked(account_textEdit.Text.Trim()))
            {
                labelControl8.ForeColor = Color.Red;
                labelControl8.Text = "存在相同的账号名了";
                account_textEdit.Focus();
            }
            else
            {
                labelControl8.ForeColor = System.Drawing.SystemColors.ControlDark;
                labelControl8.Text = "请输入您的用户名";
            }
        }

        private void person_textEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;
            if (!FullCheck())
            {
                return;
            }

            AccountInfo account = new AccountInfo();
            account.Account = account_textEdit.Text.Trim();
            account.Person = person_textEdit.Text.Trim();
            account.Password = Encryption.EncryptBase64(password_textEdit.Text.Trim());
            account.Key = Encryption.EncryptBase64(key_textEdit.Text.Trim());
            if (AccountInfo.RegisterAccount(account))
            {
                XtraMessageBox.Show(
                    "注册成功！请牢记以下信息：\r\n" + string.Format("账号：{0}\r\n密码：{1}\r\n安全码：{2}\r\n", account.Account,
                        Encryption.DecryptBase64(account.Password), Encryption.DecryptBase64(account.Key)), "消息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                XtraMessageBox.Show("注册失败！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnWindowClosed?.Invoke();
        }
    }
}