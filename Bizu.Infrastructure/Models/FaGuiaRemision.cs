using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdGuiaRemision")]
[Table("fa_guia_remision")]
[Index("IdEmpresa", "IdPeriodo", Name = "FK_fa_guia_remision_ct_periodo")]
[Index("IdEmpresa", "IdVendedor", Name = "FK_fa_guia_remision_fa_Vendedor")]
[Index("IdEmpresa", "IdCliente", Name = "FK_fa_guia_remision_fa_cliente")]
[Index("IdEmpresa", "CodDocumentoTipo", "Serie1", "Serie2", "NumGuiaPreimpresa", Name = "FK_fa_guia_remision_tb_sis_Documento_Tipo_Talonario")]
[Index("IdEmpresa", "IdTransportista", Name = "FK_fa_guia_remision_tb_transportista")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaGuiaRemision
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    [StringLength(20)]
    public string CodGuiaRemision { get; set; } = null!;

    [StringLength(20)]
    public string? CodDocumentoTipo { get; set; }

    [StringLength(3)]
    public string? Serie1 { get; set; }

    [StringLength(3)]
    public string? Serie2 { get; set; }

    [Column("NumGuia_Preimpresa")]
    [StringLength(20)]
    public string? NumGuiaPreimpresa { get; set; }

    [Column("NUAutorizacion")]
    [StringLength(50)]
    public string? Nuautorizacion { get; set; }

    [Column("Fecha_Autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Precision(18, 0)]
    public decimal IdTransportista { get; set; }

    [Column("gi_fecha")]
    [MaxLength(6)]
    public DateTime GiFecha { get; set; }

    [Column("gi_plazo")]
    [Precision(18, 0)]
    public decimal? GiPlazo { get; set; }

    [Column("gi_fech_venc")]
    [MaxLength(6)]
    public DateTime? GiFechVenc { get; set; }

    [Column("gi_Observacion")]
    [StringLength(1000)]
    public string? GiObservacion { get; set; }

    [Column("gi_TotalKilos")]
    public double? GiTotalKilos { get; set; }

    [Column("gi_TotalQuintales")]
    public double? GiTotalQuintales { get; set; }

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
    [StringLength(50)]
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    public string Ip { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [StringLength(1)]
    public string? Impreso { get; set; }

    public int? IdPeriodo { get; set; }

    [Column("gi_flete")]
    public double GiFlete { get; set; }

    [Column("gi_interes")]
    public double GiInteres { get; set; }

    [Column("gi_seguro")]
    public double GiSeguro { get; set; }

    [Column("gi_OtroValor1")]
    public double GiOtroValor1 { get; set; }

    [Column("gi_OtroValor2")]
    public double GiOtroValor2 { get; set; }

    [Column("gi_FechaIniTraslado")]
    [MaxLength(6)]
    public DateTime GiFechaIniTraslado { get; set; }

    [Column("gi_FechaFinTraslado")]
    [MaxLength(6)]
    public DateTime GiFechaFinTraslado { get; set; }

    [Column("placa")]
    [StringLength(20)]
    public string Placa { get; set; } = null!;

    [Column("ruta")]
    [StringLength(300)]
    public string? Ruta { get; set; }

    [Column("Direccion_Origen")]
    [StringLength(300)]
    public string DireccionOrigen { get; set; } = null!;

    [Column("Direccion_Destino")]
    [StringLength(300)]
    public string DireccionDestino { get; set; } = null!;

    [Column("idMotivo_traslado")]
    public int? IdMotivoTraslado { get; set; }

    [ForeignKey("IdEmpresa, IdPeriodo")]
    [InverseProperty("FaGuiaRemision")]
    public virtual CtPeriodo? CtPeriodo { get; set; }

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("FaGuiaRemision")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [InverseProperty("FaGuiaRemision")]
    public virtual ICollection<FaFacturaXFaGuiaRemision> FaFacturaXFaGuiaRemision { get; set; } = new List<FaFacturaXFaGuiaRemision>();

    [InverseProperty("FaGuiaRemision")]
    public virtual ICollection<FaGuiaRemisionDet> FaGuiaRemisionDet { get; set; } = new List<FaGuiaRemisionDet>();

    [ForeignKey("IdEmpresa, IdVendedor")]
    [InverseProperty("FaGuiaRemision")]
    public virtual FaVendedor FaVendedor { get; set; } = null!;

    [InverseProperty("FaGuiaRemision")]
    public virtual ICollection<InTransferenciaXFaGuiaRemision> InTransferenciaXFaGuiaRemision { get; set; } = new List<InTransferenciaXFaGuiaRemision>();

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("FaGuiaRemision")]
    public virtual TbBodega TbBodega { get; set; } = null!;

    [ForeignKey("IdEmpresa, CodDocumentoTipo, Serie1, Serie2, NumGuiaPreimpresa")]
    [InverseProperty("FaGuiaRemision")]
    public virtual TbSisDocumentoTipoTalonario? TbSisDocumentoTipoTalonario { get; set; }

    [ForeignKey("IdEmpresa, IdTransportista")]
    [InverseProperty("FaGuiaRemision")]
    public virtual TbTransportista TbTransportista { get; set; } = null!;
}
