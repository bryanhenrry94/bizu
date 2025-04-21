using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdGuia")]
[Table("in_Guia_x_traspaso_bodega")]
[Index("IdMotivoTraslado", Name = "FK_in_Guia_x_traspaso_bodega_in_Catalogo")]
[Index("IdEmpresa", "CodDocumentoTipo", "IdEstablecimiento", "IdPuntoEmision", "NumDocumentoGuia", Name = "FK_in_Guia_x_traspaso_bodega_tb_sis_Documento_Tipo_Talonario")]
[Index("IdEmpresa", "IdSucursalPartida", Name = "FK_in_Guia_x_traspaso_bodega_tb_sucursal")]
[Index("IdEmpresa", "IdSucursalLlegada", Name = "FK_in_Guia_x_traspaso_bodega_tb_sucursal1")]
[Index("IdEmpresa", "IdTransportista", Name = "FK_in_Guia_x_traspaso_bodega_tb_transportista")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InGuiaXTraspasoBodega
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuia { get; set; }

    [StringLength(50)]
    public string? NumGuia { get; set; }

    [Column("IdSucursal_Partida")]
    public int? IdSucursalPartida { get; set; }

    [Column("IdSucursal_Llegada")]
    public int? IdSucursalLlegada { get; set; }

    [Column("Direc_sucu_Partida")]
    [StringLength(250)]
    public string? DirecSucuPartida { get; set; }

    [Column("Direc_sucu_Llegada")]
    [StringLength(250)]
    public string? DirecSucuLlegada { get; set; }

    [Precision(18, 0)]
    public decimal? IdTransportista { get; set; }

    [MaxLength(6)]
    public DateTime? Fecha { get; set; }

    [Column("Fecha_Traslado")]
    [MaxLength(6)]
    public DateTime? FechaTraslado { get; set; }

    [Column("Fecha_llegada")]
    [MaxLength(6)]
    public DateTime? FechaLlegada { get; set; }

    [Column("IdMotivo_Traslado")]
    [StringLength(15)]
    public string? IdMotivoTraslado { get; set; }

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

    [Column("Hora_Traslado")]
    [MaxLength(6)]
    public TimeOnly? HoraTraslado { get; set; }

    [Column("Hora_Llegada")]
    [MaxLength(6)]
    public TimeOnly? HoraLlegada { get; set; }

    [StringLength(20)]
    public string? CodDocumentoTipo { get; set; }

    [StringLength(3)]
    public string? IdEstablecimiento { get; set; }

    [StringLength(3)]
    public string? IdPuntoEmision { get; set; }

    [Column("NumDocumento_Guia")]
    [StringLength(20)]
    public string? NumDocumentoGuia { get; set; }

    [ForeignKey("IdMotivoTraslado")]
    [InverseProperty("InGuiaXTraspasoBodega")]
    public virtual InCatalogo? IdMotivoTrasladoNavigation { get; set; }

    [InverseProperty("InGuiaXTraspasoBodega")]
    public virtual ICollection<InGuiaXTraspasoBodegaDet> InGuiaXTraspasoBodegaDet { get; set; } = new List<InGuiaXTraspasoBodegaDet>();

    [InverseProperty("InGuiaXTraspasoBodega")]
    public virtual ICollection<InGuiaXTraspasoBodegaDetSinOc> InGuiaXTraspasoBodegaDetSinOc { get; set; } = new List<InGuiaXTraspasoBodegaDetSinOc>();

    [InverseProperty("InGuiaXTraspasoBodega")]
    public virtual ICollection<InGuiaXTraspasoBodegaXInTransferenciaDet> InGuiaXTraspasoBodegaXInTransferenciaDet { get; set; } = new List<InGuiaXTraspasoBodegaXInTransferenciaDet>();

    [InverseProperty("InGuiaXTraspasoBodega")]
    public virtual ICollection<InTransferenciaXInGuiaXTraspasoBodega> InTransferenciaXInGuiaXTraspasoBodega { get; set; } = new List<InTransferenciaXInGuiaXTraspasoBodega>();

    [ForeignKey("IdEmpresa, CodDocumentoTipo, IdEstablecimiento, IdPuntoEmision, NumDocumentoGuia")]
    [InverseProperty("InGuiaXTraspasoBodega")]
    public virtual TbSisDocumentoTipoTalonario? TbSisDocumentoTipoTalonario { get; set; }

    [ForeignKey("IdEmpresa, IdSucursalLlegada")]
    [InverseProperty("InGuiaXTraspasoBodegaTbSucursal")]
    public virtual TbSucursal? TbSucursal { get; set; }

    [ForeignKey("IdEmpresa, IdSucursalPartida")]
    [InverseProperty("InGuiaXTraspasoBodegaTbSucursalNavigation")]
    public virtual TbSucursal? TbSucursalNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdTransportista")]
    [InverseProperty("InGuiaXTraspasoBodega")]
    public virtual TbTransportista? TbTransportista { get; set; }
}
