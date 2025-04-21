using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaSp", "IdUsuarioSp")]
[Table("tbINV_Rpt001")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbInvRpt001
{
    [Key]
    [Column("IdEmpresa_SP")]
    public int IdEmpresaSp { get; set; }

    [Key]
    [Column("IdUsuario_SP")]
    [StringLength(20)]
    public string IdUsuarioSp { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(20)]
    public string? NomPc { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    public string SuDescripcion { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    public string BoDescripcion { get; set; } = null!;

    [StringLength(25)]
    public string IdCategoria { get; set; } = null!;

    [Column("ca_Categoria")]
    [StringLength(100)]
    public string CaCategoria { get; set; } = null!;

    [Column("pr_codigo")]
    [StringLength(50)]
    public string? PrCodigo { get; set; }

    [Column("pr_descripcion")]
    [StringLength(500)]
    public string? PrDescripcion { get; set; }

    [Column("pr_peso")]
    public double? PrPeso { get; set; }

    [Column("stock")]
    public double? Stock { get; set; }

    [Column("Tonelaje_x_Sucursal")]
    public double? TonelajeXSucursal { get; set; }

    [Column("pr_Pedidos")]
    public double PrPedidos { get; set; }

    [Column("Toneladas_x_Pedido")]
    public double? ToneladasXPedido { get; set; }

    public double? Disponible { get; set; }

    [Column("Tonelaje_Disponible")]
    public double? TonelajeDisponible { get; set; }
}
