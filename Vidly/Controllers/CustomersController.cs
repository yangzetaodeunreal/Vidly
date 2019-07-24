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
        //dbcontext
        private VidlyContext _context;

        public CustomersController()
        {
            //initialize dbcontext
            _context = new VidlyContext();
        }

       
        protected override void Dispose(bool disposing)
        {
            //dispose dbcontext when controller diposed
            _context.Dispose();
            base.Dispose(disposing);
        }

        // GET: Customers
        public ActionResult Index()
        {
            return View(_context.Customers.Include(mt => mt.MemberShipType));
            
        }


        //new action for genrate new page
        public ActionResult New()
        {
            CustomerFormViewModel ViewModel = new CustomerFormViewModel
            {
                MemberShipTypes = _context.MemberShipTypes.ToArray(),
                Customer = new Customer { Id = 0 }
               
            };
            return View("CustomerForm", ViewModel);
        }

        //save action for update or insert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (ModelState.IsValid == false)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MemberShipTypes = _context.MemberShipTypes.ToArray()
                };

                return View("CustomerForm", viewModel);
            }

            //dropbox no select,default to 0
            if (customer.MemberShipTypeId == null)
                customer.MemberShipTypeId = 0;

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


        //edit action for genrate edit page
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