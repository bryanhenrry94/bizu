using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomDevCompraDetCantDevueltaXProd
{
    [Column("ocdet_IdEmpresa")]
    public int? OcdetIdEmpresa { get; set; }

    [Column("ocdet_IdSucursal")]
    public int? OcdetIdSucursal { get; set; }

    [Column("ocdet_IdOrdenCompra")]
    [Precision(18, 0)]
    public decimal? OcdetIdOrdenCompra { get; set; }

    [Column("ocdet_Secuencia")]
    public int? OcdetSecuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("cant_devuelta")]
    public double? CantDevuelta { get; set; }
}
