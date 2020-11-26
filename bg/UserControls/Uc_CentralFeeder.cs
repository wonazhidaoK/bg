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

            Set(dgvCF);
            var list = CourseRecords.ToList();
            foreach (var item in list)
            {
                var classes = help.GetTAS_ClassesRecordByCourseId(new TAS_ClassesRecord { CourseID = item.ID }).FirstOrDefault();

                if (classes != null)
                {
                    this.dgvCF.RowCount = list.Count();
                    foreach (DataGridViewRow row in this.dgvCF.Rows)
                    {
                        row.Cells[0].Value = item.CourseCode.Trim();
                        row.Cells[1].Value = item.CourseTitle.Trim();
                        row.Cells[2].Value = classes.UId.ToString().Trim();
                        row.Cells[3].Value = classes.ClasseTitle.ToString().Trim();
                    }
                }
            }
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
