using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
        

        // GET: Home
        public ActionResult Index()
        {
            IReviewDAL thisDAL = new ReviewSqlDAL();
            List<Review> listReviews = thisDAL.GetAllReviews();
            return View("Index", listReviews);
        } 
        
        // GET: Home/NewReview
        public ActionResult NewReview(string username, int rating, string title, string msg )
        {
            if (username != "" && rating != 0)
            {
                Review newReview = (Review)Session["NewReview"];
                IReviewDAL thisDAL = new ReviewSqlDAL();
                bool rowInserted = thisDAL.SaveReview(newReview);
                if (rowInserted)
                {
                    return View("Index");
                }
            }

            return View("NewReview");
        }      

    }
}