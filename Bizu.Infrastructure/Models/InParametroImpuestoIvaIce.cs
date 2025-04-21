using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("in_parametro_Impuesto_Iva_Ice")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InParametroImpuestoIvaIce
{
    [Key]
    public int Idempresa { get; set; }

    [StringLength(50)]
    public string? IdCodImpuesIva { get; set; }

    [StringLength(50)]
    public string? IdCodImpuesIce { get; set; }

    [StringLength(25)]
    public string? IdPresentacion { get; set; }
}
