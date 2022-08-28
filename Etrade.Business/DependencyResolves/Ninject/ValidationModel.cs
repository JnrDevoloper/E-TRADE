using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etrade.Business.Validation;
using ETrade.Entities.Concrete;
using FluentValidation;
using Ninject.Modules;

namespace Etrade.Business.DependencyResolves.Ninject
{
    class ValidationModel : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Member>>().To<MemberValidator>().InSingletonScope();
        }
    }
}
