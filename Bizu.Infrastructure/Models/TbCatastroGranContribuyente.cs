using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_catastroGranContribuyente")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCatastroGranContribuyente
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ruc")]
    [StringLength(15)]
    public string Ruc { get; set; } = null!;

    [Column("razon_social")]
    [StringLength(500)]
    public string RazonSocial { get; set; } = null!;

    [Column("oficio_atributo_gran_contribuyente")]
    [StringLength(50)]
    public string? OficioAtributoGranContribuyente { get; set; }

    [Column("provincia")]
    [StringLength(50)]
    public string? Provincia { get; set; }

    [Column("jurisdiccion")]
    [StringLength(50)]
    public string? Jurisdiccion { get; set; }

    [Column("descripcion_tipo")]
    [StringLength(100)]
    public string? DescripcionTipo { get; set; }

    [Column("descripcion_subtipo")]
    [StringLength(100)]
    public string? DescripcionSubtipo { get; set; }
}
