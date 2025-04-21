using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdCobro", "Secuencial")]
[Table("cxc_cobro_det")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_cxc_cobro_det_ct_centro_costo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [Key]
    [Column("secuencial")]
    public int Secuencial { get; set; }

    [Column("dc_TipoDocumento")]
    [StringLength(20)]
    public string? DcTipoDocumento { get; set; }

    [Column("IdBodega_Cbte")]
    public int? IdBodegaCbte { get; set; }

    [Column("IdCbte_vta_nota")]
    [Precision(18, 0)]
    public decimal IdCbteVtaNota { get; set; }

    [Column("dc_ValorPago")]
    public double DcValorPago { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

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

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [Column("estado")]
    [StringLength(1)]
    public string? Estado { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CxcCobroDet")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdCobro")]
    [InverseProperty("CxcCobroDet")]
    public virtual CxcCobro CxcCobro { get; set; } = null!;

    [InverseProperty("CxcCobroDet")]
    public virtual ICollection<CxcConciliacionDet> CxcConciliacionDet { get; set; } = new List<CxcConciliacionDet>();
}
