using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogueOfShops.Models.Repository
{
    public class ShopRepository : IRepository<Shop>
    {
        private ShopContext db;

        public ShopRepository()
        {
            this.db = new ShopContext();
        }

        public IEnumerable<Shop> GetList()
        {
            return db.Shops;
        }

        public Shop GetItem(int id)
        {
            return db.Shops.Find(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}