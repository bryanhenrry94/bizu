using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinIngEgrInvenXInMoviInve
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Column("signo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Signo { get; set; } = null!;

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }

    [Column("Desc_mov_inv")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescMovInv { get; set; } = null!;

    [Column("tm_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TmDescripcion { get; set; } = null!;

    [Column("cm_descripcionCorta")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmDescripcionCorta { get; set; } = null!;

    [Column("cm_observacion", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacion { get; set; } = null!;

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [Column("Genera_Movi_Inven")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string GeneraMoviInven { get; set; } = null!;
}
