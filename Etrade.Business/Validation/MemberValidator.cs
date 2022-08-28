using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETrade.Entities.Concrete;
using FluentValidation;

namespace Etrade.Business.Validation
{
    public class MemberValidator :AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
