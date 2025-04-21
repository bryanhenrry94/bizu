using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwInvRpt004
{
    public int IdEmpresa { get; set; }

    [Column("IdSucursal_oc")]
    public int IdSucursalOc { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [Column("Fecha_oc")]
    [MaxLength(6)]
    public DateTime FechaOc { get; set; }

    [Column("Observacion_oc")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ObservacionOc { get; set; } = null!;

    [Column("Estado_oc")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EstadoOc { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Column("IdSucursal_inv")]
    public int IdSucursalInv { get; set; }

    [Column("IdBodega_inv")]
    public int IdBodegaInv { get; set; }

    [Column("Cant_Pedida_oc")]
    public double CantPedidaOc { get; set; }

    [Column("Cant_Recibida_inv")]
    public double CantRecibidaInv { get; set; }

    [Column("Cant_x_Recivir_inv")]
    public double CantXRecivirInv { get; set; }

    [StringLength(2)]
    public string EstadoPago { get; set; } = null!;
}
