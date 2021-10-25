using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker_APP.Interfaces;

namespace Worker_APP
{
    class Logger : ILogger
    {
        public string CreateLog(Exception ex)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("--------------------");
            builder.AppendLine(ex.Message);
            builder.Append(ex.Source);
            builder.Append(ex.StackTrace);
            return builder.ToString();
        }

        public void Log(string source)
        {
            string path = Directory.GetCurrentDirectory();
            path = Path.Combine(new string[] { path, "log" });
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path = Path.Combine(new string[] { path, "logs.text" });
            if (!File.Exists(path))
                File.Create(path);
            File.WriteAllText(path, source);

           
        }
    }
}
