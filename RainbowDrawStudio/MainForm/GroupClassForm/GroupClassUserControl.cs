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

namespace RainbowDrawStudio.MainForm.GroupClassForm
{
    public partial class GroupClassUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private PageControl _page;
        private int _pageIndex;
        private int _pageSize;
        private int _pageTotal;
        private int _selectionRow;
        private string _key;
        public GroupClassUserControl()
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
            CreateForm.OnWindowClosed += OnWindowClosed;
        }

        private void OnWindowClosed()
        {
            CreateForm.OnWindowClosed -= OnWindowClosed;
            Query();
        }

        private void Page_PageChanged(object sender, EventArgs e)
        {
            _pageIndex = _page.PageIndex;
            _pageSize = _page.PageSize;
            Query();
        }

        private void Query()
        {
            gridControl1.DataSource = GroupClassInfo.SimpleQuery(_pageIndex, _pageSize, _key, out _pageTotal);
            gridView1.FocusedRowHandle = _selectionRow;
            DevExpress.XtraGrid.Views.Base.ColumnView columnView =
                gridControl1.FocusedView as DevExpress.XtraGrid.Views.Base.ColumnView;
            columnView.MoveBy(0);
            gridControl1.RefreshDataSource();
            _page.SetPage(_pageIndex, _pageSize, _pageTotal);
        }

        private void GroupClassUserControl_Load(object sender, EventArgs e)
        {
            if (this.Visible == false)
                return;
            Query();
        }

        private void GroupClassUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
                return;
            Query();
        }

        private void query_textEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;
            _key = query_textEdit.Text.Trim();
            Query();
        }

        private void query_simpleButton_Click(object sender, EventArgs e)
        {
            _key = query_textEdit.Text.Trim();
            Query();
        }

        private void modify_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupClassInfo arg = gridView1.GetRow(gridView1.FocusedRowHandle) as GroupClassInfo;
            if (arg == null)
            {
                XtraMessageBox.Show("所选行数据错误，请刷新后重试","消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CreateForm form = new CreateForm(arg, WindowsModel.Modify);
            form.Show();
        }

        private void add_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm form = new CreateForm(new GroupClassInfo(), WindowsModel.AddNew);
            form.Show();
        }

        private void delete_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("确认删除选中行吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
                return;

            VerificationForm form = new VerificationForm();
            form.ShowDialog();
            if (!form.Result)
            {
                return;
            }

            int[] selectRows = gridView1.GetSelectedRows();
            int[] ids = new int[selectRows.Length];
            for (int i = 0; i < ids.Length; i++)
            {
                ids[i] = (gridView1.GetRow(selectRows[i]) as GroupClassInfo).ID;
            }

            if (GroupClassInfo.Delete(ids) <= 0)
            {
                XtraMessageBox.Show("部分选中行删除失败！请刷新后重试", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Query();
                return;
            }

            XtraMessageBox.Show("删除成功！", "消息", MessageBoxButtons.OK);
            Query();
            return;
        }

        private void oneKey_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GroupClassInfo arg = gridView1.GetRow(gridView1.FocusedRowHandle) as GroupClassInfo;
            if (arg == null)
            {
                XtraMessageBox.Show("所选数据错误，请刷新后重试", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DetailForm form = new DetailForm(arg, WindowsModel.Modify);
            form.Show();
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
