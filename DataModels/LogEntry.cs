using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class LogEntry
    {
        public int Day { get; set; }

        public string Month { get; set; }

        public int Year { get; set; }

        public DateTime Date
        {
            get
            {
                var dateFormat = "d MMMM YYYY";
                var dateString = $"{this.Day} {this.Month} {this.Year}";
                return DateTime.ParseExact(dateString, dateFormat, CultureInfo.InvariantCulture);
            }
        }

        public string Text { get; set; }
    }
}
