﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
  public class CustomersController : Controller
  {
    // GET: Customers
    public ActionResult Index()
    {
      var customers = new List<Customer>
      {
        new Customer { Id = 1, Name = "John Smith" },
        new Customer { Id = 2, Name = "Mary Williams" }
      };

      var viewModel = new RandomMovieViewModel
      {
        Movie = null,
        Customers = customers
      };

      return View(viewModel);
    }

    [Route("Customers/Details/{id}")]
    public ActionResult Details(int id)
    {
      var customers = new List<Customer>
      {
        new Customer { Id = 1, Name = "John Smith" },
        new Customer { Id = 2, Name = "Mary Williams" }
      };

      var customer = customers.Where(cust => cust.Id == id).SingleOrDefault();

      if (customer == null)
        return HttpNotFound();

      return View(customer);
    }
  }
}