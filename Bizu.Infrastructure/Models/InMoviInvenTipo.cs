using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMoviInvenTipo")]
[Table("in_movi_inven_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMoviInvenTipo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [StringLength(10)]
    public string Codigo { get; set; } = null!;

    [Column("tm_descripcion")]
    [StringLength(50)]
    public string TmDescripcion { get; set; } = null!;

    [Column("cm_tipo_movi")]
    [StringLength(1)]
    public string CmTipoMovi { get; set; } = null!;

    [Column("cm_interno")]
    [StringLength(1)]
    public string CmInterno { get; set; } = null!;

    [Column("cm_descripcionCorta")]
    [StringLength(10)]
    public string CmDescripcionCorta { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    public int? IdTipoCbte { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [Column("Genera_Movi_Inven")]
    public bool? GeneraMoviInven { get; set; }

    [Column("Genera_Diario_Contable")]
    public bool? GeneraDiarioContable { get; set; }

    [InverseProperty("InMoviInvenTipo")]
    public virtual ICollection<ComParametro> ComParametroInMoviInvenTipo { get; set; } = new List<ComParametro>();

    [InverseProperty("InMoviInvenTipoNavigation")]
    public virtual ICollection<ComParametro> ComParametroInMoviInvenTipoNavigation { get; set; } = new List<ComParametro>();

    [InverseProperty("InMoviInvenTipo")]
    public virtual ICollection<FaParametro> FaParametroInMoviInvenTipo { get; set; } = new List<FaParametro>();

    [InverseProperty("InMoviInvenTipo1")]
    public virtual ICollection<FaParametro> FaParametroInMoviInvenTipo1 { get; set; } = new List<FaParametro>();

    [InverseProperty("InMoviInvenTipo2")]
    public virtual ICollection<FaParametro> FaParametroInMoviInvenTipo2 { get; set; } = new List<FaParametro>();

    [InverseProperty("InMoviInvenTipoNavigation")]
    public virtual ICollection<FaParametro> FaParametroInMoviInvenTipoNavigation { get; set; } = new List<FaParametro>();

    [InverseProperty("InMoviInvenTipo")]
    public virtual ICollection<InMoviInve> InMoviInve { get; set; } = new List<InMoviInve>();

    [InverseProperty("InMoviInvenTipo")]
    public virtual ICollection<InMoviInvenTipoXTbBodega> InMoviInvenTipoXTbBodega { get; set; } = new List<InMoviInvenTipoXTbBodega>();

    [InverseProperty("InMoviInvenTipo")]
    public virtual ICollection<InParametro> InParametroInMoviInvenTipo { get; set; } = new List<InParametro>();

    [InverseProperty("InMoviInvenTipo1")]
    public virtual ICollection<InParametro> InParametroInMoviInvenTipo1 { get; set; } = new List<InParametro>();

    [InverseProperty("InMoviInvenTipo2")]
    public virtual ICollection<InParametro> InParametroInMoviInvenTipo2 { get; set; } = new List<InParametro>();

    [InverseProperty("InMoviInvenTipo3")]
    public virtual ICollection<InParametro> InParametroInMoviInvenTipo3 { get; set; } = new List<InParametro>();

    [InverseProperty("InMoviInvenTipo4")]
    public virtual ICollection<InParametro> InParametroInMoviInvenTipo4 { get; set; } = new List<InParametro>();

    [InverseProperty("InMoviInvenTipo5")]
    public virtual ICollection<InParametro> InParametroInMoviInvenTipo5 { get; set; } = new List<InParametro>();

    [InverseProperty("InMoviInvenTipo6")]
    public virtual ICollection<InParametro> InParametroInMoviInvenTipo6 { get; set; } = new List<InParametro>();

    [InverseProperty("InMoviInvenTipo7")]
    public virtual ICollection<InParametro> InParametroInMoviInvenTipo7 { get; set; } = new List<InParametro>();

    [InverseProperty("InMoviInvenTipoNavigation")]
    public virtual ICollection<InParametro> InParametroInMoviInvenTipoNavigation { get; set; } = new List<InParametro>();
}
