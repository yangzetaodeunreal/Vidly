using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

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


        public ActionResult New()
        {
            NewCustomerViewModel ViewModel = new NewCustomerViewModel
            {
                MemberShipTypes = _context.MemberShipTypes.ToArray()
            };
            return View(ViewModel);
        }

        [HttpPost]
        public ActionResult Create(NewCustomerViewModel viewModel)
        {
            return RedirectToAction("Index", "Customers");
        }

        //GET: Customer Details
        public ActionResult Detail(int id)
        {
            return View(_context.Customers.Include(mt => mt.MemberShipType).Single(c => c.Id == id));
        }
    }
}