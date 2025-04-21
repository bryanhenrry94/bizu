using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt006
{
    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Nota")]
    [Precision(18, 0)]
    public decimal IdCbteCbleNota { get; set; }

    [Column("IdTipoCbte_Nota")]
    public int IdTipoCbteNota { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DebCre { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoNota { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Detalle { get; set; } = null!;

    [Column("cn_total")]
    [Precision(18, 2)]
    public decimal CnTotal { get; set; }

    [Column("cn_Nota")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnNota { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("nom_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCuenta { get; set; }

    [Column("clave")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Clave { get; set; }

    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("dc_Valor")]
    public double DcValor { get; set; }

    [Column("valor_debe")]
    public double ValorDebe { get; set; }

    [Column("valor_haber")]
    public double ValorHaber { get; set; }

    [Column("dc_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DcObservacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nom_Proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    public int IdSucursal { get; set; }

    [Column("nom_Sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [Column("nom_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoCbte { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Nombre { get; set; } = null!;

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [Column("cn_serie1")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnSerie1 { get; set; }

    [Column("cn_serie2")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnSerie2 { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }

    [Column("nom_punto_cargo_grupo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargoGrupo { get; set; }
}
