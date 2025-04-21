using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("caj_catalogo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajCatalogo
{
    [Key]
    [Column("IdCatalogo_cj")]
    [StringLength(25)]
    public string IdCatalogoCj { get; set; } = null!;

    [Column("nom_Catalogo_cj")]
    [StringLength(50)]
    public string NomCatalogoCj { get; set; } = null!;

    [Column("IdCatalogo_cj_tipo")]
    [StringLength(25)]
    public string IdCatalogoCjTipo { get; set; } = null!;
}
