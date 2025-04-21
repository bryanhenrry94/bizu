using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProveedor", "Id")]
[Table("cp_proveedor_x_tb_ciiu")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpProveedorXTbCiiu
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Key]
    public int Id { get; set; }
}
