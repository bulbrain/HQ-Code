using System;
using System.Collections.Generic;
using _17.SOLID_Principles.Appenders;
using _17.SOLID_Principles.Contracts;
namespace _17.SOLID_Principles.Loggers
{
    class Logger : ILogger
    {
        public IList<IAppender> Appenders { get; private set; }

        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>(appenders);
        }

        public void Info(string messege)
        {
            this.Log(messege, ReportLevel.Info);
        }

        public void Warning(string messege)
        {
            this.Log(messege, ReportLevel.Warn);
        }

        public void Error(string messege)
        {
            this.Log(messege, ReportLevel.Error);
        }

        public void Critical(string messege)
        {
            this.Log(messege, ReportLevel.Critical);
        }

        public void Fatal(string messege)
        {
            this.Log(messege, ReportLevel.Fatal);
        }

        private void Log(string msg, ReportLevel reportLevel)
        {
            foreach (var appender in this.Appenders)
            {
                var date = DateTime.Now;
                appender.Append(msg, reportLevel, date);
            }
        }
    }
}
