using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaNotaCreDebDetSubtotalIva0Totales
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [Column("SubTotal_0")]
    public double SubTotal0 { get; set; }

    [Column("SubTotal_Iva")]
    public double SubTotalIva { get; set; }

    [Column("sc_iva")]
    public double ScIva { get; set; }

    [Column("sc_total")]
    public double ScTotal { get; set; }
}
