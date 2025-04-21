using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("in_UnidadMedida")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InUnidadMedida
{
    [Key]
    [StringLength(25)]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("cod_alterno")]
    [StringLength(25)]
    public string? CodAlterno { get; set; }

    [StringLength(500)]
    public string Descripcion { get; set; } = null!;

    [Column("Usado_en_Movimiento")]
    [StringLength(1)]
    public string? UsadoEnMovimiento { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<ComOrdencompraLocalDet> ComOrdencompraLocalDet { get; set; } = new List<ComOrdencompraLocalDet>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<ComSolicitudCompraDet> ComSolicitudCompraDet { get; set; } = new List<ComSolicitudCompraDet>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<ComSolicitudCompraDetAprobacion> ComSolicitudCompraDetAprobacion { get; set; } = new List<ComSolicitudCompraDetAprobacion>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<CpLiquidacionCompraDet> CpLiquidacionCompraDet { get; set; } = new List<CpLiquidacionCompraDet>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<InGuiaRemisionDet> InGuiaRemisionDet { get; set; } = new List<InGuiaRemisionDet>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDetIdUnidadMedidaNavigation { get; set; } = new List<InIngEgrInvenDet>();

    [InverseProperty("IdUnidadMedidaSinConversionNavigation")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDetIdUnidadMedidaSinConversionNavigation { get; set; } = new List<InIngEgrInvenDet>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<InInvRpt026> InInvRpt026 { get; set; } = new List<InInvRpt026>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<InMoviInveDetalle> InMoviInveDetalleIdUnidadMedidaNavigation { get; set; } = new List<InMoviInveDetalle>();

    [InverseProperty("IdUnidadMedidaSinConversionNavigation")]
    public virtual ICollection<InMoviInveDetalle> InMoviInveDetalleIdUnidadMedidaSinConversionNavigation { get; set; } = new List<InMoviInveDetalle>();

    [InverseProperty("IdUnidadMedidaConsumoNavigation")]
    public virtual ICollection<InProducto> InProductoIdUnidadMedidaConsumoNavigation { get; set; } = new List<InProducto>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<InProducto> InProductoIdUnidadMedidaNavigation { get; set; } = new List<InProducto>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<InTransferenciaDet> InTransferenciaDet { get; set; } = new List<InTransferenciaDet>();

    [InverseProperty("IdUnidadMedidaEquivaNavigation")]
    public virtual ICollection<InUnidadMedidaEquivConversion> InUnidadMedidaEquivConversionIdUnidadMedidaEquivaNavigation { get; set; } = new List<InUnidadMedidaEquivConversion>();

    [InverseProperty("IdUnidadMedidaNavigation")]
    public virtual ICollection<InUnidadMedidaEquivConversion> InUnidadMedidaEquivConversionIdUnidadMedidaNavigation { get; set; } = new List<InUnidadMedidaEquivConversion>();
}
