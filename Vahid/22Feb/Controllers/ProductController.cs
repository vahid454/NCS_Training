using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _22febMVC.Controllers
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
     
    }
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            List<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel { Id = 111, Name = "Internet of things"});
            products.Add(new ProductModel { Id = 121, Name = "Machine Learning" });
            products.Add(new ProductModel { Id = 131, Name = "Artificial Intelligence" });
            products.Add(new ProductModel { Id = 141, Name = "SAPs" });

            products.Add(new ProductModel { Id = 151, Name = "Cloud" });
            ViewBag.Products= products;


            return View();
        }
    }
}