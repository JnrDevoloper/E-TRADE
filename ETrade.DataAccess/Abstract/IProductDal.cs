using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETrade.Devframework.Core.DataAccess;
using ETrade.Entities.Concrete;

namespace ETrade.DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Productcs>
    {
    }
}
