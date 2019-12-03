using Abc.Core.DataAccess.EntityFramework;
using Abc.Northwind.Entities.Concrete;
using Abc.Nortwind.DataAcces.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Nortwind.DataAcces.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
