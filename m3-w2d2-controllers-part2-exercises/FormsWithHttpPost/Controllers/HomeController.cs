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
        public ActionResult NewReview(Review model )
        {
            if (model.Username != "" && model.Rating != 0 && model.Title != "")
            {
                Review newReview = model;
                IReviewDAL thisDAL = new ReviewSqlDAL();
                bool rowInserted = thisDAL.SaveReview(newReview);
                if (rowInserted)
                {
                    List<Review> listReviews = thisDAL.GetAllReviews();
                    return View("Index", listReviews);
                }
            }

            return View("NewReview");
        }  

    }
}