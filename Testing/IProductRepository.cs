using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Products>GetAllProducts();
    }
}
