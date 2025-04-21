using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdCobro")]
[Table("cxc_cobro_Obra")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroObra
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [StringLength(20)]
    public string? CodObra { get; set; }
}
