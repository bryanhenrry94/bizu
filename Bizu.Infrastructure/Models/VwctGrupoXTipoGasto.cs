using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwctGrupoXTipoGasto
{
    public int IdEmpresa { get; set; }

    [Column("IdTipo_Gasto")]
    public int IdTipoGasto { get; set; }

    [Column("nom_tipo_Gasto")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoGasto { get; set; } = null!;

    [Column("IdTipo_Gasto_Padre")]
    public int? IdTipoGastoPadre { get; set; }

    [Column("nom_tipo_Gasto_Padre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoGastoPadre { get; set; } = null!;

    [Column("estado")]
    public bool Estado { get; set; }

    [Column("nivel")]
    public int? Nivel { get; set; }

    [Column("orden")]
    public int? Orden { get; set; }
}
