using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCbleOgiro", "IdTipoCbteOgiro", "CodigoPagoSri")]
[Table("cp_orden_giro_pagos_sri")]
[Index("CodigoPagoSri", Name = "FK_cp_orden_giro_pagos_sri_cp_pagos_sri")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenGiroPagosSri
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Key]
    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Key]
    [Column("codigo_pago_sri")]
    [StringLength(25)]
    public string CodigoPagoSri { get; set; } = null!;

    [Column("formas_pago_sri")]
    [StringLength(255)]
    public string? FormasPagoSri { get; set; }

    [ForeignKey("CodigoPagoSri")]
    [InverseProperty("CpOrdenGiroPagosSri")]
    public virtual CpPagosSri CodigoPagoSriNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCbteCbleOgiro, IdTipoCbteOgiro")]
    [InverseProperty("CpOrdenGiroPagosSri")]
    public virtual CpOrdenGiro CpOrdenGiro { get; set; } = null!;
}
