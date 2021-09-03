using BlueFashionRetailer.Models;
using Microsoft.AspNetCore.Identity;
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

        List<Product> ProducsByUserRole(string getRole)
        {
            //var query1 = "SELECT p.* FROM Product p " +
            //"JOIN AspNetUsers u ON p.createdById = u.Id " +
            //"JOIN AspNetUserRoles ur ON u.Id = ur.UserId " +
            //"JOIN AspNetRoles r ON ur.RoleId = r.Id " +
            //$"WHERE r.Name = '{role}'";

            var lquery1 = from product in _context.Set<Product>()
                          join user in _context.Set<IdentityUser>()
                            on product.createdById equals user.Id
                          join userRoles in _context.Set<IdentityUserRole<string>>()
                            on user.Id equals userRoles.UserId
                          join role in _context.Set<IdentityRole>()
                            on userRoles.RoleId equals role.Id
                          where role.Name.ToUpper() == getRole
                          select new Product()
                          {
                                id = product.id,
                                name = product.name,
                                price = product.price,
                                description = product.description,
                                created = product.created,
                                updated = product.updated,
                                createdById = product.createdById,
                                updatedById = product.updatedById,
                          };

            //return _context.Product.FromSqlRaw(query1).ToList();
        }
    }
}