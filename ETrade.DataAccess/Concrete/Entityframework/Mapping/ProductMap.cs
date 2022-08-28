using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETrade.Entities.Concrete;

namespace ETrade.DataAccess.Concrete.Entityframework.Mapping
{
    class ProductMap : EntityTypeConfiguration<Productcs>
    {
        public ProductMap()
        {
            ToTable(@"Products", @"dbo");

            HasKey(x => x.ProductId);

            Property(x => x.ProductName).HasColumnName("ProductName");
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.ColorId).HasColumnName("ColorId");
            Property(x => x.Price).HasColumnName("Price");
        }
    }
}
