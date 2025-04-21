using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdCobro")]
[Table("cxc_cobro")]
[Index("IdBanco", Name = "FK_cxc_cobro_ba_Banco_Cuenta")]
[Index("IdEmpresa", "IdCaja", Name = "FK_cxc_cobro_caj_Caja")]
[Index("IdCobroTipo", Name = "FK_cxc_cobro_cxc_cobro_tipo")]
[Index("IdTipoNotaCredito", Name = "FK_cxc_cobro_fa_TipoNota")]
[Index("IdEmpresa", "IdCliente", Name = "FK_cxc_cobro_fa_cliente")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [Column("IdCobro_a_aplicar")]
    [Precision(18, 0)]
    public decimal? IdCobroAAplicar { get; set; }

    [Column("cr_Codigo")]
    [StringLength(10)]
    public string? CrCodigo { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string IdCobroTipo { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("cr_TotalCobro")]
    public double CrTotalCobro { get; set; }

    [Column("cr_fecha")]
    [MaxLength(6)]
    public DateTime CrFecha { get; set; }

    [Column("cr_fechaDocu")]
    [MaxLength(6)]
    public DateTime CrFechaDocu { get; set; }

    [Column("cr_fechaCobro")]
    [MaxLength(6)]
    public DateTime CrFechaCobro { get; set; }

    [Column("cr_observacion")]
    [StringLength(700)]
    public string CrObservacion { get; set; } = null!;

    [Column("cr_Banco")]
    [StringLength(50)]
    public string? CrBanco { get; set; }

    [Column("cr_cuenta")]
    [StringLength(100)]
    public string? CrCuenta { get; set; }

    [Column("cr_NumDocumento")]
    [StringLength(100)]
    public string? CrNumDocumento { get; set; }

    [Column("cr_Tarjeta")]
    [StringLength(50)]
    public string? CrTarjeta { get; set; }

    [Column("cr_propietarioCta")]
    [StringLength(100)]
    public string? CrPropietarioCta { get; set; }

    [Column("cr_estado")]
    [StringLength(1)]
    public string? CrEstado { get; set; }

    [Column("cr_recibo")]
    [Precision(18, 0)]
    public decimal? CrRecibo { get; set; }

    [Column("cr_es_anticipo")]
    [StringLength(1)]
    public string? CrEsAnticipo { get; set; }

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

    public int? IdBanco { get; set; }

    public int IdCaja { get; set; }

    [StringLength(50)]
    public string? MotiAnula { get; set; }

    public int? IdTipoNotaCredito { get; set; }

    [Column("es_electronica")]
    public int? EsElectronica { get; set; }

    [ForeignKey("IdEmpresa, IdCaja")]
    [InverseProperty("CxcCobro")]
    public virtual CajCaja CajCaja { get; set; } = null!;

    [InverseProperty("CxcCobro")]
    public virtual ICollection<CxcCobroDet> CxcCobroDet { get; set; } = new List<CxcCobroDet>();

    [InverseProperty("CxcCobro")]
    public virtual ICollection<CxcCobroXAnticipoDet> CxcCobroXAnticipoDet { get; set; } = new List<CxcCobroXAnticipoDet>();

    [InverseProperty("CxcCobro")]
    public virtual ICollection<CxcCobroXCajCajaMovimiento> CxcCobroXCajCajaMovimiento { get; set; } = new List<CxcCobroXCajCajaMovimiento>();

    [InverseProperty("CxcCobro")]
    public virtual ICollection<CxcCobroXCtCbtecble> CxcCobroXCtCbtecble { get; set; } = new List<CxcCobroXCtCbtecble>();

    [InverseProperty("CxcCobro")]
    public virtual ICollection<CxcCobroXCtCbtecbleXAnulado> CxcCobroXCtCbtecbleXAnulado { get; set; } = new List<CxcCobroXCtCbtecbleXAnulado>();

    [InverseProperty("CxcCobro")]
    public virtual ICollection<CxcCobroXEstadoCobro> CxcCobroXEstadoCobro { get; set; } = new List<CxcCobroXEstadoCobro>();

    [InverseProperty("CxcCobro")]
    public virtual ICollection<CxcCobroXTarjeta> CxcCobroXTarjeta { get; set; } = new List<CxcCobroXTarjeta>();

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("CxcCobro")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [InverseProperty("CxcCobro")]
    public virtual ICollection<FaNotaCreDebXCxcCobro> FaNotaCreDebXCxcCobro { get; set; } = new List<FaNotaCreDebXCxcCobro>();

    [ForeignKey("IdBanco")]
    [InverseProperty("CxcCobro")]
    public virtual TbBanco? IdBancoNavigation { get; set; }

    [ForeignKey("IdCobroTipo")]
    [InverseProperty("CxcCobro")]
    public virtual CxcCobroTipo IdCobroTipoNavigation { get; set; } = null!;

    [ForeignKey("IdTipoNotaCredito")]
    [InverseProperty("CxcCobro")]
    public virtual FaTipoNota? IdTipoNotaCreditoNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("CxcCobro")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
