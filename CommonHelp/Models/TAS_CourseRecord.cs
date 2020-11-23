using System;

namespace CommonHelp.Models
{
    public class TAS_CourseRecord
    {
        public int ID { get; set; }

        public string CourseCode { get; set; }

        public string CourseTitle { get; set; }

        ///// <summary>
        ///// CourseType
        ///// </summary>
        //public string Type { get; set; }

        //public double Hours { get; set; }

        public string Dept { get; set; }

        ///// <summary>
        ///// 短名称
        ///// </summary>
        //public string UId { get; set; }

        public DateTime Schooltime { get; set; }

        #region 这里不是清晰当前处理为各个成本中心的学生数
        public int HQ { get; set; }

        public int UNITA { get; set; }

        public int UNITB { get; set; }

        public int UNITC { get; set; }

        public int ITGY { get; set; }

        public int MSAF { get; set; }

        public int SMG { get; set; } 
        #endregion
    }
}
