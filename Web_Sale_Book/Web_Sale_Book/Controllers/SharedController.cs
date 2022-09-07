using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Sale_Book.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult _Layout()
        {
            return View();
        }
        public ActionResult _Login()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}