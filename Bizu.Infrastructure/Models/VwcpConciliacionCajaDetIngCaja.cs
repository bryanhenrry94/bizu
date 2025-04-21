using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpConciliacionCajaDetIngCaja
{
    public int IdEmpresa { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_movcaj")]
    public int IdEmpresaMovcaj { get; set; }

    [Column("IdCbteCble_movcaj")]
    [Precision(18, 0)]
    public decimal IdCbteCbleMovcaj { get; set; }

    [Column("IdTipocbte_movcaj")]
    public int IdTipocbteMovcaj { get; set; }

    [Column("valor_aplicado")]
    public double ValorAplicado { get; set; }

    [Column("cm_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacion { get; set; } = null!;

    [Column("cm_valor")]
    public double CmValor { get; set; }

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    public int IdPeriodo { get; set; }
}
