using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcCobroXAnticipoTotalRespaldado
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdAnticipo { get; set; }

    [Column("Secuencia_ant")]
    public int SecuenciaAnt { get; set; }

    [Column("IdEmpresa_cbr")]
    public int IdEmpresaCbr { get; set; }

    [Column("IdSucursal_cbr")]
    public int IdSucursalCbr { get; set; }

    [Column("IdCobro_cbr")]
    [Precision(18, 0)]
    public decimal IdCobroCbr { get; set; }

    [Column("Total_Pagado")]
    public double? TotalPagado { get; set; }
}
