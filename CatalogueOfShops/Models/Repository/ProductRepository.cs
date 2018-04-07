using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogueOfShops.Models.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private ShopContext db;

        public ProductRepository()
        {
            this.db = new ShopContext();
        }

        public IEnumerable<Product> GetList()
        {
            return db.Products;
        }

        public Product GetItem(int id)
        {
            return db.Products.Find(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}