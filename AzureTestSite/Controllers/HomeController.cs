using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureTestSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
	        var response = new DumbClass().DoDumbThing();
            return View("Index", null, response);
        }

    }
}
