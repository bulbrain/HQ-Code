using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SOLID_Principles.Contracts
{
    public interface ILayout
    {
        string Format(string msg, ReportLevel reportLevel, DateTime date);
    }
}