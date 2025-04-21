using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinMoviInveDetalleXComOrdencompraLocalDetTotalCant
{
    [Column("ocd_IdEmpresa")]
    public int? OcdIdEmpresa { get; set; }

    [Column("ocd_IdSucursal")]
    public int? OcdIdSucursal { get; set; }

    [Column("ocd_IdOrdenCompra")]
    [Precision(18, 0)]
    public decimal? OcdIdOrdenCompra { get; set; }

    [Column("ocd_Secuencia")]
    public int? OcdSecuencia { get; set; }

    [Column("dm_cantidad_Inv")]
    public double? DmCantidadInv { get; set; }
}
