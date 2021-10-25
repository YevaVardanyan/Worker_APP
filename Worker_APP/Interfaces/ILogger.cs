using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_APP.Interfaces
{
    interface ILogger
    {
        public void Log(string source);
        public string CreateLog(Exception ex);

    }
}
