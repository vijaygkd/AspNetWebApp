using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataHelper;

namespace AspNetWebApp.Controllers
{
    public class LogsController : Controller
    {
        public LogsController() : base()
        {
            var x = "Heyy";
        }

        // GET: Logs
        [Route("logs/{year=0}/{month=}/{day=0}")]
        public ActionResult Index(string searchString, int? year, string month, int? day)
        {
            var logs = LogProvider.Logs;

            if (year > 0)
            {
                logs = logs
                        .Where(log => log.Year == year)
                        .ToList();
            }
            if (!string.IsNullOrWhiteSpace(month))
            {
                logs = logs
                        .Where(log => log.Month.IndexOf(month, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();

            }
            if (day > 0)
            {
                logs = logs
                        .Where(log => log.Day == day)
                        .ToList();
            }
            if (!string.IsNullOrWhiteSpace(searchString))
            {
                logs = logs
                        .Where(log => log.Text.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();

            }

            return View(logs);
        }
    }
}