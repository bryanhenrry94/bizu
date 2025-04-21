using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPresentacion")]
[Table("in_presentacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InPresentacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(25)]
    public string IdPresentacion { get; set; } = null!;

    [Column("nom_presentacion")]
    [StringLength(150)]
    public string NomPresentacion { get; set; } = null!;

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [InverseProperty("InPresentacion")]
    public virtual ICollection<InProducto> InProducto { get; set; } = new List<InProducto>();
}
