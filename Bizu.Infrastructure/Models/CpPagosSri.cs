using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_pagos_sri")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpPagosSri
{
    [Column("formas_pago_sri")]
    [StringLength(255)]
    public string FormasPagoSri { get; set; } = null!;

    [Key]
    [Column("codigo_pago_sri")]
    [StringLength(25)]
    public string CodigoPagoSri { get; set; } = null!;

    [InverseProperty("CodigoPagoSriNavigation")]
    public virtual ICollection<CpOrdenGiroPagosSri> CpOrdenGiroPagosSri { get; set; } = new List<CpOrdenGiroPagosSri>();
}
