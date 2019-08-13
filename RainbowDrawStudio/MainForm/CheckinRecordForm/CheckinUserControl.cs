using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using RainbowDrawStudio.Public;
using RDS_Model;

namespace RainbowDrawStudio.MainForm.CheckinRecordForm
{
    public partial class CheckinUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private PageControl _page;
        private int _pageIndex;
        private int _pageSize;
        private int _pageTotal;
        private int _selectionRow;
        private string _key;
        public CheckinUserControl()
        {
            InitializeComponent();
            _key = string.Empty;
            _selectionRow = 0;
            _page = new PageControl();
            _pageIndex = _page.PageIndex;
            _pageSize = _page.PageSize;
            _pageTotal = _page.PageTotal;
            _page.Parent = splitContainer1.Panel2;
            _page.Dock = DockStyle.Fill;
            _page.PageChanged += Page_PageChanged;
        }

        private void Page_PageChanged(object sender, EventArgs e)
        {
            _pageIndex = _page.PageIndex;
            _pageSize = _page.PageSize;
            Query();
        }

        private void Query()
        {
            gridControl1.DataSource = CheckinRecordInfo.SimpleQuery(_pageIndex, _pageSize, _key, out _pageTotal);
            gridView1.FocusedRowHandle = _selectionRow;
            ColumnView columnView = gridControl1.FocusedView as ColumnView;
            columnView.MoveBy(0);
            gridControl1.RefreshDataSource();
            _page.SetPage(_pageIndex, _pageSize, _pageTotal);
        }

        private void query_textEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;
            _pageIndex = 1;
            _key = query_textEdit.Text.Trim();
            Query();
        }

        private void query_simpleButton_Click(object sender, EventArgs e)
        {
            _pageIndex = 1;
            _key = query_textEdit.Text.Trim();
            Query();
        }

        private void CheckinUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
                return;
           
            Query();
        }

        private void CheckinUserControl_Load(object sender, EventArgs e)
        {
            if (this.Visible == false)
                return;

            Query();
        }

        private void gridView1_CustomDrawEmptyForeground(object sender, CustomDrawEventArgs e)
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