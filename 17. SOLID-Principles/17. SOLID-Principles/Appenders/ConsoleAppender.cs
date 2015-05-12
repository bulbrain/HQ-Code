using System;
using _17.SOLID_Principles.Contracts;

namespace _17.SOLID_Principles.Appenders
{
    class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public ReportLevel ReportLevel { get; set; }

        public override void Append(string msg, ReportLevel reportLevel, DateTime date)
        {
            if (TreshHold <= reportLevel)
            {
                var formattedMessege = this.Layout.Format(msg, reportLevel, date);
                Console.WriteLine(formattedMessege);
            }
        }
    }
}
