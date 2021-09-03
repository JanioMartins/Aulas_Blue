using BlueFashionRetailer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Services
{
    public interface IProductService
    {
        List<Product> All();
        Product Get(int? id);
        bool Create(Product p);
        bool Update(Product p);
        bool Delete(int? id);
    }
}
