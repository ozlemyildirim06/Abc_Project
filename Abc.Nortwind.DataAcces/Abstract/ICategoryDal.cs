using Abc.Core.DataAccess;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Nortwind.DataAcces.Abstract
{
  public interface ICategoryDal: IEntityRepository<Category>
    {
    }
}
