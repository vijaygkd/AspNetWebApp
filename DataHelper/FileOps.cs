using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using Microsoft.VisualBasic.FileIO;
using Models;

namespace DataHelper
{
    internal static class FileOps
    {
        private static string FilePath = "C:\\MySource\\Repo\\AspNetWebApp\\DataHelper\\data\\columbus.csv";

        public static List<LogEntry> ReadLogs()
        {
            var engine = new FileHelperEngine<LogEntry>();
            var logs = engine.ReadFileAsList(FilePath);
            return logs;
        }

    }
}
