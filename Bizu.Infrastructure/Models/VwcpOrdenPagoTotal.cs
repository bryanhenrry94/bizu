using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpOrdenPagoTotal
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenPago { get; set; }

    [Column("Total_OP")]
    public double? TotalOp { get; set; }
}
