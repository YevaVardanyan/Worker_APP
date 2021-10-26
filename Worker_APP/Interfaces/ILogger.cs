using System;

namespace Worker_APP.Interfaces
{
    interface ILogger
    {
        public void Log(string source);
        public string CreateLog(Exception ex);
    }
}
