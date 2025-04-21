using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdMoviInvenTipo", "IdNumMovi", "IdGuiaRemision")]
[Table("in_Ing_Egr_Inven_x_in_GuiaRemision")]
[Index("IdEmpresa", "IdSucursal", "IdGuiaRemision", Name = "FK_in_Ing_Egr_Inven_x_in_GuiaRemision_in_GuiaRemision")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InIngEgrInvenXInGuiaRemision
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdGuiaRemision")]
    [InverseProperty("InIngEgrInvenXInGuiaRemision")]
    public virtual InGuiaRemision InGuiaRemision { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdMoviInvenTipo, IdNumMovi")]
    [InverseProperty("InIngEgrInvenXInGuiaRemision")]
    public virtual InIngEgrInven InIngEgrInven { get; set; } = null!;
}
