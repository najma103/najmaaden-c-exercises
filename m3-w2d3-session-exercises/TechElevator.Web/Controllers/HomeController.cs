using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using TechElevator.Web.Models;

namespace TechElevator.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Page1(Favorites model)
        {
            
            return View("Page1", model);
        }
        public ActionResult Page2(Favorites model)
        {
            Session["Color"] = model.FavoriteColor;
            return View("Page2", model);
        }

        public ActionResult Page3(Favorites model)
        {
            Session["Food"] = model.FavoriteFood;
            return View("Page3", model);
        }
        public ActionResult Summary(Favorites model)
        {
            Session["Season"] = model.FavoriteSeason;
            Favorites favorites = new Favorites();
            favorites.FavoriteColor = (string)Session["Color"];
            favorites.FavoriteFood = (string)Session["Food"];
            favorites.FavoriteSeason = (string)Session["Season"];
                        
         
            return View("Summary", favorites);
        }
    }
}