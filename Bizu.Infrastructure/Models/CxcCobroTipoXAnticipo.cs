using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCobroTipo")]
[Table("cxc_cobro_tipo_x_anticipo")]
[Index("IdCobroTipo", Name = "FK_cxc_cobro_tipo_x_anticipo_cxc_cobro_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroTipoXAnticipo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string IdCobroTipo { get; set; } = null!;

    [Column("posicion")]
    public int? Posicion { get; set; }

    [ForeignKey("IdCobroTipo")]
    [InverseProperty("CxcCobroTipoXAnticipo")]
    public virtual CxcCobroTipo IdCobroTipoNavigation { get; set; } = null!;
}
