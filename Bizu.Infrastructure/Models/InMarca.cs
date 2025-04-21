using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMarca")]
[Table("in_Marca")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMarca
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdMarca { get; set; }

    [StringLength(100)]
    public string? Descripcion { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("InMarca")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("InMarca")]
    public virtual ICollection<InMarcaFiltro> InMarcaFiltro { get; set; } = new List<InMarcaFiltro>();

    [InverseProperty("InMarca")]
    public virtual ICollection<InProducto> InProducto { get; set; } = new List<InProducto>();
}
