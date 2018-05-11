using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        public CustomersController()
        {

        }

        // Get /api/customers
        public IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };

            return customers;
        }

        // GET /api/customers/1
        public Customer GetCustomer(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };

            var customer = customers.Where(cust => cust.Id == id).SingleOrDefault();

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return customer;
        }
    }
}
