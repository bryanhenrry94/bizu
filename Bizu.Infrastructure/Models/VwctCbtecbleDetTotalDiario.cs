using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctCbtecbleDetTotalDiario
{
    public int IdEmpresa { get; set; }

    public int IdTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Column("dc_Valor")]
    public double? DcValor { get; set; }
}
