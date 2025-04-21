using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctCentroCostoSubCentroCosto
{
    public int IdEmpresa { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCentroCosto { get; set; } = null!;

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCentroCostoSubCentroCosto { get; set; } = null!;

    [Column("cod_subcentroCosto")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodSubcentroCosto { get; set; }

    [Column("nom_Centro_costo_sub_centro_costo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCentroCostoSubCentroCosto { get; set; } = null!;

    [Column("pc_Estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcEstado { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCble { get; set; }

    [Column("nom_Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCentroCosto { get; set; } = null!;

    [Column("pc_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PcCuenta { get; set; }

    [Column("pc_clave_corta")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PcClaveCorta { get; set; }
}
