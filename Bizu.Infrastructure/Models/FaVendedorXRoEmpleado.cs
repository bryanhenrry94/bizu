using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdVendedor", "IdEmpleado")]
[Table("fa_vendedor_x_ro_empleado")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaVendedorXRoEmpleado
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdVendedor { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdEmpleado { get; set; }

    [ForeignKey("IdEmpresa, IdVendedor")]
    [InverseProperty("FaVendedorXRoEmpleado")]
    public virtual FaVendedor FaVendedor { get; set; } = null!;
}
