using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdDepreciacion", "IdTipoDepreciacion")]
[Table("Af_Depreciacion")]
[Index("IdTipoDepreciacion", Name = "FK_Af_Depreciacion_Af_Tipo_Depreciacion")]
[Index("IdEmpresa", "IdPeriodo", Name = "FK_Af_Depreciacion_ct_periodo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfDepreciacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdDepreciacion { get; set; }

    [Key]
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

    [InverseProperty("AfDepreciacion")]
    public virtual ICollection<AfDepreciacionDet> AfDepreciacionDet { get; set; } = new List<AfDepreciacionDet>();

    [InverseProperty("AfDepreciacion")]
    public virtual ICollection<AfDepreciacionHisAnulacion> AfDepreciacionHisAnulacion { get; set; } = new List<AfDepreciacionHisAnulacion>();

    [ForeignKey("IdEmpresa, IdPeriodo")]
    [InverseProperty("AfDepreciacion")]
    public virtual CtPeriodo CtPeriodo { get; set; } = null!;

    [ForeignKey("IdTipoDepreciacion")]
    [InverseProperty("AfDepreciacion")]
    public virtual AfTipoDepreciacion IdTipoDepreciacionNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdDepreciacion, IdTipoDepreciacion")]
    [InverseProperty("AfDepreciacion")]
    public virtual ICollection<CtCbtecble> CtCbtecble { get; set; } = new List<CtCbtecble>();
}
