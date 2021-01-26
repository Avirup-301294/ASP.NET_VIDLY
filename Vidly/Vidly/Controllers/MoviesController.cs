using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var Customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = Customers
            };
             return View(viewModel);

            /* ViewData["RandomMovie"] = movie;
             ViewBag.RandomMovie = movie; */

             // return View(); 

             // return View(movie);

            // return Content("Hello");
            // return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { Page = 1, sortBy = "name" });
        }
       /* public ActionResult Edit(int id)
        {
            return Content("Id: " + id);
        } */
        // movies
       /* public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("PageIndex={0}&SortBy={1}", pageIndex, sortBy));
        } */

        /* [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")] */
        /* public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        } */

    }
}