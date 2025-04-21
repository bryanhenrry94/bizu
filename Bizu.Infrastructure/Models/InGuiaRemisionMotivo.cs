using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMotivo")]
[Table("in_GuiaRemision_Motivo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InGuiaRemisionMotivo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdMotivo { get; set; }

    [StringLength(50)]
    public string Codigo { get; set; } = null!;

    [StringLength(300)]
    public string Descripcion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [InverseProperty("InGuiaRemisionMotivo")]
    public virtual ICollection<InGuiaRemision> InGuiaRemision { get; set; } = new List<InGuiaRemision>();
}
