using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etrade.Business.Abstract;
using ETrade.DataAccess.Abstract;
using ETrade.Entities.Concrete;

namespace Etrade.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Productcs product)
        {
            _productDal.Add( product);
        }
    }
}
