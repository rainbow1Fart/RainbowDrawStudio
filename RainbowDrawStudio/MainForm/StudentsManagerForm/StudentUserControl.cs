using DevExpress.XtraEditors;
using RainbowDrawStudio.Public;
using RDS_Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace RainbowDrawStudio.MainForm.StudentsManagerForm
{
    public partial class StudentUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private PageControl _page;
        private int _pageIndex;
        private int _pageSize;
        private int _pageTotal;
        private int _selectionRow;
        private string _key;

        public StudentUserControl()
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
            gridControl1.DataSource = StudentsInfo.SimpleQuery(_pageIndex, _pageSize, _key, out _pageTotal);
            gridView1.FocusedRowHandle = _selectionRow;
            ColumnView columnView = gridControl1.FocusedView as ColumnView;
            columnView.MoveBy(0);
            gridControl1.RefreshDataSource();
            _page.SetPage(_pageIndex, _pageSize, _pageTotal);
        }

        private void StudentUserControl_Load(object sender, EventArgs e)
        {
            if (Visible == false)
                return;
            Query();
        }

        private void StudentUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
                return;
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
            _key = query_textEdit.Text.Trim(); Query();
        }

        private void gridView1_RowClick(object sender,
            DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _selectionRow = e.RowHandle;
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StudentsInfo stu = gridView1.GetRow(_selectionRow) as StudentsInfo;
            if (stu == null)
            {
                XtraMessageBox.Show("所选信息无效，请刷新后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //学生信息详细界面
            DetailForm form = new DetailForm(stu, WindowsModel.Display);
            DetailForm.OnWindowClosed += OnWindowClosed;
            form.Show();
        }

        private void OnWindowClosed()
        {
            DetailForm.OnWindowClosed -= OnWindowClosed;
            Query();
        }

        private void delete_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("确认要删除选中的学生信息吗", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
                return;

            //验证账号信息
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

            int result = StudentsInfo.FalseDelete(ids);
            if (result > 0)
            {
                XtraMessageBox.Show("删除成功");
                Query();
                return;
            }

            XtraMessageBox.Show("删除失败");
            return;
        }

        private void edit_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsInfo stu = gridView1.GetRow(_selectionRow) as StudentsInfo;
            if (stu == null)
            {
                XtraMessageBox.Show("所选信息无效，请刷新后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //学生信息详细界面
            DetailForm form = new DetailForm(stu, WindowsModel.Display);
            DetailForm.OnWindowClosed += OnWindowClosed;
            form.Show();
        }

        private void new_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private void gridView1_CustomColumnDisplayText(object sender,
            DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "LastPayDate" && !string.IsNullOrEmpty(e.DisplayText))
            {
                DateTime d = new DateTime(1970, 1, 1);
                DateTime dt = DateTime.Parse(e.DisplayText);
                if (DateTime.Compare(d, dt) >= 0)
                    e.DisplayText = string.Empty;
            }
        }
    }
}
