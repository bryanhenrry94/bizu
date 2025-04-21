using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("SYP_FE_RESPUESTA_SRI")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SypFeRespuestaSri
{
    [Column("numDoc")]
    [StringLength(17)]
    public string? NumDoc { get; set; }

    [Column("codDoc")]
    [StringLength(2)]
    public string? CodDoc { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [Column("claveAcceso")]
    [StringLength(49)]
    public string? ClaveAcceso { get; set; }

    [Column("numeroautorizacion")]
    [StringLength(49)]
    public string? Numeroautorizacion { get; set; }

    public int? Estado { get; set; }

    [StringLength(2000)]
    public string? Error { get; set; }

    [StringLength(2000)]
    public string? RutaArchivo { get; set; }
}
