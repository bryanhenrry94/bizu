using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("in_Ing_Egr_Inven_tmp")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InIngEgrInvenTmp
{
    public int? IdEmpresa { get; set; }

    public int? IdSucursal { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int? IdMoviInvenTipo { get; set; }

    [Precision(18, 0)]
    public decimal? IdNumMovi { get; set; }

    public int? IdBodega { get; set; }

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }

    [Column("IdMovi_inven_tipo_new")]
    public int? IdMoviInvenTipoNew { get; set; }

    [Column("IdNumMovi_new")]
    [Precision(18, 0)]
    public decimal? IdNumMoviNew { get; set; }
}
