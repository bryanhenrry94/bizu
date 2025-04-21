using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("cxc_rpt_tmp_Cobros_fecha_corte_SP012")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcRptTmpCobrosFechaCorteSp012
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    public string? VtTipoDoc { get; set; }

    [Precision(18, 0)]
    public decimal? IdCobro { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string IdCobroTipo { get; set; } = null!;

    [Column("dc_TipoDocumento")]
    [StringLength(20)]
    public string? DcTipoDocumento { get; set; }

    [Column("vt_total")]
    public double? VtTotal { get; set; }

    [Column("vt_Observacion")]
    [StringLength(500)]
    public string? VtObservacion { get; set; }
}
