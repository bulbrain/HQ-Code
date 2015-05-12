using System;
using _17.SOLID_Principles.Contracts;

namespace _17.SOLID_Principles.Layouts
{
    class SimpleLayout : ILayout
    {

        private const string LayoutFormat = "{0} - {1} - {2}";
        public string Format(string msg, ReportLevel reportLevel, DateTime date)
        {
            return string.Format(LayoutFormat, date, reportLevel, msg);
        }
    }
}
