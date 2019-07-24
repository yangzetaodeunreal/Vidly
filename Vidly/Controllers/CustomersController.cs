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
            CustomerFormViewModel ViewModel = new CustomerFormViewModel
            {
                MemberShipTypes = _context.MemberShipTypes.ToArray()
            };
            return View("CustomerForm", ViewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                //TryUpdateModel(customerInDb); //Security hole
                customerInDb.Name = customer.Name;
                customerInDb.MemberShipTypeId = customer.MemberShipTypeId;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.IsSubscribed = customer.IsSubscribed;
                customerInDb.FavoriteMovie = customer.FavoriteMovie;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.Single(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MemberShipTypes = _context.MemberShipTypes.ToArray()
            };

            return View("CustomerForm", viewModel);
        }

        //GET: Customer Details
        public ActionResult Detail(int id)
        {
            return View(_context.Customers.Include(mt => mt.MemberShipType).Single(c => c.Id == id));
        }
    }
}