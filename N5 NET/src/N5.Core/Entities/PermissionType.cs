using System;
using System.Collections.Generic;

namespace N5.Core.Entities;

public partial class PermissionType
{
    public int IdPermissionType { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
