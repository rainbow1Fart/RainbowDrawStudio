namespace RainbowDrawStudio
{
    partial class RegisterForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.register_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.close_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.person_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.password_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.pwdAgain_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.key_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.keyAgain_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.account_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.person_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdAgain_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAgain_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_textEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(90, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "姓名";
            // 
            // labelControl2
            // 
            this.labelControl2.Enabled = false;
            this.labelControl2.Location = new System.Drawing.Point(90, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "密码";
            // 
            // labelControl3
            // 
            this.labelControl3.Enabled = false;
            this.labelControl3.Location = new System.Drawing.Point(42, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "再次输入密码";
            // 
            // labelControl4
            // 
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(78, 144);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "安全码";
            // 
            // labelControl5
            // 
            this.labelControl5.Enabled = false;
            this.labelControl5.Location = new System.Drawing.Point(30, 174);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "再次输入安全码";
            // 
            // register_simpleButton
            // 
            this.register_simpleButton.Location = new System.Drawing.Point(64, 226);
            this.register_simpleButton.Name = "register_simpleButton";
            this.register_simpleButton.Size = new System.Drawing.Size(75, 23);
            this.register_simpleButton.TabIndex = 7;
            this.register_simpleButton.Text = "注册";
            this.register_simpleButton.Click += new System.EventHandler(this.register_simpleButton_Click);
            // 
            // close_simpleButton
            // 
            this.close_simpleButton.Location = new System.Drawing.Point(232, 226);
            this.close_simpleButton.Name = "close_simpleButton";
            this.close_simpleButton.Size = new System.Drawing.Size(75, 23);
            this.close_simpleButton.TabIndex = 8;
            this.close_simpleButton.Text = "关闭";
            this.close_simpleButton.Click += new System.EventHandler(this.close_simpleButton_Click);
            // 
            // person_textEdit
            // 
            this.person_textEdit.Location = new System.Drawing.Point(120, 21);
            this.person_textEdit.Name = "person_textEdit";
            this.person_textEdit.Size = new System.Drawing.Size(150, 20);
            this.person_textEdit.TabIndex = 1;
            this.person_textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.person_textEdit_KeyPress);
            // 
            // password_textEdit
            // 
            this.password_textEdit.Location = new System.Drawing.Point(120, 81);
            this.password_textEdit.Name = "password_textEdit";
            this.password_textEdit.Properties.PasswordChar = '*';
            this.password_textEdit.Size = new System.Drawing.Size(150, 20);
            this.password_textEdit.TabIndex = 3;
            this.password_textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.person_textEdit_KeyPress);
            this.password_textEdit.Leave += new System.EventHandler(this.password_textEdit_Leave);
            this.password_textEdit.MouseEnter += new System.EventHandler(this.password_textEdit_MouseEnter);
            this.password_textEdit.MouseLeave += new System.EventHandler(this.password_textEdit_MouseLeave);
            // 
            // pwdAgain_textEdit
            // 
            this.pwdAgain_textEdit.Location = new System.Drawing.Point(120, 111);
            this.pwdAgain_textEdit.Name = "pwdAgain_textEdit";
            this.pwdAgain_textEdit.Properties.PasswordChar = '*';
            this.pwdAgain_textEdit.Size = new System.Drawing.Size(150, 20);
            this.pwdAgain_textEdit.TabIndex = 4;
            this.pwdAgain_textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.person_textEdit_KeyPress);
            this.pwdAgain_textEdit.Leave += new System.EventHandler(this.pwdAgain_textEdit_Leave);
            this.pwdAgain_textEdit.MouseEnter += new System.EventHandler(this.password_textEdit_MouseEnter);
            this.pwdAgain_textEdit.MouseLeave += new System.EventHandler(this.password_textEdit_MouseLeave);
            // 
            // key_textEdit
            // 
            this.key_textEdit.Location = new System.Drawing.Point(120, 139);
            this.key_textEdit.Name = "key_textEdit";
            this.key_textEdit.Properties.PasswordChar = '*';
            this.key_textEdit.Size = new System.Drawing.Size(150, 20);
            this.key_textEdit.TabIndex = 5;
            this.key_textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.person_textEdit_KeyPress);
            this.key_textEdit.Leave += new System.EventHandler(this.key_textEdit_Leave);
            this.key_textEdit.MouseEnter += new System.EventHandler(this.key_textEdit_MouseEnter);
            this.key_textEdit.MouseLeave += new System.EventHandler(this.key_textEdit_MouseLeave);
            // 
            // keyAgain_textEdit
            // 
            this.keyAgain_textEdit.Location = new System.Drawing.Point(120, 172);
            this.keyAgain_textEdit.Name = "keyAgain_textEdit";
            this.keyAgain_textEdit.Properties.PasswordChar = '*';
            this.keyAgain_textEdit.Size = new System.Drawing.Size(150, 20);
            this.keyAgain_textEdit.TabIndex = 6;
            this.keyAgain_textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.person_textEdit_KeyPress);
            this.keyAgain_textEdit.Leave += new System.EventHandler(this.keyAgain_textEdit_Leave);
            this.keyAgain_textEdit.MouseEnter += new System.EventHandler(this.key_textEdit_MouseEnter);
            this.keyAgain_textEdit.MouseLeave += new System.EventHandler(this.key_textEdit_MouseLeave);
            // 
            // labelControl6
            // 
            this.labelControl6.Enabled = false;
            this.labelControl6.Location = new System.Drawing.Point(78, 54);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "用户名";
            // 
            // account_textEdit
            // 
            this.account_textEdit.Location = new System.Drawing.Point(120, 51);
            this.account_textEdit.Name = "account_textEdit";
            this.account_textEdit.Properties.Mask.EditMask = "[0-9a-zA-Z_]{1,}";
            this.account_textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.account_textEdit.Size = new System.Drawing.Size(150, 20);
            this.account_textEdit.TabIndex = 2;
            this.account_textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.person_textEdit_KeyPress);
            this.account_textEdit.Leave += new System.EventHandler(this.account_textEdit_Leave);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(276, 24);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(84, 14);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "请输入您的姓名";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(276, 54);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 14);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "请输入您的用户名";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(276, 84);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(127, 14);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "请输入6位数以上的密码";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(276, 114);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(84, 14);
            this.labelControl10.TabIndex = 9;
            this.labelControl10.Text = "请再次输入密码";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(276, 144);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(72, 14);
            this.labelControl11.TabIndex = 9;
            this.labelControl11.Text = "请输入安全码";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(276, 174);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(96, 14);
            this.labelControl12.TabIndex = 9;
            this.labelControl12.Text = "请再次输入安全码";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(30, 198);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(381, 14);
            this.labelControl13.TabIndex = 9;
            this.labelControl13.Text = "Tip:安全码用户密码的找回，请牢记安全码。建议使用手机号作为安全码";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 270);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.keyAgain_textEdit);
            this.Controls.Add(this.key_textEdit);
            this.Controls.Add(this.pwdAgain_textEdit);
            this.Controls.Add(this.password_textEdit);
            this.Controls.Add(this.account_textEdit);
            this.Controls.Add(this.person_textEdit);
            this.Controls.Add(this.close_simpleButton);
            this.Controls.Add(this.register_simpleButton);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.person_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdAgain_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAgain_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_textEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton register_simpleButton;
        private DevExpress.XtraEditors.SimpleButton close_simpleButton;
        private DevExpress.XtraEditors.TextEdit person_textEdit;
        private DevExpress.XtraEditors.TextEdit password_textEdit;
        private DevExpress.XtraEditors.TextEdit pwdAgain_textEdit;
        private DevExpress.XtraEditors.TextEdit key_textEdit;
        private DevExpress.XtraEditors.TextEdit keyAgain_textEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit account_textEdit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
    }
}