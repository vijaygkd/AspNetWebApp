using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace Models
{
    [DelimitedRecord(","), IgnoreFirst(1)]
    public class LogEntry
    {
        public int Day;

        [FieldQuoted()]
        public string Month;

        public int Year;



        [FieldQuoted()]
        public string Text;
    }
}
