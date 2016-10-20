using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataHelper
{
    public class LogDataProvider : IDataProvider<LogEntry>
    {
        private IEnumerable<LogEntry> _logs;

        public LogDataProvider()
        {
            _logs = SeedData.GetData();
        }

        public IEnumerable<LogEntry> GetData()
        {
            return _logs;
        }

    }
}
