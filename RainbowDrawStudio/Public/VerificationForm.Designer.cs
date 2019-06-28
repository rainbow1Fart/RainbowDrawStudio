namespace RainbowDrawStudio.Public
{
    partial class VerificationForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cancel_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ok_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.password_textEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_textEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cancel_simpleButton);
            this.panelControl1.Controls.Add(this.ok_simpleButton);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.password_textEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(406, 102);
            this.panelControl1.TabIndex = 0;
            // 
            // cancel_simpleButton
            // 
            this.cancel_simpleButton.Location = new System.Drawing.Point(321, 59);
            this.cancel_simpleButton.Name = "cancel_simpleButton";
            this.cancel_simpleButton.Size = new System.Drawing.Size(75, 23);
            this.cancel_simpleButton.TabIndex = 3;
            this.cancel_simpleButton.Text = "取消(&C)";
            this.cancel_simpleButton.Click += new System.EventHandler(this.cancel_simpleButton_Click);
            // 
            // ok_simpleButton
            // 
            this.ok_simpleButton.Location = new System.Drawing.Point(240, 59);
            this.ok_simpleButton.Name = "ok_simpleButton";
            this.ok_simpleButton.Size = new System.Drawing.Size(75, 23);
            this.ok_simpleButton.TabIndex = 2;
            this.ok_simpleButton.Text = "确认(&O)";
            this.ok_simpleButton.Click += new System.EventHandler(this.ok_simpleButton_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(232, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "当前正在进行敏感操作,请验证当前账号密码";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "请输入登录密码";
            // 
            // password_textEdit
            // 
            this.password_textEdit.Location = new System.Drawing.Point(34, 62);
            this.password_textEdit.Name = "password_textEdit";
            this.password_textEdit.Properties.MaxLength = 100;
            this.password_textEdit.Properties.PasswordChar = '*';
            this.password_textEdit.Size = new System.Drawing.Size(200, 20);
            this.password_textEdit.TabIndex = 1;
            this.password_textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_textEdit_KeyPress);
            // 
            // VerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 102);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "验证账号信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerificationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_textEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit password_textEdit;
        private DevExpress.XtraEditors.SimpleButton cancel_simpleButton;
        private DevExpress.XtraEditors.SimpleButton ok_simpleButton;
    }
}