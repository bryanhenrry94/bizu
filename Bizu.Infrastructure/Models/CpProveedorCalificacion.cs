using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProveedor", "IdCalificacion")]
[Table("cp_proveedor_Calificacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpProveedorCalificacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Key]
    public int IdCalificacion { get; set; }

    public double Calificacion { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [MaxLength(6)]
    public DateTime FechaTransaccion { get; set; }

    [StringLength(25)]
    public string IdUsuario { get; set; } = null!;

    [MaxLength(6)]
    public DateTime FechaCreacion { get; set; }

    [StringLength(25)]
    public string? IdUsuarioModificacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaModificacion { get; set; }

    [StringLength(25)]
    public string? IdUsuarioAnulacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [StringLength(50)]
    public string? MotivoAnulacion { get; set; }

    public bool Liberado { get; set; }

    [StringLength(25)]
    public string? IdUsuarioAprobacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAprobacion { get; set; }

    [StringLength(50)]
    public string? MotivoAprobacion { get; set; }
}
