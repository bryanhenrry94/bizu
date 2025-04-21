using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cxc_cobro_tipo")]
[Index("IdMotivoTipoCobro", Name = "FK_cxc_cobro_tipo_cxc_cobro_tipo_motivo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroTipo
{
    [Key]
    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string IdCobroTipo { get; set; } = null!;

    [Column("tc_descripcion")]
    [StringLength(50)]
    public string TcDescripcion { get; set; } = null!;

    [Column("tc_EsCheque")]
    [StringLength(1)]
    public string TcEsCheque { get; set; } = null!;

    [Column("tc_Afecha")]
    [StringLength(1)]
    public string TcAfecha { get; set; } = null!;

    [Column("tc_interno")]
    [StringLength(1)]
    public string TcInterno { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("tc_generaNCAuto")]
    [StringLength(1)]
    public string TcGeneraNcauto { get; set; } = null!;

    [Column("tc_abreviatura")]
    [StringLength(5)]
    public string TcAbreviatura { get; set; } = null!;

    [Column("tc_cobroDirecto")]
    [StringLength(1)]
    public string TcCobroDirecto { get; set; } = null!;

    [Column("tc_cobroInDirecto")]
    [StringLength(1)]
    public string TcCobroInDirecto { get; set; } = null!;

    [Column("tc_docXCobrar")]
    [StringLength(1)]
    public string TcDocXcobrar { get; set; } = null!;

    [Column("tc_Orden")]
    public int TcOrden { get; set; }

    [Column("tc_seMuestraManCheque")]
    [StringLength(1)]
    public string TcSeMuestraManCheque { get; set; } = null!;

    [Column("tc_Que_Tipo_Registro_Genera")]
    [StringLength(20)]
    public string TcQueTipoRegistroGenera { get; set; } = null!;

    [Column("tc_Tomar_Cta_Cble_De")]
    [StringLength(20)]
    public string? TcTomarCtaCbleDe { get; set; }

    [Column("tc_seCobra")]
    [StringLength(1)]
    public string TcSeCobra { get; set; } = null!;

    [Column("IdEstadoCobro_Inicial")]
    [StringLength(5)]
    public string? IdEstadoCobroInicial { get; set; }

    [Column("ESRetenIVA")]
    [StringLength(1)]
    public string? EsretenIva { get; set; }

    [Column("ESRetenFTE")]
    [StringLength(1)]
    public string? EsretenFte { get; set; }

    public double? PorcentajeRet { get; set; }

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

    [Column("tc_SePuede_Depositar")]
    [StringLength(1)]
    public string? TcSePuedeDepositar { get; set; }

    [Column("IdMotivo_tipo_cobro")]
    [StringLength(15)]
    public string? IdMotivoTipoCobro { get; set; }

    [InverseProperty("IdCobroTipoNavigation")]
    public virtual ICollection<CajCajaMovimientoDet> CajCajaMovimientoDet { get; set; } = new List<CajCajaMovimientoDet>();

    [InverseProperty("IdCobroTipoNavigation")]
    public virtual ICollection<CxcCancelacionIntercompany> CxcCancelacionIntercompany { get; set; } = new List<CxcCancelacionIntercompany>();

    [InverseProperty("IdCobroTipoNavigation")]
    public virtual ICollection<CxcCobro> CxcCobro { get; set; } = new List<CxcCobro>();

    [InverseProperty("IdCobroTipoNavigation")]
    public virtual ICollection<CxcCobroTipoParamContaXSucursal> CxcCobroTipoParamContaXSucursal { get; set; } = new List<CxcCobroTipoParamContaXSucursal>();

    [InverseProperty("IdCobroTipoNavigation")]
    public virtual ICollection<CxcCobroTipoXAnticipo> CxcCobroTipoXAnticipo { get; set; } = new List<CxcCobroTipoXAnticipo>();

    [InverseProperty("IdCobroTipoNavigation")]
    public virtual CxcCobroTipoXCobrosDocxc? CxcCobroTipoXCobrosDocxc { get; set; }

    [InverseProperty("IdCobroTipoNavigation")]
    public virtual ICollection<CxcCobroXAnticipoDet> CxcCobroXAnticipoDet { get; set; } = new List<CxcCobroXAnticipoDet>();

    [InverseProperty("PaIdCobroTipoComisionTcNavigation")]
    public virtual ICollection<CxcParametro> CxcParametroPaIdCobroTipoComisionTcNavigation { get; set; } = new List<CxcParametro>();

    [InverseProperty("PaIdCobroTipoDefaultNavigation")]
    public virtual ICollection<CxcParametro> CxcParametroPaIdCobroTipoDefaultNavigation { get; set; } = new List<CxcParametro>();

    [InverseProperty("TipoCobroDafaultFactuNavigation")]
    public virtual ICollection<FaParametro> FaParametro { get; set; } = new List<FaParametro>();

    [ForeignKey("IdMotivoTipoCobro")]
    [InverseProperty("CxcCobroTipo")]
    public virtual CxcCobroTipoMotivo? IdMotivoTipoCobroNavigation { get; set; }

    [InverseProperty("IdCobroTipoXRetFuNavigation")]
    public virtual ICollection<TbTarjetaParametro> TbTarjetaParametroIdCobroTipoXRetFuNavigation { get; set; } = new List<TbTarjetaParametro>();

    [InverseProperty("IdCobroTipoXRetIvaNavigation")]
    public virtual ICollection<TbTarjetaParametro> TbTarjetaParametroIdCobroTipoXRetIvaNavigation { get; set; } = new List<TbTarjetaParametro>();

    [InverseProperty("IdCobroTipoXTarjNavigation")]
    public virtual ICollection<TbTarjetaParametro> TbTarjetaParametroIdCobroTipoXTarjNavigation { get; set; } = new List<TbTarjetaParametro>();
}
