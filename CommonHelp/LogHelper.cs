using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonHelp
{
    public  class LogHelper
    {
        public static LogHelper logHelper = new LogHelper();
        private readonly static ILog _errorLog = LogManager.GetLogger("ErrorLog");
        private readonly static ILog _infoLog = LogManager.GetLogger("InfoLog");
        private readonly static ILog _warnLog = LogManager.GetLogger("WarnLog");
        private readonly static ILog _fatalLog = LogManager.GetLogger("FatalLog");
        public  LogHelper()
        {
            //获取配置文件全称
            string str = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".log4net.config";
            //读取配置文件
            System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(str);
            log4net.Config.XmlConfigurator.Configure(stream);
        }

        /// <summary>
        /// 普通日志信息
        /// </summary>
        /// <param name="msg">日志内容</param>
        /// <param name="stackTrace">位置跟踪</param>
        public void InfoLog(string msg, string stackTrace)
        {
            Log(LogType.InfoLog, msg, stackTrace);
        }

        /// <summary>
        /// 警告级日志信息
        /// </summary>
        /// <param name="msg">日志内容</param>
        /// <param name="stackTrace">位置跟踪</param>
        public void WarnLog(string msg, string stackTrace)
        {
            Log(LogType.WarnLog, msg, stackTrace);
        }

        /// <summary>
        /// Error级日志信息
        /// </summary>
        /// <param name="msg">日志内容</param>
        /// <param name="stackTrace">位置跟踪</param>
        public void ErrorLog(string msg, string stackTrace)
        {
            Log(LogType.ErrorLog, msg, stackTrace);
        }
        /// <summary>
        /// 致命级日志信息
        /// </summary>
        /// <param name="msg">日志内容</param>
        /// <param name="stackTrace">位置跟踪</param>
        public void FatalLog(string msg, string stackTrace)
        {

            Log(LogType.FatalLog, msg, stackTrace);
        }

        /// <summary>
        /// 记录日志通用方法 
        /// </summary>
        /// <param name="ltype">所添加日志类型，LogType枚举</param>
        /// <param name="logs">所添加的日志信息</param>
        public void Log(LogType ltype, params string[] logs)
        {
            string msg = string.Join("\n", logs);
            switch (ltype)
            {
                case LogType.InfoLog:
                    if (_infoLog.IsInfoEnabled) _infoLog.Info(msg);
                    break;
                case LogType.WarnLog:
                    if (_warnLog.IsWarnEnabled) _warnLog.Warn(msg);
                    break;
                case LogType.ErrorLog:
                    if (_errorLog.IsErrorEnabled) _errorLog.Error(msg);
                    break;
                case LogType.FatalLog:
                    if (_fatalLog.IsFatalEnabled) _fatalLog.Fatal(msg);
                    break;
            }
        }
    }
}
