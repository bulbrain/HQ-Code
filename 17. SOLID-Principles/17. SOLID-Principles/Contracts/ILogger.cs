using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SOLID_Principles.Contracts
{
    interface ILogger
    {
        IList<IAppender> Appenders { get; }

        void Info(string messege);

        void Warning(string messege);

        void Error(string messege);

        void Critical(string messege);

        void Fatal(string messege);
    }
}
