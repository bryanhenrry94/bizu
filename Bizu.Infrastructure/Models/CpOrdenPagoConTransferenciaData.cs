using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdUsuario", "IdOrdenPago", "SecuenciaOp")]
[Table("cp_orden_pago_con_Transferencia_data")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenPagoConTransferenciaData
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    public int IdOrdenPago { get; set; }

    [Key]
    [Column("Secuencia_OP")]
    public int SecuenciaOp { get; set; }

    [Column("IdTipo_op")]
    [StringLength(20)]
    public string IdTipoOp { get; set; } = null!;

    [StringLength(523)]
    public string? Referencia { get; set; }

    [StringLength(34)]
    public string? Referencia2 { get; set; }

    [StringLength(20)]
    public string IdTipoPersona { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Precision(18, 0)]
    public decimal IdEntidad { get; set; }

    [Column("Fecha_OP")]
    [MaxLength(6)]
    public DateTime? FechaOp { get; set; }

    [Column("Fecha_Fa_Prov")]
    [MaxLength(6)]
    public DateTime? FechaFaProv { get; set; }

    [Column("Fecha_Venc_Fac_Prov")]
    [MaxLength(6)]
    public DateTime? FechaVencFacProv { get; set; }

    [StringLength(500)]
    public string Observacion { get; set; } = null!;

    [Column("Nom_Beneficiario")]
    [StringLength(200)]
    public string? NomBeneficiario { get; set; }

    [Column("Girar_Cheque_a")]
    [StringLength(200)]
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
    public string IdEstadoAprobacion { get; set; } = null!;

    [StringLength(20)]
    public string? IdFormaPago { get; set; }

    [Column("Fecha_Pago")]
    public DateOnly? FechaPago { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdSubCentro_Costo")]
    [StringLength(20)]
    public string? IdSubCentroCosto { get; set; }

    [Column("Cbte_cxp")]
    [Precision(18, 0)]
    public decimal CbteCxp { get; set; }

    [StringLength(2)]
    public string Estado { get; set; } = null!;

    [Column("Nom_Beneficiario_2")]
    [StringLength(266)]
    public string? NomBeneficiario2 { get; set; }

    [Column("IdEmpresa_cxp")]
    public int IdEmpresaCxp { get; set; }

    [Column("IdTipoCbte_cxp")]
    public int IdTipoCbteCxp { get; set; }

    [Column("IdCbteCble_cxp")]
    [Precision(18, 0)]
    public decimal IdCbteCbleCxp { get; set; }

    [Column("IdTipoCta_acreditacion_cat")]
    [StringLength(25)]
    public string? IdTipoCtaAcreditacionCat { get; set; }

    [Column("num_cta_acreditacion")]
    [StringLength(50)]
    public string? NumCtaAcreditacion { get; set; }

    [Column("IdBanco_acreditacion")]
    public int? IdBancoAcreditacion { get; set; }

    [Column("IdTipoDocumento_acreditacion")]
    [StringLength(25)]
    public string? IdTipoDocumentoAcreditacion { get; set; }

    [Column("cedulaRuc_acreditacion")]
    [StringLength(50)]
    public string? CedulaRucAcreditacion { get; set; }

    [Column("beneficiario_acreditacion")]
    [StringLength(200)]
    public string? BeneficiarioAcreditacion { get; set; }

    [Column("correo_acreditacion")]
    [StringLength(200)]
    public string? CorreoAcreditacion { get; set; }

    [Column("ba_descripcion")]
    [StringLength(100)]
    public string? BaDescripcion { get; set; }

    [StringLength(10)]
    public string? CodigoLegal { get; set; }

    public bool Checked { get; set; }

    [Column("IdEmpresa_pago")]
    public int? IdEmpresaPago { get; set; }

    [Column("IdTipoCbte_pago")]
    public int? IdTipoCbtePago { get; set; }

    [Column("IdCbteCble_pago")]
    [Precision(18, 0)]
    public decimal? IdCbteCblePago { get; set; }

    [Column("tipo_cbte_pago")]
    [StringLength(50)]
    public string? TipoCbtePago { get; set; }

    [Column("Secuencial_reg_x_proceso")]
    [Precision(18, 0)]
    public decimal? SecuencialRegXProceso { get; set; }

    [Column("Secuencia_ar")]
    public int SecuenciaAr { get; set; }
}
