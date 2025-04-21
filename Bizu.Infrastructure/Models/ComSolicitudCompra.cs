using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdSolicitudCompra")]
[Table("com_solicitud_compra")]
[Index("IdEstadoAprobacion", Name = "FK_com_solicitud_compra_com_catalogo")]
[Index("IdEmpresa", Name = "FK_com_solicitud_compra_com_comprador")]
[Index("IdEmpresa", "IdSucursal", "IdProyecto", "IdOferta", Name = "FK_com_solicitud_compra_obr_Oferta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComSolicitudCompra
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdSolicitudCompra { get; set; }

    [StringLength(50)]
    public string NumDocumento { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdSolicitante { get; set; }

    [Column("fecha")]
    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("plazo")]
    public int Plazo { get; set; }

    [Column("fecha_vtc")]
    [MaxLength(6)]
    public DateTime FechaVtc { get; set; }

    [Column("observacion")]
    [StringLength(1000)]
    public string Observacion { get; set; } = null!;

    public int? IdProyecto { get; set; }

    public int? IdOferta { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAnul { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(500)]
    public string? MotivoAnulacion { get; set; }

    [StringLength(25)]
    public string? IdEstadoAprobacion { get; set; }

    [StringLength(25)]
    public string? IdUsuarioAprobo { get; set; }

    [StringLength(25)]
    public string? MotivoAprobacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAprobacion { get; set; }

    [InverseProperty("ComSolicitudCompra")]
    public virtual ICollection<ComSolicitudCompraDet> ComSolicitudCompraDet { get; set; } = new List<ComSolicitudCompraDet>();

    [ForeignKey("IdEstadoAprobacion")]
    [InverseProperty("ComSolicitudCompra")]
    public virtual ComCatalogo? IdEstadoAprobacionNavigation { get; set; }
}
