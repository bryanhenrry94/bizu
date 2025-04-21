using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdListadoElementosXOt")]
[Table("com_ListadoElementos_x_OT")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComListadoElementosXOt
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdListadoElementos_x_OT")]
    [Precision(18, 0)]
    public decimal IdListadoElementosXOt { get; set; }

    [StringLength(20)]
    public string CodObra { get; set; } = null!;

    [Column("ot_IdSucursal")]
    public int OtIdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenTaller { get; set; }

    [MaxLength(6)]
    public DateTime FechaReg { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string Usuario { get; set; } = null!;

    [StringLength(50)]
    public string Motivo { get; set; } = null!;

    [Column("lm_Observacion")]
    [StringLength(500)]
    public string? LmObservacion { get; set; }
}
