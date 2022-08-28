using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETrade.DataAccess.Concrete.Entityframework.Mapping;
using ETrade.Entities.Concrete;

namespace ETrade.DataAccess.Concrete
{
    public class ProductShipContext : DbContext
    {
        public ProductShipContext()
        {
            Database.SetInitializer<Membershipcontext>(null);
        }

        public DbSet<Productcs> Productcs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
