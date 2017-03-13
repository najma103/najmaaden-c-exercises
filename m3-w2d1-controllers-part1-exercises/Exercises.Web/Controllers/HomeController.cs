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

        //GET: /Home/LastTwo
        public ActionResult LastTWo()
        {
            return View("LastTwo");
        }

        public ActionResult LastTwoResult()
        {
            string[] WordList = new string[10];
            if (Request.Params["w1"].Length > 1)
            {
                string word = Request.Params["w1"];
                string last = word.Substring(word.Length - 1);
                string secondFromLast = word.Substring(word.Length - 2, 1);
                WordList[0] = word.Substring(0, word.Length - 2) + last + secondFromLast;
            }
            else
            {
                WordList[0] = Request.Params["w1"];
            }
            //word 2
            if (Request.Params["w2"].Length > 1)
            {
                string word = Request.Params["w2"];
                string last = word.Substring(word.Length - 1);
                string secondFromLast = word.Substring(word.Length - 2, 1);
                WordList[1] = word + ":  " + word.Substring(0, word.Length - 2) + last + secondFromLast;
            }
            else
            {
                WordList[1] = Request.Params["w2"];
            }
            //word 3
            if (Request.Params["w3"].Length > 1)
            {
                string word = Request.Params["w3"];
                string last = word.Substring(word.Length - 1);
                string secondFromLast = word.Substring(word.Length - 2, 1);
                WordList[2] = word + ":  " + word.Substring(0, word.Length - 2) + last + secondFromLast;
            }
            else
            {
                WordList[2] = Request.Params["w3"];
            }
            //word 4
            if (Request.Params["w4"].Length > 1)
            {
                string word = Request.Params["w4"];
                string last = word.Substring(word.Length - 1);
                string secondFromLast = word.Substring(word.Length - 2, 1);
                WordList[3] = word + ":  " + word.Substring(0, word.Length - 2) + last + secondFromLast;
            }
            else
            {
                WordList[3] = Request.Params["w4"];
            }
            //word 5
            if (Request.Params["w5"].Length > 1)
            {
                string word = Request.Params["w5"];
                string last = word.Substring(word.Length - 1);
                string secondFromLast = word.Substring(word.Length - 2, 1);
                WordList[4] = word + ":  " + word.Substring(0, word.Length - 2) + last + secondFromLast;
            }
            else
            {
                WordList[4] = Request.Params["w5"];
            }

            // word 6
            if (Request.Params["w6"].Length > 1)
            {
                string word = Request.Params["w6"];
                string last = word.Substring(word.Length - 1);
                string secondFromLast = word.Substring(word.Length - 2, 1);
                WordList[5] = word + ":  " + word.Substring(0, word.Length - 2) + last + secondFromLast;
            }
            else
            {
                WordList[5] = Request.Params["w6"];
            }
            // word 7
            if (Request.Params["w7"].Length > 1)
            {
                string word = Request.Params["w7"];
                string last = word.Substring(word.Length - 1);
                string secondFromLast = word.Substring(word.Length - 2, 1);
                WordList[6] = word + ":  " + word.Substring(0, word.Length - 2) + last + secondFromLast;
            }
            else
            {
                WordList[6] = Request.Params["w7"];
            }
            //word 8
            if (Request.Params["w8"].Length > 1)
            {
                string word = Request.Params["w8"];
                string last = word.Substring(word.Length - 1);
                string secondFromLast = word.Substring(word.Length - 2, 1);
                WordList[7] = word + ":  " + word.Substring(0, word.Length - 2) + last + secondFromLast;
            }
            else
            {
                WordList[7] = Request.Params["w8"];
            }
            //word 9
            if (Request.Params["w9"].Length > 1)
            {
                string word = Request.Params["w9"];
                string last = word.Substring(word.Length - 1);
                string secondFromLast = word.Substring(word.Length - 2, 1);
                WordList[8] = word + ":  " + word.Substring(0, word.Length - 2) + last + secondFromLast;
            }
            else
            {
                WordList[8] = Request.Params["w9"];
            }
            // Word 10
            if (Request.Params["w10"].Length > 1)
            {
                string word = Request.Params["w10"];
                string last = word.Substring(word.Length - 1);
                string secondFromLast = word.Substring(word.Length - 2, 1);
                WordList[9] = word + ":  " + word.Substring(0, word.Length - 2) + last + secondFromLast;
            }
            else
            {
                WordList[9] = Request.Params["w10"];
            }
            return View("LastTwoResult", WordList);
        }

        //GET: /Home/Squirrel
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