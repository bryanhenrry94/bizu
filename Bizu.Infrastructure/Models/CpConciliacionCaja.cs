using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdConciliacionCaja")]
[Table("cp_conciliacion_Caja")]
[Index("IdEmpresa", "IdTipoFlujo", Name = "FK_cp_conciliacion_Caja_ba_TipoFlujo")]
[Index("IdEmpresa", "IdCaja", Name = "FK_cp_conciliacion_Caja_caj_Caja")]
[Index("IdEmpresaMovCaj", "IdCbteCbleMovCaj", "IdTipoCbteMovCaj", Name = "FK_cp_conciliacion_Caja_caj_Caja_Movimiento")]
[Index("IdEstadoCierre", Name = "FK_cp_conciliacion_Caja_cp_catalogo")]
[Index("IdEmpresaOp", "IdOrdenPagoOp", Name = "FK_cp_conciliacion_Caja_cp_orden_pago")]
[Index("IdEmpresa", "IdPeriodo", Name = "FK_cp_conciliacion_Caja_ct_periodo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_cp_conciliacion_Caja_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpConciliacionCaja
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    public int IdPeriodo { get; set; }

    [Column("Fecha_ini")]
    [MaxLength(6)]
    public DateTime? FechaIni { get; set; }

    [Column("Fecha_fin")]
    [MaxLength(6)]
    public DateTime? FechaFin { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public int IdCaja { get; set; }

    [StringLength(25)]
    public string IdEstadoCierre { get; set; } = null!;

    [StringLength(1000)]
    public string Observacion { get; set; } = null!;

    [Column("IdEmpresa_op")]
    public int? IdEmpresaOp { get; set; }

    [Column("IdOrdenPago_op")]
    [Precision(18, 0)]
    public decimal? IdOrdenPagoOp { get; set; }

    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Column("Saldo_cont_al_periodo")]
    public double SaldoContAlPeriodo { get; set; }

    public double Ingresos { get; set; }

    [Column("Total_Ing")]
    public double TotalIng { get; set; }

    [Column("Total_fact_vale")]
    public double TotalFactVale { get; set; }

    [Column("Total_fondo")]
    public double TotalFondo { get; set; }

    [Column("Dif_x_pagar_o_cobrar")]
    public double DifXPagarOCobrar { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [Column("IdEmpresa_mov_caj")]
    public int? IdEmpresaMovCaj { get; set; }

    [Column("IdTipoCbte_mov_caj")]
    public int? IdTipoCbteMovCaj { get; set; }

    [Column("IdCbteCble_mov_caj")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleMovCaj { get; set; }

    [ForeignKey("IdEmpresa, IdTipoFlujo")]
    [InverseProperty("CpConciliacionCaja")]
    public virtual BaTipoFlujo? BaTipoFlujo { get; set; }

    [ForeignKey("IdEmpresa, IdCaja")]
    [InverseProperty("CpConciliacionCaja")]
    public virtual CajCaja CajCaja { get; set; } = null!;

    [ForeignKey("IdEmpresaMovCaj, IdCbteCbleMovCaj, IdTipoCbteMovCaj")]
    [InverseProperty("CpConciliacionCaja")]
    public virtual CajCajaMovimiento? CajCajaMovimiento { get; set; }

    [InverseProperty("CpConciliacionCaja")]
    public virtual ICollection<CpConciliacionCajaDet> CpConciliacionCajaDet { get; set; } = new List<CpConciliacionCajaDet>();

    [InverseProperty("CpConciliacionCaja")]
    public virtual ICollection<CpConciliacionCajaDetIngCaja> CpConciliacionCajaDetIngCaja { get; set; } = new List<CpConciliacionCajaDetIngCaja>();

    [InverseProperty("CpConciliacionCaja")]
    public virtual ICollection<CpConciliacionCajaDetXValeCaja> CpConciliacionCajaDetXValeCaja { get; set; } = new List<CpConciliacionCajaDetXValeCaja>();

    [ForeignKey("IdEmpresaOp, IdOrdenPagoOp")]
    [InverseProperty("CpConciliacionCaja")]
    public virtual CpOrdenPago? CpOrdenPago { get; set; }

    [ForeignKey("IdEmpresa, IdPeriodo")]
    [InverseProperty("CpConciliacionCaja")]
    public virtual CtPeriodo CtPeriodo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CpConciliacionCaja")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [ForeignKey("IdEstadoCierre")]
    [InverseProperty("CpConciliacionCaja")]
    public virtual CpCatalogo IdEstadoCierreNavigation { get; set; } = null!;
}
