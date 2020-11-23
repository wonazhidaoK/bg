using CommonHelp;
using CommonHelp.Models;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
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
            var CourseRecords = help.GetTAS_CourseRecordAll().Where(x=>x.Schooltime>= timeS&& x.Schooltime<= timeE);

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

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<WorksheetModel> worksheets = new List<WorksheetModel>();

            NewMethod1(worksheets);

            NewMethod3(worksheets);
            NewMethod2(worksheets);

            DataTableToExcel(worksheets); 
        }

        private void NewMethod3(List<WorksheetModel> worksheets)
        {
            var timeS = new DateTime(dtSchooltime.Value.Year, dtSchooltime.Value.Month, 1, 00, 00, 00);

            var timeE = GetCurrentMonthLastDay(timeS);
            var CourseRecords = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= timeS && x.Schooltime <= timeE);
            var list = CourseRecords.ToList();
            System.Data.DataTable dt1 = new System.Data.DataTable();
            dt1.Columns.Add("TR");
            dt1.Columns.Add("TR classes");
            dt1.Columns.Add("TR Hours");
            dt1.Columns.Add("Course Code");
            dt1.Columns.Add("Course Title");
            foreach (var item in list)
            {
                var classes = help.GetTAS_ClassesRecordByCourseId(new TAS_ClassesRecord { CourseID = item.ID }).FirstOrDefault();
                if (classes!=null) 
                {
                    DataRow NewRow = dt1.NewRow();
                    NewRow["TR"] = classes.UId;
                    NewRow["TR classes"] = classes.ClasseTitle;
                    NewRow["TR Hours"] = classes.Hours;
                    NewRow["Course Code"] = item.CourseCode;
                    NewRow["Course Title"] = item.CourseTitle;

                    dt1.Rows.Add(NewRow);
                }
            }

            worksheets.Add(new WorksheetModel
            {
                Table = dt1,
                Title = "",
                WorksheetName = "Dept Feeder-ITGY",
                HeadStr = null
            });
        }

        private void NewMethod2(List<WorksheetModel> worksheets)
        {
            var timeS = new DateTime(dtSchooltime.Value.Year, dtSchooltime.Value.Month, 1, 00, 00, 00);

            var timeE = GetCurrentMonthLastDay(timeS);
            var CourseRecords = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= timeS && x.Schooltime <= timeE);
            var list = CourseRecords.Where(x => x.Dept.Trim() == Dept.MGAF.Value.ToString()).ToList();
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
                WorksheetName = "Dept Feeder-MGAF",
                HeadStr = null

            });
        }

        private void NewMethod1(List<WorksheetModel> worksheets)
        {
            var timeS = new DateTime(dtSchooltime.Value.Year, dtSchooltime.Value.Month, 1, 00, 00, 00);

            var timeE = GetCurrentMonthLastDay(timeS);
            var CourseRecords = help.GetTAS_CourseRecordAll().Where(x => x.Schooltime >= timeS && x.Schooltime <= timeE);
            var list = CourseRecords.Where(x => x.Dept.Trim() == Dept.ITGY.Value.ToString()).ToList();
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
                    NewRow["Normal or OT"] = classes.Position.Trim()== Position.TROT.Value?"OT": (classes.Position.Trim() == Position.CT.Value ? "CT" : "");
                    dt1.Rows.Add(NewRow);
                }
            }
            worksheets.Add(new WorksheetModel
            {
                Table = dt1,
                Title = "",
                WorksheetName = "Central Feeder",
                HeadStr = new string[5] { "Course Code", "Course Title", "User ID", "Classes", "Normal or OT" }

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
                NewMethod(item.Table, item.HeadStr, item.WorksheetName, excelApp, workBook, i);
                i++;
            }

            //设置Excel可见
            excelApp.Visible = true;
        }

        private static void NewMethod(System.Data.DataTable dataTable, string[] strHead, string worksheetName, Microsoft.Office.Interop.Excel.Application excelApp, Workbook workBook,int worksheetIndex)
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

        private void dtSchooltime_ValueChanged(object sender, EventArgs e)
        {
            LoadDgv();
        }
    }
}
