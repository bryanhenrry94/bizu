using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_Impuesto_Tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisImpuestoTipo
{
    [Key]
    [StringLength(50)]
    public string IdTipoImpuesto { get; set; } = null!;

    [Column("nom_tipoImpuesto")]
    [StringLength(50)]
    public string NomTipoImpuesto { get; set; } = null!;

    [InverseProperty("IdTipoImpuestoNavigation")]
    public virtual ICollection<TbSisImpuesto> TbSisImpuesto { get; set; } = new List<TbSisImpuesto>();
}
