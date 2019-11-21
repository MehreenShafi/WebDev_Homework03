using System;
using Homework3WebApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework3WebApplication.Context;


namespace Homework3WebApplication.Controllers
{
    public class PricesController : Controller
    {
        private PricesContext context = new PricesContext();

        public ActionResult Index() //get last 3
        {
            PricesContext con = new PricesContext();
            var prods = con.Prices.ToList();
            prods = prods.Skip(Math.Max(0, prods.Count() - 3)).ToList();
            return View(prods); 
        }
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Prices());
        }
        [Authorize]
        [HttpPost]
        public ActionResult Create(Prices price)
        {
            if (ModelState.IsValid)
            {
                context.Prices.Add(price);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {

                return View(price);
            }

        }
    }
}