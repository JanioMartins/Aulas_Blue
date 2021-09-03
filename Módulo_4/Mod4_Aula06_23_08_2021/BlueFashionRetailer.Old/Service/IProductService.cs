using BlueFashionRetailer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Service
{
    public interface IProductService
    {

		List<Product> All();
		Product Get(int Id);

		bool Create(Product p);

		bool Update(Product p);

		bool Delete(int? Id);

	}
}
