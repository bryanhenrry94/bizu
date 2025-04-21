using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("com_catalogo")]
[Index("IdCatalogocompraTipo", Name = "FK_com_catalogo_com_catalogo_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComCatalogo
{
    [Key]
    [StringLength(25)]
    public string IdCatalogocompra { get; set; } = null!;

    [Column("IdCatalogocompra_tipo")]
    [StringLength(15)]
    public string IdCatalogocompraTipo { get; set; } = null!;

    [StringLength(15)]
    public string? CodCatalogo { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(10)]
    public string? Abrebiatura { get; set; }

    [StringLength(50)]
    public string? NombreIngles { get; set; }

    public int? Orden { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [InverseProperty("IdEstadoAprobacionCatNavigation")]
    public virtual ICollection<ComOrdencompraLocal> ComOrdencompraLocalIdEstadoAprobacionCatNavigation { get; set; } = new List<ComOrdencompraLocal>();

    [InverseProperty("IdEstadoRecepcionCatNavigation")]
    public virtual ICollection<ComOrdencompraLocal> ComOrdencompraLocalIdEstadoRecepcionCatNavigation { get; set; } = new List<ComOrdencompraLocal>();

    [InverseProperty("IdEstadoAnulacionOcNavigation")]
    public virtual ICollection<ComParametro> ComParametroIdEstadoAnulacionOcNavigation { get; set; } = new List<ComParametro>();

    [InverseProperty("IdEstadoAprobacionOcNavigation")]
    public virtual ICollection<ComParametro> ComParametroIdEstadoAprobacionOcNavigation { get; set; } = new List<ComParametro>();

    [InverseProperty("IdEstadoAprobacionSolCompraNavigation")]
    public virtual ICollection<ComParametro> ComParametroIdEstadoAprobacionSolCompraNavigation { get; set; } = new List<ComParametro>();

    [InverseProperty("IdEstadoAprobacionNavigation")]
    public virtual ICollection<ComSolicitudCompra> ComSolicitudCompra { get; set; } = new List<ComSolicitudCompra>();

    [InverseProperty("IdEstadoAprobacionNavigation")]
    public virtual ICollection<ComSolicitudCompraDetAprobacion> ComSolicitudCompraDetAprobacionIdEstadoAprobacionNavigation { get; set; } = new List<ComSolicitudCompraDetAprobacion>();

    [InverseProperty("IdEstadoPreAprobacionNavigation")]
    public virtual ICollection<ComSolicitudCompraDetAprobacion> ComSolicitudCompraDetAprobacionIdEstadoPreAprobacionNavigation { get; set; } = new List<ComSolicitudCompraDetAprobacion>();

    [InverseProperty("IdEstadoAprobacionNavigation")]
    public virtual ICollection<ComSolicitudCompraDetPreAprobacion> ComSolicitudCompraDetPreAprobacion { get; set; } = new List<ComSolicitudCompraDetPreAprobacion>();

    [ForeignKey("IdCatalogocompraTipo")]
    [InverseProperty("ComCatalogo")]
    public virtual ComCatalogoTipo IdCatalogocompraTipoNavigation { get; set; } = null!;
}
