using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N5.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace N5.Infrastructure.Configurations
{
    public class PermissionTypeConfiguration : IEntityTypeConfiguration<PermissionType>
    {
        public void Configure(EntityTypeBuilder<PermissionType> entity)
        {
            entity.HasKey(e => e.IdPermissionType).HasName("PK__Permissi__F9915DAF97D65B5A");

            entity.Property(e => e.Description).HasMaxLength(255);
        }
    }
}
