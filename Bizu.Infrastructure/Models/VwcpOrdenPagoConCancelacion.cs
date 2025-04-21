using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpOrdenPagoConCancelacion
{
    [Precision(21, 0)]
    public decimal Fila { get; set; }

    public int IdEmpresa { get; set; }

    [Column("IdTipo_op")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoOp { get; set; } = null!;

    [Column(TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Referencia { get; set; } = null!;

    [StringLength(54)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Referencia2 { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenPago { get; set; }

    [Column("Secuencia_OP")]
    public int? SecuenciaOp { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoPersona { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Precision(18, 0)]
    public decimal? IdEntidad { get; set; }

    [Column("Fecha_OP")]
    [MaxLength(6)]
    public DateTime FechaOp { get; set; }

    [Column("Fecha_Fa_Prov")]
    [MaxLength(6)]
    public DateTime FechaFaProv { get; set; }

    [Column("Fecha_Venc_Fac_Prov")]
    [MaxLength(6)]
    public DateTime FechaVencFacProv { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("Nom_Beneficiario")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomBeneficiario { get; set; }

    [Column("Girar_Cheque_a")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? GirarChequeA { get; set; }

    [Column("Valor_a_pagar")]
    public double ValorAPagar { get; set; }

    [Column("Valor_estimado_a_pagar_OP")]
    public double ValorEstimadoAPagarOp { get; set; }

    [Column("Total_cancelado_OP")]
    public double TotalCanceladoOp { get; set; }

    [Column("Saldo_x_Pagar_OP")]
    public double SaldoXPagarOp { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdFormaPago { get; set; } = null!;

    [Column("Fecha_Pago")]
    public DateOnly? FechaPago { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdSubCentro_Costo")]
    [MaxLength(0)]
    public byte[]? IdSubCentroCosto { get; set; }

    [Column("Cbte_cxp")]
    [Precision(18, 0)]
    public decimal? CbteCxp { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("Nom_Beneficiario_2")]
    [StringLength(264)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomBeneficiario2 { get; set; }

    [Column("IdEmpresa_cxp")]
    public int? IdEmpresaCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int? IdTipoCbteCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCxp { get; set; }

    public int? IdBanco { get; set; }
}
