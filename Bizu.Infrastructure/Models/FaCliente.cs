using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCliente")]
[Table("fa_cliente")]
[Index("IdEmpresa", "IdCentroCostoCxc", Name = "FK_fa_cliente_ct_centro_costo")]
[Index("IdEmpresa", "IdCentroCostoAnticipo", Name = "FK_fa_cliente_ct_centro_costo1")]
[Index("IdEmpresa", "IdCentroCostoCxcCredito", Name = "FK_fa_cliente_ct_centro_costo2")]
[Index("IdEmpresa", "IdCtaCbleCxc", Name = "FK_fa_cliente_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleAnti", Name = "FK_fa_cliente_ct_plancta1")]
[Index("IdEmpresa", "IdCtaCbleCxcCredito", Name = "FK_fa_cliente_ct_plancta2")]
[Index("IdActividadComercial", Name = "FK_fa_cliente_fa_catalogo")]
[Index("IdEmpresa", "IdtipoCliente", Name = "FK_fa_cliente_fa_cliente_tipo")]
[Index("IdCiudad", Name = "FK_fa_cliente_tb_ciudad")]
[Index("IdPersona", Name = "FK_fa_cliente_tb_persona")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaCliente
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [StringLength(50)]
    public string? Codigo { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    public int IdSucursal { get; set; }

    public int IdVendedor { get; set; }

    [Column("Idtipo_cliente")]
    public int IdtipoCliente { get; set; }

    [StringLength(6)]
    public string IdTipoCredito { get; set; } = null!;

    [Column("cl_Cat_crediticia")]
    [StringLength(2)]
    public string ClCatCrediticia { get; set; } = null!;

    [Column("cl_plazo")]
    public int ClPlazo { get; set; }

    [Column("cl_porcentaje_descuento")]
    public double ClPorcentajeDescuento { get; set; }

    [Column("IdCtaCble_cxc")]
    [StringLength(20)]
    public string? IdCtaCbleCxc { get; set; }

    [Column("IdCtaCble_Anti")]
    [StringLength(20)]
    public string? IdCtaCbleAnti { get; set; }

    [Column("cl_Cell_Garante")]
    [StringLength(13)]
    public string? ClCellGarante { get; set; }

    [Column("cl_Garante")]
    [StringLength(100)]
    public string? ClGarante { get; set; }

    [Column("cl_Mail_Garante")]
    [StringLength(60)]
    public string? ClMailGarante { get; set; }

    [Column("cl_observacion")]
    [StringLength(130)]
    public string ClObservacion { get; set; } = null!;

    [StringLength(25)]
    public string IdCiudad { get; set; } = null!;

    [Column("cl_Cupo")]
    public double ClCupo { get; set; }

    [Precision(18, 0)]
    public decimal? IdClienteRelacionado { get; set; }

    [Column("cl_LocalComercial")]
    [StringLength(500)]
    public string? ClLocalComercial { get; set; }

    [Column("cl_Rep_Legal")]
    [StringLength(100)]
    public string? ClRepLegal { get; set; }

    [Column("cl_Mail_Rep_Legal")]
    [StringLength(60)]
    public string? ClMailRepLegal { get; set; }

    [Column("cl_Cell_Rep_Legal")]
    [StringLength(13)]
    public string? ClCellRepLegal { get; set; }

    [Column("cl_Ger_Gen")]
    [StringLength(100)]
    public string? ClGerGen { get; set; }

    [Column("cl_Mail_Ger_Gen")]
    [StringLength(60)]
    public string? ClMailGerGen { get; set; }

    [Column("cl_Cell_Ger_Gen")]
    [StringLength(13)]
    public string? ClCellGerGen { get; set; }

    [Column("cl_casilla")]
    [StringLength(50)]
    public string ClCasilla { get; set; } = null!;

    [Column("cl_fax")]
    [StringLength(50)]
    public string ClFax { get; set; } = null!;

    [StringLength(15)]
    public string IdActividadComercial { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

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
    [StringLength(20)]
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    public string Ip { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("Mail_Principal")]
    [StringLength(50)]
    public string MailPrincipal { get; set; } = null!;

    [Column("Mail_Secundario1")]
    [StringLength(50)]
    public string? MailSecundario1 { get; set; }

    [Column("Mail_Secundario2")]
    [StringLength(50)]
    public string? MailSecundario2 { get; set; }

    [Column("IdCentroCosto_CXC")]
    [StringLength(20)]
    public string? IdCentroCostoCxc { get; set; }

    [Column("IdCentroCosto_Anticipo")]
    [StringLength(20)]
    public string? IdCentroCostoAnticipo { get; set; }

    [Column("IdCentroCosto_CXC_Credito")]
    [StringLength(20)]
    public string? IdCentroCostoCxcCredito { get; set; }

    [Column("IdCtaCble_cxc_Credito")]
    [StringLength(20)]
    public string? IdCtaCbleCxcCredito { get; set; }

    [StringLength(25)]
    public string? IdParroquia { get; set; }

    [Column("es_empresa_relacionada")]
    public bool? EsEmpresaRelacionada { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCostoAnticipo")]
    [InverseProperty("FaClienteCtCentroCosto")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCostoCxcCredito")]
    [InverseProperty("FaClienteCtCentroCosto1")]
    public virtual CtCentroCosto? CtCentroCosto1 { get; set; }

    [InverseProperty("FaCliente")]
    public virtual ICollection<CtCentroCostoEstadoCierre> CtCentroCostoEstadoCierre { get; set; } = new List<CtCentroCostoEstadoCierre>();

    [ForeignKey("IdEmpresa, IdCentroCostoCxc")]
    [InverseProperty("FaClienteCtCentroCostoNavigation")]
    public virtual CtCentroCosto? CtCentroCostoNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleAnti")]
    [InverseProperty("FaClienteCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleCxcCredito")]
    [InverseProperty("FaClienteCtPlancta1")]
    public virtual CtPlancta? CtPlancta1 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleCxc")]
    [InverseProperty("FaClienteCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [InverseProperty("FaCliente")]
    public virtual ICollection<CxcAnticipoFacturado> CxcAnticipoFacturado { get; set; } = new List<CxcAnticipoFacturado>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<CxcCancelacionIntercompany> CxcCancelacionIntercompany { get; set; } = new List<CxcCancelacionIntercompany>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<CxcCobro> CxcCobro { get; set; } = new List<CxcCobro>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<CxcCobroXAnticipo> CxcCobroXAnticipo { get; set; } = new List<CxcCobroXAnticipo>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<CxcConciliacion> CxcConciliacion { get; set; } = new List<CxcConciliacion>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<FaClienteContactos> FaClienteContactos { get; set; } = new List<FaClienteContactos>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<FaClienteObra> FaClienteObra { get; set; } = new List<FaClienteObra>();

    [ForeignKey("IdEmpresa, IdtipoCliente")]
    [InverseProperty("FaCliente")]
    public virtual FaClienteTipo FaClienteTipo { get; set; } = null!;

    [InverseProperty("FaCliente")]
    public virtual ICollection<FaCotizacion> FaCotizacion { get; set; } = new List<FaCotizacion>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<FaDevolVenta> FaDevolVenta { get; set; } = new List<FaDevolVenta>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<FaFactura> FaFactura { get; set; } = new List<FaFactura>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<FaGuiaRemision> FaGuiaRemision { get; set; } = new List<FaGuiaRemision>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<FaNotaCreDeb> FaNotaCreDeb { get; set; } = new List<FaNotaCreDeb>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<FaOrdenDesp> FaOrdenDesp { get; set; } = new List<FaOrdenDesp>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<FaPedido> FaPedido { get; set; } = new List<FaPedido>();

    [InverseProperty("FaCliente")]
    public virtual ICollection<FaVentaTelefonica> FaVentaTelefonica { get; set; } = new List<FaVentaTelefonica>();

    [ForeignKey("IdActividadComercial")]
    [InverseProperty("FaCliente")]
    public virtual FaCatalogo IdActividadComercialNavigation { get; set; } = null!;

    [ForeignKey("IdCiudad")]
    [InverseProperty("FaCliente")]
    public virtual TbCiudad IdCiudadNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("FaCliente")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdPersona")]
    [InverseProperty("FaCliente")]
    public virtual TbPersona IdPersonaNavigation { get; set; } = null!;
}
