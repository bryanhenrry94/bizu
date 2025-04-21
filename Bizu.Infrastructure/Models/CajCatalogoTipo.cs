using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("caj_catalogo_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajCatalogoTipo
{
    [Key]
    [Column("IdCatalogo_cj_tipo")]
    [StringLength(25)]
    public string IdCatalogoCjTipo { get; set; } = null!;

    [Column("nom_IdCatalogo_cj_tipo")]
    [StringLength(50)]
    public string NomIdCatalogoCjTipo { get; set; } = null!;
}
