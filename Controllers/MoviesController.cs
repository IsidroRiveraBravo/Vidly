using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            //
             return View(movie);
            
            // return Content("Hello World");
            // return HttpNotFound();
            // return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, SortBy = "name" });
        }

        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";

            return Content(string.Format("pageindex={0} & sortBy={1}", pageIndex, sortBy));

        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}