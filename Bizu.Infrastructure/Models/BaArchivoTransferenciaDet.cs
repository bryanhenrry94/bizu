using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdArchivo", "Secuencia")]
[Table("ba_Archivo_Transferencia_Det")]
[Index("IdEstadoRegistroCat", Name = "FK_ba_Archivo_Transferencia_Det_ba_Catalogo1")]
[Index("IdEmpresaPago", "IdTipoCbtePago", "IdCbteCblePago", Name = "FK_ba_Archivo_Transferencia_Det_ct_cbtecble")]
[Index("IdEmpresa", "IdArchivo", "Secuencia", Name = "IX_ba_Archivo_Transferencia_Det")]
[Index("IdEmpresaOp", "IdOrdenPago", "SecuenciaOp", Name = "IX_ba_Archivo_Transferencia_Det_1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaArchivoTransferenciaDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdArchivo { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("IdProceso_bancario")]
    [StringLength(25)]
    public string IdProcesoBancario { get; set; } = null!;

    [Column("Id_Item")]
    [StringLength(50)]
    public string? IdItem { get; set; }

    [Column("IdEmpresa_OP")]
    public int? IdEmpresaOp { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenPago { get; set; }

    [Column("Secuencia_OP")]
    public int? SecuenciaOp { get; set; }

    public int? IdEmpresaNomina { get; set; }

    public int? IdNominaTipo { get; set; }

    public int? IdNominaTipoLiqui { get; set; }

    public int? IdPeriodo { get; set; }

    [StringLength(10)]
    public string? IdRubro { get; set; }

    public int? IdEmpleado { get; set; }

    [Column("IdEstadoRegistro_cat")]
    [StringLength(50)]
    public string IdEstadoRegistroCat { get; set; } = null!;

    public bool Estado { get; set; }

    [Precision(18, 2)]
    public decimal Valor { get; set; }

    [Column("Valor_cobrado")]
    [Precision(18, 2)]
    public decimal ValorCobrado { get; set; }

    [Column("Secuencial_reg_x_proceso")]
    [Precision(18, 0)]
    public decimal? SecuencialRegXProceso { get; set; }

    public bool? Contabilizado { get; set; }

    [Column("IdEmpresa_pago")]
    public int? IdEmpresaPago { get; set; }

    [Column("IdTipoCbte_pago")]
    public int? IdTipoCbtePago { get; set; }

    [Column("IdCbteCble_pago")]
    [Precision(18, 0)]
    public decimal? IdCbteCblePago { get; set; }

    [Column("IdInstitucion_col")]
    public int? IdInstitucionCol { get; set; }

    [Column("IdPreFacturacion_col")]
    [Precision(18, 0)]
    public decimal? IdPreFacturacionCol { get; set; }

    [Column("Secuencia_Proce_col")]
    public int? SecuenciaProceCol { get; set; }

    [Column("secuencia_col")]
    public int? SecuenciaCol { get; set; }

    [Column("IdInstitucion_contrato")]
    public int? IdInstitucionContrato { get; set; }

    [Column("idContrato")]
    [Precision(18, 0)]
    public decimal? IdContrato { get; set; }

    [Column("Fecha_proceso")]
    [MaxLength(6)]
    public DateTime? FechaProceso { get; set; }

    [ForeignKey("IdEmpresa, IdArchivo")]
    [InverseProperty("BaArchivoTransferenciaDet")]
    public virtual BaArchivoTransferencia BaArchivoTransferencia { get; set; } = null!;

    [ForeignKey("IdEmpresaOp, IdOrdenPago, SecuenciaOp")]
    [InverseProperty("BaArchivoTransferenciaDet")]
    public virtual CpOrdenPagoDet? CpOrdenPagoDet { get; set; }

    [ForeignKey("IdEmpresaPago, IdTipoCbtePago, IdCbteCblePago")]
    [InverseProperty("BaArchivoTransferenciaDet")]
    public virtual CtCbtecble? CtCbtecble { get; set; }

    [ForeignKey("IdEstadoRegistroCat")]
    [InverseProperty("BaArchivoTransferenciaDet")]
    public virtual BaCatalogo IdEstadoRegistroCatNavigation { get; set; } = null!;
}
