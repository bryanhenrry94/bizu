using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdPresupuesto")]
[Table("in_presupuesto")]
[Index("IdEmpresa", "IdProveedor", Name = "FK_in_presupuesto_cp_proveedor")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InPresupuesto
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPresupuesto { get; set; }

    [StringLength(5)]
    public string Tipo { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("pr_plazo")]
    public int PrPlazo { get; set; }

    [Column("pr_fecha")]
    [MaxLength(6)]
    public DateTime PrFecha { get; set; }

    [Column("pr_subtotal")]
    public double PrSubtotal { get; set; }

    [Column("pr_iva")]
    public double PrIva { get; set; }

    [Column("pr_descuento")]
    public double PrDescuento { get; set; }

    [Column("pr_pordesc")]
    public short PrPordesc { get; set; }

    [Column("pr_flete")]
    public double PrFlete { get; set; }

    [Column("pr_total")]
    public double PrTotal { get; set; }

    [Column("pr_Base_conIva")]
    public double PrBaseConIva { get; set; }

    [Column("pr_Base_sinIva")]
    public double PrBaseSinIva { get; set; }

    [Column("pr_observacion")]
    [StringLength(1000)]
    public string PrObservacion { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fechreg { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("pr_NumDocumento")]
    [StringLength(50)]
    public string? PrNumDocumento { get; set; }

    [StringLength(3)]
    public string IdEstadoAprobacion { get; set; } = null!;

    [Column("co_fecha_aprobacion")]
    [MaxLength(6)]
    public DateTime? CoFechaAprobacion { get; set; }

    public int? IdTerminoPago { get; set; }

    [Column("co_FechaFactProv")]
    [MaxLength(6)]
    public DateTime? CoFechaFactProv { get; set; }

    [Column("co_DiasFecFacProv")]
    public int? CoDiasFecFacProv { get; set; }

    [Column("co_fecha_salida")]
    [MaxLength(6)]
    public DateTime? CoFechaSalida { get; set; }

    [Column("co_fecha_llegada")]
    [MaxLength(6)]
    public DateTime? CoFechaLlegada { get; set; }

    [Column("IdUsuario_Aprueba")]
    [StringLength(20)]
    public string? IdUsuarioAprueba { get; set; }

    [Column("IdUsuario_Reprue")]
    [StringLength(20)]
    public string? IdUsuarioReprue { get; set; }

    [Column("co_fechaReproba")]
    [MaxLength(6)]
    public DateTime? CoFechaReproba { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAnul { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("pr_PesoTotal")]
    public double? PrPesoTotal { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("pr_fecha_emision")]
    [MaxLength(6)]
    public DateTime? PrFechaEmision { get; set; }

    [Column("IdUsuario_Solicitante")]
    [StringLength(20)]
    public string? IdUsuarioSolicitante { get; set; }

    [Column("IdUsuario_Emicion")]
    [StringLength(20)]
    public string? IdUsuarioEmicion { get; set; }

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("InPresupuesto")]
    public virtual CpProveedor CpProveedor { get; set; } = null!;

    [InverseProperty("InPresupuesto")]
    public virtual ICollection<InPresupuestoDet> InPresupuestoDet { get; set; } = new List<InPresupuestoDet>();

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("InPresupuesto")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
