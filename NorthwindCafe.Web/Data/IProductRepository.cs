using NorthwindCafe.Web.Models;
using System.Collections.Generic;

namespace NorthwindCafe.Web.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}