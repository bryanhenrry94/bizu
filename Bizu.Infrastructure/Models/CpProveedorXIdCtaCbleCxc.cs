using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProveedor", "IdCtaCbleCxc")]
[Table("cp_proveedor_x_IdCtaCble_CXC")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpProveedorXIdCtaCbleCxc
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Key]
    [Column("IdCtaCble_CXC")]
    [StringLength(20)]
    public string IdCtaCbleCxc { get; set; } = null!;
}
