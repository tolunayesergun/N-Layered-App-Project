using Northwind.Entities.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramewrok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager
    {
        // ProductEFDAL _productDAL = new ProductEFDAL();
        private IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public List<Product> GetAll()
        {         
            return _productDAL.GetAll();
        }

        public void Delete(Product product)
        {
            _productDAL.Delete(product);
        }

    }
}
