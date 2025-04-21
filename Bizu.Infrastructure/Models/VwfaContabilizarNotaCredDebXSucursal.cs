using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaContabilizarNotaCredDebXSucursal
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [Column("IVA")]
    public double? Iva { get; set; }

    [Column("SUBTOTAL")]
    public double? Subtotal { get; set; }

    [Column("tOTAL")]
    public double? TOtal { get; set; }

    [Column("descuentototal")]
    public double? Descuentototal { get; set; }
}
