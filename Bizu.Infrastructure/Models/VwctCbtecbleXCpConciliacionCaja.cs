using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctCbtecbleXCpConciliacionCaja
{
    public int IdEmpresa { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcTipoCbte { get; set; } = null!;

    [Column("IdEmpresa_cbte")]
    public int IdEmpresaCbte { get; set; }

    public int IdTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Column("secuencia")]
    public int Secuencia { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("nom_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCuenta { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("nom_Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("nom_Centro_costo_sub_centro_costo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCostoSubCentroCosto { get; set; }

    public double Debe { get; set; }

    public double Haber { get; set; }

    [Column("dc_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DcObservacion { get; set; } = null!;

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("nom_punto_cargo_grupo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargoGrupo { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }
}
