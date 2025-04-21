using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal")]
[Table("tb_sucursal")]
[Index("IdEmpresa", "IdSucursal", Name = "ix_tb_sucursal")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSucursal
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Column("codigo")]
    [StringLength(10)]
    public string? Codigo { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    public string SuDescripcion { get; set; } = null!;

    [Column("Su_CodigoEstablecimiento")]
    [StringLength(30)]
    public string? SuCodigoEstablecimiento { get; set; }

    [Column("Su_Ubicacion")]
    [StringLength(20)]
    public string? SuUbicacion { get; set; }

    [Column("Su_Ruc")]
    [StringLength(15)]
    public string? SuRuc { get; set; }

    [Column("Su_JefeSucursal")]
    [StringLength(100)]
    public string? SuJefeSucursal { get; set; }

    [Column("Su_Telefonos")]
    [StringLength(50)]
    public string? SuTelefonos { get; set; }

    [Column("Su_Direccion")]
    [StringLength(100)]
    public string? SuDireccion { get; set; }

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
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [Column("Es_establecimiento")]
    public bool? EsEstablecimiento { get; set; }

    [InverseProperty("TbSucursal")]
    public virtual ICollection<AfActivoFijo> AfActivoFijo { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<AfCambioUbicacionActivo> AfCambioUbicacionActivoTbSucursal { get; set; } = new List<AfCambioUbicacionActivo>();

    [InverseProperty("TbSucursalNavigation")]
    public virtual ICollection<AfCambioUbicacionActivo> AfCambioUbicacionActivoTbSucursalNavigation { get; set; } = new List<AfCambioUbicacionActivo>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<BaCbteBan> BaCbteBan { get; set; } = new List<BaCbteBan>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<CajCaja> CajCaja { get; set; } = new List<CajCaja>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<CajCajaMovimiento> CajCajaMovimiento { get; set; } = new List<CajCajaMovimiento>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<ComCotizacionCompra> ComCotizacionCompra { get; set; } = new List<ComCotizacionCompra>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<ComOrdencompraLocal> ComOrdencompraLocal { get; set; } = new List<ComOrdencompraLocal>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<ComParametro> ComParametro { get; set; } = new List<ComParametro>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<CpNotaDebCre> CpNotaDebCre { get; set; } = new List<CpNotaDebCre>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiro { get; set; } = new List<CpOrdenGiro>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<CtCbtecble> CtCbtecble { get; set; } = new List<CtCbtecble>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<CxcCobro> CxcCobro { get; set; } = new List<CxcCobro>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<CxcCobroTipoParamContaXSucursal> CxcCobroTipoParamContaXSucursal { get; set; } = new List<CxcCobroTipoParamContaXSucursal>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<CxcCobroXAnticipo> CxcCobroXAnticipo { get; set; } = new List<CxcCobroXAnticipo>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<FaPuntoVta> FaPuntoVta { get; set; } = new List<FaPuntoVta>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<FaTipoNotaXEmpresaXSucursal> FaTipoNotaXEmpresaXSucursal { get; set; } = new List<FaTipoNotaXEmpresaXSucursal>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<FaVendedorxSucursal> FaVendedorxSucursal { get; set; } = new List<FaVendedorxSucursal>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<FaVentaTelefonica> FaVentaTelefonica { get; set; } = new List<FaVentaTelefonica>();

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TbSucursal")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("TbSucursal")]
    public virtual ICollection<InGuiaXTraspasoBodega> InGuiaXTraspasoBodegaTbSucursal { get; set; } = new List<InGuiaXTraspasoBodega>();

    [InverseProperty("TbSucursalNavigation")]
    public virtual ICollection<InGuiaXTraspasoBodega> InGuiaXTraspasoBodegaTbSucursalNavigation { get; set; } = new List<InGuiaXTraspasoBodega>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<InIngEgrInven> InIngEgrInven { get; set; } = new List<InIngEgrInven>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<InPrecargaItemsOrdenCompra> InPrecargaItemsOrdenCompra { get; set; } = new List<InPrecargaItemsOrdenCompra>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<InPresupuesto> InPresupuesto { get; set; } = new List<InPresupuesto>();

    [InverseProperty("TbSucursal")]
    public virtual ICollection<TbBodega> TbBodega { get; set; } = new List<TbBodega>();
}
