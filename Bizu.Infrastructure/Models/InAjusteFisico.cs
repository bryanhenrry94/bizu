using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAjusteFisico")]
[Table("in_ajusteFisico")]
[Index("IdEstadoAprobacion", Name = "FK_in_ajusteFisico_in_Catalogo")]
[Index("IdEmpresa", "IdSucursal", "IdBodega", Name = "FK_in_ajusteFisico_tb_bodega")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InAjusteFisico
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAjusteFisico { get; set; }

    [StringLength(20)]
    public string CodAjusteFisico { get; set; } = null!;

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Column("IdMovi_inven_tipo_Ing")]
    public int? IdMoviInvenTipoIng { get; set; }

    [Column("IdNumMovi_Ing")]
    [Precision(18, 0)]
    public decimal? IdNumMoviIng { get; set; }

    [Column("IdMovi_inven_tipo_Egr")]
    public int? IdMoviInvenTipoEgr { get; set; }

    [Column("IdNumMovi_Egr")]
    [Precision(18, 0)]
    public decimal? IdNumMoviEgr { get; set; }

    [StringLength(300)]
    public string Observacion { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(20)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [Column("motivo_anula")]
    [StringLength(1000)]
    public string? MotivoAnula { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [StringLength(20)]
    public string? IdUsuarioAnulacion { get; set; }

    [StringLength(15)]
    public string? IdEstadoAprobacion { get; set; }

    [ForeignKey("IdEstadoAprobacion")]
    [InverseProperty("InAjusteFisico")]
    public virtual InCatalogo? IdEstadoAprobacionNavigation { get; set; }

    [InverseProperty("InAjusteFisico")]
    public virtual ICollection<InAjusteFisicoDetalle> InAjusteFisicoDetalle { get; set; } = new List<InAjusteFisicoDetalle>();

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("InAjusteFisico")]
    public virtual TbBodega TbBodega { get; set; } = null!;
}
