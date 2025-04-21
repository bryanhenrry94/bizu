using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCliente", "IdUsuario")]
[Table("fa_cliente_Filtro")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaClienteFiltro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Key]
    [StringLength(25)]
    public string IdUsuario { get; set; } = null!;
}
