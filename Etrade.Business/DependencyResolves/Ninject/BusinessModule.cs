using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etrade.Business.Abstract;
using Etrade.Business.Concrete;
using ETrade.DataAccess.Abstract;
using ETrade.DataAccess.Concrete;
using Ninject.Modules;

namespace Etrade.Business.DependencyResolves.Ninject
{
    public class BusinessModule :NinjectModule
    {
        public override void Load()
        {
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();
            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

        }
    }
}
