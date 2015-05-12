using _17.SOLID_Principles.Contracts;
using System;

namespace _17.SOLID_Principles.Appenders
{
    public abstract class Appender : IAppender
    {
        public ILayout Layout { get; set; }

        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public abstract void Append(string msg, ReportLevel reportLevel, DateTime date);

        public ReportLevel TreshHold { get; set; }
    }
}
