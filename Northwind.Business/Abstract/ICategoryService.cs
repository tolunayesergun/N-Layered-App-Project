﻿using Nortwhind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
      
    }
}
