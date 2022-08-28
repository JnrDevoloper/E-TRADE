using System.Data.Entity;
using ETrade.Entities.Concrete;
using EtradeDataAccess_.Concrete.Entityframework.Mapping;

namespace ETrade.DataAccess.Concrete
{
    public class Membershipcontext : DbContext
    {
        public Membershipcontext()
        {
            Database.SetInitializer<Membershipcontext>(null);
        }

        public DbSet<Member> Members { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
        }
    }
}
    

