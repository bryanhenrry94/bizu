using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("ImpIdEmpresa", "ImpIdSucursal", "ImpIdOrdenCompraExt", "InIdEmpresa", "InIdSucursal", "InIdBodega", "InIdMoviInvenTipo", "InIdNumMovi")]
[Table("in_movi_inven_X_imp_OrdCompraExterna")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMoviInvenXImpOrdCompraExterna
{
    [Key]
    [Column("imp_IdEmpresa")]
    public int ImpIdEmpresa { get; set; }

    [Key]
    [Column("imp_IdSucursal")]
    public int ImpIdSucursal { get; set; }

    [Key]
    [Column("imp_IdOrdenCompraExt")]
    [Precision(18, 0)]
    public decimal ImpIdOrdenCompraExt { get; set; }

    [Key]
    [Column("in_IdEmpresa")]
    public int InIdEmpresa { get; set; }

    [Key]
    [Column("in_IdSucursal")]
    public int InIdSucursal { get; set; }

    [Key]
    [Column("in_IdBodega")]
    public int InIdBodega { get; set; }

    [Key]
    [Column("in_IdMovi_inven_tipo")]
    public int InIdMoviInvenTipo { get; set; }

    [Key]
    [Column("in_IdNumMovi")]
    [Precision(18, 0)]
    public decimal InIdNumMovi { get; set; }
}
