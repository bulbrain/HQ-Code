using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _17.SOLID_Principles.Contracts;

namespace _17.SOLID_Principles.Layouts
{
    class XmlLayout : ILayout
    {
        private const string LayoutFormat = "<log>\r\n <date>{0}</date>\r\n <level>{1}</level>\r\n <message>{2}</message>\r\n</log>";
        public string Format(string msg, ReportLevel reportLevel, DateTime date)
        {
            return string.Format(LayoutFormat, date, reportLevel, msg);
        }
    }
}
