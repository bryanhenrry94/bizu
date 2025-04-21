using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaFacturaXInMoviInve
{
    [Column("fa_IdEmpresa")]
    public int FaIdEmpresa { get; set; }

    [Column("fa_IdSucursal")]
    public int FaIdSucursal { get; set; }

    [Column("fa_IdBodega")]
    public int FaIdBodega { get; set; }

    [Column("fa_IdCbteVta")]
    [Precision(18, 0)]
    public decimal FaIdCbteVta { get; set; }

    [Column("inv_IdEmpresa")]
    public int InvIdEmpresa { get; set; }

    [Column("inv_IdSucursal")]
    public int InvIdSucursal { get; set; }

    [Column("inv_IdBodega")]
    public int InvIdBodega { get; set; }

    [Column("inv_IdMovi_inven_tipo")]
    public int InvIdMoviInvenTipo { get; set; }

    [Column("inv_IdNumMovi")]
    [Precision(18, 0)]
    public decimal InvIdNumMovi { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }
}
