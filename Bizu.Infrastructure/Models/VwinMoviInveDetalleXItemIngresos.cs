using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinMoviInveDetalleXItemIngresos
{
    [Column("IdEmpresa_oc")]
    public int? IdEmpresaOc { get; set; }

    [Column("IdSucursal_oc")]
    public int? IdSucursalOc { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenCompra { get; set; }

    [Column("Secuencia_oc")]
    public int? SecuenciaOc { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dm_cantidad")]
    public double DmCantidad { get; set; }

    [Column("dm_precio")]
    public double DmPrecio { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("oc_NumDocumento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? OcNumDocumento { get; set; }

    [Column("codigo_reg")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodigoReg { get; set; } = null!;

    [Column("cantidad")]
    public double Cantidad { get; set; }

    [Column("IdEmpresa_ing")]
    public int IdEmpresaIng { get; set; }

    [Column("IdSucursal_ing")]
    public int IdSucursalIng { get; set; }

    [Column("IdBodega_ing")]
    public int IdBodegaIng { get; set; }

    [Column("IdMovi_inven_tipo_ing")]
    public int IdMoviInvenTipoIng { get; set; }

    [Column("IdNumMovi_ing")]
    [Precision(18, 0)]
    public decimal IdNumMoviIng { get; set; }

    [Column("Secuencia_ing")]
    public int SecuenciaIng { get; set; }

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime? OcFecha { get; set; }
}
