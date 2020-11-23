using CommonHelp;
using CommonHelp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            //this.DataGridView1.AllowUserToAddRows = true;
            //this.DataGridView1.AllowUserToDeleteRows = false;
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
            //this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            //this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = true; //建议改为true；为了以后显示序号。
            this.DataGridView1.RowTemplate.Height = 23;
            //this.DataGridView1.RowTemplate.ReadOnly = true;
        }

        private void BindingDepts()
        {
            List<Dept> depts = new List<Dept>()
            {
              Dept.MGAF,
              Dept.ITGY
            };

            deptBindingSource.DataSource = depts;
            cbDept.DataSource = deptBindingSource;
        }

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void LoadDgv()
        {
            var CourseRecords = help.GetTAS_CourseRecordAll();
            var timeS = new DateTime(dtSchooltime.Value.Year, dtSchooltime.Value.Month, dtSchooltime.Value.Day, 00, 00,00);
            var timeE = new DateTime(dtSchooltime.Value.Year, dtSchooltime.Value.Month, dtSchooltime.Value.Day, 23, 59, 59);
            if (cbDept.Text == Dept.MGAF.Name)
            {
                SetMGAFDGV(DataGridView1);
                var list = CourseRecords.Where(x => x.Dept.Trim() == cbDept.Text).Where(x => x.Schooltime >= timeS && x.Schooltime <= timeE).ToList();
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
                            row.Cells[Position.ChiefTR.Value + " Hours"].Value = c.ClasseTitle;
                        }
                        c = classes.FirstOrDefault(x => x.Position.Trim() == Position.CT.Value);
                        if (c != null)
                        {
                            row.Cells[Position.CT.Value].Value = c.UId.Trim();
                            row.Cells[Position.CT.Value + " classes"].Value = c.ClasseTitle;
                            row.Cells[Position.ChiefTR.Value + " Hours"].Value = c.ClasseTitle;
                        }
                        c = classes.FirstOrDefault(x => x.Position.Trim() == Position.OtherTR.Value);
                        if (c != null)
                        {
                            row.Cells[Position.OtherTR.Value].Value = c.UId.Trim();
                            row.Cells[Position.OtherTR.Value + " classes"].Value = c.ClasseTitle;
                            row.Cells[Position.ChiefTR.Value + " Hours"].Value = c.ClasseTitle;
                        }
                        c = classes.FirstOrDefault(x => x.Position.Trim() == Position.TempTR.Value);
                        if (c != null)
                        {
                            row.Cells[Position.TempTR.Value].Value = c.UId.Trim();
                            row.Cells[Position.TempTR.Value + " classes"].Value = c.ClasseTitle;
                            row.Cells[Position.ChiefTR.Value + " Hours"].Value = c.ClasseTitle;
                        }
                    }
                    row.Cells["id"].Value = list[i].ID;
                    i++;
                }
            }
            else
            {
                SetITGYDGV(DataGridView1);
                var list = CourseRecords.Where(x => x.Dept.Trim() == cbDept.Text).Where(x=>x.Schooltime>= timeS&& x.Schooltime<= timeE).ToList();
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


                    var classe = help.GetTAS_ClassesRecordByCourseId(new TAS_ClassesRecord { CourseID = list[i].ID }).FirstOrDefault();
                    if (classe != null)
                    {
                        //var c = classes.FirstOrDefault(x => x.Position.Trim() == Position.TR.Value);
                        //if (c != null)
                        //{
                        ((DataGridViewComboBoxCell)row.Cells["TR"]).Value = classe.UId.Trim();
                        row.Cells["TR classes"].Value = classe.ClasseTitle;
                        //} 
                    }
                    i++;
                }
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

        private void DataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            var s = DataGridView1.Rows[e.RowIndex];


            if (cbDept.Text == Dept.MGAF.Name)
            {
                if (s.Cells.Count < 7)
                {
                    return;
                }
                if (s.Cells["id"].Value != null)
                {
                    return;
                }
                if ((s.Cells["Course Code"].Value == null) || (s.Cells["Course Title"].Value == null))
                {
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
                    if (s.Cells[Position.ChiefTR.Value].Value != null && s.Cells[Position.ChiefTR.Value + " classes"].Value != null && s.Cells[Position.ChiefTR.Value + " Hours"].Value != null)
                    {
                        help.AddTAS_ClassesRecords(new TAS_ClassesRecord
                        {
                            ClasseTitle = s.Cells[Position.ChiefTR.Value + " classes"].Value.ToString(),
                            CourseID = r1,
                            Hours = Convert.ToInt32(s.Cells[Position.ChiefTR.Value + " Hours"].Value.ToString()),//TODO 需要再确认
                            Position = Position.ChiefTR.Value,
                            UId = s.Cells[Position.ChiefTR.Value].Value.ToString()
                        });
                    }
                    if (s.Cells[Position.CT.Value].Value != null && s.Cells[Position.CT.Value + " classes"].Value != null)
                    {
                        help.AddTAS_ClassesRecords(new TAS_ClassesRecord
                        {
                            ClasseTitle = s.Cells[Position.CT.Value + " classes"].Value.ToString(),
                            CourseID = r1,
                            Hours = Convert.ToInt32(s.Cells[Position.CT.Value + " Hours"].Value.ToString()),//TODO 需要再确认
                            Position = Position.CT.Value,
                            UId = s.Cells[Position.CT.Value].Value.ToString()
                        });
                    }
                    if (s.Cells[Position.OtherTR.Value].Value != null && s.Cells[Position.OtherTR.Value + " classes"].Value != null)
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
                    if (s.Cells[Position.TempTR.Value].Value != null && s.Cells[Position.TempTR.Value + " classes"].Value != null)
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
            }
            else
            {
                if (s.Cells.Count > 6)
                {
                    return;
                }
                if (s.Cells[4].Value == null)
                {
                    return;
                }

                if ((s.Cells[2].Value == null) || (s.Cells[3].Value == null))
                {
                    return;
                }

                var r1 = help.AddTAS_CourseRecords(new TAS_CourseRecord
                {
                    CourseCode = s.Cells[2].Value.ToString(),
                    CourseTitle = s.Cells[3].Value.ToString(),
                    Dept = cbDept.Text,
                    Schooltime = dtSchooltime.Value
                });

                if (r1 > 0)
                {
                    help.AddTAS_ClassesRecords(new TAS_ClassesRecord
                    {
                        ClasseTitle = s.Cells[1].Value.ToString(),
                        CourseID = r1,
                        Hours = Convert.ToInt32(s.Cells["Course Hours"].Value.ToString()),//TODO 需要再确认
                        Position = "TR",
                        UId = s.Cells[0].Value.ToString().Trim()
                    });
                }
            }
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
                        var 第几周 = WeekHelp.GetWeekByTime(DateTime.Now);
                        var 本周的星期一 = WeekHelp.GetTimeByWeek(2020, 第几周, 1);
                        var 前一周的星期一 = WeekHelp.GetTimeByWeek(2020, 第几周 - 1, 1);
                        var 前两周的星期一 = WeekHelp.GetTimeByWeek(2020, 第几周 - 2, 1);
                        var 前三周的星期一 = WeekHelp.GetTimeByWeek(2020, 第几周 - 3, 1);
                        var 本周课程 = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= 本周的星期一 && x.Schooltime <= 本周的星期一.AddDays(6) && x.Dept == Dept.MGAF.Value).ToList();
                        List<TAS_ClassesRecord> 本周课程班级 = new List<TAS_ClassesRecord>();
                        if (本周课程.Count > 0)
                        {
                            本周课程班级 = help.GetTAS_ClassesRecordByCourseIds(new DataHelp.ByCourseIdsModel
                            {
                                ids = 本周课程.Select(x => x.ID).ToArray()
                            });
                        }

                        var 前一周课程 = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= 前一周的星期一 && x.Schooltime <= 前一周的星期一.AddDays(6) && x.Dept == Dept.MGAF.Value).ToList();
                        List<TAS_ClassesRecord> 前一周课程班级 = new List<TAS_ClassesRecord>();
                        if (前一周课程.Count > 0) { 前一周课程班级 = help.GetTAS_ClassesRecordByCourseIds(new DataHelp.ByCourseIdsModel { ids = 前一周课程.Select(x => x.ID).ToArray() }); }


                        var 前两周课程 = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= 前两周的星期一 && x.Schooltime <= 前两周的星期一.AddDays(6) && x.Dept == Dept.MGAF.Value).ToList();
                        List<TAS_ClassesRecord> 前两周课程班级 = new List<TAS_ClassesRecord>();
                        if (前两周课程.Count > 0) { 前两周课程班级 = help.GetTAS_ClassesRecordByCourseIds(new DataHelp.ByCourseIdsModel { ids = 前两周课程.Select(x => x.ID).ToArray() }); }

                        var 前三周课程 = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= 前三周的星期一 && x.Schooltime <= 前三周的星期一.AddDays(6) && x.Dept == Dept.MGAF.Value).ToList();
                        List<TAS_ClassesRecord> 前三周课程班级 = new List<TAS_ClassesRecord>();
                        if (前三周课程.Count > 0) { 前三周课程班级 = help.GetTAS_ClassesRecordByCourseIds(new DataHelp.ByCourseIdsModel { ids = 前三周课程.Select(x => x.ID).ToArray() }); }

                        foreach (var user in list)
                        {
                            double 本周课时 = 0;
                            if (本周课程班级.Count > 0)
                            {
                                本周课时 = 本周课程班级.Where(x => x.UId == user.UId).Sum(x => x.Hours);
                            }
                            double 前一周课时 = 0;
                            if (前一周课程班级.Count > 0)
                            {
                                前一周课时 = 前一周课程班级.Where(x => x.UId == user.UId).Sum(x => x.Hours);
                            }
                            double 前三周课时 = 0;
                            if (前三周课程班级.Count > 0)
                            {
                                前三周课时 = 前三周课程班级.Where(x => x.UId == user.UId).Sum(x => x.Hours);
                            }
                            double 前两周课时 = 0;
                            if (前两周课程班级.Count > 0)
                            {
                                前两周课时 = 前两周课程班级.Where(x => x.UId == user.UId).Sum(x => x.Hours);
                            }

                            if (!((本周课时 >= 18) && (前一周课时 >= 18) && (前两周课时 >= 18) && (前三周课时 >= 18)))
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
    }
}
