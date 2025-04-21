using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdOrdenPago", "IdArchivo", "IdUsuario")]
[Table("cp_orden_pago_x_IdArchivo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenPagoXIdArchivo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenPago { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdArchivo { get; set; }

    [Key]
    [StringLength(25)]
    public string IdUsuario { get; set; } = null!;
}
