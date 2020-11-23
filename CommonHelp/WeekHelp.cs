using System;

namespace CommonHelp
{
    public static class WeekHelp
    {
        /// <summary>
        /// 根据第几周和星期几获取具体的某天的日期
        /// </summary>
        /// <param name="year"></param>
        /// <param name="week">第几周</param>
        /// <param name="day">周几（1、2、3、4、5、6、7）</param>
        /// <returns>返回指定的日期</returns>
        public static DateTime GetTimeByWeek(int? year, int? week, int? day)
        {
            if (year == null) year = 2019;
            if (week == null) week = 1;
            if (day == null) day = 1;
            DateTime dt = Convert.ToDateTime(year + "-1-1");
            int i = dt.DayOfWeek - DayOfWeek.Monday;
            if (i == -1) i = 6;
            TimeSpan ts = new TimeSpan(i, 0, 0, 0);
            dt = dt.Subtract(ts).AddDays((week.Value - 1) * 7);//获取周一
            dt = dt.AddDays(day.Value - 1);//获取指定的某天
            return dt;
        }
        /// <summary>
        /// 根据日期获取第几周
        /// </summary>
        /// <param name="dtime"></param>
        /// <returns></returns>
        public static int GetWeekByTime(DateTime dtime)
        {
            //确定此时间在一年中的位置
            int dayOfYear = dtime.DayOfYear;
            //当年第一天
            DateTime tempDate = new DateTime(dtime.Year, 1, 1);
            //确定当年第一天
            int tempDayOfWeek = (int)tempDate.DayOfWeek;
            tempDayOfWeek = tempDayOfWeek == 0 ? 7 : tempDayOfWeek;
            //确定星期几
            int index = (int)dtime.DayOfWeek;
            index = index == 0 ? 7 : index;

            //当前周的范围
            DateTime retStartDay = dtime.AddDays(-(index - 1));
            DateTime retEndDay = dtime.AddDays(6 - index);

            //确定当前是第几周
            int weekIndex = (int)Math.Ceiling(((double)dayOfYear + tempDayOfWeek - 1) / 7);

            if (retStartDay.Year < retEndDay.Year)
            {
                weekIndex = 1;
            }

            return weekIndex;
        }

        /// <summary>
        /// 求某年有多少周
        /// </summary>
        /// <param name="dtime"></param>
        /// <returns></returns>
        public static int GetWeeksOfYear(DateTime dtime)
        {
            int countDay = DateTime.Parse(dtime.Year + "-12-31").DayOfYear;
            int countWeek = countDay / 7;
            return countWeek;
        }

        /// <summary>
        /// 获取某月的第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetFirstDayOfMonth(DateTime dt)
        {
            return dt.AddDays(1 - dt.Day);
        }

        /// <summary>
        /// 获取某月的最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetLastDayOfMonth(DateTime dt)
        {
            return dt.AddDays(1 - dt.Day).AddMonths(1).AddDays(-1);
        }

        /// <summary>
        /// 获取指定周起止时间描述
        /// </summary>
        /// <param name="year"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public static string GetWeekStartToEndDay(int year, int week)
        {
            DateTime startTime = GetTimeByWeek(year, week, 1);
            DateTime endTime = GetTimeByWeek(year, week, 7);
            return string.Format("{0:yyyy-MM-dd}~{1:yyyy-MM-dd}", startTime, endTime);
        }
    }
}
