using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdBanco")]
[Table("ba_Archivo_Transferencia_Parametros")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaArchivoTransferenciaParametros
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdBanco { get; set; }

    [Column("cod_banco")]
    [StringLength(20)]
    public string CodBanco { get; set; } = null!;
}
