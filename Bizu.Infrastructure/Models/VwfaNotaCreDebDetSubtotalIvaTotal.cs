using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaNotaCreDebDetSubtotalIvaTotal
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [Column("sc_subtotal")]
    public double? ScSubtotal { get; set; }

    [Column("sc_iva")]
    public double? ScIva { get; set; }

    [Column("sc_total")]
    public double? ScTotal { get; set; }

    [Column("vt_por_iva")]
    public double? VtPorIva { get; set; }
}
