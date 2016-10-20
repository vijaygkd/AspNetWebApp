using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataHelper
{
    public static class SeedData
    {
        private static List<LogEntry> _data;

        /// <summary>
        /// Initialize the data seeding from source file.
        /// </summary>
        /// <returns></returns>
        public static void Init()
        {
            _data = FileOps.ReadLogs().ToList();
        }

        /// <summary>
        /// Returns new collection of data.
        /// </summary>
        /// <returns></returns>
        public static IList<LogEntry> GetData()
        {
            return _data.Select(i => i).ToList();
        }
    }
}
