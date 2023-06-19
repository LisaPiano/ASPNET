using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.ComponentModel.Design;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn; 
        public ProductRepository(IDbConnection conn) { 
            _conn = conn;
        
        
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _conn.Query<Products>("SELECT * FROM Products");
        }
    }
}
