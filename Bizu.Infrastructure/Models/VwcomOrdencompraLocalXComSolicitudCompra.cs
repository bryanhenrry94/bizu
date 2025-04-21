using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomOrdencompraLocalXComSolicitudCompra
{
    [Column("IdEmpresa_oc")]
    public int IdEmpresaOc { get; set; }

    [Column("IdSucursal_oc")]
    public int IdSucursalOc { get; set; }

    [Column("IdOrdenCompra_oc")]
    [Precision(18, 0)]
    public decimal IdOrdenCompraOc { get; set; }

    [Column("IdEmpresa_sc")]
    public int IdEmpresaSc { get; set; }

    [Column("IdSucursal_sc")]
    public int IdSucursalSc { get; set; }

    [Column("IdSolicitudCompra_sc")]
    [Precision(18, 0)]
    public decimal IdSolicitudCompraSc { get; set; }

    [Column("Secuencia_sc")]
    public int SecuenciaSc { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    public double Cantidad { get; set; }

    [Column("observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;
}
