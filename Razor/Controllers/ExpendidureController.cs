using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class ExpendidureController : Controller
    {
        // GET: Expendidure
        public ActionResult Index()
        {
            List<Expendidure> depense = new List<Expendidure>
            {
                new Expendidure("iphone",new DateTime(2021,10,10),800),
                new Expendidure("four",new DateTime(2018,09,10),200),
                new Expendidure("pc",new DateTime(2021,10,06),500),
            };

            return View(depense);
        }
    }
}