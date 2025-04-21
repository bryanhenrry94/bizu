using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tmp_Cobros_fecha_corte_SP010")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class TmpCobrosFechaCorteSp010
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtTipoDoc { get; set; }

    [Precision(18, 0)]
    public decimal? IdCobro { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    [Column("dc_TipoDocumento")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DcTipoDocumento { get; set; }

    [Column("vt_total")]
    public double? VtTotal { get; set; }
}
