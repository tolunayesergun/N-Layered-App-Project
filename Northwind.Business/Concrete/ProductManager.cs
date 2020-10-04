

using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using NorthWind.Business.Abstract;
using Nortwhind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
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

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDAL.GetAll(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDAL.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Add(Product product)
        {
            _productDAL.Add(product);
        }

        public void Update(Product product)
        {
            _productDAL.Update(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDAL.Delete(product);
            }
            catch (DbUpdateException)
            {
                throw new Exception("Silme Başarısız Oldu");
            }
            
        }
    }
}
