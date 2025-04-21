using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaBancoEstadoCheques
{
    public int IdEmpresa { get; set; }

    [Column("IdEstado_Concil_Cat")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoConcilCat { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Column("checked")]
    public bool Checked { get; set; }

    [Column("Estado_Conciliacion")]
    [StringLength(20)]
    public string? EstadoConciliacion { get; set; }

    public int IdTipocbte { get; set; }
}
