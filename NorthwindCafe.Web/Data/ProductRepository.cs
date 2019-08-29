using NorthwindCafe.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindCafe.Web.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly NorthwindContext _context;

        public ProductRepository(NorthwindContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.OrderBy(p => p.Name).ToList();
        }
    }
}