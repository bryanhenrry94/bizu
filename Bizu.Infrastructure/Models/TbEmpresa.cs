using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_empresa")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbEmpresa
{
    [Key]
    public int IdEmpresa { get; set; }

    [Column("codigo")]
    [StringLength(50)]
    public string Codigo { get; set; } = null!;

    [Column("em_nombre")]
    [StringLength(50)]
    public string EmNombre { get; set; } = null!;

    [StringLength(300)]
    public string RazonSocial { get; set; } = null!;

    [StringLength(300)]
    public string NombreComercial { get; set; } = null!;

    [StringLength(5)]
    public string? ContribuyenteEspecial { get; set; }

    [StringLength(2)]
    public string ObligadoAllevarConta { get; set; } = null!;

    [Column("em_ruc")]
    [StringLength(13)]
    public string EmRuc { get; set; } = null!;

    [Column("em_gerente")]
    [StringLength(50)]
    public string? EmGerente { get; set; }

    [Column("em_contador")]
    [StringLength(150)]
    public string? EmContador { get; set; }

    [Column("em_rucContador")]
    [StringLength(20)]
    public string? EmRucContador { get; set; }

    [Column("em_telefonos")]
    [StringLength(100)]
    public string? EmTelefonos { get; set; }

    [Column("em_fax")]
    [StringLength(20)]
    public string? EmFax { get; set; }

    [Column("em_notificacion")]
    public int? EmNotificacion { get; set; }

    [Column("em_direccion")]
    [StringLength(300)]
    public string EmDireccion { get; set; } = null!;

    [Column("em_tel_int")]
    [StringLength(50)]
    public string? EmTelInt { get; set; }

    [Column("em_logo")]
    public byte[]? EmLogo { get; set; }

    [Column("em_fondo")]
    public byte[]? EmFondo { get; set; }

    [Column("em_fechaInicioContable", TypeName = "timestamp")]
    [MaxLength(6)]
    public DateTime EmFechaInicioContable { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("em_fechaInicioActividad", TypeName = "timestamp")]
    [MaxLength(6)]    
    public DateTime? EmFechaInicioActividad { get; set; }

    [Column("cod_entidad_dinardap")]
    [StringLength(50)]
    public string? CodEntidadDinardap { get; set; }

    [Column("em_Email")]
    [StringLength(300)]
    public string? EmEmail { get; set; }

    [Column("em_Email_Contacto")]
    [StringLength(300)]
    public string? EmEmailContacto { get; set; }

    [Column("Sitio_Web")]
    [StringLength(300)]
    public string? SitioWeb { get; set; }

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<AfActivoFijo> AfActivoFijo { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual AfParametros? AfParametros { get; set; }

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<BaBancoCuenta> BaBancoCuenta { get; set; } = new List<BaBancoCuenta>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual BaParametros? BaParametros { get; set; }

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<BaTipoFlujo> BaTipoFlujo { get; set; } = new List<BaTipoFlujo>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<BaTipoNota> BaTipoNota { get; set; } = new List<BaTipoNota>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<CajCaja> CajCaja { get; set; } = new List<CajCaja>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual CajParametro? CajParametro { get; set; }

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<ComComprador> ComComprador { get; set; } = new List<ComComprador>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ComParametro? ComParametro { get; set; }

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<ComSolicitante> ComSolicitante { get; set; } = new List<ComSolicitante>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual CpParametros? CpParametros { get; set; }

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<CpProveedor> CpProveedor { get; set; } = new List<CpProveedor>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<CpRetencion> CpRetencion { get; set; } = new List<CpRetencion>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<CtCentroCostoNivel> CtCentroCostoNivel { get; set; } = new List<CtCentroCostoNivel>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<CtPeriodo> CtPeriodo { get; set; } = new List<CtPeriodo>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<CtPlancta> CtPlancta { get; set; } = new List<CtPlancta>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual CxcParametro? CxcParametro { get; set; }

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<CxcParametrosXCheqProtesto> CxcParametrosXCheqProtesto { get; set; } = new List<CxcParametrosXCheqProtesto>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<FaCliente> FaCliente { get; set; } = new List<FaCliente>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual FaParametro? FaParametro { get; set; }

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<FaVendedor> FaVendedor { get; set; } = new List<FaVendedor>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<InCategorias> InCategorias { get; set; } = new List<InCategorias>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<InMarca> InMarca { get; set; } = new List<InMarca>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<InMotivoInven> InMotivoInven { get; set; } = new List<InMotivoInven>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<InProducto> InProducto { get; set; } = new List<InProducto>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<SegMenuXEmpresa> SegMenuXEmpresa { get; set; } = new List<SegMenuXEmpresa>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<SegUsuarioXEmpresa> SegUsuarioXEmpresa { get; set; } = new List<SegUsuarioXEmpresa>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TbContacto> TbContacto { get; set; } = new List<TbContacto>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TbSisDocumentoTipoXEmpresa> TbSisDocumentoTipoXEmpresa { get; set; } = new List<TbSisDocumentoTipoXEmpresa>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TbSucursal> TbSucursal { get; set; } = new List<TbSucursal>();

    [InverseProperty("IdEmpresaNavigation")]
    public virtual ICollection<TbTarjetaParametro> TbTarjetaParametro { get; set; } = new List<TbTarjetaParametro>();
}
