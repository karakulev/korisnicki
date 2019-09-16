using PrivateTransport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrivateTransport.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private RouteDbContext _context;

        public HomeController() {
            _context = new RouteDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "HOW IT WORKS";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult CreateRoute() {
            Route model = new Route();
            return View(model);
        }
        [Authorize]
        [HttpPost]
        public ActionResult CreateRoute(Route model) {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _context.routes.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Transports", _context.routes.ToList());
        }
        public ActionResult Transports() {
            var list = _context.routes.ToList();
            return View(list);
        }
    }
}