using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdtipoCliente")]
[Table("fa_cliente_tipo")]
[Index("IdEmpresa", "IdCtaCbleCxcCon", Name = "FK_fa_cliente_tipo_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleCxcCred", Name = "FK_fa_cliente_tipo_ct_plancta1")]
[Index("IdEmpresa", "IdCtaCbleCxcAnticipo", Name = "FK_fa_cliente_tipo_ct_plancta2")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaClienteTipo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("Idtipo_cliente")]
    public int IdtipoCliente { get; set; }

    [Column("Cod_cliente_tipo")]
    [StringLength(10)]
    public string CodClienteTipo { get; set; } = null!;

    [Column("Descripcion_tip_cliente")]
    [StringLength(50)]
    public string DescripcionTipCliente { get; set; } = null!;

    [Column("IdCtaCble_CXC_Anticipo")]
    [StringLength(20)]
    public string? IdCtaCbleCxcAnticipo { get; set; }

    [Column("IdCtaCble_CXC_Con")]
    [StringLength(20)]
    public string? IdCtaCbleCxcCon { get; set; }

    [Column("IdCtaCble_CXC_Cred")]
    [StringLength(20)]
    public string? IdCtaCbleCxcCred { get; set; }

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

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCtaCbleCxcAnticipo")]
    [InverseProperty("FaClienteTipoCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleCxcCred")]
    [InverseProperty("FaClienteTipoCtPlancta1")]
    public virtual CtPlancta? CtPlancta1 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleCxcCon")]
    [InverseProperty("FaClienteTipoCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [InverseProperty("FaClienteTipo")]
    public virtual ICollection<FaCliente> FaCliente { get; set; } = new List<FaCliente>();
}
