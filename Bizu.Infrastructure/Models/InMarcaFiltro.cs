using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "Codigo", "IdMarca")]
[Table("in_Marca_filtro")]
[Index("IdEmpresa", "IdMarca", Name = "FK_in_Marca_filtro_in_Marca")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMarcaFiltro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(50)]
    public string Codigo { get; set; } = null!;

    [Key]
    public int IdMarca { get; set; }

    [ForeignKey("IdEmpresa, IdMarca")]
    [InverseProperty("InMarcaFiltro")]
    public virtual InMarca InMarca { get; set; } = null!;
}
