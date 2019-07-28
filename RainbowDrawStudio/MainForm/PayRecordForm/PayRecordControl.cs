using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RainbowDrawStudio.MainForm.StudentsManagerForm;
using RainbowDrawStudio.Public;
using RDS_Controller;
using RDS_Model;

namespace RainbowDrawStudio.MainForm.PayRecordForm
{
    public partial class PayRecordControl : DevExpress.XtraEditors.XtraUserControl
    {
        private PageControl _page;
        private int _pageIndex;
        private int _pageSize;
        private int _pageTotal;
        private int _selectionRow;
        private string _key;

        public PayRecordControl()
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

        ~PayRecordControl()
        {
            _page.PageChanged -= Page_PageChanged;
        }
        private void Page_PageChanged(object sender, EventArgs e)
        {
            _pageIndex = _page.PageIndex;
            _pageSize = _page.PageSize;
            Query();
        }

        private void Query()
        {
            gridControl1.DataSource = PayRecordInfo.SimpleQuery(_pageIndex, _pageSize, _key, out _pageTotal);
            gridView1.FocusedRowHandle = _selectionRow;
            DevExpress.XtraGrid.Views.Base.ColumnView columnView =
                gridControl1.FocusedView as DevExpress.XtraGrid.Views.Base.ColumnView;
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

        private void PayRecordControl_Load(object sender, EventArgs e)
        {
            if (this.Visible == false)
                return;
            Query();
        }

        private void PayRecordControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
                return;
            Query();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _selectionRow = e.RowHandle;
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

        private void delete_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("确认删除选中的缴费记录吗？删除后数据不可恢复，请谨慎操作。", "消息", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            VerificationForm form = new VerificationForm();
            form.ShowDialog();
            if (!form.Result)
                return;

            int[] selectRows = gridView1.GetSelectedRows();
            int[] rowsID =new int[selectRows.Length];
            for (int i = 0; i < selectRows.Length; i++)
            {
                rowsID[i] = (gridView1.GetRow(selectRows[i]) as PayRecordInfo).ID;
            }
            int result = SQLiteControl.RealyDelete("PayRecordTable", "ID", rowsID);
            if (result <= 0)
            {
                XtraMessageBox.Show("删除选中的缴费记录失败", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }

            Query();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            _selectionRow = gridView1.FocusedRowHandle;
            if (AccountInfo.AccountSession.Power != -1)
                delete_toolStripMenuItem.Enabled = false;
            else
                delete_toolStripMenuItem.Enabled = true;
        }

        private void watch_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayRecordInfo arg = gridView1.GetRow(gridView1.FocusedRowHandle) as PayRecordInfo;
            if (arg == null)
            {
                XtraMessageBox.Show("选中的信息错误，请刷新后重试", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PayDetailForm form = new PayDetailForm(arg, WindowsModel.Display);
            form.Show();
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PayRecordInfo arg = gridView1.GetRow(gridView1.FocusedRowHandle) as PayRecordInfo;
            if (arg == null)
            {
                XtraMessageBox.Show("选中的信息错误，请刷新后重试", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PayDetailForm form = new PayDetailForm(arg, WindowsModel.Display);
            form.Show();
        }
    }
}
