﻿using Northwind.Entities.Concrete;
using Nortwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDAL:IEntityRepository<Product>
    {
     
    }
}
