using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMotivoInv")]
[Table("in_Motivo_Inven")]
[Index("EsInvenOConsumo", Name = "FK_in_Motivo_Inven_in_Catalogo")]
[Index("TipoIngEgr", Name = "FK_in_Motivo_Inven_in_Catalogo1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMotivoInven
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdMotivo_Inv")]
    public int IdMotivoInv { get; set; }

    [Column("Cod_Motivo_Inv")]
    [StringLength(20)]
    public string CodMotivoInv { get; set; } = null!;

    [Column("Desc_mov_inv")]
    [StringLength(250)]
    public string DescMovInv { get; set; } = null!;

    [Column("Genera_Movi_Inven")]
    [StringLength(1)]
    public string GeneraMoviInven { get; set; } = null!;

    [Column("Genera_CXP")]
    [StringLength(1)]
    public string GeneraCxp { get; set; } = null!;

    [Column("Exigir_Punto_Cargo")]
    [StringLength(1)]
    public string? ExigirPuntoCargo { get; set; }

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAnul { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(250)]
    public string? MotivoAnulacion { get; set; }

    [Column("IdCtaCble_Inven")]
    [StringLength(20)]
    public string? IdCtaCbleInven { get; set; }

    [Column("IdCtaCble_Costo")]
    [StringLength(20)]
    public string? IdCtaCbleCosto { get; set; }

    [Column("es_Inven_o_Consumo")]
    [StringLength(15)]
    public string? EsInvenOConsumo { get; set; }

    [Column("Tipo_Ing_Egr")]
    [StringLength(15)]
    public string? TipoIngEgr { get; set; }

    [ForeignKey("EsInvenOConsumo")]
    [InverseProperty("InMotivoInvenEsInvenOConsumoNavigation")]
    public virtual InCatalogo? EsInvenOConsumoNavigation { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("InMotivoInven")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("InMotivoInven")]
    public virtual ICollection<InIngEgrInven> InIngEgrInven { get; set; } = new List<InIngEgrInven>();

    [InverseProperty("InMotivoInven")]
    public virtual ICollection<InMoviInve> InMoviInve { get; set; } = new List<InMoviInve>();

    [ForeignKey("TipoIngEgr")]
    [InverseProperty("InMotivoInvenTipoIngEgrNavigation")]
    public virtual InCatalogo? TipoIngEgrNavigation { get; set; }
}
