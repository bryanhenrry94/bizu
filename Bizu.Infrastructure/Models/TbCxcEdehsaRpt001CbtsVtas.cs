using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tbCXC_EDEHSA_Rpt001_cbts_vtas")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCxcEdehsaRpt001CbtsVtas
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    public string? VtTipoDoc { get; set; }

    public double? Monto { get; set; }

    public double? TotalCobrado { get; set; }

    [Column(TypeName = "text")]
    public string? Observacion { get; set; }

    [StringLength(25)]
    public string? CodObra { get; set; }
}
