﻿using System;
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
      var customers = new List<Customer>
      {
        new Customer { Name = "Customer 1" },
        new Customer { Name = "Customer 2" }
      };

      var viewModel = new RandomMovieViewModel
      {
        Movie = movie,
        Customers = customers
      };

      //ViewData["Movie"] = movie;
      //ViewBag.Movie = movie;

      return View(viewModel);
      //return Content("Hello World!");
      //return HttpNotFound();
      //return new EmptyResult();
      //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
    }

    public ActionResult Edit(int id)
    {
      return Content("id=" + id);
    }

    // Movies
    public ActionResult Index(int? pageIndex, String sortBy)
    {
      if (!pageIndex.HasValue)
        pageIndex = 1;

      if (String.IsNullOrEmpty(sortBy))
        sortBy = "Name";

      return Content(String.Format("pageIndex{0}&sortBy={1}", pageIndex, sortBy));
    }

    [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
    public ActionResult ByReleaseYear(int year, String month)
    {
      return Content(year + "/" + month);
    }
  }
}