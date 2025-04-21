using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCaja")]
[Table("caj_Caja")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_caj_Caja_ct_plancta")]
[Index("IdEmpresa", "IdSucursal", Name = "FK_caj_Caja_tb_sucursal")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajCaja
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdCaja { get; set; }

    public int? IdSucursal { get; set; }

    [Column("ca_Codigo")]
    [StringLength(50)]
    public string CaCodigo { get; set; } = null!;

    [Column("ca_Descripcion")]
    [StringLength(50)]
    public string CaDescripcion { get; set; } = null!;

    [Column("ca_Moneda")]
    [StringLength(50)]
    public string CaMoneda { get; set; } = null!;

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [Column("IdUsuario_Responsable")]
    [StringLength(50)]
    public string? IdUsuarioResponsable { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(300)]
    public string? MotivoAnu { get; set; }

    public int? IdMoneda { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [InverseProperty("CajCaja")]
    public virtual ICollection<CajCajaMovimiento> CajCajaMovimiento { get; set; } = new List<CajCajaMovimiento>();

    [InverseProperty("CajCaja")]
    public virtual ICollection<CpConciliacionCaja> CpConciliacionCaja { get; set; } = new List<CpConciliacionCaja>();

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CajCaja")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [InverseProperty("CajCaja")]
    public virtual ICollection<CxcCobro> CxcCobro { get; set; } = new List<CxcCobro>();

    [InverseProperty("CajCaja")]
    public virtual ICollection<CxcCobroXAnticipo> CxcCobroXAnticipo { get; set; } = new List<CxcCobroXAnticipo>();

    [InverseProperty("CajCaja")]
    public virtual ICollection<CxcParametro> CxcParametroCajCaja { get; set; } = new List<CxcParametro>();

    [InverseProperty("CajCajaNavigation")]
    public virtual ICollection<CxcParametro> CxcParametroCajCajaNavigation { get; set; } = new List<CxcParametro>();

    [InverseProperty("CajCaja")]
    public virtual ICollection<FaFactura> FaFactura { get; set; } = new List<FaFactura>();

    [InverseProperty("CajCaja")]
    public virtual ICollection<FaNotaCreDeb> FaNotaCreDeb { get; set; } = new List<FaNotaCreDeb>();

    [InverseProperty("CajCaja")]
    public virtual ICollection<FaParametro> FaParametro { get; set; } = new List<FaParametro>();

    [ForeignKey("IdEmpresa")]
    [InverseProperty("CajCaja")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("CajCaja")]
    public virtual TbSucursal? TbSucursal { get; set; }
}
