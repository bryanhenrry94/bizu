using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFacRpt014
{
    public int IdMarca { get; set; }

    [Column("marca")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Marca { get; set; }

    public int IdGrupo { get; set; }

    [Column("nom_grupo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomGrupo { get; set; } = null!;

    [Column("vt_Peso")]
    public double? VtPeso { get; set; }

    [Column("vt_cantidad")]
    public double? VtCantidad { get; set; }

    [Column("vt_total")]
    public double? VtTotal { get; set; }

    [Column("vt_DescUnitario")]
    public double? VtDescUnitario { get; set; }

    [Column("vt_PorDescUnitario")]
    public double? VtPorDescUnitario { get; set; }

    [Column("vt_PrecioFinal")]
    public double? VtPrecioFinal { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Column("vt_Subtotal")]
    public double? VtSubtotal { get; set; }

    [Column("vt_iva")]
    public double? VtIva { get; set; }

    [Column("vt_por_iva")]
    public double? VtPorIva { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("mv_costo")]
    public double? MvCosto { get; set; }
}
