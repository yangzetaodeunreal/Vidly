using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private VidlyContext _context;

        public CustomersController()
        {
            _context = new VidlyContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
        // GET: Customers
        public ActionResult Index()
        {
            return View(_context.Customers.Include(mt => mt.MemberShipType));
            
        }

        //GET: Customer Details
        public ActionResult Detail(int id)
        {
            return View(_context.Customers.Include(m => m.FavoriteMovie).Single(c => c.Id == id));
        }
    }
}