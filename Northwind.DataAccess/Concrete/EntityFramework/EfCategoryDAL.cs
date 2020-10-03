using Northwind.DataAccess.Concrete.EntityFramewrok;
using Nortwhind.Entities.Concrete;
using Nortwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDAL:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDAL
    {
    }
}
