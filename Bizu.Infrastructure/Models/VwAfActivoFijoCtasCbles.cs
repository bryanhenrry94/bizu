using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwAfActivoFijoCtasCbles
{
    public int IdEmpresa { get; set; }

    public int IdActivoFijo { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoCuenta { get; set; } = null!;

    [Precision(21, 0)]
    public decimal Secuencia { get; set; }

    [Column("porc_distribucion")]
    public double PorcDistribucion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    public long IdActijoFijoTipo { get; set; }
}
