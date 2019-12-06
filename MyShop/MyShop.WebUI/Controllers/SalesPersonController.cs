using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.WebUI.Controllers
{
    [Authorize(Roles = "SalesPerson")]
    public class SalesPersonController : Controller
    {
        // GET: SalesPerson
        public ActionResult Index()
        {
            return View();
        }
    }
}