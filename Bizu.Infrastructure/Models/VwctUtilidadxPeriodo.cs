using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctUtilidadxPeriodo
{
    public int IdEmpresa { get; set; }

    public int IdanioFiscal { get; set; }

    public int IdPeriodo { get; set; }

    [Column("Utilidad_Anterior")]
    public double UtilidadAnterior { get; set; }

    [Column("Utilidad_Periodo")]
    public double UtilidadPeriodo { get; set; }

    [Column("Utilidad_acum")]
    public double UtilidadAcum { get; set; }
}
