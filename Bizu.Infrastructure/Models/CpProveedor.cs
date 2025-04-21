using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProveedor")]
[Table("cp_proveedor")]
[Index("IdTipoServicio", Name = "FK_cp_proveedor_cp_catalogo")]
[Index("IdTipoGasto", Name = "FK_cp_proveedor_cp_catalogo1")]
[Index("IdTipoCtaAcreditacionCat", Name = "FK_cp_proveedor_cp_catalogo2")]
[Index("IdCreditoPredeter", Name = "FK_cp_proveedor_cp_codigo_SRI")]
[Index("CodigoSriIcePredeter", Name = "FK_cp_proveedor_cp_codigo_SRI1")]
[Index("CodigoSri101Predeter", Name = "FK_cp_proveedor_cp_codigo_SRI2")]
[Index("IdEmpresa", "IdClaseProveedor", Name = "FK_cp_proveedor_cp_proveedor_clase")]
[Index("IdEmpresa", "IdCtaCbleCxp", Name = "FK_cp_proveedor_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleAnticipo", Name = "FK_cp_proveedor_ct_plancta1")]
[Index("IdEmpresa", "IdCtaCbleGasto", Name = "FK_cp_proveedor_ct_plancta2")]
[Index("IdEmpresa", "IdPuntoCargo", Name = "FK_cp_proveedor_ct_punto_cargo")]
[Index("IdEmpresa", "IdPuntoCargoGrupo", Name = "FK_cp_proveedor_ct_punto_cargo_grupo")]
[Index("IdBancoAcreditacion", Name = "FK_cp_proveedor_tb_banco")]
[Index("IdCiudad", Name = "FK_cp_proveedor_tb_ciudad")]
[Index("IdPersona", Name = "FK_cp_proveedor_tb_persona")]
[Index("IdEmpresa", "IdProveedor", "IdPersona", Name = "IX_cp_proveedor")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpProveedor
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Column("pr_codigo")]
    [StringLength(50)]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_nombre")]
    [StringLength(100)]
    public string? PrNombre { get; set; }

    [Column("pr_girar_cheque_a")]
    [StringLength(100)]
    public string? PrGirarChequeA { get; set; }

    [StringLength(25)]
    public string IdTipoServicio { get; set; } = null!;

    [Column("IdCtaCble_CXP")]
    [StringLength(20)]
    public string? IdCtaCbleCxp { get; set; }

    [StringLength(25)]
    public string IdTipoGasto { get; set; } = null!;

    [Column("pr_contribuyenteEspecial")]
    [StringLength(1)]
    public string? PrContribuyenteEspecial { get; set; }

    [Column("pr_contribuyenteExentoDeIVA")]
    [StringLength(1)]
    public string? PrContribuyenteExentoDeIva { get; set; }

    [Column("pr_plazo")]
    public int? PrPlazo { get; set; }

    [Column("representante_legal")]
    [StringLength(250)]
    public string? RepresentanteLegal { get; set; }

    [Column("pr_estado")]
    [StringLength(1)]
    public string? PrEstado { get; set; }

    [StringLength(25)]
    public string IdCiudad { get; set; } = null!;

    [Column("pr_nacionalidad")]
    [StringLength(50)]
    public string? PrNacionalidad { get; set; }

    [Column("idCredito_Predeter")]
    public int? IdCreditoPredeter { get; set; }

    [Column("codigoSRI_ICE_Predeter")]
    public int? CodigoSriIcePredeter { get; set; }

    [Column("codigoSRI_101_Predeter")]
    public int? CodigoSri101Predeter { get; set; }

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

    [Column("contacto")]
    [StringLength(200)]
    public string? Contacto { get; set; }

    [Column("responsable")]
    [StringLength(100)]
    public string? Responsable { get; set; }

    [Column("comentario")]
    [StringLength(300)]
    public string? Comentario { get; set; }

    [StringLength(20)]
    public string? IdCentroCosot { get; set; }

    [Column("IdCtaCble_Anticipo")]
    [StringLength(20)]
    public string? IdCtaCbleAnticipo { get; set; }

    [Column("IdCtaCble_Gasto")]
    [StringLength(20)]
    public string? IdCtaCbleGasto { get; set; }

    [Column("IdCtaCble_TarjetaPago")]
    [StringLength(20)]
    public string? IdCtaCbleTarjetaPago { get; set; }

    public int IdClaseProveedor { get; set; }

    [StringLength(200)]
    public string? MotivoAnulacion { get; set; }

    [Column("IdTipoCta_acreditacion_cat")]
    [StringLength(25)]
    public string? IdTipoCtaAcreditacionCat { get; set; }

    [Column("num_cta_acreditacion")]
    [StringLength(50)]
    public string? NumCtaAcreditacion { get; set; }

    [Column("IdBanco_acreditacion")]
    public int? IdBancoAcreditacion { get; set; }

    [Column("IdTipoDocumento_acreditacion")]
    [StringLength(25)]
    public string? IdTipoDocumentoAcreditacion { get; set; }

    [Column("cedulaRuc_acreditacion")]
    [StringLength(50)]
    public string? CedulaRucAcreditacion { get; set; }

    [Column("beneficiario_acreditacion")]
    [StringLength(200)]
    public string? BeneficiarioAcreditacion { get; set; }

    [Column("correo_acreditacion")]
    [StringLength(200)]
    public string? CorreoAcreditacion { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("es_empresa_relacionada")]
    public bool? EsEmpresaRelacionada { get; set; }

    [StringLength(25)]
    public string? IdTerminoPago { get; set; }

    [Column("pr_GranContribuyente")]
    [StringLength(1)]
    public string? PrGranContribuyente { get; set; }

    [StringLength(25)]
    public string? IdRegimen { get; set; }

    [StringLength(100)]
    public string? CorreoPrincipal { get; set; }

    [StringLength(100)]
    public string? CorreoSecundario { get; set; }

    [StringLength(100)]
    public string? CorreoAlterno { get; set; }

    [InverseProperty("CpProveedor")]
    public virtual ICollection<AfActivoFijo> AfActivoFijo { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<AfMejBajActivo> AfMejBajActivo { get; set; } = new List<AfMejBajActivo>();

    [ForeignKey("CodigoSri101Predeter")]
    [InverseProperty("CpProveedorCodigoSri101PredeterNavigation")]
    public virtual CpCodigoSri? CodigoSri101PredeterNavigation { get; set; }

    [ForeignKey("CodigoSriIcePredeter")]
    [InverseProperty("CpProveedorCodigoSriIcePredeterNavigation")]
    public virtual CpCodigoSri? CodigoSriIcePredeterNavigation { get; set; }

    [InverseProperty("CpProveedor")]
    public virtual ICollection<ComCotizacionCompra> ComCotizacionCompra { get; set; } = new List<ComCotizacionCompra>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<ComDevCompra> ComDevCompra { get; set; } = new List<ComDevCompra>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<ComOrdencompraLocal> ComOrdencompraLocal { get; set; } = new List<ComOrdencompraLocal>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<CpAprobacionIngBodXOc> CpAprobacionIngBodXOc { get; set; } = new List<CpAprobacionIngBodXOc>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<CpNotaDebCre> CpNotaDebCre { get; set; } = new List<CpNotaDebCre>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiro { get; set; } = new List<CpOrdenGiro>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<CpProveedorAutorizacion> CpProveedorAutorizacion { get; set; } = new List<CpProveedorAutorizacion>();

    [ForeignKey("IdEmpresa, IdClaseProveedor")]
    [InverseProperty("CpProveedor")]
    public virtual CpProveedorClase CpProveedorClase { get; set; } = null!;

    [InverseProperty("CpProveedor")]
    public virtual ICollection<CpProveedorCodigoSri> CpProveedorCodigoSri { get; set; } = new List<CpProveedorCodigoSri>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<CpProveedorContactos> CpProveedorContactos { get; set; } = new List<CpProveedorContactos>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<CpReembolso> CpReembolso { get; set; } = new List<CpReembolso>();

    [ForeignKey("IdEmpresa, IdCtaCbleAnticipo")]
    [InverseProperty("CpProveedorCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleGasto")]
    [InverseProperty("CpProveedorCtPlancta1")]
    public virtual CtPlancta? CtPlancta1 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleCxp")]
    [InverseProperty("CpProveedorCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargo")]
    [InverseProperty("CpProveedor")]
    public virtual CtPuntoCargo? CtPuntoCargo { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargoGrupo")]
    [InverseProperty("CpProveedor")]
    public virtual CtPuntoCargoGrupo? CtPuntoCargoGrupo { get; set; }

    [ForeignKey("IdBancoAcreditacion")]
    [InverseProperty("CpProveedor")]
    public virtual TbBanco? IdBancoAcreditacionNavigation { get; set; }

    [ForeignKey("IdCiudad")]
    [InverseProperty("CpProveedor")]
    public virtual TbCiudad IdCiudadNavigation { get; set; } = null!;

    [ForeignKey("IdCreditoPredeter")]
    [InverseProperty("CpProveedorIdCreditoPredeterNavigation")]
    public virtual CpCodigoSri? IdCreditoPredeterNavigation { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("CpProveedor")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdPersona")]
    [InverseProperty("CpProveedor")]
    public virtual TbPersona IdPersonaNavigation { get; set; } = null!;

    [ForeignKey("IdTipoCtaAcreditacionCat")]
    [InverseProperty("CpProveedorIdTipoCtaAcreditacionCatNavigation")]
    public virtual CpCatalogo? IdTipoCtaAcreditacionCatNavigation { get; set; }

    [ForeignKey("IdTipoGasto")]
    [InverseProperty("CpProveedorIdTipoGastoNavigation")]
    public virtual CpCatalogo IdTipoGastoNavigation { get; set; } = null!;

    [ForeignKey("IdTipoServicio")]
    [InverseProperty("CpProveedorIdTipoServicioNavigation")]
    public virtual CpCatalogo IdTipoServicioNavigation { get; set; } = null!;

    [InverseProperty("CpProveedor")]
    public virtual ICollection<InGuiaXTraspasoBodegaDetSinOc> InGuiaXTraspasoBodegaDetSinOc { get; set; } = new List<InGuiaXTraspasoBodegaDetSinOc>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<InPrecargaItemsOrdenCompra> InPrecargaItemsOrdenCompra { get; set; } = new List<InPrecargaItemsOrdenCompra>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<InPresupuesto> InPresupuesto { get; set; } = new List<InPresupuesto>();

    [InverseProperty("CpProveedor")]
    public virtual ICollection<InProductoXCpProveedor> InProductoXCpProveedor { get; set; } = new List<InProductoXCpProveedor>();
}
