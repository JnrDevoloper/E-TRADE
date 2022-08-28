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
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public List<Member> GetAll()
        {
            return _memberDal.GetList();
        }

        public Member GetById(int id)
        {
            return _memberDal.Get(x => x.UserId==id);
        }

        public void Add(Member member)
        {
            _memberDal.Add(member);
        }
        
        public Member GetByUserNameAndPassword(string userName, string password)
        {
          
            //(member);
            return _memberDal.Get(u => u.UserName == userName & u.Password == password);
        }

        private void CheckUserRoleName(Member member)
        {
            if (_memberDal.Get(x => x.RoleId == 3) != null)
            {
                throw new Exception("Bu Kullanıcı ürün kaydı yapamaz");
            }

            
        }
    }
}
