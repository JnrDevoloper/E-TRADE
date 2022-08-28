using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETrade.Entities.Concrete;

namespace Etrade.Business.Abstract
{
    public interface IMemberService
    {
        List<Member> GetAll();
        Member GetById(int id);

        void Add(Member member);
        Member GetByUserNameAndPassword(string userName, string password );
    }
}
