namespace CommonHelp.Models
{
   public class TAS_User
    {
        public int ID { get; set; }

        /// <summary>
        /// 存储短名称
        /// </summary>
        public string UId { get; set; }
        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// 职工编号
        /// </summary>
        public string StaffNo { get; set; }


        public string Type { get; set; }
    }
}
