using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using Microsoft.VisualBasic.FileIO;

namespace DataHelper
{
    internal static class FileOps
    {
        private static string FilePath = "C:\\MySource\\Repo\\AspNetWebApp\\DataHelper\\data\\columbus.csv";

        public static LogEntry[] ReadLogs()
        {
            var engine = new FileHelperEngine<LogEntry>();
            var logs = engine.ReadFile(FilePath);
            return logs;
        }

    }
}
