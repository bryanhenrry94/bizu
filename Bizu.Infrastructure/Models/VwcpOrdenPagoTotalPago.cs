using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpOrdenPagoTotalPago
{
    [Column("IdEmpresa_cbtecble")]
    public int IdEmpresaCbtecble { get; set; }

    [Column("IdTipoCbte_cbtecble")]
    public int IdTipoCbteCbtecble { get; set; }

    [Column("IdCbteCble_cbtecble")]
    [Precision(18, 0)]
    public decimal IdCbteCbleCbtecble { get; set; }

    [Column("Total_Pagado")]
    public double? TotalPagado { get; set; }
}
