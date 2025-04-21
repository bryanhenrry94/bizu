using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tbINV_Rpt005")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbInvRpt005
{
    public int? IdEmpresa { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(20)]
    public string? NomPc { get; set; }

    [Column("pr_descripcion")]
    [StringLength(500)]
    public string PrDescripcion { get; set; } = null!;
}
