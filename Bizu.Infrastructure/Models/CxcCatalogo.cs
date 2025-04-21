using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cxc_Catalogo")]
[Index("IdCatalogoTipo", Name = "FK_cxc_Catalogo_cxc_CatalogoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCatalogo
{
    [Key]
    [StringLength(20)]
    public string IdCatalogo { get; set; } = null!;

    [Column("IdCatalogo_tipo")]
    [StringLength(20)]
    public string IdCatalogoTipo { get; set; } = null!;

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    public int? Orden { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [ForeignKey("IdCatalogoTipo")]
    [InverseProperty("CxcCatalogo")]
    public virtual CxcCatalogoTipo IdCatalogoTipoNavigation { get; set; } = null!;
}
