using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinMoviInveXComOrdencompraLocal
{
    [Column("mi_IdEmpresa")]
    public int MiIdEmpresa { get; set; }

    [Column("mi_IdSucursal")]
    public int MiIdSucursal { get; set; }

    [Column("mi_IdBodega")]
    public int MiIdBodega { get; set; }

    [Column("mi_IdMovi_inven_tipo")]
    public int MiIdMoviInvenTipo { get; set; }

    [Column("mi_IdNumMovi")]
    [Precision(18, 0)]
    public decimal MiIdNumMovi { get; set; }

    [Column("ocd_IdEmpresa")]
    public int OcdIdEmpresa { get; set; }

    [Column("ocd_IdSucursal")]
    public int OcdIdSucursal { get; set; }

    [Column("ocd_IdOrdenCompra")]
    [Precision(18, 0)]
    public decimal OcdIdOrdenCompra { get; set; }
}
