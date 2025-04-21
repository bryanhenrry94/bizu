using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cxc_cobro_tipo_motivo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroTipoMotivo
{
    [Key]
    [Column("IdMotivo_tipo_cobro")]
    [StringLength(15)]
    public string IdMotivoTipoCobro { get; set; } = null!;

    [Column("nom_Motivo_tipo_cobro")]
    [StringLength(50)]
    public string NomMotivoTipoCobro { get; set; } = null!;

    [InverseProperty("IdMotivoTipoCobroNavigation")]
    public virtual ICollection<CxcCobroTipo> CxcCobroTipo { get; set; } = new List<CxcCobroTipo>();
}
