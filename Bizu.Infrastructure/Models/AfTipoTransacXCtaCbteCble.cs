using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipTransActivoFijo", "IdCatalogo", "CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble")]
[Table("Af_TipoTransac_x_Cta_CbteCble")]
[Index("IdCatalogo", Name = "FK_Af_TipoTransac_x_Cta_CbteCble_Af_Catalogo")]
[Index("CtIdEmpresa", "CtIdTipoCbte", "CtIdCbteCble", Name = "FK_Af_TipoTransac_x_Cta_CbteCble_ct_cbtecble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfTipoTransacXCtaCbteCble
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdTipTransActivoFijo { get; set; }

    [Key]
    [StringLength(35)]
    public string IdCatalogo { get; set; } = null!;

    [Key]
    [Column("ct_IdEmpresa")]
    public int CtIdEmpresa { get; set; }

    [Key]
    [Column("ct_IdTipoCbte")]
    public int CtIdTipoCbte { get; set; }

    [Key]
    [Column("ct_IdCbteCble")]
    [Precision(18, 0)]
    public decimal CtIdCbteCble { get; set; }

    [ForeignKey("CtIdEmpresa, CtIdTipoCbte, CtIdCbteCble")]
    [InverseProperty("AfTipoTransacXCtaCbteCble")]
    public virtual CtCbtecble CtCbtecble { get; set; } = null!;

    [ForeignKey("IdCatalogo")]
    [InverseProperty("AfTipoTransacXCtaCbteCble")]
    public virtual AfCatalogo IdCatalogoNavigation { get; set; } = null!;
}
