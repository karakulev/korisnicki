using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RouteController : Controller
    {
        private RouteDbContext _context;

        public RouteController() {
            _context = new RouteDbContext();
        }
        [Authorize]
        public ActionResult Create() {
            Route model = new Route();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(Route route)
        {
            _context.routes.Add(route);
            _context.SaveChanges();
            return View("Index", _context.routes.ToList());
        }

            // GET: Route
            public ActionResult Index()
        {

            return View(_context.routes.ToList());
        }
    }
}