using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinCategoriaLinGrSubgr
{
    [Precision(21, 0)]
    public decimal IdRegistro { get; set; }

    public int IdEmpresa { get; set; }

    [Column("ID")]
    [StringLength(61)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Id { get; set; } = null!;

    [Column("IDPadre")]
    [StringLength(49)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Idpadre { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Codigo { get; set; }

    [Column("descripcion")]
    [StringLength(211)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    public int? IdLinea { get; set; }

    public int? IdGrupo { get; set; }

    public int? IdSubGrupo { get; set; }

    public long IdNivel { get; set; }
}
