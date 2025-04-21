using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdHisDepreciacion")]
[Table("Af_Depreciacion_His_Anulacion")]
[Index("IdEmpresa", "IdDepreciacion", "IdTipoDepreciacion", Name = "FK_Af_Depreciacion_His_Anulacion_Af_Depreciacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfDepreciacionHisAnulacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdHisDepreciacion { get; set; }

    [Precision(18, 0)]
    public decimal IdDepreciacion { get; set; }

    public int IdTipoDepreciacion { get; set; }

    [Column("Cod_Depreciacion")]
    [StringLength(20)]
    public string CodDepreciacion { get; set; } = null!;

    public int IdPeriodo { get; set; }

    [StringLength(200)]
    public string? Descripcion { get; set; }

    [Column("Fecha_Depreciacion")]
    [MaxLength(6)]
    public DateTime FechaDepreciacion { get; set; }

    [Column("Num_Act_Depre")]
    public int NumActDepre { get; set; }

    [Column("Valor_Tot_Act")]
    public double ValorTotAct { get; set; }

    [Column("Valor_Tot_Depre")]
    public double ValorTotDepre { get; set; }

    [Column("Valor_Tot_DepreAcum")]
    public double ValorTotDepreAcum { get; set; }

    [Column("Valot_Tot_Importe")]
    public double ValotTotImporte { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

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

    [StringLength(100)]
    public string? MotivoAnula { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [ForeignKey("IdEmpresa, IdDepreciacion, IdTipoDepreciacion")]
    [InverseProperty("AfDepreciacionHisAnulacion")]
    public virtual AfDepreciacion AfDepreciacion { get; set; } = null!;

    [InverseProperty("AfDepreciacionHisAnulacion")]
    public virtual ICollection<AfDepreciacionDetHisAnulacion> AfDepreciacionDetHisAnulacion { get; set; } = new List<AfDepreciacionDetHisAnulacion>();
}
