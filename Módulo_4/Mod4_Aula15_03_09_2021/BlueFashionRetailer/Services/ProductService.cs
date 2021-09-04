using BlueFashionRetailer.Data;
using BlueFashionRetailer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Services
{
    public class ProductService : IProductService
    {
        BFRContext _context;

        public ProductService(BFRContext context)
        {
            _context = context;
        }

        public List<Product> All()
        {
            return _context.Product.ToList();
        }

        public bool Create(Product p)
        {
            try
            {
                p.created = DateTime.Now;
                _context.Add(p);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Product Get(int? id)
        {
            return _context.Product.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(Product prod)
        {
            try
            {
                if (!_context.Product.Any(p => p.Id == prod.Id)) throw new Exception("Produto não existe!");

                prod.updated = DateTime.Now;
                _context.Update(prod);
                _context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int? id)
        {
            try
            {
                _context.Remove(this.Get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Product> ProductsByUserRole(string getRole)
        {
            //var query1 = "SELECT p.* FROM Product p " +
            //    "JOIN AspNetUsers u ON p.createdById = u.Id " +
            //    "JOIN AspNetUserRoles ur ON u.Id = ur.UserId " +
            //    "JOIN AspNetRoles r ON ur.RoleId = r.Id " +
            //    $"WHERE r.Name = '{getRole}'";

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
                              Id = product.Id,
                              Name = product.Name,
                              Price = product.Price,
                              Description = product.Description,
                              created = product.created,
                              updated = product.updated,
                              createdBy = product.createdBy,
                              updatedBy = product.updatedBy
                          };

            //var query2 = "SELECT p.* FROM AspNetRoles r " +
            //    "JOIN AspNetUserRoles ur ON r.Id = ur.RoleId" +
            //    "JOIN AspNetUsers u ON ur.UserId = u.Id" +
            //    "JOIN Product p ON p.createdById = u.Id" +
            //    $"WHERE r.Name = '{getRole}'";

            //var lquery2 = from role in _context.Set<IdentityRole>()
            //              join userRoles in _context.Set<IdentityUserRole<string>>()
            //                  on role.Id equals userRoles.RoleId
            //              join user in _context.Set<IdentityUser>()
            //                  on userRoles.UserId equals user.Id
            //              join product in _context.Set<Product>()
            //                  on user.Id equals product.createdById
            //              where role.Name.ToUpper() == getRole
            //              select new Product()
            //              {
            //                  Id = product.Id,
            //                  Name = product.Name,
            //                  Price = product.Price,
            //                  Description = product.Description,
            //                  created = product.created,
            //                  updated = product.updated,
            //                  createdById = product.createdById,
            //                  updatedById = product.updatedById,
            //              };


            //var query3 = "SELECT p.* FROM Product p, AspNetUsers u, AspNetUserRoles ur, AspNetRoles r " +
            //    "WHERE 1 = 1 " +
            //    "AND p.createdById = u.Id " +
            //    "AND ur.UserId = u.Id " +
            //    "AND r.Id = ur.RoleId " +
            //    $"AND r.Name = '{getRole}'";

            //var lquery3 = from p in _context.Set<Product>()
            //              from u in _context.Set<IdentityUser>()
            //              from ur in _context.Set<IdentityUserRole<string>>()
            //              from r in _context.Set<IdentityRole>()
            //              where 1 == 1
            //                && p.createdById == u.Id
            //                && u.Id == ur.UserId
            //                && ur.RoleId == r.Id
            //                && r.Name == getRole
            //              select new Product()
            //              {
            //                  Id = p.Id,
            //                  Name = p.Name,
            //                  Price = p.Price,
            //                  Description = p.Description,
            //                  created = p.created,
            //                  updated = p.updated,
            //                  createdById = p.createdById,
            //                  updatedById = p.updatedById,
            //              };

            //return _context.Product.FromSqlRaw(query1).ToList();
            return lquery1.ToList();
        }
    }
}
