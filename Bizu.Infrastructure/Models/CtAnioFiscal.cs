using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ct_anio_fiscal")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtAnioFiscal
{
    [Key]
    public int IdanioFiscal { get; set; }

    [Column("af_fechaIni")]
    public DateOnly AfFechaIni { get; set; }

    [Column("af_fechaFin")]
    public DateOnly AfFechaFin { get; set; }

    [Column("af_estado")]
    [StringLength(1)]
    public string AfEstado { get; set; } = null!;

    [InverseProperty("IdanioFiscalNavigation")]
    public virtual ICollection<CtAnioFiscalXCuentaUtilidad> CtAnioFiscalXCuentaUtilidad { get; set; } = new List<CtAnioFiscalXCuentaUtilidad>();

    [InverseProperty("CbAnioNavigation")]
    public virtual ICollection<CtCbtecble> CtCbtecble { get; set; } = new List<CtCbtecble>();

    [InverseProperty("IdanioFiscalNavigation")]
    public virtual ICollection<CtPeriodo> CtPeriodo { get; set; } = new List<CtPeriodo>();

    [InverseProperty("IdAnioFNavigation")]
    public virtual ICollection<CtSaldoxCuentas> CtSaldoxCuentas { get; set; } = new List<CtSaldoxCuentas>();

    [InverseProperty("IdAnioFNavigation")]
    public virtual ICollection<CtSaldoxCuentasMovi> CtSaldoxCuentasMovi { get; set; } = new List<CtSaldoxCuentasMovi>();
}
