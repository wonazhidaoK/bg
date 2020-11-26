using CommonHelp;
using CommonHelp.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace bg.UserControls
{
    public partial class Uc_CentralFeeder : UserControl
    {
        readonly DataHelp help = new DataHelp();

        public Uc_CentralFeeder()
        {
            InitializeComponent();
        }

        private void Uc_CentralFeeder_Load(object sender, EventArgs e)
        {
            LoadDgv();
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

        private void LoadDgv()
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
                var classes = help.GetTAS_ClassesRecordByCourseId(new TAS_ClassesRecord { CourseID = item.ID }).ToList();
                foreach (var c in classes)
                {
                    DataRow NewRow = dt1.NewRow();
                    NewRow["Course Code"] = item.CourseCode;
                    NewRow["Course Title"] = item.CourseTitle;
                    NewRow["User ID"] = c.UId;
                    NewRow["Classes"] = c.ClasseTitle;
                    NewRow["Normal or OT"] = c.Position.Trim() == Position.TROT.Value ? "OT" : (c.Position.Trim() == Position.CT.Value ? "CT" : "");
                    dt1.Rows.Add(NewRow);
                }
            }
            this.dgvCF.DataSource = null;
            this.dgvCF.DataSource = dt1;
        }

        public void Set(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Columns.Add("Course Code", "Course Code");
            dataGridView.Columns.Add("Course Title", "Course Title");
            dataGridView.Columns.Add("User ID", "User ID");
            dataGridView.Columns.Add("Classes", "Classes");
            dataGridView.Columns.Add("Normal or OT", "Normal or OT");

        }

        private void dtSchooltime_ValueChanged(object sender, EventArgs e)
        {
            LoadDgv();
        }
    }
}
