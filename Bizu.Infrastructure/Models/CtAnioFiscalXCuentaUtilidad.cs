using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdanioFiscal", "IdCtaCble")]
[Table("ct_anio_fiscal_x_cuenta_utilidad")]
[Index("IdanioFiscal", Name = "FK_ct_anio_fiscal_x_cuenta_utilidad_ct_anio_fiscal")]
[Index("IdEmpresaCbteCierre", "IdTipoCbteCbteCierre", "IdCbteCbleCbteCierre", Name = "FK_ct_anio_fiscal_x_cuenta_utilidad_ct_cbtecble")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ct_anio_fiscal_x_cuenta_utilidad_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtAnioFiscalXCuentaUtilidad
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdanioFiscal { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Column("observacion")]
    [StringLength(50)]
    public string? Observacion { get; set; }

    [Column("IdEmpresa_cbte_cierre")]
    public int? IdEmpresaCbteCierre { get; set; }

    [Column("IdTipoCbte_cbte_cierre")]
    public int? IdTipoCbteCbteCierre { get; set; }

    [Column("IdCbteCble_cbte_cierre")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCbteCierre { get; set; }

    [ForeignKey("IdEmpresaCbteCierre, IdTipoCbteCbteCierre, IdCbteCbleCbteCierre")]
    [InverseProperty("CtAnioFiscalXCuentaUtilidad")]
    public virtual CtCbtecble? CtCbtecble { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CtAnioFiscalXCuentaUtilidad")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [ForeignKey("IdanioFiscal")]
    [InverseProperty("CtAnioFiscalXCuentaUtilidad")]
    public virtual CtAnioFiscal IdanioFiscalNavigation { get; set; } = null!;
}
