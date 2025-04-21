using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdAnticipo")]
[Table("cxc_anticipo_facturado")]
[Index("IdEmpresaCt", "IdTipoCbteCt", "IdCbteCbleCt", Name = "FK_cxc_anticipo_facturado_ct_cbtecble")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_cxc_anticipo_facturado_ct_centro_costo")]
[Index("IdEmpresa", "IdCliente", Name = "FK_cxc_anticipo_facturado_fa_cliente")]
[Index("IdEmpresaCbteVta", "IdSucursalCbteVta", "IdBodegaCbteVta", "IdCbteVta", Name = "FK_cxc_anticipo_facturado_fa_factura")]
[Index("IdEmpresa", "IdSucursal", "IdProyecto", "IdOferta", Name = "FK_cxc_anticipo_facturado_obr_Oferta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcAnticipoFacturado
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAnticipo { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdProyecto { get; set; }

    public int IdOferta { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    public double Valor { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(250)]
    public string? Observacion { get; set; }

    [Column("IdEmpresa_ct")]
    public int? IdEmpresaCt { get; set; }

    [Column("IdTipoCbte_ct")]
    public int? IdTipoCbteCt { get; set; }

    [Column("IdCbteCble_ct")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCt { get; set; }

    [Column("IdEmpresa_CbteVta")]
    public int? IdEmpresaCbteVta { get; set; }

    [Column("IdSucursal_CbteVta")]
    public int? IdSucursalCbteVta { get; set; }

    [Column("IdBodega_CbteVta")]
    public int? IdBodegaCbteVta { get; set; }

    [Precision(18, 0)]
    public decimal? IdCbteVta { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(50)]
    public string? MotiAnula { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [ForeignKey("IdEmpresaCt, IdTipoCbteCt, IdCbteCbleCt")]
    [InverseProperty("CxcAnticipoFacturado")]
    public virtual CtCbtecble? CtCbtecble { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CxcAnticipoFacturado")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [InverseProperty("CxcAnticipoFacturado")]
    public virtual ICollection<CxcAnticipoFacturadoDet> CxcAnticipoFacturadoDet { get; set; } = new List<CxcAnticipoFacturadoDet>();

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("CxcAnticipoFacturado")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [ForeignKey("IdEmpresaCbteVta, IdSucursalCbteVta, IdBodegaCbteVta, IdCbteVta")]
    [InverseProperty("CxcAnticipoFacturado")]
    public virtual FaFactura? FaFactura { get; set; }
}
