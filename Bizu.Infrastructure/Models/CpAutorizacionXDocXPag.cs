using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_Autorizacion_x_Doc_x_Pag")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpAutorizacionXDocXPag
{
    [Key]
    [Column("Id_Num_Autorizacion")]
    [StringLength(200)]
    public string IdNumAutorizacion { get; set; } = null!;

    [StringLength(5)]
    public string? Serie1 { get; set; }

    [StringLength(5)]
    public string? Serie2 { get; set; }

    [Column("Valido_Hasta")]
    public DateOnly? ValidoHasta { get; set; }

    [Column("factura_inicial")]
    [StringLength(50)]
    public string? FacturaInicial { get; set; }

    [Column("factura_final")]
    [StringLength(50)]
    public string? FacturaFinal { get; set; }

    [StringLength(50)]
    public string? NumAutorizacionImprenta { get; set; }
}
