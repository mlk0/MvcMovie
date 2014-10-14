using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        ////
        //// GET: /HelloWorld/
        //public ActionResult Index()
        //{
        //    return View();
        //}


        public string Index()
        {
            return "This is from within the Index method out of the HelloWorldController";
        }


        public string Welcome() 
        {
            return "This is from within he Welcome method";
        }


        public string WelcomeParameters(string name, int numIterations = 1) 
        {
            return HttpUtility.HtmlEncode(String.Format("Hello {0}, number of iterations is {1}.", name, numIterations));
        }


        public string WelcomeParametersAndId(string name, int id) 
        {
            return HttpUtility.HtmlEncode(String.Format("Name: {0}, id={1}",name, id));
        }


        public ActionResult Yo() 
        {
            return View();
        }

        public ActionResult YoMan()
        {
            //return View("YoMyMan.chhtml");
            return View("YoMyMan");
        }

        public ActionResult Aloha(string name="Kurto", int numTimes=3) 
        {
            ViewBag.Name = name;
            ViewBag.NumberOfItems = numTimes;

            return View();
        }
	}
}