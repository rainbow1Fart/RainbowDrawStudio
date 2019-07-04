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
using RainbowDrawStudio.Public;
using RDS_Model;

namespace RainbowDrawStudio.MainForm.AccountManagerForm
{
    public partial class AccountManagerControl : DevExpress.XtraEditors.XtraUserControl
    {

        private PageControl _page;
        private int _pageIndex;
        private int _pageSize;
        private int _pageTotal;
        private int _selectionRow;
        private string _key;
        public AccountManagerControl()
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

        
        private void gridView1_RowClick(object sender, 
            DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _selectionRow = gridView1.FocusedRowHandle;
        }

        private void gridView1_FocusedRowChanged(object sender, 
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _selectionRow = gridView1.FocusedRowHandle;
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
            else if(dataSource.Count == 0)
            {
                s = "没有找到符合条件的数据 QAQ";
            }
            Font font = new Font("微软雅黑", 10, FontStyle.Bold);
            Rectangle r = new Rectangle(e.Bounds.Left + 5, e.Bounds.Top + 5, e.Bounds.Width - 5, e.Bounds.Height - 5);
            e.Graphics.DrawString(s, font, Brushes.Black, r);
        }

        private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;
        }

        private void Query()
        {
            gridControl1.DataSource = AccountInfo.SimpleQuery(_pageIndex, _pageSize, _key, out _pageTotal);
            gridControl1.RefreshDataSource();
            gridView1.MoveBy(0);
             _page.SetPage(_pageIndex, _pageSize, _pageTotal);
        }

        private void new_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            RegisterForm.OnWindowClosed += OnWindowClosed;
            form.Text = "新建账号";
            form.Show();
        }

        private void OnWindowClosed()
        {
            RegisterForm.OnWindowClosed -= OnWindowClosed;
            Query();
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Query();
        }

        private void edit_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountInfo account = gridView1.GetRow(_selectionRow) as AccountInfo;
            if (account == null)
            {
                XtraMessageBox.Show("所选信息无效，请刷新后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            RegisterForm form = new RegisterForm(account, WindowsModel.Modify);
            RegisterForm.OnWindowClosed += OnWindowClosed;
            form.Show();
        }

        private void delete_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("确认删除选择的内容吗？删除后无法找回，请谨慎操作。", "消息", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;

            //验证当前登录用户密码
            VerificationForm form = new VerificationForm();
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
            form.FormClosed -= Form_FormClosed;
            if (!form.Result)
            {
                XtraMessageBox.Show("验证失败");
                return;
            }

            int[] selects = gridView1.GetSelectedRows();
            int[] ids = new int[selects.Length];
            for (int i = 0; i < selects.Length; i++)
            {
                ids[i] = (gridView1.GetRow(selects[i]) as AccountInfo).ID;
            }

            if (AccountInfo.SimpleDelete(ids))
            {
                XtraMessageBoxArgs args = ControlHelper.XtraMessageBoxArgs("消息","删除成功", new DialogResult[]{ DialogResult.OK});
                XtraMessageBox.Show(args);
                return;
            }
            else
            {
                XtraMessageBoxArgs args = ControlHelper.XtraMessageBoxArgs("消息", "删除失败", new DialogResult[] { DialogResult.OK });
                XtraMessageBox.Show(args);
            }
        }


        private void StudentManagerControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false)
                return;
            Query();
        }

        private void StudentManagerControl_Load(object sender, EventArgs e)
        {
            if (Visible == false)
                return;
            Query();
        }

    }
}
