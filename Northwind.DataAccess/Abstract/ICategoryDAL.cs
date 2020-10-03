using Nortwhind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.DataAccess.Abstract
{
    public interface ICategoryDAL:IEntityRepository<Category>
    {
    }
}
