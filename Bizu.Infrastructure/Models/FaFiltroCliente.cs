using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdUsuario", "IdCliente")]
[Table("fa_filtro_cliente")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFiltroCliente
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    public int IdCliente { get; set; }
}
