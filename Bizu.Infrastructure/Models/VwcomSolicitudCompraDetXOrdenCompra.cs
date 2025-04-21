using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomSolicitudCompraDetXOrdenCompra
{
    [Column("scd_IdEmpresa")]
    public int ScdIdEmpresa { get; set; }

    [Column("scd_IdSolicitudCompra")]
    [Precision(18, 0)]
    public decimal ScdIdSolicitudCompra { get; set; }

    [Column("scd_IdSucursal")]
    public int ScdIdSucursal { get; set; }

    [Column("scd_Secuencia")]
    public int ScdSecuencia { get; set; }

    [Column("ocd_IdEmpresa")]
    public int OcdIdEmpresa { get; set; }

    [Column("ocd_IdSucursal")]
    public int OcdIdSucursal { get; set; }

    [Column("ocd_IdOrdenCompra")]
    [Precision(18, 0)]
    public decimal OcdIdOrdenCompra { get; set; }
}
