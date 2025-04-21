using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpConciliacionDetXCbtePago
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    [Column("IdEmpresa_pago")]
    public int IdEmpresaPago { get; set; }

    [Column("IdCbteCble_pago")]
    [Precision(18, 0)]
    public decimal IdCbteCblePago { get; set; }

    [Column("IdTipoCbte_pago")]
    public int IdTipoCbtePago { get; set; }
}
