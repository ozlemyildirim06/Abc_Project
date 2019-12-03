using Abc.Core.DataAccess.EntityFramework;
using Abc.Nortwind.DataAcces.Abstract;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Abc.Nortwind.DataAcces.Concrete.EntityFramework
{
  public  class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {

    }
}
