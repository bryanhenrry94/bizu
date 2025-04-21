using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_orden_pago_estado_aprob")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenPagoEstadoAprob
{
    [Key]
    [StringLength(10)]
    public string IdEstadoAprobacion { get; set; } = null!;

    [StringLength(250)]
    public string Descripcion { get; set; } = null!;
}
