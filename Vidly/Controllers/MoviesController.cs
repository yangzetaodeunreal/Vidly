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
    public class MoviesController : Controller
    {
        public VidlyContext _context;

        public MoviesController()
        {
            _context = new VidlyContext();
        }

        public ActionResult Index()
        {
            return View(_context.Movies.Include(g => g.Genre));

        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            return View(_context.Movies.Single(m => m.Id == id));
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Id = 2, Name = "Shark With You" };
            var customers = new List<Customer>()
            {
                new Customer() {Id = 1, Name = "Peter"},
                new Customer() {Id = 2, Name = "John"},
                new Customer() {Id = 3, Name = "Jared"},
                new Customer() {Id = 4, Name = "TGold"}

            };
            var viewModel = new RandomMovieViewModel() {movie = movie, Customer = customers};


            ViewData["Movie"] = movie;
            ViewBag.Movie = movie;

            return View(viewModel);
        }

        public ActionResult status(int id, string name)
        {   

            return Content(string.Format("Your id is {0}, and your name is {1}", id, name));

        }

        [Route("movies/released/{year:range(1900, 2050)}/{month:range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(month + "/" + year);
        }
    }
}