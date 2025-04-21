using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_Conexion_Dashboard")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbConexionDashboard
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Provider { get; set; } = null!;

    [StringLength(50)]
    public string ServerName { get; set; } = null!;

    [StringLength(5)]
    public string PortNumber { get; set; } = null!;

    [StringLength(50)]
    public string DatabaseName { get; set; } = null!;

    [StringLength(50)]
    public string UserName { get; set; } = null!;

    [StringLength(50)]
    public string Password { get; set; } = null!;

    [StringLength(200)]
    public string StringConnection { get; set; } = null!;
}
