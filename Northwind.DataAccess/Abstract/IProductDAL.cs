using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDAL
    {

         List<Product> GetAll();

         Product Get(int id);

         void Add(Product product);

         void Update(Product product);

         void Delete(Product product);


    }
}
