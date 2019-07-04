namespace RainbowDrawStudio.MainForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.top_panelControl = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timer_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.main_navigationPane = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.account_navigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.student_navigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.restore_navigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.top_panelControl)).BeginInit();
            this.top_panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_navigationPane)).BeginInit();
            this.main_navigationPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panelControl
            // 
            this.top_panelControl.Controls.Add(this.labelControl1);
            this.top_panelControl.Controls.Add(this.timer_labelControl);
            this.top_panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panelControl.Location = new System.Drawing.Point(0, 0);
            this.top_panelControl.Name = "top_panelControl";
            this.top_panelControl.Size = new System.Drawing.Size(784, 95);
            this.top_panelControl.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "欢迎你 Admin";
            // 
            // timer_labelControl
            // 
            this.timer_labelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timer_labelControl.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.timer_labelControl.Appearance.Options.UseForeColor = true;
            this.timer_labelControl.Location = new System.Drawing.Point(12, 75);
            this.timer_labelControl.Name = "timer_labelControl";
            this.timer_labelControl.Size = new System.Drawing.Size(118, 14);
            this.timer_labelControl.TabIndex = 0;
            this.timer_labelControl.Text = "9999-99-99 99:99:99";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.main_navigationPane);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 95);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 466);
            this.panelControl1.TabIndex = 1;
            // 
            // main_navigationPane
            // 
            this.main_navigationPane.Controls.Add(this.account_navigationPage);
            this.main_navigationPane.Controls.Add(this.student_navigationPage);
            this.main_navigationPane.Controls.Add(this.restore_navigationPage);
            this.main_navigationPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_navigationPane.Location = new System.Drawing.Point(2, 2);
            this.main_navigationPane.Name = "main_navigationPane";
            this.main_navigationPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.account_navigationPage,
            this.student_navigationPage,
            this.restore_navigationPage});
            this.main_navigationPane.RegularSize = new System.Drawing.Size(780, 462);
            this.main_navigationPane.SelectedPage = this.account_navigationPage;
            this.main_navigationPane.Size = new System.Drawing.Size(780, 462);
            this.main_navigationPane.TabIndex = 0;
            this.main_navigationPane.Text = "MainNavigationPane";
            this.main_navigationPane.Click += new System.EventHandler(this.navigationPane1_Click);
            // 
            // account_navigationPage
            // 
            this.account_navigationPage.Caption = "账号管理";
            this.account_navigationPage.Name = "account_navigationPage";
            this.account_navigationPage.Size = new System.Drawing.Size(686, 402);
            // 
            // student_navigationPage
            // 
            this.student_navigationPage.Caption = "学生信息";
            this.student_navigationPage.Name = "student_navigationPage";
            this.student_navigationPage.Size = new System.Drawing.Size(780, 462);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // restore_navigationPage
            // 
            this.restore_navigationPage.Caption = "学生回收站";
            this.restore_navigationPage.Name = "restore_navigationPage";
            this.restore_navigationPage.Size = new System.Drawing.Size(686, 402);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.top_panelControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "七彩画室";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.top_panelControl)).EndInit();
            this.top_panelControl.ResumeLayout(false);
            this.top_panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_navigationPane)).EndInit();
            this.main_navigationPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl top_panelControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl timer_labelControl;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Navigation.NavigationPane main_navigationPane;
        private DevExpress.XtraBars.Navigation.NavigationPage account_navigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage student_navigationPage;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private DevExpress.XtraBars.Navigation.NavigationPage restore_navigationPage;
    }
}