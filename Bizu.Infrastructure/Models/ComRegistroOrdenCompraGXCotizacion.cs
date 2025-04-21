using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdOrdenCompra", "IdCotizacion", "SecuenciaDetalleCotizacion", "IdListadoMateriales")]
[Table("com_Registro_OrdenCompraG_x_Cotizacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComRegistroOrdenCompraGXCotizacion
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
    public decimal IdCotizacion { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal SecuenciaDetalleCotizacion { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdListadoMateriales { get; set; }

    [Column("estado")]
    public bool Estado { get; set; }
}
