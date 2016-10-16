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
        public ActionResult Index(string searchString)
        {
            var logs = LogProvider.Logs;

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                logs = DataHelper.LogProvider.Logs
                        .Where(log => log.Text.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();

            }           

            return View(logs);
        }
    }
}