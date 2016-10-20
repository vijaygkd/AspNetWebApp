using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class LogEntryExtensions
    {
        public static DateTime GetDateTime(this LogEntry log)
        {
            //return new datetime from log object
            var dateFormat = "d/MMMM/yyyy";
            var dateString = $"{log.Day}/{log.Month}/{log.Year}";
            return DateTime.ParseExact(dateString, dateFormat, null);
        }
    }
}
