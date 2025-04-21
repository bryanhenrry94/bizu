using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpConciliacionCajaDetIngCajaTotalAplicado
{
    [Column("IdEmpresa_movcaj")]
    public int IdEmpresaMovcaj { get; set; }

    [Column("IdCbteCble_movcaj")]
    [Precision(18, 0)]
    public decimal IdCbteCbleMovcaj { get; set; }

    [Column("IdTipocbte_movcaj")]
    public int IdTipocbteMovcaj { get; set; }

    [Column("Total_aplicado")]
    public double? TotalAplicado { get; set; }
}
