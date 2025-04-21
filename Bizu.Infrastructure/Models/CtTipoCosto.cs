using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoCosto")]
[Table("ct_Tipo_costo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtTipoCosto
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdTipo_Costo")]
    public int IdTipoCosto { get; set; }

    [Column("nom_tipo_Costo")]
    [StringLength(250)]
    public string? NomTipoCosto { get; set; }

    [Column("nom_tipo_Costo2")]
    [StringLength(250)]
    public string? NomTipoCosto2 { get; set; }

    [Column("estado")]
    public bool? Estado { get; set; }

    [Column("orden")]
    public int? Orden { get; set; }
}
