using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace RainbowDrawStudio.Public
{
    public partial class PageControl : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler PageChanged;

        private int _pageIndex;
        private int _pageSize;
        private int _pageTotal;

        public int PageIndex
        {
            get { return _pageIndex; }
        }
        public int PageSize
        {
            get { return _pageSize; }
        }

        public int PageTotal
        {
            get { return _pageTotal; }
        }
        public PageControl()
        {
            InitializeComponent();
            _pageIndex = 1;
            _pageSize = 25;
            _pageTotal = 0;
            page_comboBoxEdit.SelectedIndex = 0;
        }

        ~PageControl()
        {
            if (PageChanged != null)
            {
                PageChanged = null;
            }
        }

        public void SetPage(int pageIndex,int pageSize, int pageTotal)
        {
            _pageTotal = pageTotal;
            _pageIndex = pageIndex;
            _pageSize = pageSize;

            total_labelControl.Text = string.Format("共 {0} 条记录", _pageTotal);
            int result = (_pageTotal % _pageSize) == 0 ? PageTotal / _pageSize : (PageTotal / _pageSize) + 1;
            curPage_labelControl.Text = string.Format("{0}/{1}页", _pageIndex, result);
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frist_hyperlinkLabelControl_Click(object sender, EventArgs e)
        {
            if (_pageTotal == 0)
            {
                curPage_labelControl.Text = "1/1 页";
                return;
            }
            _pageIndex = 1;
            int result = (_pageTotal % _pageSize) == 0 ? PageTotal / _pageSize : (PageTotal / _pageSize) + 1;
            curPage_labelControl.Text = string.Format("1/{0} 页", result);
            PageChanged?.Invoke(sender, e);
        }

        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void last_hyperlinkLabelControl_Click(object sender, EventArgs e)
        {
            if (_pageTotal == 0)
            {
                curPage_labelControl.Text = "1/1 页";
                return;
            }

            _pageIndex = (_pageTotal % _pageSize) == 0 ? PageTotal / _pageSize : (PageTotal / _pageSize) + 1;
            curPage_labelControl.Text = string.Format("{0}/{0} 页", _pageIndex);
            PageChanged?.Invoke(sender, e);
        }

        private void current_hyperlinkLabelControl_Click(object sender, EventArgs e)
        {
            if (_pageTotal == 0)
            {
                curPage_labelControl.Text = "1/1 页";
                return;
            }

            int result = (_pageTotal % _pageSize) == 0 ? PageTotal / _pageSize : (PageTotal / _pageSize) + 1;
            if (_pageIndex == result)
                return;
            --_pageIndex;
            curPage_labelControl.Text = string.Format("{0}/{1} 页", _pageIndex, result);
            PageChanged?.Invoke(sender, e);
        }

        private void next_hyperlinkLabelControl_Click(object sender, EventArgs e)
        {
            if (_pageTotal == 0)
            {
                curPage_labelControl.Text = "1/1 页";
                return;
            }

            int result = (_pageTotal % _pageSize) == 0 ? PageTotal / _pageSize : (PageTotal / _pageSize) + 1;
            if (_pageIndex >= result)
                return;
            ++_pageIndex;
            curPage_labelControl.Text = string.Format("{0}/{1} 页", _pageIndex, result);
            PageChanged?.Invoke(sender, e);
        }

        private void page_comboBoxEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            _pageSize = int.Parse(page_comboBoxEdit.Text.Trim().ToString());
            PageChanged?.Invoke(sender, e);
        }

        private void page_comboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pageSize = int.Parse(page_comboBoxEdit.Text.Trim().ToString());
            PageChanged?.Invoke(sender, e);
        }
    }
}
