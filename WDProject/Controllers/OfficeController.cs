using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Common;
using DataSource;

namespace WDProject.Controllers
{
    public class OfficeController : Controller
    {
        // GET: Office
        public ActionResult Index()
        {
            var db = DBConnection.DisplayHoliday();
            return View(db);
        }

        //public ActionResult CheckWorkingDay()
        //{
        //    return View();
        //}
    }
}