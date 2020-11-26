using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonHelp
{
    public enum LogType
    {
        /// <summary>
        /// 普通日志
        /// </summary>
        InfoLog = 1,
        /// <summary>
        /// 警告级别日志
        /// </summary>
        WarnLog = 2,
        /// <summary>
        /// 错误级别日志
        /// </summary>
        ErrorLog = 4,
        /// <summary>
        /// 致命级别日志
        /// </summary>
        FatalLog = 8
    }
}
