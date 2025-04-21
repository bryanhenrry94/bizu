using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinProductoDespachadoXGuiaRemisionAcumulada
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("CantidadTotal_Guia_Acumulado")]
    public double? CantidadTotalGuiaAcumulado { get; set; }
}
