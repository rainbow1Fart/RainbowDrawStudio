namespace RainbowDrawStudio.Public
{
    partial class PageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.page_comboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.curPage_labelControl = new DevExpress.XtraEditors.LabelControl();
            this.frist_hyperlinkLabelControl = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.current_hyperlinkLabelControl = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.next_hyperlinkLabelControl = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.last_hyperlinkLabelControl = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.total_labelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.page_comboBoxEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "每页显示";
            // 
            // page_comboBoxEdit
            // 
            this.page_comboBoxEdit.Location = new System.Drawing.Point(57, 1);
            this.page_comboBoxEdit.Name = "page_comboBoxEdit";
            this.page_comboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.page_comboBoxEdit.Properties.Items.AddRange(new object[] {
            "25",
            "50",
            "100",
            "200",
            "500"});
            this.page_comboBoxEdit.Properties.MaxLength = 3;
            this.page_comboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.page_comboBoxEdit.Size = new System.Drawing.Size(100, 20);
            this.page_comboBoxEdit.TabIndex = 1;
            this.page_comboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.page_comboBoxEdit_SelectedIndexChanged);
            this.page_comboBoxEdit.SelectedValueChanged += new System.EventHandler(this.page_comboBoxEdit_SelectedValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(163, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(12, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "条";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(194, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "当前第";
            // 
            // curPage_labelControl
            // 
            this.curPage_labelControl.Location = new System.Drawing.Point(236, 4);
            this.curPage_labelControl.Name = "curPage_labelControl";
            this.curPage_labelControl.Size = new System.Drawing.Size(165, 14);
            this.curPage_labelControl.TabIndex = 0;
            this.curPage_labelControl.Text = "9999999999/9999999999  页";
            // 
            // frist_hyperlinkLabelControl
            // 
            this.frist_hyperlinkLabelControl.Location = new System.Drawing.Point(407, 4);
            this.frist_hyperlinkLabelControl.Name = "frist_hyperlinkLabelControl";
            this.frist_hyperlinkLabelControl.Size = new System.Drawing.Size(24, 14);
            this.frist_hyperlinkLabelControl.TabIndex = 2;
            this.frist_hyperlinkLabelControl.Text = "首页";
            this.frist_hyperlinkLabelControl.Click += new System.EventHandler(this.frist_hyperlinkLabelControl_Click);
            // 
            // current_hyperlinkLabelControl
            // 
            this.current_hyperlinkLabelControl.Location = new System.Drawing.Point(437, 4);
            this.current_hyperlinkLabelControl.Name = "current_hyperlinkLabelControl";
            this.current_hyperlinkLabelControl.Size = new System.Drawing.Size(36, 14);
            this.current_hyperlinkLabelControl.TabIndex = 2;
            this.current_hyperlinkLabelControl.Text = "上一页";
            this.current_hyperlinkLabelControl.Click += new System.EventHandler(this.current_hyperlinkLabelControl_Click);
            // 
            // next_hyperlinkLabelControl
            // 
            this.next_hyperlinkLabelControl.Location = new System.Drawing.Point(479, 4);
            this.next_hyperlinkLabelControl.Name = "next_hyperlinkLabelControl";
            this.next_hyperlinkLabelControl.Size = new System.Drawing.Size(36, 14);
            this.next_hyperlinkLabelControl.TabIndex = 2;
            this.next_hyperlinkLabelControl.Text = "下一页";
            this.next_hyperlinkLabelControl.Click += new System.EventHandler(this.next_hyperlinkLabelControl_Click);
            // 
            // last_hyperlinkLabelControl
            // 
            this.last_hyperlinkLabelControl.Location = new System.Drawing.Point(521, 4);
            this.last_hyperlinkLabelControl.Name = "last_hyperlinkLabelControl";
            this.last_hyperlinkLabelControl.Size = new System.Drawing.Size(24, 14);
            this.last_hyperlinkLabelControl.TabIndex = 2;
            this.last_hyperlinkLabelControl.Text = "尾页";
            this.last_hyperlinkLabelControl.Click += new System.EventHandler(this.last_hyperlinkLabelControl_Click);
            // 
            // total_labelControl
            // 
            this.total_labelControl.Location = new System.Drawing.Point(551, 4);
            this.total_labelControl.Name = "total_labelControl";
            this.total_labelControl.Size = new System.Drawing.Size(140, 14);
            this.total_labelControl.TabIndex = 3;
            this.total_labelControl.Text = "共 999999999999 条记录";
            // 
            // PageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.total_labelControl);
            this.Controls.Add(this.last_hyperlinkLabelControl);
            this.Controls.Add(this.next_hyperlinkLabelControl);
            this.Controls.Add(this.current_hyperlinkLabelControl);
            this.Controls.Add(this.frist_hyperlinkLabelControl);
            this.Controls.Add(this.page_comboBoxEdit);
            this.Controls.Add(this.curPage_labelControl);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "PageControl";
            this.Size = new System.Drawing.Size(773, 24);
            ((System.ComponentModel.ISupportInitialize)(this.page_comboBoxEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit page_comboBoxEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl curPage_labelControl;
        private DevExpress.XtraEditors.HyperlinkLabelControl frist_hyperlinkLabelControl;
        private DevExpress.XtraEditors.HyperlinkLabelControl current_hyperlinkLabelControl;
        private DevExpress.XtraEditors.HyperlinkLabelControl next_hyperlinkLabelControl;
        private DevExpress.XtraEditors.HyperlinkLabelControl last_hyperlinkLabelControl;
        private DevExpress.XtraEditors.LabelControl total_labelControl;
    }
}
