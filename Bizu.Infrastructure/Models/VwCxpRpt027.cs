using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt027
{
    public int IdEmpresa { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    public int Secuencia { get; set; }

    [Column("IdEmpresa_movcaja")]
    public int IdEmpresaMovcaja { get; set; }

    [Column("IdCbteCble_movcaja")]
    [Precision(18, 0)]
    public decimal IdCbteCbleMovcaja { get; set; }

    [Column("IdTipocbte_movcaja")]
    public int IdTipocbteMovcaja { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("cm_valor")]
    public double CmValor { get; set; }

    [Column("cm_beneficiario")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmBeneficiario { get; set; } = null!;

    public int IdTipoMovi { get; set; }

    [Column("tm_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TmDescripcion { get; set; } = null!;

    [Column("cm_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacion { get; set; } = null!;

    [Column("pc_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcCuenta { get; set; } = null!;
}
