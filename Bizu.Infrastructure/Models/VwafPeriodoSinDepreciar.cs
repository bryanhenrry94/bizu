using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwafPeriodoSinDepreciar
{
    public int IdEmpresa { get; set; }

    public int IdPeriodo { get; set; }

    public int IdanioFiscal { get; set; }

    [Column("pe_mes")]
    public int PeMes { get; set; }

    [Column("pe_FechaIni", TypeName = "datetime")]
    public DateTime PeFechaIni { get; set; }

    [Column("pe_FechaFin", TypeName = "datetime")]
    public DateTime PeFechaFin { get; set; }

    [Column("pe_cerrado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCerrado { get; set; } = null!;

    [Column("pe_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeEstado { get; set; }

    [Column("idMes")]
    public int IdMes { get; set; }

    [Column("smes")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Smes { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Nemonico { get; set; } = null!;

    [Column("smesIngles")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SmesIngles { get; set; }
}
