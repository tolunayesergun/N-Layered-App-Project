using Northwind.Entities.Concrete;
using Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Nortwind.DataAccess.Concrete.EntityFramework;

namespace Northwind.DataAccess.Concrete.EntityFramewrok
{
    public class ProductEFDAL :EfEntityRepositoryBase<Product,NorthwindContext>, IProductDAL
    {
    }
}
