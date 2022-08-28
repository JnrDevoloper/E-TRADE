using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETrade.Entities.Concrete;

namespace EtradeDataAccess_.Concrete.Entityframework.Mapping
{
    class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            ToTable(@"User", @"dbo");

            HasKey(x => x.UserId);

            
            Property(x => x.RoleId).HasColumnName("RoleId");
            Property(x => x.UserName).HasColumnName("UserName");
            Property(x => x.Password).HasColumnName("Password");



        }

        
        }
    }

