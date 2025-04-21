using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaContabilizacionFacturaXSucursal
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    public double? Subtotal { get; set; }

    public double? Descuento { get; set; }

    [Column("iva")]
    public double? Iva { get; set; }

    public double? Total { get; set; }
}
