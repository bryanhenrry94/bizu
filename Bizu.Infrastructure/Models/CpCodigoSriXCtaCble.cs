using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCodigoSri")]
[Table("cp_codigo_SRI_x_CtaCble")]
[Index("IdCodigoSri", Name = "FK_cp_codigo_SRI_x_CtaCble_cp_codigo_SRI")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_cp_codigo_SRI_x_CtaCble_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpCodigoSriXCtaCble
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("idCodigo_SRI")]
    public int IdCodigoSri { get; set; }

    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Column("fecha_UltMod")]
    [MaxLength(6)]
    public DateTime FechaUltMod { get; set; }

    [Column("idUsuario")]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("nom_pc")]
    [StringLength(50)]
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    public string Ip { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CpCodigoSriXCtaCble")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [ForeignKey("IdCodigoSri")]
    [InverseProperty("CpCodigoSriXCtaCble")]
    public virtual CpCodigoSri IdCodigoSriNavigation { get; set; } = null!;
}
