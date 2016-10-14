using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    public static class LogProvider
    {
        public static LogEntry[] Logs;

        public static void Init()
        {
            Logs = FileOps.ReadLogs();
        }
    }
}
