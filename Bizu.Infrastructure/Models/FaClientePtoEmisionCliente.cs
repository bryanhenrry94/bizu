using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCliente", "IdPuntoEmision")]
[Table("fa_cliente_pto_emision_cliente")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaClientePtoEmisionCliente
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Key]
    public int IdPuntoEmision { get; set; }

    [Column("cod_ptoemision")]
    [StringLength(50)]
    public string CodPtoemision { get; set; } = null!;

    [Column("ruc")]
    [StringLength(50)]
    public string Ruc { get; set; } = null!;

    [Column("direccion")]
    [StringLength(250)]
    public string Direccion { get; set; } = null!;

    [Column("telefono")]
    [StringLength(50)]
    public string Telefono { get; set; } = null!;

    [Column("mail1")]
    [StringLength(50)]
    public string Mail1 { get; set; } = null!;

    [Column("mail2")]
    [StringLength(50)]
    public string Mail2 { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;
}
