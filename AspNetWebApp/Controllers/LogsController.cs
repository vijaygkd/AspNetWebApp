using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetWebApp.Controllers
{
    public class LogsController : Controller
    {
        public LogsController() : base()
        {
            var x = "Heyy";
        }

        // GET: Logs
        public ActionResult Index()
        {
            return View(DataHelper.LogProvider.Logs);
        }
    }
}