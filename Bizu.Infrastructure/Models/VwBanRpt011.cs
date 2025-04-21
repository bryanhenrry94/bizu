using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwBanRpt011
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    public int IdBanco { get; set; }

    public int IdPeriodo { get; set; }

    [Column("nom_banco")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBanco { get; set; } = null!;

    [Column("ba_Num_Cuenta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BaNumCuenta { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoCbte { get; set; } = null!;

    [Column("Tipo_Cbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoCbte { get; set; } = null!;

    public double Valor { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Cheque { get; set; }

    [Column("Titulo_grupo")]
    [MaxLength(0)]
    public byte[]? TituloGrupo { get; set; }

    [Column("referencia")]
    [MaxLength(0)]
    public byte[]? Referencia { get; set; }

    [Column("ruc_empresa")]
    [StringLength(13)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string RucEmpresa { get; set; } = null!;

    [Column("nom_empresa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEmpresa { get; set; } = null!;
}
