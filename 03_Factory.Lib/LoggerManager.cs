using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Factory.Lib
{
    public class LoggerManager
    {
        private Dictionary<LogTypes, ILoggerFactory> loggers;

        public LoggerManager()
        {
            loggers = new Dictionary<LogTypes, ILoggerFactory>();
            loggers.Add(LogTypes.FileLogger,new FileLoggerFactory());
            loggers.Add(LogTypes.DbLogger,new DbLoggerFactory());
        }

        public ILoggerFactory CreateFactory(LogTypes logType)
        {
            return loggers[logType];
        }
    }

    public enum LogTypes
    {
        FileLogger,
        DbLogger
    }
}
