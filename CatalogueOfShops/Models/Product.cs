using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogueOfShops.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string NameOfProduct { get; set; }

        public string Description { get; set; }

        public int ShopId { get; set; }
    }
}