using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
