using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProj.Models;

namespace WebApiProj.Controllers
{
    public class ProductController : ApiController
    {

        Product[] products = new Product[]
        {
            new Product { id = 1, name = "Tomato Soup",desc = "Tomato Soup desc", supplier = "Groceries supplier", price = 1 },
            new Product { id = 2, name = "Yo-yo",desc = "Yo-yo desc", supplier = "Toys supplier", price = 3 },
            new Product { id = 3, name = "Hammer",desc = "Hammer desc", supplier = "Hardware supplier", price = 16 }
        };
        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post(Product product)
        {

        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
