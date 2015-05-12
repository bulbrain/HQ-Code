using System;
using _17.SOLID_Principles.Contracts;
using _17.SOLID_Principles.Layouts;

namespace _17.SOLID_Principles.Appenders
{
    class FileAppender : Appender
    {
        

        public FileAppender(ILayout layout) : base(layout)
        {
        }


        public override void Append(string msg, ReportLevel reportLevel, System.DateTime date)
        {
            if (TreshHold <= reportLevel)
            {
                var formattedMessege = this.Layout.Format(msg, reportLevel, date);
                System.IO.File.WriteAllText(this.File, formattedMessege);
            }
        }

        public string File { get; set; }
    }
}
