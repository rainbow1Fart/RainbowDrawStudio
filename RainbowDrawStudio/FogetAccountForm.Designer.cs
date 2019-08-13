namespace RainbowDrawStudio
{
    partial class FogetAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FogetAccountForm));
            this.key_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.pwdAgain_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.password_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.account_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ok_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.close_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.key_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdAgain_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_textEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // key_textEdit
            // 
            this.key_textEdit.Location = new System.Drawing.Point(85, 100);
            this.key_textEdit.Name = "key_textEdit";
            this.key_textEdit.Properties.PasswordChar = '*';
            this.key_textEdit.Size = new System.Drawing.Size(150, 20);
            this.key_textEdit.TabIndex = 4;
            this.key_textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_textEdit_KeyPress);
            // 
            // pwdAgain_textEdit
            // 
            this.pwdAgain_textEdit.Location = new System.Drawing.Point(85, 72);
            this.pwdAgain_textEdit.Name = "pwdAgain_textEdit";
            this.pwdAgain_textEdit.Properties.PasswordChar = '*';
            this.pwdAgain_textEdit.Size = new System.Drawing.Size(150, 20);
            this.pwdAgain_textEdit.TabIndex = 3;
            this.pwdAgain_textEdit.Leave += new System.EventHandler(this.pwdAgain_textEdit_Leave);
            this.pwdAgain_textEdit.MouseEnter += new System.EventHandler(this.pwdAgain_textEdit_MouseEnter);
            this.pwdAgain_textEdit.MouseLeave += new System.EventHandler(this.pwdAgain_textEdit_MouseLeave);
            // 
            // password_textEdit
            // 
            this.password_textEdit.Location = new System.Drawing.Point(85, 42);
            this.password_textEdit.Name = "password_textEdit";
            this.password_textEdit.Properties.PasswordChar = '*';
            this.password_textEdit.Size = new System.Drawing.Size(150, 20);
            this.password_textEdit.TabIndex = 2;
            this.password_textEdit.Leave += new System.EventHandler(this.password_textEdit_Leave);
            this.password_textEdit.MouseEnter += new System.EventHandler(this.password_textEdit_MouseEnter);
            this.password_textEdit.MouseLeave += new System.EventHandler(this.password_textEdit_MouseLeave);
            // 
            // account_textEdit
            // 
            this.account_textEdit.Location = new System.Drawing.Point(85, 12);
            this.account_textEdit.Name = "account_textEdit";
            this.account_textEdit.Properties.Mask.EditMask = "[0-9a-zA-Z_]{1,}";
            this.account_textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.account_textEdit.Size = new System.Drawing.Size(150, 20);
            this.account_textEdit.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(43, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "安全码";
            // 
            // labelControl3
            // 
            this.labelControl3.Enabled = false;
            this.labelControl3.Location = new System.Drawing.Point(31, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "再次输入";
            // 
            // labelControl6
            // 
            this.labelControl6.Enabled = false;
            this.labelControl6.Location = new System.Drawing.Point(43, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "用户名";
            // 
            // labelControl2
            // 
            this.labelControl2.Enabled = false;
            this.labelControl2.Location = new System.Drawing.Point(43, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "新密码";
            // 
            // ok_simpleButton
            // 
            this.ok_simpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ok_simpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ok_simpleButton.ImageOptions.Image")));
            this.ok_simpleButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ok_simpleButton.Location = new System.Drawing.Point(312, 132);
            this.ok_simpleButton.Name = "ok_simpleButton";
            this.ok_simpleButton.Size = new System.Drawing.Size(25, 25);
            this.ok_simpleButton.TabIndex = 5;
            this.ok_simpleButton.Text = "确定(&O)";
            this.ok_simpleButton.Click += new System.EventHandler(this.ok_simpleButton_Click);
            // 
            // close_simpleButton
            // 
            this.close_simpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.close_simpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("close_simpleButton.ImageOptions.Image")));
            this.close_simpleButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.close_simpleButton.Location = new System.Drawing.Point(352, 132);
            this.close_simpleButton.Name = "close_simpleButton";
            this.close_simpleButton.Size = new System.Drawing.Size(25, 25);
            this.close_simpleButton.TabIndex = 6;
            this.close_simpleButton.Text = "关闭(&C)";
            this.close_simpleButton.Click += new System.EventHandler(this.close_simpleButton_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(241, 105);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(72, 14);
            this.labelControl11.TabIndex = 10;
            this.labelControl11.Text = "请输入安全码";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(241, 75);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(84, 14);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "请再次输入密码";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(241, 45);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(127, 14);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "请输入6位数以上的密码";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(241, 15);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 14);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "请输入您的用户名";
            // 
            // FogetAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 169);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.close_simpleButton);
            this.Controls.Add(this.ok_simpleButton);
            this.Controls.Add(this.key_textEdit);
            this.Controls.Add(this.pwdAgain_textEdit);
            this.Controls.Add(this.password_textEdit);
            this.Controls.Add(this.account_textEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FogetAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "忘记密码";
            ((System.ComponentModel.ISupportInitialize)(this.key_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdAgain_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_textEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit key_textEdit;
        private DevExpress.XtraEditors.TextEdit pwdAgain_textEdit;
        private DevExpress.XtraEditors.TextEdit password_textEdit;
        private DevExpress.XtraEditors.TextEdit account_textEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton ok_simpleButton;
        private DevExpress.XtraEditors.SimpleButton close_simpleButton;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}