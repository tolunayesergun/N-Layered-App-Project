using Northwind.Entities.Concrete;
using Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramewrok
{
    public class ProductEFDAL:IProductDAL
    {

        public List<Product> GetAll()
        {
            using(NorthwindContext context =new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using(NorthwindContext context=new NorthwindContext())
            {
                return context.Products.FirstOrDefault(p => p.ProductId == id);
            }
        }

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Entry(product).State= EntityState.Modified;
                context.SaveChanges();
            }

        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Entry(product).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
