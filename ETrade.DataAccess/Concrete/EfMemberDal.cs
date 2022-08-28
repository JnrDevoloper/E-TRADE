
using ETrade.DataAccess.Abstract;
using ETrade.Devframework.Core.DataAccess.EntityFramework;
using ETrade.Entities.Concrete;
using EtradeDataAccess_.Concrete;

namespace ETrade.DataAccess.Concrete
{
 public  class EfMemberDal : EfEntityRepositoryBase <Member ,Membershipcontext> ,IMemberDal
 {
    }
}
