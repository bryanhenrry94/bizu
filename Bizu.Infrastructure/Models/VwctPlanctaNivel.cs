using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctPlanctaNivel
{
    public int IdEmpresa { get; set; }

    public int IdNivelCta { get; set; }

    [Column("nv_NumDigitos")]
    public int NvNumDigitos { get; set; }

    [Column("nv_Descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NvDescripcion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }

    [Column("nv_NumDigitos_total")]
    [Precision(32, 0)]
    public decimal? NvNumDigitosTotal { get; set; }
}
