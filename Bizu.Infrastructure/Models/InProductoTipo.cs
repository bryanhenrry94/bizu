using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProductoTipo")]
[Table("in_ProductoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InProductoTipo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdProductoTipo { get; set; }

    [Column("tp_descripcion")]
    [StringLength(50)]
    public string TpDescripcion { get; set; } = null!;

    [Column("tp_EsCombo")]
    [StringLength(1)]
    public string? TpEsCombo { get; set; }

    [Column("tp_ManejaInven")]
    [StringLength(1)]
    public string? TpManejaInven { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

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
    public string? EsMateriaPrima { get; set; }

    [StringLength(1)]
    public string? EsProductoTerminado { get; set; }

    [StringLength(200)]
    public string? MotivoAnulacion { get; set; }

    [InverseProperty("InProductoTipo")]
    public virtual ICollection<InProducto> InProducto { get; set; } = new List<InProducto>();
}
