using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaBaPrestamoDetalleXAfActivoFijoPrendados
{
    public int IdEmpresa { get; set; }

    public int IdPrestamo { get; set; }

    public int IdActivoFijo { get; set; }

    [Column("Garantia_Bancaria")]
    public double? GarantiaBancaria { get; set; }

    [Column("Af_costo_compra")]
    public double AfCostoCompra { get; set; }
}
