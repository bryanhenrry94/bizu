using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tbCONTA_Rpt005")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbContaRpt005
{
    [Column("IdEmpresa_SP")]
    public int? IdEmpresaSp { get; set; }

    [Column("IdUsuario_SP")]
    [StringLength(20)]
    public string? IdUsuarioSp { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(20)]
    public string? NomPc { get; set; }

    public int IdEmpresa { get; set; }
}
