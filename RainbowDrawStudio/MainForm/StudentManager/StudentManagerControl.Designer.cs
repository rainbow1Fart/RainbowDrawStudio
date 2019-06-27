namespace RainbowDrawStudio.MainForm.StudentManager
{
    partial class StudentManagerControl
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.query_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.query_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.new_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.query_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.query_simpleButton);
            this.panelControl1.Controls.Add(this.query_textEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(750, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // query_simpleButton
            // 
            this.query_simpleButton.Location = new System.Drawing.Point(276, 11);
            this.query_simpleButton.Name = "query_simpleButton";
            this.query_simpleButton.Size = new System.Drawing.Size(75, 23);
            this.query_simpleButton.TabIndex = 1;
            this.query_simpleButton.Text = "查询(&Q)";
            this.query_simpleButton.Click += new System.EventHandler(this.query_simpleButton_Click);
            // 
            // query_textEdit
            // 
            this.query_textEdit.Location = new System.Drawing.Point(5, 12);
            this.query_textEdit.Name = "query_textEdit";
            this.query_textEdit.Size = new System.Drawing.Size(265, 20);
            this.query_textEdit.TabIndex = 0;
            this.query_textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.query_textEdit_KeyPress);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.splitContainer1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 45);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(750, 405);
            this.panelControl2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(746, 401);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(746, 372);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControl1_KeyPress);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowErrorPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gridView1_CustomDrawEmptyForeground);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_toolStripMenuItem,
            this.edit_toolStripMenuItem,
            this.toolStripSeparator1,
            this.delete_toolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 76);
            // 
            // new_toolStripMenuItem
            // 
            this.new_toolStripMenuItem.Name = "new_toolStripMenuItem";
            this.new_toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.new_toolStripMenuItem.Text = "新建用户(&N)";
            this.new_toolStripMenuItem.Click += new System.EventHandler(this.new_toolStripMenuItem_Click);
            // 
            // edit_toolStripMenuItem
            // 
            this.edit_toolStripMenuItem.Name = "edit_toolStripMenuItem";
            this.edit_toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edit_toolStripMenuItem.Text = "编辑用户(&E)";
            this.edit_toolStripMenuItem.Click += new System.EventHandler(this.edit_toolStripMenuItem_Click);
            // 
            // delete_toolStripMenuItem
            // 
            this.delete_toolStripMenuItem.Name = "delete_toolStripMenuItem";
            this.delete_toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.delete_toolStripMenuItem.Text = "删除用户(&D)";
            this.delete_toolStripMenuItem.Click += new System.EventHandler(this.delete_toolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn1.Caption = "姓名";
            this.gridColumn1.FieldName = "Person";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn2.Caption = "用户名";
            this.gridColumn2.FieldName = "Account";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn3.Caption = "权限";
            this.gridColumn3.FieldName = "StrPower";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // StudentManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "StudentManagerControl";
            this.Size = new System.Drawing.Size(750, 450);
            this.VisibleChanged += new System.EventHandler(this.StudentManagerControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.query_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton query_simpleButton;
        private DevExpress.XtraEditors.TextEdit query_textEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem new_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit_toolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem delete_toolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
