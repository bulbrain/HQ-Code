using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SOLID_Principles.Contracts
{
    interface IAppender
    {
        ReportLevel TreshHold { get; set; }
        ILayout Layout { get; }

        void Append(string msg, ReportLevel reportLevel, DateTime date);
    }
}
