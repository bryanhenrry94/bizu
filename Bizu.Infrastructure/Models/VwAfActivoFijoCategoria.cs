using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwAfActivoFijoCategoria
{
    public int IdEmpresa { get; set; }

    [Column("IdCategoriaAF")]
    public int IdCategoriaAf { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    [Column("CodCategoriaAF")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodCategoriaAf { get; set; }

    public int IdActivoFijoTipo { get; set; }

    [Column("Af_Descripcion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfDescripcion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;
}
