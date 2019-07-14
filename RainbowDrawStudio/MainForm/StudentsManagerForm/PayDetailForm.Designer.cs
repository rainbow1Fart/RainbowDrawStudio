namespace RainbowDrawStudio.MainForm.StudentsManagerForm
{
    partial class PayDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayDetailForm));
            this.ok_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.close_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.no_checkEdit = new DevExpress.XtraEditors.CheckEdit();
            this.yes_checkEdit = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.notPay_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.tuition_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.classHours_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.remaining_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.last_dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.remark_memoEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.no_checkEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yes_checkEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notPay_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuition_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classHours_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaining_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remark_memoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_simpleButton
            // 
            this.ok_simpleButton.Location = new System.Drawing.Point(12, 266);
            this.ok_simpleButton.Name = "ok_simpleButton";
            this.ok_simpleButton.Size = new System.Drawing.Size(75, 23);
            this.ok_simpleButton.TabIndex = 0;
            this.ok_simpleButton.Text = "确定(&O)";
            this.ok_simpleButton.Click += new System.EventHandler(this.ok_simpleButton_Click);
            // 
            // close_simpleButton
            // 
            this.close_simpleButton.Location = new System.Drawing.Point(197, 266);
            this.close_simpleButton.Name = "close_simpleButton";
            this.close_simpleButton.Size = new System.Drawing.Size(75, 23);
            this.close_simpleButton.TabIndex = 0;
            this.close_simpleButton.Text = "关闭(&C)";
            this.close_simpleButton.Click += new System.EventHandler(this.close_simpleButton_Click);
            // 
            // no_checkEdit
            // 
            this.no_checkEdit.Location = new System.Drawing.Point(197, 136);
            this.no_checkEdit.Name = "no_checkEdit";
            this.no_checkEdit.Properties.Caption = "未缴清";
            this.no_checkEdit.Properties.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("no_checkEdit.Properties.ImageOptions.ImageChecked")));
            this.no_checkEdit.Size = new System.Drawing.Size(75, 19);
            this.no_checkEdit.TabIndex = 25;
            this.no_checkEdit.CheckedChanged += new System.EventHandler(this.no_checkEdit_CheckedChanged);
            // 
            // yes_checkEdit
            // 
            this.yes_checkEdit.Location = new System.Drawing.Point(82, 136);
            this.yes_checkEdit.Name = "yes_checkEdit";
            this.yes_checkEdit.Properties.Caption = "已缴清";
            this.yes_checkEdit.Properties.ImageOptions.ImageChecked = ((System.Drawing.Image)(resources.GetObject("yes_checkEdit.Properties.ImageOptions.ImageChecked")));
            this.yes_checkEdit.Size = new System.Drawing.Size(75, 19);
            this.yes_checkEdit.TabIndex = 24;
            this.yes_checkEdit.CheckedChanged += new System.EventHandler(this.yes_checkEdit_CheckedChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Enabled = false;
            this.labelControl12.Location = new System.Drawing.Point(16, 170);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 14);
            this.labelControl12.TabIndex = 18;
            this.labelControl12.Text = "未缴余额";
            // 
            // labelControl11
            // 
            this.labelControl11.Enabled = false;
            this.labelControl11.Location = new System.Drawing.Point(16, 138);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(55, 14);
            this.labelControl11.TabIndex = 19;
            this.labelControl11.Text = "*是否缴清";
            // 
            // notPay_textEdit
            // 
            this.notPay_textEdit.Location = new System.Drawing.Point(82, 167);
            this.notPay_textEdit.Name = "notPay_textEdit";
            this.notPay_textEdit.Properties.Mask.EditMask = "(([0-9]+\\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\\.[0-9]+)|([0-9]*[1-9][0-9]*))";
            this.notPay_textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.notPay_textEdit.Properties.MaxLength = 10;
            this.notPay_textEdit.Size = new System.Drawing.Size(190, 20);
            this.notPay_textEdit.TabIndex = 26;
            // 
            // tuition_textEdit
            // 
            this.tuition_textEdit.Location = new System.Drawing.Point(82, 7);
            this.tuition_textEdit.Name = "tuition_textEdit";
            this.tuition_textEdit.Properties.Mask.EditMask = "(-?[0-9])+(.[0-9]{1,2})?";
            this.tuition_textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tuition_textEdit.Properties.Mask.PlaceHolder = '0';
            this.tuition_textEdit.Properties.MaxLength = 10;
            this.tuition_textEdit.Size = new System.Drawing.Size(190, 20);
            this.tuition_textEdit.TabIndex = 20;
            // 
            // classHours_textEdit
            // 
            this.classHours_textEdit.Location = new System.Drawing.Point(82, 39);
            this.classHours_textEdit.Name = "classHours_textEdit";
            this.classHours_textEdit.Properties.Mask.EditMask = "-?\\d+";
            this.classHours_textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.classHours_textEdit.Properties.Mask.PlaceHolder = '0';
            this.classHours_textEdit.Properties.MaxLength = 10;
            this.classHours_textEdit.Size = new System.Drawing.Size(190, 20);
            this.classHours_textEdit.TabIndex = 21;
            // 
            // remaining_textEdit
            // 
            this.remaining_textEdit.Location = new System.Drawing.Point(82, 71);
            this.remaining_textEdit.Name = "remaining_textEdit";
            this.remaining_textEdit.Properties.Mask.EditMask = "-?\\d+";
            this.remaining_textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.remaining_textEdit.Properties.Mask.PlaceHolder = '0';
            this.remaining_textEdit.Properties.MaxLength = 10;
            this.remaining_textEdit.Size = new System.Drawing.Size(190, 20);
            this.remaining_textEdit.TabIndex = 22;
            // 
            // last_dateEdit
            // 
            this.last_dateEdit.EditValue = null;
            this.last_dateEdit.Location = new System.Drawing.Point(82, 103);
            this.last_dateEdit.Name = "last_dateEdit";
            this.last_dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.last_dateEdit.Size = new System.Drawing.Size(190, 20);
            this.last_dateEdit.TabIndex = 23;
            // 
            // labelControl10
            // 
            this.labelControl10.Enabled = false;
            this.labelControl10.Location = new System.Drawing.Point(16, 106);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(55, 14);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "*追缴日期";
            // 
            // labelControl9
            // 
            this.labelControl9.Enabled = false;
            this.labelControl9.Location = new System.Drawing.Point(16, 74);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 14);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "剩余课时";
            // 
            // labelControl8
            // 
            this.labelControl8.Enabled = false;
            this.labelControl8.Location = new System.Drawing.Point(16, 42);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 14);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "当期总课时";
            // 
            // labelControl7
            // 
            this.labelControl7.Enabled = false;
            this.labelControl7.Location = new System.Drawing.Point(16, 10);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 14);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "已缴学费";
            // 
            // labelControl1
            // 
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(16, 202);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 14);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "备注(200字以内):";
            // 
            // remark_memoEdit
            // 
            this.remark_memoEdit.Location = new System.Drawing.Point(12, 221);
            this.remark_memoEdit.Name = "remark_memoEdit";
            this.remark_memoEdit.Properties.MaxLength = 200;
            this.remark_memoEdit.Size = new System.Drawing.Size(260, 39);
            this.remark_memoEdit.TabIndex = 27;
            // 
            // PayDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 301);
            this.Controls.Add(this.remark_memoEdit);
            this.Controls.Add(this.no_checkEdit);
            this.Controls.Add(this.yes_checkEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.notPay_textEdit);
            this.Controls.Add(this.tuition_textEdit);
            this.Controls.Add(this.classHours_textEdit);
            this.Controls.Add(this.remaining_textEdit);
            this.Controls.Add(this.last_dateEdit);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.close_simpleButton);
            this.Controls.Add(this.ok_simpleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PayDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学费信息";
            ((System.ComponentModel.ISupportInitialize)(this.no_checkEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yes_checkEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notPay_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuition_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classHours_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaining_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remark_memoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ok_simpleButton;
        private DevExpress.XtraEditors.SimpleButton close_simpleButton;
        private DevExpress.XtraEditors.CheckEdit no_checkEdit;
        private DevExpress.XtraEditors.CheckEdit yes_checkEdit;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit notPay_textEdit;
        private DevExpress.XtraEditors.TextEdit tuition_textEdit;
        private DevExpress.XtraEditors.TextEdit classHours_textEdit;
        private DevExpress.XtraEditors.TextEdit remaining_textEdit;
        private DevExpress.XtraEditors.DateEdit last_dateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit remark_memoEdit;
    }
}