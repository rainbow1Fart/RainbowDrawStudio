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
            this.top_panelControl = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timer_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.account_navigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.student_navigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.top_panelControl)).BeginInit();
            this.top_panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
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
            this.panelControl1.Controls.Add(this.navigationPane1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 95);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 466);
            this.panelControl1.TabIndex = 1;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.account_navigationPage);
            this.navigationPane1.Controls.Add(this.student_navigationPage);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(2, 2);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.account_navigationPage,
            this.student_navigationPage});
            this.navigationPane1.RegularSize = new System.Drawing.Size(780, 462);
            this.navigationPane1.SelectedPage = this.student_navigationPage;
            this.navigationPane1.Size = new System.Drawing.Size(780, 462);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // account_navigationPage
            // 
            this.account_navigationPage.Caption = "账号管理";
            this.account_navigationPage.Name = "account_navigationPage";
            this.account_navigationPage.Size = new System.Drawing.Size(698, 402);
            // 
            // student_navigationPage
            // 
            this.student_navigationPage.Caption = "学生信息";
            this.student_navigationPage.Name = "student_navigationPage";
            this.student_navigationPage.Size = new System.Drawing.Size(698, 402);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            ((System.ComponentModel.ISupportInitialize)(this.top_panelControl)).EndInit();
            this.top_panelControl.ResumeLayout(false);
            this.top_panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl top_panelControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl timer_labelControl;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage account_navigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage student_navigationPage;
        private System.Windows.Forms.Timer timer;
    }
}