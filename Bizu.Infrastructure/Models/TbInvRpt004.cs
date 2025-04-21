using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdUsuario", "FechaTransac")]
[Table("tbINV_Rpt004")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbInvRpt004
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(20)]
    public string? NomPc { get; set; }

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    public string PeNombreCompleto { get; set; } = null!;
}
