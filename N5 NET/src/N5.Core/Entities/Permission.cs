using System;
using System.Collections.Generic;

namespace N5.Core.Entities;

public partial class Permission
{
    public int Id { get; set; }

    public int IdEmployee { get; set; }

    public int IdPermissionType { get; set; }

    public DateTime GrantedDate { get; set; }

    public virtual Employee IdEmployeeNavigation { get; set; } = null!;

    public virtual PermissionType IdPermissionTypeNavigation { get; set; } = null!;
}
