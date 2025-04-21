using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt005
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenPago { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoPersona { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Precision(18, 0)]
    public decimal? IdEntidad { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdFormaPago { get; set; } = null!;

    [Column("Fecha_Pago")]
    public DateOnly FechaPago { get; set; }

    public int? IdBanco { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    public int Secuencia { get; set; }

    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [Column("Valor_a_pagar")]
    public double ValorAPagar { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Referencia { get; set; }

    [Column("IdTipo_op")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoOp { get; set; } = null!;

    [Column("nom_Banco")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomBanco { get; set; }

    [Column("nom_PagoTipo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomPagoTipo { get; set; } = null!;

    [Column("nom_FormaPago")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomFormaPago { get; set; } = null!;

    [Column("nom_beneficiario")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomBeneficiario { get; set; }

    [Column("nom_EstadoAprobacion")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEstadoAprobacion { get; set; } = null!;

    [Column("IdUsuario_Aprobacion")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprobacion { get; set; }

    [Column("fecha_hora_Aproba")]
    [MaxLength(6)]
    public DateTime? FechaHoraAproba { get; set; }

    [Column("Motivo_aproba")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAproba { get; set; }

    [Column("num_CuentaBanco")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumCuentaBanco { get; set; }

    [Column("valor_factura")]
    public double? ValorFactura { get; set; }

    [Column("saldo")]
    public double? Saldo { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [Column("co_total")]
    public double? CoTotal { get; set; }

    [Column("Total_Retencion")]
    public double TotalRetencion { get; set; }
}
