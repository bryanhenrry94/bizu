using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCategoria")]
[Table("in_categorias")]
[Index("CodCategoria", Name = "IX_in_categorias_Ca_Categoria")]
[Index("IdCategoria", Name = "IX_in_categorias_IdCategoria")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InCategorias
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(25)]
    public string IdCategoria { get; set; } = null!;

    [Column("ca_Categoria")]
    [StringLength(100)]
    public string CaCategoria { get; set; } = null!;

    [StringLength(25)]
    public string? IdCategoriaPadre { get; set; }

    [Column("ca_Posicion")]
    public int CaPosicion { get; set; }

    [Column("ca_indexIcono")]
    public int CaIndexIcono { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("ca_nivel")]
    public int CaNivel { get; set; }

    [StringLength(500)]
    public string RutaPadre { get; set; } = null!;

    [Column("IdCtaCtble_Inve")]
    [StringLength(20)]
    public string? IdCtaCtbleInve { get; set; }

    [Column("IdCtaCtble_Costo")]
    [StringLength(20)]
    public string? IdCtaCtbleCosto { get; set; }

    [Column("IdCentro_Costo_Inventario")]
    [StringLength(20)]
    public string? IdCentroCostoInventario { get; set; }

    [Column("IdCentro_Costo_Costo")]
    [StringLength(20)]
    public string? IdCentroCostoCosto { get; set; }

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(50)]
    public string? MotivoAnulacion { get; set; }

    [Column("cod_categoria")]
    [StringLength(50)]
    public string? CodCategoria { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("InCategorias")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("InCategorias")]
    public virtual ICollection<InLinea> InLinea { get; set; } = new List<InLinea>();
}
