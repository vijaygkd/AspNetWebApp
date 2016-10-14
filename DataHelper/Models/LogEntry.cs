using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace DataHelper
{
    [DelimitedRecord(","), IgnoreFirst(1)]
    public class LogEntry
    {
        public int Day;

        [FieldQuoted()]
        public string Month;

        public int Year;

        //public DateTime Date
        //{
        //    get
        //    {
        //        var dateFormat = "d MMMM YYYY";
        //        var dateString = $"{this.Day} {this.Month} {this.Year}";
        //        return DateTime.ParseExact(dateString, dateFormat, CultureInfo.InvariantCulture);
        //    }
        //}

        [FieldQuoted()]
        public string Text;
    }
}
