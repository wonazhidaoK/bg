using CommonHelp;
using CommonHelp.Models;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace bg.UserControls
{
    public partial class Uc_DeptFeeder : UserControl
    {
        
        readonly DataHelp help = new DataHelp();
        public Uc_DeptFeeder()
        {
            InitializeComponent();
            dgvStyle();
        }

        private void Uc_DeptFeeder_Load(object sender, EventArgs e)
        {
            BindingDepts();
            LoadDgv();
        }

        private void dgvStyle()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            this.DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGridView1.RowHeadersVisible = true;
            this.DataGridView1.RowTemplate.Height = 23;
        }

        private void BindingDepts()
        {
            deptBindingSource.DataSource = Dept.GetAll();
            cbDept.DataSource = deptBindingSource;
        }

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void LoadDgv()
        {
            var CourseRecords = help.GetTAS_CourseRecordAll();
            var timeS = new DateTime(dtSchooltime.Value.Year, dtSchooltime.Value.Month, dtSchooltime.Value.Day, 00, 00, 00);
            var timeE = new DateTime(dtSchooltime.Value.Year, dtSchooltime.Value.Month, dtSchooltime.Value.Day, 23, 59, 59);
            List<TAS_CourseRecord> list = new List<TAS_CourseRecord>();
            SetMGAFDGV(DataGridView1);
            if (cbDept.Text == Dept.MGAF.Name)
            {

                list = CourseRecords.Where(x => x.Dept.Trim() == cbDept.Text).Where(x => x.Schooltime >= timeS && x.Schooltime <= timeE).ToList();
            }
            else
            {
                list = CourseRecords.Where(x => x.Dept.Trim() == cbDept.Text).Where(x => x.Schooltime >= timeS && x.Schooltime <= timeE).ToList();
            }
            this.DataGridView1.RowCount = list.Count() + 1;
            int i = 0;
            foreach (DataGridViewRow row in this.DataGridView1.Rows)
            {
                if (i >= list.Count())
                {
                    return;
                }
                row.Cells["Course Code"].Value = list[i].CourseCode.Trim();
                row.Cells["Course Title"].Value = list[i].CourseTitle.Trim();
                row.Cells["HQ"].Value = list[i].HQ.ToString().Trim();
                row.Cells["ITGY"].Value = list[i].ITGY.ToString().Trim();
                row.Cells["SMG"].Value = list[i].SMG.ToString().Trim();
                row.Cells["UNITA"].Value = list[i].UNITA.ToString().Trim();
                row.Cells["UNITB"].Value = list[i].UNITB.ToString().Trim();
                row.Cells["UNITC"].Value = list[i].UNITC.ToString().Trim();
                row.Cells["MSAF"].Value = list[i].MSAF.ToString().Trim();
                var classes = help.GetTAS_ClassesRecordByCourseId(new TAS_ClassesRecord { CourseID = list[i].ID });
                if (classes.Count > 0)
                {
                    var c = classes.FirstOrDefault(x => x.Position.Trim() == Position.ChiefTR.Value);
                    if (c != null)
                    {
                        ((DataGridViewComboBoxCell)row.Cells[Position.ChiefTR.Value]).Value = c.UId.Trim();
                        row.Cells[Position.ChiefTR.Value + " classes"].Value = c.ClasseTitle;
                        row.Cells[Position.ChiefTR.Value + " Hours"].Value = c.Hours;
                    }
                    c = classes.FirstOrDefault(x => x.Position.Trim() == Position.CT.Value);
                    if (c != null)
                    {
                        //row.Cells[Position.CT.Value].Value = c.UId.Trim();
                        ((DataGridViewComboBoxCell)row.Cells[Position.CT.Value]).Value = c.UId.Trim();
                        row.Cells[Position.CT.Value + " classes"].Value = c.ClasseTitle;
                        row.Cells[Position.CT.Value + " Hours"].Value = c.Hours;
                    }
                    c = classes.FirstOrDefault(x => x.Position.Trim() == Position.OtherTR.Value);
                    if (c != null)
                    {
                        row.Cells[Position.OtherTR.Value].Value = c.UId.Trim();
                        row.Cells[Position.OtherTR.Value + " classes"].Value = c.ClasseTitle;
                        row.Cells[Position.OtherTR.Value + " Hours"].Value = c.Hours;
                    }
                    c = classes.FirstOrDefault(x => x.Position.Trim() == Position.TempTR.Value);
                    if (c != null)
                    {
                        row.Cells[Position.TempTR.Value].Value = c.UId.Trim();
                        row.Cells[Position.TempTR.Value + " classes"].Value = c.ClasseTitle;
                        row.Cells[Position.TempTR.Value + " Hours"].Value = c.Hours;
                    }
                }
                row.Cells["id"].Value = list[i].ID;
                i++;
            }
        }

        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DataGridView1.IsCurrentCellDirty)
            {
                DataGridView1.CurrentCellDirtyStateChanged -= DataGridView1_CurrentCellDirtyStateChanged;
                DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DataGridView1.CurrentCellDirtyStateChanged += DataGridView1_CurrentCellDirtyStateChanged;
                int c = DataGridView1.CurrentCellAddress.X;
                int r = DataGridView1.CurrentCellAddress.Y;
            }
        }

        private bool AddRowVerify(DataGridViewRow row, ref string message)
        {
            foreach (var item in Position.GetAll())
            {
                if (row.Cells[item.Value].Value != null && row.Cells[item.Value + " classes"].Value != null && row.Cells[item.Value + " Hours"].Value != null)
                {
                    return true;
                }
            }
            message = "There is no class information";
            return false;
        }

        private int AddRowVerify(DataGridViewRow row, Position position, ref string message)
        {
            if (row.Cells[position.Value].Value == null && row.Cells[position.Value + " classes"].Value == null && row.Cells[position.Value + " Hours"].Value == null)
            {
                return 0;
            }
            if (row.Cells[position.Value].Value == null)
            {
                MessageBox.Show(position.Value + " info incomplete");
            }
            if (row.Cells[position.Value + " classes"].Value == null)
            {
                MessageBox.Show(position.Value + " classes info incomplete");
            }
            if (row.Cells[position.Value + " Hours"].Value == null)
            {
                MessageBox.Show(position.Value + " Hours info incomplete");
            }
            return 1;
        }
        private void DataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            var s = DataGridView1.Rows[e.RowIndex];
            if (s.Cells["id"].Value != null)
            {
                return;
            }
            if ((s.Cells["Course Code"].Value == null) || (s.Cells["Course Title"].Value == null))
            {
                return;
            }
            string message = "";
            if (!AddRowVerify(s, ref message))
            {
                MessageBox.Show(message);
                this.BeginInvoke(new System.Action(() =>
                {
                    // 更新使用次数
                    LoadDgv();
                }));

                return;
            }
            TAS_CourseRecord courseRecord = new TAS_CourseRecord();

            courseRecord.CourseCode = s.Cells["Course Code"].Value.ToString();
            courseRecord.CourseTitle = s.Cells["Course Title"].Value.ToString();
            courseRecord.Dept = cbDept.Text;
            courseRecord.HQ = s.Cells["HQ"].Value == null ? default : Convert.ToInt32(s.Cells["HQ"].Value.ToString());
            courseRecord.ITGY = s.Cells["ITGY"].Value == null ? default : Convert.ToInt32(s.Cells["ITGY"].Value.ToString());
            courseRecord.MSAF = s.Cells["MSAF"].Value == null ? default : Convert.ToInt32(s.Cells["MSAF"].Value.ToString());
            courseRecord.Schooltime = dtSchooltime.Value;
            courseRecord.SMG = s.Cells["SMG"].Value == null ? default : Convert.ToInt32(s.Cells["SMG"].Value.ToString());
            courseRecord.UNITA = s.Cells["UNITA"].Value == null ? default : Convert.ToInt32(s.Cells["UNITA"].Value.ToString());
            courseRecord.UNITB = s.Cells["UNITB"].Value == null ? default : Convert.ToInt32(s.Cells["UNITB"].Value.ToString());
            courseRecord.UNITC = s.Cells["UNITC"].Value == null ? default : Convert.ToInt32(s.Cells["UNITC"].Value.ToString());

            var r1 = help.AddTAS_CourseRecords(courseRecord);
            if (r1 > 0)
            {
                if (AddRowVerify(s, Position.ChiefTR, ref message) == 1)
                {
                    help.AddTAS_ClassesRecords(new TAS_ClassesRecord
                    {
                        ClasseTitle = s.Cells[Position.ChiefTR.Value + " classes"].Value.ToString(),
                        CourseID = r1,
                        Hours = Convert.ToInt32(s.Cells[Position.ChiefTR.Value + " Hours"].Value.ToString()),
                        Position = Position.ChiefTR.Value,
                        UId = s.Cells[Position.ChiefTR.Value].Value.ToString()
                    });
                }
                if (AddRowVerify(s, Position.CT, ref message) == 1)
                {
                    help.AddTAS_ClassesRecords(new TAS_ClassesRecord
                    {
                        ClasseTitle = s.Cells[Position.CT.Value + " classes"].Value.ToString(),
                        CourseID = r1,
                        Hours = Convert.ToInt32(s.Cells[Position.CT.Value + " Hours"].Value.ToString()),
                        Position = Position.CT.Value,
                        UId = s.Cells[Position.CT.Value].Value.ToString()
                    });
                }
                if (AddRowVerify(s, Position.OtherTR, ref message) == 1)
                //if (s.Cells[Position.OtherTR.Value].Value != null && s.Cells[Position.OtherTR.Value + " classes"].Value != null)
                {
                    help.AddTAS_ClassesRecords(new TAS_ClassesRecord
                    {
                        ClasseTitle = s.Cells[Position.OtherTR.Value + " classes"].Value.ToString(),
                        CourseID = r1,
                        Hours = Convert.ToInt32(s.Cells[Position.OtherTR.Value + " Hours"].Value.ToString()),//TODO 需要再确认
                        Position = Position.OtherTR.Value,
                        UId = s.Cells[Position.OtherTR.Value].Value.ToString()
                    });
                }
                if (AddRowVerify(s, Position.TempTR, ref message) == 1)
                //if (s.Cells[Position.TempTR.Value].Value != null && s.Cells[Position.TempTR.Value + " classes"].Value != null)
                {
                    help.AddTAS_ClassesRecords(new TAS_ClassesRecord
                    {
                        ClasseTitle = s.Cells[Position.TempTR.Value + " classes"].Value.ToString(),
                        CourseID = r1,
                        Hours = Convert.ToInt32(s.Cells[Position.TempTR.Value + " Hours"].Value.ToString()),
                        Position = Position.TempTR.Value,
                        UId = s.Cells[Position.TempTR.Value].Value.ToString()
                    });
                }
            }
            //}
            //else
            //{
            //    if (s.Cells.Count > 6)
            //    {
            //        return;
            //    }
            //    if (s.Cells[4].Value == null)
            //    {
            //        return;
            //    }

            //    if ((s.Cells[2].Value == null) || (s.Cells[3].Value == null))
            //    {
            //        return;
            //    }

            //    var r1 = help.AddTAS_CourseRecords(new TAS_CourseRecord
            //    {
            //        CourseCode = s.Cells[2].Value.ToString(),
            //        CourseTitle = s.Cells[3].Value.ToString(),
            //        Dept = cbDept.Text,
            //        Schooltime = dtSchooltime.Value
            //    });

            //    if (r1 > 0)
            //    {
            //        help.AddTAS_ClassesRecords(new TAS_ClassesRecord
            //        {
            //            ClasseTitle = s.Cells[1].Value.ToString(),
            //            CourseID = r1,
            //            Hours = Convert.ToInt32(s.Cells["Course Hours"].Value.ToString()),//TODO 需要再确认
            //            Position = "TR",
            //            UId = s.Cells[0].Value.ToString().Trim()
            //        });
            //    }
            //}
        }

        public DataGridView SetITGYDGV(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            DataGridViewComboBoxColumn d = new DataGridViewComboBoxColumn
            {
                HeaderText = "TR"
            };
            d.DataSource = help.GetTAS_UserAll().Where(x => x.Type == Teacher_type.T.Name).ToList();
            d.HeaderText = "TR";
            d.Name = "TR";
            d.DisplayMember = "UId";
            d.ValueMember = "UId";
            dataGridView.Columns.Add(d);
            dataGridView.Columns.Add("TR classes", "TR classes");
            dataGridView.Columns.Add("Course Code", "Course Code");
            dataGridView.Columns.Add("Course Title", "Course Title");
            dataGridView.Columns.Add("Course Hours", "Course Hours");
            dataGridView.Columns.Add("id", "id");
            dataGridView.Columns["id"].Visible = false;

            return dataGridView;
        }

        public DataGridView SetMGAFDGV(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Columns.Add("Course Code", "Course Code");
            dataGridView.Columns.Add("Course Title", "Course Title");

            foreach (var item in Cost_Centre.GetAll())
            {
                dataGridView.Columns.Add(item.Name, item.Name);
            }

            foreach (var item in Position.GetMGAFAll())
            {
                DataGridViewComboBoxColumn d = new DataGridViewComboBoxColumn
                {
                    HeaderText = item.Value
                };
                if (item.Value == Position.CT.Value)
                {
                    var list = help.GetTAS_UserAll().Where(x => x.Type == Teacher_type.C.Name);
                    List<TAS_User> users = new List<TAS_User>();
                    if (list.Count() > 0)
                    {
                        /*
                         * 分别找寻前三周和本周的工作时长 判断是否能继续雇佣
                         */
                        var WeekNo = WeekHelp.GetWeekByTime(DateTime.Now);
                        var ThisWeekMonday = WeekHelp.GetTimeByWeek(2020, WeekNo, 1);
                        var LastWeekMonday = WeekHelp.GetTimeByWeek(2020, WeekNo - 1, 1);
                        var BeforeLastWeekMonday = WeekHelp.GetTimeByWeek(2020, WeekNo - 2, 1);
                        var FirstThreeWeekMonday = WeekHelp.GetTimeByWeek(2020, WeekNo - 3, 1);
                        var ThisWeekCourse = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= ThisWeekMonday && x.Schooltime <= ThisWeekMonday.AddDays(6) && x.Dept == Dept.MGAF.Value).ToList();
                        List<TAS_ClassesRecord> ThisWeekCourseClass = new List<TAS_ClassesRecord>();
                        if (ThisWeekCourse.Count > 0)
                        {
                            ThisWeekCourseClass = help.GetTAS_ClassesRecordByCourseIds(new DataHelp.ByCourseIdsModel
                            {
                                ids = ThisWeekCourse.Select(x => x.ID).ToArray()
                            });
                        }

                        var LastWeekCourse = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= LastWeekMonday && x.Schooltime <= LastWeekMonday.AddDays(6) && x.Dept == Dept.MGAF.Value).ToList();
                        List<TAS_ClassesRecord> LastWeekCourseClass = new List<TAS_ClassesRecord>();
                        if (LastWeekCourse.Count > 0) { LastWeekCourseClass = help.GetTAS_ClassesRecordByCourseIds(new DataHelp.ByCourseIdsModel { ids = LastWeekCourse.Select(x => x.ID).ToArray() }); }


                        var BeforeLastCourse = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= BeforeLastWeekMonday && x.Schooltime <= BeforeLastWeekMonday.AddDays(6) && x.Dept == Dept.MGAF.Value).ToList();
                        List<TAS_ClassesRecord> BeforeLastCourseClass = new List<TAS_ClassesRecord>();
                        if (BeforeLastCourse.Count > 0) { BeforeLastCourseClass = help.GetTAS_ClassesRecordByCourseIds(new DataHelp.ByCourseIdsModel { ids = BeforeLastCourse.Select(x => x.ID).ToArray() }); }

                        var FirstThreeCourse = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= FirstThreeWeekMonday && x.Schooltime <= FirstThreeWeekMonday.AddDays(6) && x.Dept == Dept.MGAF.Value).ToList();
                        List<TAS_ClassesRecord> FirstThreeCourseClass = new List<TAS_ClassesRecord>();
                        if (FirstThreeCourse.Count > 0) { FirstThreeCourseClass = help.GetTAS_ClassesRecordByCourseIds(new DataHelp.ByCourseIdsModel { ids = FirstThreeCourse.Select(x => x.ID).ToArray() }); }

                        foreach (var user in list)
                        {
                            double ThisWeekhour = 0;
                            if (ThisWeekCourseClass.Count > 0)
                            {
                                ThisWeekhour = ThisWeekCourseClass.Where(x => x.UId == user.UId).Sum(x => x.Hours);
                            }
                            double LastWeekhour = 0;
                            if (LastWeekCourseClass.Count > 0)
                            {
                                LastWeekhour = LastWeekCourseClass.Where(x => x.UId == user.UId).Sum(x => x.Hours);
                            }
                            double FirstThreehour = 0;
                            if (FirstThreeCourseClass.Count > 0)
                            {
                                FirstThreehour = FirstThreeCourseClass.Where(x => x.UId == user.UId).Sum(x => x.Hours);
                            }
                            double BeforeLasthour = 0;
                            if (BeforeLastCourseClass.Count > 0)
                            {
                                BeforeLasthour = BeforeLastCourseClass.Where(x => x.UId == user.UId).Sum(x => x.Hours);
                            }

                            if (!((ThisWeekhour >= 18) || (LastWeekhour >= 18) || (BeforeLasthour >= 18) || (FirstThreehour) >= 18))
                            {
                                users.Add(user);
                            }
                        }
                    }


                    d.DataSource = users;
                }
                else
                {
                    d.DataSource = help.GetTAS_UserAll().Where(x => x.Type == Teacher_type.T.Name).ToList();
                }
                // d.DataSource = help.GetTAS_UserAll().Where(x => x.Type == Teacher_type.C.Value);
                d.HeaderText = item.Value;
                d.DisplayMember = "UId";
                d.ValueMember = "UId";
                d.Name = item.Value;
                dataGridView.Columns.Add(d);
                dataGridView.Columns.Add(item.Value + " classes", item.Value + " classes");
                dataGridView.Columns.Add(item.Value + " Hours", item.Value + " Hours");
            }
            dataGridView.Columns.Add("id", "id");
            dataGridView.Columns["id"].Visible = false;

            return dataGridView;
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dtSchooltime_ValueChanged(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<WorksheetModel> worksheets = new List<WorksheetModel>();
            /*
             * 导出文件的具体规则
             */
            SetCentralFeeder(worksheets);
            SetRef(worksheets);
            foreach (var item in Dept.GetAll())
            {
                SetDeptFeeder(worksheets, item);
            }
            DataTableToExcel(worksheets);
        }
        private void SetRef(List<WorksheetModel> worksheets)
        {
            //var timeS = new DateTime(dtSchooltime.Value.Year, dtSchooltime.Value.Month, 1, 00, 00, 00);

            //var timeE = GetCurrentMonthLastDay(timeS);
            var users = help.GetTAS_UserAll();
            //var list = CourseRecords.Where(x => x.Dept.Trim() == dept.Value.ToString()).ToList();
            if (users.Count < 1)
            {
                return;
            }
            System.Data.DataTable dt1 = new System.Data.DataTable();
            dt1.Columns.Add("User ID");
            dt1.Columns.Add("Full Name");
            //foreach (var item in Cost_Centre.GetAll())
            //{
            //    dt1.Columns.Add(item.Name);
            //}
            //foreach (var item in Position.GetMGAFAll())
            //{
            //    dt1.Columns.Add(item.Value);
            //    dt1.Columns.Add(item.Value + " classes");
            //    dt1.Columns.Add(item.Value + " Hours");
            //}
            string[] strHead = new string[19];
            foreach (var item in users)
            {
                DataRow NewRow = dt1.NewRow();
                NewRow["User ID"] = item.UId;
                NewRow["Full Name"] = item.Fname + " " + item.Lname;


                dt1.Rows.Add(NewRow);
            }
            worksheets.Add(new WorksheetModel
            {
                Table = dt1,
                Title = "",
                WorksheetName = "Ref",
                HeadStr = null

            });
        }

        private void SetDeptFeeder(List<WorksheetModel> worksheets, Dept dept)
        {
            var timeS = new DateTime(dtSchooltime.Value.Year, dtSchooltime.Value.Month, 1, 00, 00, 00);

            var timeE = GetCurrentMonthLastDay(timeS);
            var CourseRecords = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= timeS && x.Schooltime <= timeE);
            var list = CourseRecords.Where(x => x.Dept.Trim() == dept.Value.ToString()).ToList();
            if (list.Count < 1)
            {
                return;
            }
            System.Data.DataTable dt1 = new System.Data.DataTable();
            dt1.Columns.Add("Course Code");
            dt1.Columns.Add("Course Title");
            foreach (var item in Cost_Centre.GetAll())
            {
                dt1.Columns.Add(item.Name);
            }
            foreach (var item in Position.GetMGAFAll())
            {
                dt1.Columns.Add(item.Value);
                dt1.Columns.Add(item.Value + " classes");
                dt1.Columns.Add(item.Value + " Hours");
            }
            string[] strHead = new string[19];
            foreach (var item in list)
            {
                DataRow NewRow = dt1.NewRow();
                NewRow["Course Code"] = item.CourseCode;
                NewRow["Course Title"] = item.CourseTitle;
                NewRow["HQ"] = item.HQ;
                NewRow["ITGY"] = item.ITGY;
                NewRow["SMG"] = item.SMG;
                NewRow["UNITA"] = item.UNITA;
                NewRow["UNITB"] = item.UNITB;
                NewRow["UNITC"] = item.UNITC;
                NewRow["MSAF"] = item.MSAF;

                var classes = help.GetTAS_ClassesRecordByCourseId(new TAS_ClassesRecord { CourseID = item.ID });
                if (classes.Count > 0)
                {
                    var c = classes.FirstOrDefault(x => x.Position.Trim() == Position.ChiefTR.Value);
                    if (c != null)
                    {
                        NewRow[Position.ChiefTR.Value] = c.UId.Trim();
                        NewRow[Position.ChiefTR.Value + " classes"] = c.UId.Trim();
                        NewRow[Position.ChiefTR.Value + " Hours"] = c.Hours;
                    }
                    c = classes.FirstOrDefault(x => x.Position.Trim() == Position.CT.Value);
                    if (c != null)
                    {
                        NewRow[Position.CT.Value] = c.UId.Trim();
                        NewRow[Position.CT.Value + " classes"] = c.UId.Trim();
                        NewRow[Position.CT.Value + " Hours"] = c.Hours;
                    }
                    c = classes.FirstOrDefault(x => x.Position.Trim() == Position.OtherTR.Value);
                    if (c != null)
                    {
                        NewRow[Position.OtherTR.Value] = c.UId.Trim();
                        NewRow[Position.OtherTR.Value + " classes"] = c.UId.Trim();
                        NewRow[Position.OtherTR.Value + " Hours"] = c.Hours;// c.UId.Trim();
                    }
                    c = classes.FirstOrDefault(x => x.Position.Trim() == Position.TempTR.Value);
                    if (c != null)
                    {
                        NewRow[Position.TempTR.Value] = c.UId.Trim();
                        NewRow[Position.TempTR.Value + " classes"] = c.UId.Trim();
                        NewRow[Position.TempTR.Value + " Hours"] = c.Hours;//.Trim();
                    }
                }
                dt1.Rows.Add(NewRow);
            }
            worksheets.Add(new WorksheetModel
            {
                Table = dt1,
                Title = "",
                WorksheetName = "Dept Feeder-" + dept.Value.ToString(),
                HeadStr = new string[1] { dept.Value.ToString() }

            }); ;
        }

        /// <summary>
        /// 获取指定月份的最后一天
        /// </summary>
        /// <param name="dateTime">传入时间</param>
        /// <returns></returns>
        public DateTime GetCurrentMonthLastDay(DateTime dateTime)
        {
            DateTime d1 = new DateTime(dateTime.Year, dateTime.Month, 1);
            DateTime d2 = d1.AddMonths(1).AddDays(-1);
            return d2;
        }
        private void SetCentralFeeder(List<WorksheetModel> worksheets)
        {
            var timeS = new DateTime(dtSchooltime.Value.Year, dtSchooltime.Value.Month, 1, 00, 00, 00);

            var timeE = GetCurrentMonthLastDay(timeS);
            var CourseRecords = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= timeS && x.Schooltime <= timeE);
            var list = CourseRecords.ToList();
            System.Data.DataTable dt1 = new System.Data.DataTable();
            dt1.Columns.Add("Course Code");
            dt1.Columns.Add("Course Title");
            dt1.Columns.Add("User ID");
            dt1.Columns.Add("Classes");
            dt1.Columns.Add("Normal or OT");
            foreach (var item in list)
            {
                var classes = help.GetTAS_ClassesRecordByCourseId(new TAS_ClassesRecord { CourseID = item.ID }).FirstOrDefault();
                if (classes != null)
                {
                    DataRow NewRow = dt1.NewRow();
                    NewRow["Course Code"] = item.CourseCode;
                    NewRow["Course Title"] = item.CourseTitle;
                    NewRow["User ID"] = classes.UId;
                    NewRow["Classes"] = classes.ClasseTitle;
                    NewRow["Normal or OT"] = classes.Position.Trim() == Position.TROT.Value ? "OT" : (classes.Position.Trim() == Position.CT.Value ? "CT" : "");
                    dt1.Rows.Add(NewRow);
                }
            }
            worksheets.Add(new WorksheetModel
            {
                Table = dt1,
                Title = "",
                WorksheetName = "Central Feeder",
                HeadStr = null

            });
        }

        public class WorksheetModel
        {
            public string Title { get; set; }

            public System.Data.DataTable Table { get; set; }

            public string WorksheetName { get; set; }

            public string[] HeadStr { get; set; }
        }

        public void DataTableToExcel(List<WorksheetModel> worksheets)
        {


            //创建Excel对象
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //新建工作簿
            Workbook workBook = excelApp.Workbooks.Add(true);
            int i = 1;
            foreach (var item in worksheets)
            {
                if (item.HeadStr == null)
                {

                    NoHead(item.Table, item.HeadStr, item.WorksheetName, excelApp, workBook, i);
                }
                else
                {
                    OneHead(item.Table, item.HeadStr, item.WorksheetName, excelApp, workBook, i);
                }
                i++;
            }

            //设置Excel可见
            excelApp.Visible = true;
        }

        private static void NoHead(System.Data.DataTable dataTable, string[] strHead, string worksheetName, Microsoft.Office.Interop.Excel.Application excelApp, Workbook workBook, int worksheetIndex)
        {

            Worksheet worksheet;
            if (worksheetIndex > 1)
            {
                object missing = System.Reflection.Missing.Value;
                worksheet = (Worksheet)workBook.Worksheets.Add(missing, missing, missing, missing);//添加一个sheet  
            }
            else
            {
                worksheet = (Worksheet)workBook.Worksheets[worksheetIndex];//取得sheet1  
            }
            worksheet.Name = worksheetName;

            //设置表头 
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                Range headRange = worksheet.Cells[1, i + 1] as Range;//获取表头单元格,不用标题则从1开始
                headRange.Value2 = dataTable.Columns[i].ColumnName;                              //设置单元格文本
                headRange.Font.Name = "Consolas";                           //设置字体
                headRange.Font.Size = 13;                                   //字体大小
                headRange.Font.Bold = true;                                 //加粗显示
                headRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;    //水平居中
                headRange.VerticalAlignment = XlVAlign.xlVAlignCenter;      //垂直居中
                                                                            //headRange.ColumnWidth = columnWidth[i];                     //设置列宽
                headRange.Borders.LineStyle = XlLineStyle.xlContinuous;     //设置边框
                headRange.Borders.Weight = XlBorderWeight.xlThin;           //边框常规粗细


            }

            //填充数据
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    excelApp.Cells[i + 2, j + 1] = row[j].ToString().Trim();
                }
            }

        }

        private static void OneHead(System.Data.DataTable dataTable, string[] strHead, string worksheetName, Microsoft.Office.Interop.Excel.Application excelApp, Workbook workBook, int worksheetIndex)
        {

            Worksheet worksheet;
            if (worksheetIndex > 1)
            {
                object missing = System.Reflection.Missing.Value;
                worksheet = (Worksheet)workBook.Worksheets.Add(missing, missing, missing, missing);//添加一个sheet  
            }
            else
            {
                worksheet = (Worksheet)workBook.Worksheets[worksheetIndex];//取得sheet1  
            }
            worksheet.Name = worksheetName;
            ////设置标题
            Microsoft.Office.Interop.Excel.Range titleRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 1]];//选取单元格

            titleRange.Merge(true);                                         //合并单元格
            titleRange.Value2 = strHead[0];                                   //设置单元格内文本
            titleRange.Font.Name = "微软雅黑";                              //设置字体
            titleRange.Font.Size = 18;                                      //字体大小
            titleRange.Font.Bold = true;                                    //加粗显示
            titleRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;       //水平居中
            titleRange.VerticalAlignment = XlVAlign.xlVAlignCenter;         //垂直居中
            titleRange.Borders.LineStyle = XlLineStyle.xlContinuous;        //设置边框
            titleRange.Borders.Weight = XlBorderWeight.xlThin;              //边框常规粗细
            titleRange.Interior.Color = Color.FromArgb(95, 158, 160);//设置颜色
            //设置表头 
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                Range headRange = worksheet.Cells[2, i + 1] as Range;//获取表头单元格,不用标题则从1开始
                headRange.Value2 = dataTable.Columns[i].ColumnName;                              //设置单元格文本
                headRange.Font.Name = "Consolas";                           //设置字体
                headRange.Font.Size = 13;                                   //字体大小
                headRange.Font.Bold = true;                                 //加粗显示
                headRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;    //水平居中
                headRange.VerticalAlignment = XlVAlign.xlVAlignCenter;      //垂直居中
                                                                            //headRange.ColumnWidth = columnWidth[i];                     //设置列宽
                headRange.Borders.LineStyle = XlLineStyle.xlContinuous;     //设置边框
                headRange.Borders.Weight = XlBorderWeight.xlThin;           //边框常规粗细


            }

            //填充数据
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    excelApp.Cells[i + 3, j + 1] = row[j].ToString().Trim();
                }
            }

        }
    }
}
