using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETrade.DataAccess.Abstract;
using ETrade.Devframework.Core.DataAccess.EntityFramework;
using ETrade.Entities.Concrete;

namespace ETrade.DataAccess.Concrete
{
    public class EfProductDal :EfEntityRepositoryBase<Productcs,ProductShipContext>,IProductDal
    {
    }
}
