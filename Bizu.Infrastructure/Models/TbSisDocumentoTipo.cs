using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_Documento_Tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisDocumentoTipo
{
    [Key]
    [Column("codDocumentoTipo")]
    [StringLength(20)]
    public string CodDocumentoTipo { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(50)]
    public string? Descripcion { get; set; }

    [Column("estado")]
    [StringLength(1)]
    public string? Estado { get; set; }

    public int? Posicion { get; set; }

    [InverseProperty("CodDocumentoTipoNavigation")]
    public virtual ICollection<TbSisDocumentoTipoReporteXEmpresa> TbSisDocumentoTipoReporteXEmpresa { get; set; } = new List<TbSisDocumentoTipoReporteXEmpresa>();

    [InverseProperty("CodDocumentoTipoNavigation")]
    public virtual ICollection<TbSisDocumentoTipoTalonario> TbSisDocumentoTipoTalonario { get; set; } = new List<TbSisDocumentoTipoTalonario>();
}
