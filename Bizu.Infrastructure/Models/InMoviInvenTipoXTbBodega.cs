using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMoviInvenTipo", "IdSucucursal", "IdBodega")]
[Table("in_movi_inven_tipo_x_tb_bodega")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_in_movi_inven_tipo_x_tb_bodega_ct_plancta")]
[Index("IdEmpresa", "IdSucucursal", "IdBodega", Name = "FK_in_movi_inven_tipo_x_tb_bodega_tb_bodega")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMoviInvenTipoXTbBodega
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Key]
    public int IdSucucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("InMoviInvenTipoXTbBodega")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdMoviInvenTipo")]
    [InverseProperty("InMoviInvenTipoXTbBodega")]
    public virtual InMoviInvenTipo InMoviInvenTipo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucucursal, IdBodega")]
    [InverseProperty("InMoviInvenTipoXTbBodega")]
    public virtual TbBodega TbBodega { get; set; } = null!;
}
