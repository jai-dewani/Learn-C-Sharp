using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        static List<string> products = new List<string>()
        {
            "string0","string1","string2"
        };

        public IEnumerable<string> GetAllProducts()
        {
            return products;
        }

        public string GetProduct(int id)
        {
            return products[id];
        }

        public void PostProduct([FromBody] string value)
        {
            products.Add(value);
        }

        public void PutProduct(int id, [FromBody] string value)
        {
            products[id] = value;
        }

        public void DeleteProduct(int id)
        {
            products.RemoveAt(id);
        }
    }
}
