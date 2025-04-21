using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProveedor", "IdUsuario")]
[Table("cp_proveedor_Filtro")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpProveedorFiltro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Key]
    [StringLength(25)]
    public string IdUsuario { get; set; } = null!;
}
