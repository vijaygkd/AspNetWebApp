using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHelper;
using Models;

namespace Core
{
    public class LogApiProvider : IApiProvider
    {
        private IDataProvider<LogEntry> _dataProvider;

        public LogApiProvider(IDataProvider<LogEntry> dataProvider)
        {
            this._dataProvider = dataProvider;
        }

        public IList<LogEntry> GetLogsByDate(int? year, string month, int? day)
        {
            IEnumerable<LogEntry> logs = _dataProvider.GetData();

            if (year > 0)
            {
                logs = logs
                    .Where(log => log.Year == year);
            }
            if (!string.IsNullOrWhiteSpace(month))
            {
                logs = logs
                        .Where(log => log.Month.IndexOf(month, StringComparison.OrdinalIgnoreCase) >= 0);

            }
            if (day > 0)
            {
                logs = logs
                        .Where(log => log.Day == day);
            }
            //if (!string.IsNullOrWhiteSpace(searchString))
            //{
            //    logs = logs
            //            .Where(log => log.Text.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0);

            //}

            return logs.ToList();
        }
    }
}
