using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwAfValoresDepreXAf
{
    public int IdEmpresa { get; set; }

    public int IdActivoFijo { get; set; }

    public int IdTipoDepreciacion { get; set; }

    [Column("Valor_Depreciacion")]
    public double? ValorDepreciacion { get; set; }

    [Column("Valor_Depre_Acum")]
    public double? ValorDepreAcum { get; set; }

    [Column("Valor_Importe")]
    public double? ValorImporte { get; set; }
}
