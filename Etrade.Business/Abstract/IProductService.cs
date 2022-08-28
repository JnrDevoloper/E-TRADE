using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETrade.Entities.Concrete;

namespace Etrade.Business.Abstract
{
    public interface IProductService
    {
        void Add(Productcs product);
    }
}
