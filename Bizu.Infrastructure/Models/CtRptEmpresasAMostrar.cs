using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ct_rpt_Empresas_A_mostrar")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtRptEmpresasAMostrar
{
    [Key]
    public int IdEmpresa { get; set; }

    [Column("sEmpresas")]
    [StringLength(100)]
    public string? SEmpresas { get; set; }
}
