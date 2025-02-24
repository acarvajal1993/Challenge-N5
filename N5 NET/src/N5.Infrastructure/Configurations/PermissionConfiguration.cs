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
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> entity)
        {
            entity.HasKey(e => e.Id).HasName("PK__Permissi__3214EC078E7283D1");

            entity.Property(e => e.GrantedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdEmployeeNavigation).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.IdEmployee)
                .HasConstraintName("FK__Permissio__IdEmp__4E88ABD4");

            entity.HasOne(d => d.IdPermissionTypeNavigation).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.IdPermissionType)
                .HasConstraintName("FK__Permissio__IdPer__4F7CD00D");
        }
    }
}
