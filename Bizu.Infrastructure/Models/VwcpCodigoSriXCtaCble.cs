using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpCodigoSriXCtaCble
{
    public int IdEmpresa { get; set; }

    [Column("idCodigo_SRI")]
    public int IdCodigoSri { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("fecha_UltMod")]
    [MaxLength(6)]
    public DateTime FechaUltMod { get; set; }

    [Column("idUsuario")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Ip { get; set; } = null!;

    [Column("pc_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcCuenta { get; set; } = null!;

    [Column("pc_EsMovimiento")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcEsMovimiento { get; set; } = null!;
}
