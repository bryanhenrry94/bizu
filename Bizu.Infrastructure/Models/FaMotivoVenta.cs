using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMotivoVta")]
[Table("fa_motivo_venta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaMotivoVenta
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdMotivo_Vta")]
    public int IdMotivoVta { get; set; }

    [Column("codMotivo_Vta")]
    [StringLength(50)]
    public string CodMotivoVta { get; set; } = null!;

    [Column("descripcion_motivo_vta")]
    [StringLength(250)]
    public string DescripcionMotivoVta { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [MaxLength(6)]
    public DateTime? FechaModificacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(50)]
    public string? UsuarioModificacion { get; set; }

    [StringLength(50)]
    public string? UsuarioCreacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [StringLength(50)]
    public string? UsuarioAnulacion { get; set; }

    [StringLength(100)]
    public string? MotivoAnulacion { get; set; }

    [InverseProperty("FaMotivoVenta")]
    public virtual ICollection<InProducto> InProducto { get; set; } = new List<InProducto>();
}
