using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueOfShops.Models.Repository
{
    interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetList();

        T GetItem(int id);
    }
}
