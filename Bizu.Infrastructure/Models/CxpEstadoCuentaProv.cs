using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("cxp_EstadoCuenta_Prov")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class CxpEstadoCuentaProv
{
    public int? IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? RazonSocial { get; set; }

    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    [Column(TypeName = "mediumtext")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Documento { get; set; }

    public DateOnly? Fecha { get; set; }

    [Precision(10, 2)]
    public decimal? Debe { get; set; }

    [Precision(10, 2)]
    public decimal? Haber { get; set; }

    [Precision(11, 2)]
    public decimal? Saldo { get; set; }

    [Column("IdEmpresa_pago")]
    public int? IdEmpresaPago { get; set; }

    [Column("IdTipoCbte_pago")]
    public int? IdTipoCbtePago { get; set; }

    [Column("IdCbteCble_pago")]
    [Precision(18, 0)]
    public decimal? IdCbteCblePago { get; set; }

    [Column("Observacion_pago", TypeName = "mediumtext")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ObservacionPago { get; set; }

    public int? Orden { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Tipo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }
}
