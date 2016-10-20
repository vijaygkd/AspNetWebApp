using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Core
{
    /// <summary>
    /// Methods exposing core business functionality
    /// </summary>
    public interface IApiProvider
    {
        IList<LogEntry> GetLogsByDate(int? year, string month, int? day);
    }
}
