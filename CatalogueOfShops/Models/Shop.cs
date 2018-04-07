using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogueOfShops.Models
{
    public class Shop
    {
        public int Id { get; set; }
        
        public string NameOfShop { get; set; }

        public string Address { get; set; }

        public string WorkRegime { get; set; }
    }
}