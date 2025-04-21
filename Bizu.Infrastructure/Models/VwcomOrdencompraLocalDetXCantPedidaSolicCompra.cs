using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomOrdencompraLocalDetXCantPedidaSolicCompra
{
    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("do_CantidadPedida_Oc")]
    public double? DoCantidadPedidaOc { get; set; }

    [Column("scd_IdEmpresa")]
    public int? ScdIdEmpresa { get; set; }

    [Column("scd_IdSucursal")]
    public int? ScdIdSucursal { get; set; }

    [Column("scd_IdSolicitudCompra")]
    [Precision(18, 0)]
    public decimal? ScdIdSolicitudCompra { get; set; }

    [Column("scd_Secuencia")]
    public int? ScdSecuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    public int? IdMotivo { get; set; }
}
