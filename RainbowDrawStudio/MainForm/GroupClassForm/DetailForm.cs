using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RDS_Model;

namespace RainbowDrawStudio.MainForm.GroupClassForm
{
    public partial class DetailForm : DevExpress.XtraEditors.XtraForm
    {
        private int _pageTotal;
        private int _selectionRow;
        private string _key;
        private GroupClassInfo _groupClassInfo;
        public DetailForm(GroupClassInfo arg, WindowsModel wm)
        {
            InitializeComponent();
            _pageTotal = 0;
            _selectionRow = 0;
            _key = string.Empty;
            _groupClassInfo = arg;

            StudenQuery();
            ViewInit(wm);
        }

        private void ViewInit(WindowsModel wm)
        {
            labelControl1.Text = _groupClassInfo.GroupName;
            classTeacher_textEdit.Text = _groupClassInfo.ClassTeacher;
            create_textEdit.Text = _groupClassInfo.CreateDate.ToString("yyyy-MM-dd");

            Point pt = labelControl1.Location;
            pt.X = (this.Width - labelControl1.Width) / 2;
            labelControl1.Location = pt;

            pt = labelControl2.Location;
            pt.X = (this.Width - classTeacher_textEdit.Width - labelControl3.Width - create_textEdit.Width +
                    labelControl2.Width) / 2;
            labelControl2.Location = pt;
            pt.X += (labelControl2.Width + 5);
            classTeacher_textEdit.Location = pt;

            pt = classTeacher_textEdit.Location;
            pt.X += (classTeacher_textEdit.Width + 10);
            labelControl3.Location = pt;

            pt.X += (labelControl3.Width + 5);
            create_textEdit.Location = pt;

            splitContainerControl3.SplitterPosition = splitContainerControl4.SplitterPosition;
            splitContainerControl2.SplitterPosition = this.Width / 2;
        }

        private void query_textEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != 13)
                return;
            _key = query_textEdit.Text.Trim();
            StudenQuery();
        }

        private void StudenQuery()
        {
            gridControl1.DataSource = StudentInfo.SimpleQuery(1, int.MaxValue, _key, out _pageTotal);
            gridView1.FocusedRowHandle = _selectionRow;
            DevExpress.XtraGrid.Views.Base.ColumnView columnView = gridControl1.FocusedView as DevExpress.XtraGrid.Views.Base.ColumnView;
            columnView.MoveBy(0);
            gridControl1.RefreshDataSource();
        }

        private void DetailForm_SizeChanged(object sender, EventArgs e)
        {
            Point pt = labelControl1.Location;
            pt.X = (this.Width - labelControl1.Width) / 2;
            labelControl1.Location = pt;

            pt = labelControl2.Location;
            pt.X = (this.Width - classTeacher_textEdit.Width - labelControl3.Width - create_textEdit.Width +
                    labelControl2.Width) / 2;
            labelControl2.Location = pt;
            pt.X += (labelControl2.Width + 5);
            classTeacher_textEdit.Location = pt;

            pt = classTeacher_textEdit.Location;
            pt.X += (classTeacher_textEdit.Width + 10);
            labelControl3.Location = pt;

            pt.X += (labelControl3.Width + 5);
            create_textEdit.Location = pt;

            splitContainerControl3.SplitterPosition = splitContainerControl4.SplitterPosition;
            splitContainerControl2.SplitterPosition = this.Width / 2;
        }
    }
}