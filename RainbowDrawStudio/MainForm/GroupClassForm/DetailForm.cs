using System;
using System.Collections.Generic;
using System.Drawing;
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
        private List<CheckinInfo> _checkins;
        private List<StudentInfo> _students;
        private List<StudentInfo> _removeStudents;
        private List<StudentInfo> _addStudents;

        public DetailForm(GroupClassInfo arg, WindowsModel wm)
        {
            InitializeComponent();
            _pageTotal = 0;
            _selectionRow = 0;
            _key = string.Empty;
            _groupClassInfo = arg;
            _checkins = new List<CheckinInfo>();
            _students = new List<StudentInfo>();
            _removeStudents = new List<StudentInfo>();
            _addStudents = new List<StudentInfo>();

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

            classTeacher_textEdit.Properties.ReadOnly = true;
            create_textEdit.Properties.ReadOnly = true;

            CheckGroupMembers();
        }

        /// <summary>
        /// 检查小组下是否存在对应的成员
        /// </summary>
        private void CheckGroupMembers()
        {
            //检查该小组有无对应学生
            _checkins = CheckinInfo.Query(_groupClassInfo.ID);
            _students.Clear();
            if (_checkins.Count > 0)
            {
                add_simpleButton.Hide();
                update_simpleButton.Show();
                update_simpleButton.Location = add_simpleButton.Location;
                checkin_simpleButton.Enabled = true;
            }
            else
            {
                add_simpleButton.Show();
                update_simpleButton.Hide();
                checkin_simpleButton.Enabled = false;
            }

            foreach (var v in _checkins)
            {
                _students.Add(StudentInfo.QueryFromID(v.StudentID));
            }
            gridControl2.DataSource = _students;
            gridControl2.RefreshDataSource();
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

        private void query_simpleButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;
            _key = query_textEdit.Text.Trim();
            StudenQuery();
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StudentInfo temp = gridView1.GetRow(gridView1.FocusedRowHandle) as StudentInfo;
            if (temp == null)
                return;
            if(_students.Contains(temp))
            {
                XtraMessageBox.Show("本组中已存在该学生", "消息", MessageBoxButtons.OK);
                return;
            }
            _students.Add(temp);
            _addStudents.Add(temp);

            gridControl2.DataSource = _students;
            gridControl2.RefreshDataSource();
        }

        private void add_simpleButton_Click(object sender, EventArgs e)
        {
            if(_addStudents.Count <= 0)
            {
                XtraMessageBox.Show("请添加小组成员！", "消息", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("确认为小组新建以下学生吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int[] studenIDs = new int[_addStudents.Count];
            for(int i = 0; i < studenIDs.Length; i++)
            {
                studenIDs[i] = _addStudents[i].ID;
            }

            int result = CheckinInfo.AddMembers(_groupClassInfo.ID, studenIDs);
            if (result != studenIDs.Length)
            {
                XtraMessageBox.Show("部分成员添加失败，请刷新后重试", "消息", MessageBoxButtons.OK);
                return;
            }
            _addStudents.Clear();
            CheckGroupMembers();
        }

        private void gridControl2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StudentInfo temp = gridView2.GetRow(gridView2.FocusedRowHandle) as StudentInfo;
            if (temp == null)
                return;

            _students.Remove(temp);
            _removeStudents.Add(temp);
            gridControl2.DataSource = _students;
            gridControl2.RefreshDataSource();
        }

        private void update_simpleButton_Click(object sender, EventArgs e)
        {
            if(_removeStudents.Count == 0 && _addStudents.Count == 0)
            {
                XtraMessageBox.Show("未进行任何修改操作","消息", MessageBoxButtons.OK);
                return;
            }

            if (XtraMessageBox.Show("确认更新学生分组信息吗", "消息", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (_removeStudents.Count > 0)
            {
                _removeStudents.ForEach(p => CheckinInfo.DeleteMemebers(_groupClassInfo.ID, p.ID));
                _removeStudents.Clear();
            }
            if (_addStudents.Count > 0)
            {
                int[] studenIDs = new int[_addStudents.Count];
                for (int i = 0; i < studenIDs.Length; i++)
                {
                    studenIDs[i] = _addStudents[i].ID;
                }

                int result = CheckinInfo.AddMembers(_groupClassInfo.ID, studenIDs);
                _addStudents.Clear();
            }
            CheckGroupMembers();
        }

        private void query_simpleButton_Click(object sender, EventArgs e)
        {
            _key = query_textEdit.Text.Trim();
            StudenQuery();
        }

        private void checkin_simpleButton_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("确认为勾选的学生签到吗", "消息",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            List<StudentInfo> checkin = new List<StudentInfo>();
            for(int i= 0; i < gridView2.RowCount;i++)
            {
                StudentInfo stu = gridView2.GetRow(i) as StudentInfo;
                if (stu.Checkin)
                    checkin.Add(stu);
            }

            foreach(var v in checkin)
            {
                v.Remaining -= 1;
                int result = StudentInfo.Updata(v);
            }
            CheckGroupMembers();
            XtraMessageBox.Show("签到完成","消息", MessageBoxButtons.OK);

            //异步插入签到记录
            System.Threading.Tasks.Task t = new System.Threading.Tasks.Task(new Action(() => {
                checkin.ForEach(p => CheckinRecordInfo.AddRecord(p));
            }));
            t.Start();
        }
    }
}