namespace CommonHelp.Models
{
    /// <summary>
    /// 职员职责
    /// </summary>
    public class TAS_Duty
    {
        public int ID { get; set; }

        public string StaffNo { get; set; }

        /// <summary>
        /// 成本中心
        /// </summary>
        public string CostCentre { get; set; }

        public double Hours { get; set; }

        /// <summary>
        /// 责任
        /// </summary>
        public string Duty { get; set; }
    }
}
