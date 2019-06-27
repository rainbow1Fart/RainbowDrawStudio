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
using System.IO;
using System.Xml.Linq;
using DevExpress.CodeParser.VB;
using System.Xml;

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
            //每次登录前Copy一份DB
            FileInfo file = new FileInfo(@"./DataBase/database.sqlite");
            if (!File.Exists(@"./DataBase/" + DateTime.Today.ToString("yyyy-MM-dd") + ".sqlite"))
            {
                file = file.CopyTo(@"./DataBase/" + DateTime.Today.ToString("yyyy-MM-dd") + ".sqlite");
                file.Encrypt();
            }
            //解密文件
            //else
            //{
            //    file = new FileInfo(@"./DataBase/" + DateTime.Today.ToString("yyyy-MM-dd") + ".sqlite");
            //    file.Decrypt();
            //}

            PreLoad();

            login_simpleButton.Focus();
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
                XmlCreate();

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

        private void account_textEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;
            password_textEdit.Focus();

        }

        /// <summary>
        /// 预载之前要做的事
        /// </summary>
        private void PreLoad()
        {
            if (!File.Exists(@"./CONFIG.xml"))
                return;
            XDocument xml = XDocument.Load("./CONFIG.xml");
            var rootNode = xml.Document.Root;
            var result = rootNode.Element("Check").Attribute("Remeber").Value;
            int iResult = int.Parse(result.ToString());
            if (iResult == 1)
            {
                remember_checkEdit.Checked = true;
            }
            else
            {
                remember_checkEdit.Checked = false;
                return;
            }
            result = rootNode.Element("Account").Attribute("Account").Value;
            account_textEdit.Text = result;
            result = rootNode.Element("Password").Attribute("pwd").Value;
            password_textEdit.Text = Encryption.DecryptBase64(result);
        }

        private void XmlCreate()
        {
            XDocument xml = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("AccountInfo", 
                    new XElement("Account", new XAttribute("Account", account_textEdit.Text.Trim())),
                    new XElement("Password", new XAttribute("pwd", Encryption.EncryptBase64(password_textEdit.Text.Trim()))),
                    new XElement("Check", new XAttribute("Remeber", remember_checkEdit.Checked ? 1 : 0))
                    )
                );
            xml.Save("CONFIG.xml");
        }
    }
}