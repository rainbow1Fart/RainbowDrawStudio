namespace RainbowDrawStudio
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.title_label = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.remember_checkEdit = new DevExpress.XtraEditors.CheckEdit();
            this.forget_linkLabel = new System.Windows.Forms.LinkLabel();
            this.register_linkLabel = new System.Windows.Forms.LinkLabel();
            this.exit_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.login_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.password_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.account_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remember_checkEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_textEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.LightGray;
            this.title_label.Location = new System.Drawing.Point(96, 34);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(212, 27);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "七彩画室学生管理系统";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.remember_checkEdit);
            this.panelControl1.Controls.Add(this.forget_linkLabel);
            this.panelControl1.Controls.Add(this.register_linkLabel);
            this.panelControl1.Controls.Add(this.exit_simpleButton);
            this.panelControl1.Controls.Add(this.login_simpleButton);
            this.panelControl1.Controls.Add(this.password_textEdit);
            this.panelControl1.Controls.Add(this.account_textEdit);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.title_label);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(404, 236);
            this.panelControl1.TabIndex = 1;
            // 
            // remember_checkEdit
            // 
            this.remember_checkEdit.Location = new System.Drawing.Point(102, 194);
            this.remember_checkEdit.Name = "remember_checkEdit";
            this.remember_checkEdit.Properties.Caption = "记住用户名";
            this.remember_checkEdit.Size = new System.Drawing.Size(87, 19);
            this.remember_checkEdit.TabIndex = 4;
            // 
            // forget_linkLabel
            // 
            this.forget_linkLabel.AutoSize = true;
            this.forget_linkLabel.Location = new System.Drawing.Point(308, 171);
            this.forget_linkLabel.Name = "forget_linkLabel";
            this.forget_linkLabel.Size = new System.Drawing.Size(67, 14);
            this.forget_linkLabel.TabIndex = 0;
            this.forget_linkLabel.TabStop = true;
            this.forget_linkLabel.Text = "忘记密码？";
            this.forget_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forget_linkLabel_LinkClicked);
            // 
            // register_linkLabel
            // 
            this.register_linkLabel.AutoSize = true;
            this.register_linkLabel.Location = new System.Drawing.Point(308, 117);
            this.register_linkLabel.Name = "register_linkLabel";
            this.register_linkLabel.Size = new System.Drawing.Size(55, 14);
            this.register_linkLabel.TabIndex = 0;
            this.register_linkLabel.TabStop = true;
            this.register_linkLabel.Text = "注册账号";
            this.register_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_linkLabel_LinkClicked);
            // 
            // exit_simpleButton
            // 
            this.exit_simpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.exit_simpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("exit_simpleButton.ImageOptions.Image")));
            this.exit_simpleButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.exit_simpleButton.Location = new System.Drawing.Point(277, 194);
            this.exit_simpleButton.Name = "exit_simpleButton";
            this.exit_simpleButton.Size = new System.Drawing.Size(25, 25);
            this.exit_simpleButton.TabIndex = 5;
            this.exit_simpleButton.Text = "退出(&C)";
            this.exit_simpleButton.Click += new System.EventHandler(this.exit_simpleButton_Click);
            // 
            // login_simpleButton
            // 
            this.login_simpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.login_simpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("login_simpleButton.ImageOptions.Image")));
            this.login_simpleButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.login_simpleButton.Location = new System.Drawing.Point(233, 194);
            this.login_simpleButton.Name = "login_simpleButton";
            this.login_simpleButton.Size = new System.Drawing.Size(25, 25);
            this.login_simpleButton.TabIndex = 3;
            this.login_simpleButton.Text = "登录(&O)";
            this.login_simpleButton.Click += new System.EventHandler(this.login_simpleButton_Click);
            // 
            // password_textEdit
            // 
            this.password_textEdit.Location = new System.Drawing.Point(102, 168);
            this.password_textEdit.Name = "password_textEdit";
            this.password_textEdit.Properties.MaxLength = 100;
            this.password_textEdit.Properties.PasswordChar = '*';
            this.password_textEdit.Size = new System.Drawing.Size(200, 20);
            this.password_textEdit.TabIndex = 2;
            this.password_textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_textEdit_KeyPress);
            // 
            // account_textEdit
            // 
            this.account_textEdit.Location = new System.Drawing.Point(102, 114);
            this.account_textEdit.Name = "account_textEdit";
            this.account_textEdit.Properties.MaxLength = 200;
            this.account_textEdit.Size = new System.Drawing.Size(200, 20);
            this.account_textEdit.TabIndex = 1;
            this.account_textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.account_textEdit_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Enabled = false;
            this.labelControl2.Location = new System.Drawing.Point(72, 171);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "密码";
            // 
            // labelControl1
            // 
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(60, 117);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用户名";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 236);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "七彩画室学生管理系统(Rainbow Draw Studio)";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remember_checkEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_textEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit account_textEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.LinkLabel forget_linkLabel;
        private System.Windows.Forms.LinkLabel register_linkLabel;
        private DevExpress.XtraEditors.SimpleButton exit_simpleButton;
        private DevExpress.XtraEditors.SimpleButton login_simpleButton;
        private DevExpress.XtraEditors.TextEdit password_textEdit;
        private DevExpress.XtraEditors.CheckEdit remember_checkEdit;
    }
}