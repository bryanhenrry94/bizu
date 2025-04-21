using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdListadoDiseno")]
[Table("com_ListadoDiseno")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComListadoDiseno
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdListadoDiseno { get; set; }

    [StringLength(20)]
    public string CodObra { get; set; } = null!;

    [Column("ot_IdSucursal")]
    public int OtIdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenTaller { get; set; }

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

    [Column("tipo_listado")]
    [StringLength(1)]
    public string? TipoListado { get; set; }
}
