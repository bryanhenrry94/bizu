using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cxc_cobro_tipo_x_cobros_Docxc")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroTipoXCobrosDocxc
{
    [Key]
    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string IdCobroTipo { get; set; } = null!;

    public int Posicion { get; set; }

    [ForeignKey("IdCobroTipo")]
    [InverseProperty("CxcCobroTipoXCobrosDocxc")]
    public virtual CxcCobroTipo IdCobroTipoNavigation { get; set; } = null!;
}
