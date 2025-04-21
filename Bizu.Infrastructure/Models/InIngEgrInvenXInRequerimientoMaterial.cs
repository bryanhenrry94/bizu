using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdMoviInvenTipo", "IdNumMovi")]
[Table("in_Ing_Egr_Inven_x_in_RequerimientoMaterial")]
[Index("IdEmpresa", "IdSucursal", "IdBodega", Name = "FK_in_Ing_Egr_Inven_x_in_RequerimientoMaterial_tb_bodega")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InIngEgrInvenXInRequerimientoMaterial
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

    public int? IdBodega { get; set; }

    [Column("Num_Requerimiento")]
    [Precision(18, 0)]
    public decimal NumRequerimiento { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdMoviInvenTipo, IdNumMovi")]
    [InverseProperty("InIngEgrInvenXInRequerimientoMaterial")]
    public virtual InIngEgrInven InIngEgrInven { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("InIngEgrInvenXInRequerimientoMaterial")]
    public virtual TbBodega? TbBodega { get; set; }
}
