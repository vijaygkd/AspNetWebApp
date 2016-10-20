using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core;
using DataHelper;
using Models;

namespace AspNetWebApp.Controllers
{
    public class LogsController : Controller
    {
        private IApiProvider _apiProvider;

        public LogsController() : base()
        {
            _apiProvider = new LogApiProvider(new LogDataProvider());
        }

        // GET: Logs
        [Route("logs/{year=0}/{month=}/{day=0}")]
        public ActionResult Index(string searchString, int? year, string month, int? day)
        {
            //data validation of input varibles

            var logs = _apiProvider.GetLogsByDate(year, month, day);

            return View(logs.ToList());
        }
    }
}