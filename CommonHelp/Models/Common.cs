using System.Collections.Generic;

namespace CommonHelp.Models
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role
    {
        static Role()
        {
            CADM = new Role { Name = "Course Administrator", Value = "CADM" };
            CDSR = new Role { Name = "Course Designer", Value = "CDSR" };
        }

        public string Value { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Course administrator --课程管理员
        /// </summary>
        public static Role CADM { get; set; }

        /// <summary>
        /// Course Designer        --课程设计师
        /// </summary>
        public static Role CDSR { get; set; }

        public static IEnumerable<Role> GetAll() => new List<Role>() { CADM, CDSR };
    }

    /// <summary>
    /// 教师类型
    /// </summary>
    public class Teacher_type
    {
        static Teacher_type()
        {
            T = new Teacher_type { Name = "Trainer", Value = "TR" };
            C = new Teacher_type { Name = "Contractor", Value = "CT" };
        }

        public string Value { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 教师
        /// </summary>
        public static Teacher_type T { get; set; }

        /// <summary>
        /// 承包商
        /// </summary>
        public static Teacher_type C { get; set; }

        public static IEnumerable<Teacher_type> GetAll() => new List<Teacher_type>() { T, C };
    }

    /// <summary>
    /// 职称
    /// </summary>
    public class Title
    {
        static Title()
        {
            EG = new Title { Name = "EG", Value = "e.g." };
            Mr = new Title { Name = "Mr", Value = "Mr." };
            Ms = new Title { Name = "Ms", Value = "Ms" };
            Mrs = new Title { Name = "Mrs", Value = "Mrs" };
            Dr = new Title { Name = "Dr", Value = "Dr" };
            Ir = new Title { Name = "Ir", Value = "Ir" };
            JP = new Title { Name = "JP", Value = "JP" };
        }

        public string Value { get; set; }

        public string Name { get; set; }

        public static Title EG { get; set; }

        public static Title Mr { get; set; }

        public static Title Ms { get; set; }

        public static Title Mrs { get; set; }

        public static Title Dr { get; set; }

        public static Title Ir { get; set; }

        public static Title JP { get; set; }

        public static IEnumerable<Title> GetAll() => new List<Title>() { EG, Mr, Ms, Mrs , Dr , Ir , JP };

    }

    /// <summary>
    /// admin teacher
    /// </summary>
    public class UserType
    {
        static UserType()
        {
            Admin = new UserType { Name = "Admin", Value = "Admin" };
            Teacher = new UserType { Name = "Teacher", Value = "Teacher" };
        }
        public string Value { get; set; }

        public string Name { get; set; }


        public static UserType Admin { get; set; }

        public static UserType Teacher { get; set; }

        public static IEnumerable<UserType> GetAll() => new List<UserType>() { Admin, Teacher  };
    }

    public class Dept
    {
        static Dept()
        {
            ITGY = new Dept { Name = "ITGY", Value = "ITGY" };
            MGAF = new Dept { Name = "MGAF", Value = "MGAF" };
        }

        public string Value { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Information Technology 信息技术
        /// </summary>
        public static Dept ITGY { get; set; }

        /// <summary>
        /// Management, Accounting & Finance 管理,会计&财务
        /// </summary>
        public static Dept MGAF { get; set; }

        public static IEnumerable<Dept> GetAll() => new List<Dept>() { MGAF, ITGY };
    }

    /// <summary>
    /// 成本中心
    /// </summary>
    public class Cost_Centre
    {
        static Cost_Centre()
        {
            UNITA = new Cost_Centre { Name = "UNITA", Value = "UNITA" };
            HQ = new Cost_Centre { Name = "HQ", Value = "HQ" };
            UNITB = new Cost_Centre { Name = "UNITB", Value = "UNITB" };
            UNITC = new Cost_Centre { Name = "UNITC", Value = "UNITC" };
            ITGY = new Cost_Centre { Name = "ITGY", Value = "ITGY" };
            MSAF = new Cost_Centre { Name = "MSAF", Value = "MSAF" };
            SMG = new Cost_Centre { Name = "SMG", Value = "SMG" };
        }

        public string Value { get; set; }

        public string Name { get; set; }

        public static Cost_Centre UNITA { get; set; }
        public static Cost_Centre HQ { get; set; }
        public static Cost_Centre UNITB { get; set; }
        public static Cost_Centre UNITC { get; set; }
        public static Cost_Centre ITGY { get; set; } 
        public static Cost_Centre MSAF { get; set; }
        public static Cost_Centre SMG { get; set; }

        public static IEnumerable<Cost_Centre> GetAll() => new List<Cost_Centre>() { UNITA, HQ , UNITB, UNITC, ITGY, MSAF , SMG };
    }

    public class CourseType
    {
        static CourseType()
        {
            L = new CourseType { Name = "L", Value = "Lessons" };
            T = new CourseType { Name = "T", Value = "Tele-lessons" };
        }

        public string Value { get; set; }

        public string Name { get; set; }

        public static CourseType L { get; set; }

        public static CourseType T { get; set; }

        public static IEnumerable<CourseType> GetAll() => new List<CourseType>() { L, T };
    }


    public  class Position
    {

        static Position()
        {
            ChiefTR = new Position { Name = "ChiefTR", Value = "Chief TR" };
            OtherTR = new Position { Name = "OtherTR", Value = "Other TR" };
            TempTR = new Position { Name = "TempTR", Value = "Temp TR" };
            TROT = new Position { Name = "TROT", Value = "TR OT" };
            CT = new Position { Name = "CT", Value = "CT" };
            //TR = new Position { Name = "TR", Value = "TR" };
        }
        public string Value { get; set; }

        public string Name { get; set; }
        public static Position ChiefTR { get; set; }
        public static Position OtherTR { get; set; }
        public static Position TempTR  { get; set; }
        public static Position TROT { get; set; }
        public static Position CT { get; set; }
        //public static Position TR { get; set; }
        public static IEnumerable<Position> GetAll() => new List<Position>() { ChiefTR,OtherTR, TempTR, TROT, CT };
        public static IEnumerable<Position> GetMGAFAll() => new List<Position>() { ChiefTR, OtherTR, TempTR, TROT, CT };
        public static IEnumerable<Position> GetITGYAll() => new List<Position>() { ChiefTR, OtherTR, TempTR, TROT };
    }

    public class ExlcHeadStr
    {
        static ExlcHeadStr()
        {
            MGAF = new List<string>
            {
                "Course Code","Course Title"
            };
            foreach (var item in Cost_Centre.GetAll())
            {
                MGAF.Add(item.Value);
            }
            foreach (var item in Position.GetMGAFAll())
            {
                MGAF.Add(item.Value);
                MGAF.Add(item.Value + " classes");
            }
            ITGY = new List<string>();
            foreach (var item in Position.GetITGYAll())
            {
                ITGY.Add(item.Value);
                ITGY.Add(item.Value+ " classes");
            }
            ITGY.Add("Course Code");
            ITGY.Add("Course Title"); 
        }
        public static List<string> ITGY { get; set; }

        public static List<string> MGAF { get; set; }
    }
}
