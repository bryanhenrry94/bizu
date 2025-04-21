using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwAfDepreXCicloValor
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdDepreciacion { get; set; }

    public int IdTipoDepreciacion { get; set; }

    public int IdActivoFijo { get; set; }

    public long Ciclo { get; set; }

    [Column("Valor_Depreciacion_Acum")]
    public double? ValorDepreciacionAcum { get; set; }

    [Column("Es_Activo_x_Mejora")]
    public bool EsActivoXMejora { get; set; }
}
