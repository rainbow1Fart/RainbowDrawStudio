using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RainbowDrawStudio.Public;
using RDS_Model;

namespace RainbowDrawStudio.MainForm.RecordStudentManagerForm
{
    public partial class RecordStudentUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private PageControl _page;
        private int _pageIndex;
        private int _pageSize;
        private int _pageTotal;
        private int _selectionRow;
        private string _key;
        private int _selectRow;

        public RecordStudentUserControl()
        {
            InitializeComponent();
            _key = string.Empty;
            _selectionRow = 0;
            _page = new PageControl();
            _pageIndex = _page.PageIndex;
            _pageSize = _page.PageSize;
            _pageTotal = _page.PageTotal;
            _selectRow = 0;
            _page.Parent = splitContainer1.Panel2;
            _page.Dock = DockStyle.Fill;
            _page.PageChanged += Page_PageChanged;
        }
        private void Page_PageChanged(object sender, EventArgs e){
            _pageIndex = _page.PageIndex;
            _pageSize = _page.PageSize;
            Query();
        }

        private void query_simpleButton_Click(object sender, EventArgs e)
        {
            _key = query_textEdit.Text.Trim();
            Query();
        }

        private void query_textEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;
            _key = query_textEdit.Text.Trim();
            Query();
        }

        protected void Query()
        {
            gridControl1.DataSource = RDS_Model.StudentsInfo.RealyQuerry(_pageIndex, _pageSize, _key, out _pageTotal);
            gridControl1.RefreshDataSource();
            gridView1.MoveBy(0);
            _page.SetPage(_pageIndex, _pageSize, _pageTotal);
        }

        private void RecordStudentUserControl_Load(object sender, EventArgs e)
        {
            if (this.Visible == false)
                return;
            Query();
        }

        private void RecordStudentUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
                return;
            Query();
        }

        private void delete_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("确认[彻底删除]选中的学生信息吗？删除后数据不可恢复，请谨慎操作", "提示", MessageBoxButtons.YesNo) ==
                DialogResult.No)
                return;
            VerificationForm form = new VerificationForm();
            form.ShowDialog();
            if (!form.Result)
                return;
            //获取选中行
            int[] rows = gridView1.GetSelectedRows();
            int[] ids = new int[rows.Length];

            for (int i = 0; i < rows.Length; i++)
            {
                ids[i] = (gridView1.GetRow(rows[i]) as StudentsInfo).ID;
            }

            int result = StudentsInfo.RealyDelete(ids);
            if (result > 0)
            {
                XtraMessageBox.Show("删除成功");
                Query();
                return;
            }

            XtraMessageBox.Show("删除失败");
            return;
        }

        private void restore_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("确认[恢复]选中的学生信息吗？", "提示", MessageBoxButtons.YesNo) ==
                DialogResult.No)
                return;
            VerificationForm form = new VerificationForm();
            form.ShowDialog();
            if (!form.Result)
                return;
            //获取选中行
            int[] rows = gridView1.GetSelectedRows();
            int[] ids = new int[rows.Length];

            for (int i = 0; i < rows.Length; i++)
            {
                ids[i] = (gridView1.GetRow(rows[i]) as StudentsInfo).ID;
            }

            int result = StudentsInfo.Restore(ids);
            if (result > 0)
            {
                XtraMessageBox.Show("恢复成功");
                Query();
                return;
            }

            XtraMessageBox.Show("恢复失败");
            return;
        }

        private void gridView1_CustomDrawEmptyForeground(object sender, 
            DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            string s = string.Empty;
            DevExpress.XtraGrid.Views.Base.ColumnView view = sender as DevExpress.XtraGrid.Views.Base.ColumnView;
            BindingSource dataSource = view.DataSource as BindingSource;
            if (dataSource == null)
            {
                s = "没有数据 QAQ";
            }
            else if (dataSource.Count == 0)
            {
                s = "没有找到符合条件的数据 QAQ";
            }
            Font font = new Font("微软雅黑", 10, FontStyle.Bold);
            Rectangle r = new Rectangle(e.Bounds.Left + 5, e.Bounds.Top + 5, e.Bounds.Width - 5, e.Bounds.Height - 5);
            e.Graphics.DrawString(s, font, Brushes.Black, r);
        }
    }
}
