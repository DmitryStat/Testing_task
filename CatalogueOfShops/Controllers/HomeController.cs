using CatalogueOfShops.Models;
using CatalogueOfShops.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatalogueOfShops.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Shop> dbShops;
        IRepository<Product> dbProducts;

        public HomeController()
        {
            dbShops = new ShopRepository();
            dbProducts = new ProductRepository();
        }

        public ActionResult Index()
        {
            ViewBag.Shops = dbShops.GetList();

            return View();
        }

        public ActionResult ShowProducts(int id)
        {
            var currentProducts = dbProducts.GetList().Where(prod => prod.ShopId.Equals(id)).ToList();

            return PartialView(currentProducts);
        }
    }
}