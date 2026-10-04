using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practical_6.Models;

namespace practical_6.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> P = new List<Product>();
            P = GetProducts();
            return View(P);
        }

        public ActionResult Details(int id)
        {
            List<Product> PALL = GetProducts();
            Product P1 = PALL.FirstOrDefault(p => p.ProductId == id);
            return View(P1);
        }

        private List<Product> GetProducts()
        {

            return new List<Product>
            {
                new Product { ProductId = 1, Name = "Product 1", Price = 1099.0 , Description = "This is Product 1" ,Category = "Electronics"},
                new Product { ProductId = 2, Name = "Product 2", Price = 1999.0 , Description = "This is Product 2" ,Category = "Electronics"},
                new Product { ProductId = 3, Name = "Product 3", Price = 599.0 , Description = "This is Product 3" ,Category = "Electronics"}
            };
        }
    }
}