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
using RainbowDrawStudio.Public;

namespace RainbowDrawStudio
{
    public partial class FogetAccountForm : DevExpress.XtraEditors.XtraForm
    {
        public FogetAccountForm()
        {
            InitializeComponent();
        }

        private void password_textEdit_MouseLeave(object sender, EventArgs e)
        {
            password_textEdit.Properties.PasswordChar = '*';
            pwdAgain_textEdit.Properties.PasswordChar = '*';
        }

        private void pwdAgain_textEdit_MouseLeave(object sender, EventArgs e)
        {
            password_textEdit.Properties.PasswordChar = '*';
            pwdAgain_textEdit.Properties.PasswordChar = '*';
        }

        private void password_textEdit_MouseEnter(object sender, EventArgs e)
        {
            password_textEdit.Properties.PasswordChar = '\0';
            pwdAgain_textEdit.Properties.PasswordChar = '\0';
        }

        private void pwdAgain_textEdit_MouseEnter(object sender, EventArgs e)
        {
            password_textEdit.Properties.PasswordChar = '\0';
            pwdAgain_textEdit.Properties.PasswordChar = '\0';
        }

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

        private void ok_simpleButton_Click(object sender, EventArgs e)
        {
            if (FindBack())
            {
                XtraMessageBox.Show("修改成功");
                this.Close();
            }
        }

        private void key_textEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != 13)
                return;
            if(FindBack())
            {
                XtraMessageBox.Show("修改成功");
                this.Close();
            }
        }

        private bool FindBack()
        {
            if (!AccountInfo.AccountChecked(account_textEdit.Text.Trim()))
            {
                XtraMessageBox.Show("输入的账号不存在，请重新输入");
                account_textEdit.Focus();
                return false;
            }

            AccountInfo account = AccountInfo.FindBackChecked(account_textEdit.Text.Trim(), key_textEdit.Text.Trim());
            if (account == null)
            {
                XtraMessageBox.Show("账号或安全码输入有误，请重新输入");
                return false;
            }

            //通过验证
            account.Password = password_textEdit.Text.Trim();
            account.Key = RDS_Controller.Encryption.DecryptBase64(account.Key);
            if (AccountInfo.Modify(account) < 0)
                return false;
            return true;
        }
    }
}