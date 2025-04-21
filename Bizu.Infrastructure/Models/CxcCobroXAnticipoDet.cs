using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAnticipo", "Secuencia")]
[Table("cxc_cobro_x_Anticipo_det")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_cxc_cobro_x_Anticipo_det_ct_centro_costo")]
[Index("IdEmpresaCobro", "IdSucursalCobro", "IdCobroCobro", Name = "FK_cxc_cobro_x_Anticipo_det_cxc_cobro")]
[Index("IdCobroTipo", Name = "FK_cxc_cobro_x_Anticipo_det_cxc_cobro_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroXAnticipoDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAnticipo { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string IdCobroTipo { get; set; } = null!;

    [Column("IdEmpresa_Cobro")]
    public int? IdEmpresaCobro { get; set; }

    [Column("IdSucursal_cobro")]
    public int? IdSucursalCobro { get; set; }

    [Column("IdCobro_cobro")]
    [Precision(18, 0)]
    public decimal? IdCobroCobro { get; set; }

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

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [StringLength(50)]
    public string? MotiAnula { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CxcCobroXAnticipoDet")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresaCobro, IdSucursalCobro, IdCobroCobro")]
    [InverseProperty("CxcCobroXAnticipoDet")]
    public virtual CxcCobro? CxcCobro { get; set; }

    [ForeignKey("IdEmpresa, IdAnticipo")]
    [InverseProperty("CxcCobroXAnticipoDet")]
    public virtual CxcCobroXAnticipo CxcCobroXAnticipo { get; set; } = null!;

    [ForeignKey("IdCobroTipo")]
    [InverseProperty("CxcCobroXAnticipoDet")]
    public virtual CxcCobroTipo IdCobroTipoNavigation { get; set; } = null!;
}
