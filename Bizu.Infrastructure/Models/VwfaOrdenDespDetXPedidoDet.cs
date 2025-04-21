using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaOrdenDespDetXPedidoDet
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenDespacho { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("od_cantidad")]
    public double OdCantidad { get; set; }

    [Column("od_Precio")]
    public double OdPrecio { get; set; }

    [Column("od_PorDescUnitario")]
    public double OdPorDescUnitario { get; set; }

    [Column("od_DescUnitario")]
    public double OdDescUnitario { get; set; }

    [Column("od_PrecioFinal")]
    public double OdPrecioFinal { get; set; }

    [Column("od_Subtotal")]
    public double OdSubtotal { get; set; }

    [Column("od_iva")]
    public double OdIva { get; set; }

    [Column("od_total")]
    public double OdTotal { get; set; }

    [Column("od_costo")]
    public double OdCosto { get; set; }

    [Column("od_tieneIVA")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OdTieneIva { get; set; } = null!;

    [Column("od_detallexItems")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OdDetallexItems { get; set; } = null!;

    [Column("pe_IdEmpresa")]
    public int? PeIdEmpresa { get; set; }

    [Column("pe_IdSucursal")]
    public int? PeIdSucursal { get; set; }

    [Column("pe_IdBodega")]
    public int? PeIdBodega { get; set; }

    [Column("pe_IdPedido")]
    [Precision(18, 0)]
    public decimal? PeIdPedido { get; set; }

    [Column("pe_Secuencia")]
    public int? PeSecuencia { get; set; }

    [Column("od_peso")]
    public double OdPeso { get; set; }

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("Tiene_guia")]
    [StringLength(1)]
    public string TieneGuia { get; set; } = null!;
}
