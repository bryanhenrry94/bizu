using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdCodImpuesto", "IdEmpresaCta", "IdCtaCble")]
[Table("tb_sis_Impuesto_x_ctacble")]
[Index("IdEmpresaCta", "IdCtaCble", Name = "FK_tb_sis_Impuesto_x_ctacble_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisImpuestoXCtacble
{
    [Key]
    [Column("IdCod_Impuesto")]
    [StringLength(25)]
    public string IdCodImpuesto { get; set; } = null!;

    [Key]
    [Column("IdEmpresa_cta")]
    public int IdEmpresaCta { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Column("observacion")]
    [StringLength(50)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("IdEmpresaCta, IdCtaCble")]
    [InverseProperty("TbSisImpuestoXCtacble")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [ForeignKey("IdCodImpuesto")]
    [InverseProperty("TbSisImpuestoXCtacble")]
    public virtual TbSisImpuesto IdCodImpuestoNavigation { get; set; } = null!;
}
