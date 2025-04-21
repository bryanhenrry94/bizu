using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctUtilidadxPeriodoSaldoPeriodoActual
{
    public int IdEmpresa { get; set; }

    public int IdAnioF { get; set; }

    public int IdPeriodo { get; set; }

    [Column("Utilidad_Periodo")]
    public double? UtilidadPeriodo { get; set; }
}
