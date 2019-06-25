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
using RDS_Controller;

namespace RainbowDrawStudio
{
    public partial class LoginForm : XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            //连接Sqlite数据库
            if (!SQLiteControl.ConnectToDatabase("./database.sqlite"))
            {
                XtraMessageBoxArgs args =
                    ControlHelper.XtraMessageBoxArgs("消息", "连接数据库失败", new DialogResult[] {DialogResult.Yes});
                XtraMessageBox.Show(args);
                Application.Exit();
            }
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

        }

        /// <summary>
        /// 注册账号label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void register_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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

        }
    }
}