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

        public ActionResult xOrderedName()
        {
            return View("xOrderedName");
        }

        public ActionResult xOrderedNameResult()
        {
            string firstName = Request.Params["fName"];
            string lastName = Request.Params["lName"];
            string middleInit = Request.Params["mInitial"];

            string orderName = Request.Params["order"];
            ViewBag.FirstName = firstName;
            ViewBag.Middle = middleInit;
            ViewBag.LastName = lastName;

            if (firstName != "" && lastName != "")
            {
                if (orderName == "firstMidleLast")
                {
                    ViewBag.Message = "Ordered:  "
                                    + firstName + " "
                                    + middleInit + " "
                                    + lastName;
                }
                else if (orderName == "firstLast")
                {
                    ViewBag.Message = "Ordered:  "
                                    + firstName + " "
                                    + lastName;
                }
                else if (orderName == "lastFirstMiddle")
                {
                    ViewBag.Message = "Ordered:  "
                                    + lastName + ", "
                                    + firstName + " "
                                    + middleInit;
                } 
                else if (orderName == "lastFirst")
                {
                    ViewBag.Message = "Ordered: "
                                    + lastName + ", "
                                    + firstName;
                }
            }
            return View("xOrderedNameResult");
        }

        public ActionResult ColorizedName()
        {
            return View("ColorizedName");
        }

        public ActionResult ColorizedResult()
        {
            string firstName = Request.Params["fName"];
            string lastName = Request.Params["lName"];

            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;

            if (Request.Params["Red"].Contains("true"))
            {
                ViewBag.Red = "Red";
            }
            if (Request.Params["Blue"].Contains("true"))
            {
                ViewBag.Blue = "Blue";
            }
            if (Request.Params["Green"].Contains("true"))
            {
                ViewBag.Green = "Green";
            }

            return View("ColorizedResult");
        }

        //GET: /Home/FizzBuzzRevisited
        public ActionResult FizzBuzzRevisited()
        {
            return View("FizzBuzzRevisited");
        }

        public ActionResult FizzBuzzRevisitedResult()
        {
            string[] fizzbuzzList = new string[5];
            string altFizz = Request.Params["Fizz"];
            string altBuzz = Request.Params["Buzz"];
            int divisibleOne = 0;
            int divisibleTwo = 0;

            int[] numbers = new int[5];
            numbers[0] = Convert.ToInt32(Request.Params["num1"]);
            numbers[1] = Convert.ToInt32(Request.Params["num2"]);
            numbers[2] = Convert.ToInt32(Request.Params["num3"]);
            numbers[3] = Convert.ToInt32(Request.Params["num4"]);
            numbers[4] = Convert.ToInt32(Request.Params["num5"]);

            ViewBag.DivOne = Request.Params["firstDivisable"];
            ViewBag.DivTwo = Request.Params["secondDivisable"];
            ViewBag.AltFizz = altFizz;
            ViewBag.AltBuzz = altBuzz;

            if (Request.Params["FirstDivisable"] != "")
            {
                divisibleOne = Convert.ToInt32(Request.Params["firstDivisable"]);
            }

            if (Request.Params["SecondDivisable"] != "")
            {
                divisibleTwo = Convert.ToInt32(Request.Params["SecondDivisable"]);
            }

            if (divisibleOne != 0 && divisibleTwo != 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % divisibleOne == 0 && numbers[i] % divisibleTwo == 0)
                    {
                        fizzbuzzList[i] = numbers[i].ToString() + "  " + altFizz + altBuzz;
                    }
                    else if (numbers[i] % divisibleOne == 0)
                    {
                        fizzbuzzList[i] = numbers[i].ToString() + "  " + altFizz;
                    }
                    else if (numbers[i] % divisibleTwo == 0)
                    {
                        fizzbuzzList[i] = numbers[i].ToString() + "  " + altBuzz;
                    }
                    else
                    {
                        fizzbuzzList[i] = numbers[i].ToString();
                    }
                }
            }



            return View("FizzBuzzRevisitedResult", fizzbuzzList);
        }
        public ActionResult Squirrel()
        {
            return View();
        }
        public ActionResult SquirrelPartyResult()
        {
          
            if (Request.Params["numberOfSquirrels"] != "")
            {
                int numOfSquirrels = Convert.ToInt32(Request.Params["numberOfSquirrels"]);
                bool weekend = false;

                string isWknd = Request.Params["isWeekend"];
                
                if (isWknd.Contains("true"))
                {
                    weekend = true;
                }

                if ((numOfSquirrels >= 40 && numOfSquirrels <= 60 ) || weekend )
                {
                    ViewBag.Party = true;
                }
                else
                {
                    ViewBag.Party = false;
                }
            }
            else
            {
                return View("Squirrel");
            }

            return View("SquirrelPartyResult");

        }
    }
}