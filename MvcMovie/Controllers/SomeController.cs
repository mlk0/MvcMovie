using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class SampleModel {
        public int SampleId {get;set;}
        public string Name {get;set;}
    }
    public class SomeController : Controller
    {
        //
        // GET: /Some/
        public ActionResult Index()
        {
            return View();       
        }


        public ActionResult New() {
            return View();
        }

        public ActionResult Details(int id) 
        {
            return View(new SampleModel{SampleId = id, Name ="Imeto"});
        }

        public ActionResult Edit(int id) 
        {
            return View(new SampleModel { SampleId = id, Name = "Imeto" });
        }
	}
}