using BlueFashionRetailer.Models;
using System.Collections.Generic;

namespace BlueFashionRetailer.Services
{
    public interface IProductService
    {
        List<Product> All();
        bool Delete(int? id);
        bool Create(Product p);
        Product Get(int? id);
        bool Update(Product p);
        List<Product> ProductsByUserRole(string role);
    }
}