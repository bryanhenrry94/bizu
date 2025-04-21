using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpOrdenGiroCpNotaDebCreEstcue
{
    public int IdEmpresa { get; set; }

    public int IdTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? RazonSocial { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [StringLength(93)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Documento { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public double BaseImponible { get; set; }

    [Column("IVA")]
    public double Iva { get; set; }

    public double Total { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;
}
