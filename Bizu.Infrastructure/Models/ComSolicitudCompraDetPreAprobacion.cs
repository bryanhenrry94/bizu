using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursalSc", "IdSolicitudCompra", "SecuenciaSc")]
[Table("com_solicitud_compra_det_pre_aprobacion")]
[Index("IdEstadoAprobacion", Name = "FK_com_solicitud_compra_det_pre_aprobacion_com_catalogo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComSolicitudCompraDetPreAprobacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdSucursal_SC")]
    public int IdSucursalSc { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdSolicitudCompra { get; set; }

    [Key]
    [Column("Secuencia_SC")]
    public int SecuenciaSc { get; set; }

    [StringLength(25)]
    public string IdEstadoAprobacion { get; set; } = null!;

    [StringLength(25)]
    public string? IdUsuarioAprueba { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAprobacion { get; set; }

    [Column("do_observacion")]
    [StringLength(550)]
    public string? DoObservacion { get; set; }

    [ForeignKey("IdEstadoAprobacion")]
    [InverseProperty("ComSolicitudCompraDetPreAprobacion")]
    public virtual ComCatalogo IdEstadoAprobacionNavigation { get; set; } = null!;
}
