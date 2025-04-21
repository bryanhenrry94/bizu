using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdOrdenCompra", "IdSolicitud", "Secuencia")]
[Table("com_Registro_OrdenCompra_x_Solicitud")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComRegistroOrdenCompraXSolicitud
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdSolicitud { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal Secuencia { get; set; }

    [Column("estado")]
    public bool Estado { get; set; }
}
