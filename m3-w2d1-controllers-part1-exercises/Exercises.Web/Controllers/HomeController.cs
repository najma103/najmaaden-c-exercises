using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercises.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Squirrel()
        {
            return View();
        }
        public ActionResult SquirrelPartyResult()
        {
          
            if (Request.Params["numberOfSquirrels"] != null)
            {
                int numOfSquirrels = Convert.ToInt32(Request.Params["numberOfSquirrels"]);
                bool weekend = false;

                //string isWknd = Request.Params["isWeekend"];
                //bool weekend;
                //if (isWknd == "true,true")
                //{
                //    weekend = true;
                //}
                //else
                //{
                //    weekend = false;
                //}

                if ((numOfSquirrels >= 40 && numOfSquirrels <= 60 ) || weekend )
                {
                    ViewBag.Party = true;
                }
                else
                {
                    ViewBag.Party = false;
                }
            }
            return View("SquirrelPartyResult");
        }
    }
}