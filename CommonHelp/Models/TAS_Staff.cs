namespace CommonHelp.Models
{
    public  class TAS_Staff
    {
        public int ID { get; set; }

        /// <summary>
        /// 职员编号
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 成本中心
        /// </summary>
        public string CostCentre { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        public string Dept { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public string Role { get; set; }
    }
}
