using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCble", "IdTipocbte", "Secuencia")]
[Table("caj_Caja_Movimiento_det")]
[Index("IdEmpresa", "IdTipoFlujo", Name = "FK_caj_Caja_Movimiento_det_ba_TipoFlujo")]
[Index("IdEmpresaOp", "IdOrdenPagoOp", Name = "FK_caj_Caja_Movimiento_det_cp_orden_pago")]
[Index("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto", Name = "FK_caj_Caja_Movimiento_det_ct_centro_costo_sub_centro_costo")]
[Index("IdCobroTipo", Name = "FK_caj_Caja_Movimiento_det_cxc_cobro_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajCajaMovimientoDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Key]
    public int IdTipocbte { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string? IdCobroTipo { get; set; }

    [Column("cr_fecha")]
    [MaxLength(6)]
    public DateTime CrFecha { get; set; }

    [Column("cr_Valor")]
    public double CrValor { get; set; }

    [Column("cr_Banco")]
    [StringLength(50)]
    public string? CrBanco { get; set; }

    [Column("cr_cuenta")]
    [StringLength(100)]
    public string? CrCuenta { get; set; }

    [Column("cr_NumDocumento")]
    [StringLength(100)]
    public string? CrNumDocumento { get; set; }

    [Column("cr_fechaDocu")]
    [MaxLength(6)]
    public DateTime? CrFechaDocu { get; set; }

    [Column("IdEmpresa_OP")]
    public int? IdEmpresaOp { get; set; }

    [Column("IdOrdenPago_OP")]
    [Precision(18, 0)]
    public decimal? IdOrdenPagoOp { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [ForeignKey("IdEmpresa, IdTipoFlujo")]
    [InverseProperty("CajCajaMovimientoDet")]
    public virtual BaTipoFlujo? BaTipoFlujo { get; set; }

    [ForeignKey("IdEmpresa, IdCbteCble, IdTipocbte")]
    [InverseProperty("CajCajaMovimientoDet")]
    public virtual CajCajaMovimiento CajCajaMovimiento { get; set; } = null!;

    [ForeignKey("IdEmpresaOp, IdOrdenPagoOp")]
    [InverseProperty("CajCajaMovimientoDet")]
    public virtual CpOrdenPago? CpOrdenPago { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CajCajaMovimientoDet")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto, IdCentroCostoSubCentroCosto")]
    [InverseProperty("CajCajaMovimientoDet")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdCobroTipo")]
    [InverseProperty("CajCajaMovimientoDet")]
    public virtual CxcCobroTipo? IdCobroTipoNavigation { get; set; }
}
