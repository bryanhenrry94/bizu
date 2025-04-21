using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinMoviInveDetalleXItemDisponibles
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Column("codigo_reg")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodigoReg { get; set; } = null!;

    [Column("cantidad")]
    public double? Cantidad { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }
}
