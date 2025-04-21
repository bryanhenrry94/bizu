using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdUsuario")]
[Table("tb_bodega_Filtro")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbBodegaFiltro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;
}
