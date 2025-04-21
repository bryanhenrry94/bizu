using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdNota")]
[Table("fa_notaCreDeb")]
[Index("IdEmpresa", "IdCaja", Name = "FK_fa_notaCreDeb_caj_Caja")]
[Index("IdEmpresa", "IdCtaCbleTipoNota", Name = "FK_fa_notaCreDeb_ct_plancta")]
[Index("IdEmpresa", "IdSucursal", "IdPuntoVta", Name = "FK_fa_notaCreDeb_fa_PuntoVta")]
[Index("IdTipoNota", Name = "FK_fa_notaCreDeb_fa_TipoNota")]
[Index("IdEmpresa", "IdVendedor", Name = "FK_fa_notaCreDeb_fa_Vendedor")]
[Index("IdEmpresa", "IdCliente", Name = "FK_fa_notaCreDeb_fa_cliente")]
[Index("IdEmpresa", "CodDocumentoTipo", "Serie1", "Serie2", "NumNotaImpresa", Name = "IX_fa_notaCreDeb")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaNotaCreDeb
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [StringLength(50)]
    public string CodNota { get; set; } = null!;

    [StringLength(3)]
    public string CreDeb { get; set; } = null!;

    [StringLength(20)]
    public string? CodDocumentoTipo { get; set; }

    [StringLength(3)]
    public string? Serie1 { get; set; }

    [StringLength(3)]
    public string? Serie2 { get; set; }

    [Column("NumNota_Impresa")]
    [StringLength(20)]
    public string? NumNotaImpresa { get; set; }

    [StringLength(50)]
    public string? NumAutorizacion { get; set; }

    [Column("Fecha_Autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Column("no_fecha")]
    [MaxLength(6)]
    public DateTime NoFecha { get; set; }

    [Column("no_fecha_venc")]
    [MaxLength(6)]
    public DateTime? NoFechaVenc { get; set; }

    [Column("fecha_Ctble")]
    [MaxLength(6)]
    public DateTime? FechaCtble { get; set; }

    [Column("no_dev_venta")]
    [StringLength(7)]
    public string? NoDevVenta { get; set; }

    public int IdTipoNota { get; set; }

    [Column("sc_observacion")]
    [StringLength(1000)]
    public string ScObservacion { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Precision(18, 0)]
    public decimal? IdDevolucion { get; set; }

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

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    public int? IdDpto { get; set; }

    [Precision(18, 0)]
    public decimal? IdSolicitante { get; set; }

    [Column("flete")]
    public double? Flete { get; set; }

    [Column("interes")]
    public double? Interes { get; set; }

    [Column("valor1")]
    public double? Valor1 { get; set; }

    [Column("valor2")]
    public double? Valor2 { get; set; }

    [StringLength(3)]
    public string? NaturalezaNota { get; set; }

    [Column("seguro")]
    public double? Seguro { get; set; }

    public int IdCaja { get; set; }

    [Column("IdCtaCble_TipoNota")]
    [StringLength(20)]
    public string? IdCtaCbleTipoNota { get; set; }

    [Column("IdEmpresa_fac_doc_mod")]
    public int? IdEmpresaFacDocMod { get; set; }

    [Column("IdSucursal_fac_doc_mod")]
    public int? IdSucursalFacDocMod { get; set; }

    [Column("IdBodega_fac_doc_mod")]
    public int? IdBodegaFacDocMod { get; set; }

    [Column("IdCbteVta_fac_doc_mod")]
    [Precision(18, 0)]
    public decimal? IdCbteVtaFacDocMod { get; set; }

    public int? IdPuntoVta { get; set; }

    [ForeignKey("IdEmpresa, IdCaja")]
    [InverseProperty("FaNotaCreDeb")]
    public virtual CajCaja CajCaja { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCtaCbleTipoNota")]
    [InverseProperty("FaNotaCreDeb")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [InverseProperty("FaNotaCreDeb")]
    public virtual ICollection<CxcConciliacionDet> CxcConciliacionDet { get; set; } = new List<CxcConciliacionDet>();

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("FaNotaCreDeb")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [InverseProperty("FaNotaCreDeb")]
    public virtual ICollection<FaDevolVenta> FaDevolVenta { get; set; } = new List<FaDevolVenta>();

    [InverseProperty("FaNotaCreDeb")]
    public virtual ICollection<FaFactura> FaFactura { get; set; } = new List<FaFactura>();

    [InverseProperty("FaNotaCreDeb")]
    public virtual ICollection<FaNotaCreDebDet> FaNotaCreDebDet { get; set; } = new List<FaNotaCreDebDet>();

    [InverseProperty("FaNotaCreDeb")]
    public virtual ICollection<FaNotaCreDebXCtCbtecble> FaNotaCreDebXCtCbtecble { get; set; } = new List<FaNotaCreDebXCtCbtecble>();

    [InverseProperty("FaNotaCreDeb")]
    public virtual ICollection<FaNotaCreDebXCxcCobro> FaNotaCreDebXCxcCobro { get; set; } = new List<FaNotaCreDebXCxcCobro>();

    [ForeignKey("IdEmpresa, IdSucursal, IdPuntoVta")]
    [InverseProperty("FaNotaCreDeb")]
    public virtual FaPuntoVta? FaPuntoVta { get; set; }

    [ForeignKey("IdEmpresa, IdVendedor")]
    [InverseProperty("FaNotaCreDeb")]
    public virtual FaVendedor FaVendedor { get; set; } = null!;

    [ForeignKey("IdTipoNota")]
    [InverseProperty("FaNotaCreDeb")]
    public virtual FaTipoNota IdTipoNotaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("FaNotaCreDeb")]
    public virtual TbBodega TbBodega { get; set; } = null!;

    [ForeignKey("NoIdEmpresa, NoIdSucursal, NoIdBodega, NoIdNota")]
    [InverseProperty("FaNotaCreDeb")]
    public virtual ICollection<InIngEgrInven> InIngEgrInven { get; set; } = new List<InIngEgrInven>();
}
