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

namespace RainbowDrawStudio.Public
{
    public partial class VerificationForm : DevExpress.XtraEditors.XtraForm
    {
        public static RDS_Controller.ThreadDelegate.CustomerEvent OnWindowClosed;

        /// <summary>
        /// 密码验证结果
        /// </summary>
        public bool Result
        {
            get { return _result; }
        }
        private bool _result;

        public VerificationForm()
        {
            InitializeComponent();
            _result = false;
            password_textEdit.Focus();
        }

        private void ok_simpleButton_Click(object sender, EventArgs e)
        {
            if (Verfication())
                this.Close();
        }

        private void cancel_simpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerificationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnWindowClosed?.Invoke();
        }

        private void password_textEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;
            if(Verfication())
                this.Close();
        }

        protected bool Verfication()
        {
            string strPassword = password_textEdit.Text.Trim();
            if (RDS_Controller.Encryption.EncryptBase64(strPassword) != AccountInfo.AccountSession.Password)
            {
                XtraMessageBox.Show("密码验证失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _result = false;
                return _result;
            }

            _result = true;
            XtraMessageBox.Show("密码验证成功", "消息", MessageBoxButtons.OK);
            return _result;
        }
    }
}