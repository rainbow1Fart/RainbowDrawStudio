namespace RainbowDrawStudio.MainForm.GroupClassForm
{
    partial class CreateForm
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
            this.className_textEdit = new DevExpress.XtraEditors.TextEdit();
            this.ok_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.cloase_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.edit_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.classTeacher_comboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.className_textEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTeacher_comboBoxEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "班级名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "班主任";
            // 
            // className_textEdit
            // 
            this.className_textEdit.Location = new System.Drawing.Point(66, 9);
            this.className_textEdit.Name = "className_textEdit";
            this.className_textEdit.Size = new System.Drawing.Size(234, 20);
            this.className_textEdit.TabIndex = 1;
            // 
            // ok_simpleButton
            // 
            this.ok_simpleButton.Location = new System.Drawing.Point(385, 8);
            this.ok_simpleButton.Name = "ok_simpleButton";
            this.ok_simpleButton.Size = new System.Drawing.Size(75, 23);
            this.ok_simpleButton.TabIndex = 2;
            this.ok_simpleButton.Text = "确定(&O)";
            this.ok_simpleButton.Click += new System.EventHandler(this.ok_simpleButton_Click);
            // 
            // cloase_simpleButton
            // 
            this.cloase_simpleButton.Location = new System.Drawing.Point(385, 49);
            this.cloase_simpleButton.Name = "cloase_simpleButton";
            this.cloase_simpleButton.Size = new System.Drawing.Size(75, 23);
            this.cloase_simpleButton.TabIndex = 2;
            this.cloase_simpleButton.Text = "关闭(&C)";
            this.cloase_simpleButton.Click += new System.EventHandler(this.cloase_simpleButton_Click);
            // 
            // edit_simpleButton
            // 
            this.edit_simpleButton.Location = new System.Drawing.Point(306, 8);
            this.edit_simpleButton.Name = "edit_simpleButton";
            this.edit_simpleButton.Size = new System.Drawing.Size(75, 23);
            this.edit_simpleButton.TabIndex = 2;
            this.edit_simpleButton.Text = "更新(&U)";
            this.edit_simpleButton.Click += new System.EventHandler(this.edit_simpleButton_Click);
            // 
            // classTeacher_comboBoxEdit
            // 
            this.classTeacher_comboBoxEdit.Location = new System.Drawing.Point(66, 50);
            this.classTeacher_comboBoxEdit.Name = "classTeacher_comboBoxEdit";
            this.classTeacher_comboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.classTeacher_comboBoxEdit.Size = new System.Drawing.Size(234, 20);
            this.classTeacher_comboBoxEdit.TabIndex = 3;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 86);
            this.Controls.Add(this.classTeacher_comboBoxEdit);
            this.Controls.Add(this.edit_simpleButton);
            this.Controls.Add(this.cloase_simpleButton);
            this.Controls.Add(this.ok_simpleButton);
            this.Controls.Add(this.className_textEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.className_textEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTeacher_comboBoxEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit className_textEdit;
        private DevExpress.XtraEditors.SimpleButton ok_simpleButton;
        private DevExpress.XtraEditors.SimpleButton cloase_simpleButton;
        private DevExpress.XtraEditors.SimpleButton edit_simpleButton;
        private DevExpress.XtraEditors.ComboBoxEdit classTeacher_comboBoxEdit;
    }
}