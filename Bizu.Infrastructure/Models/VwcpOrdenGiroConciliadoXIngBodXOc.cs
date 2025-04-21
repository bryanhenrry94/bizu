using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpOrdenGiroConciliadoXIngBodXOc
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdAprobacion { get; set; }

    public int IdEmpresaConciliacion { get; set; }

    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    public int Secuencia { get; set; }

    [Column("IdEmpresa_Ing_Egr_Inv")]
    public int IdEmpresaIngEgrInv { get; set; }

    [Column("IdSucursal_Ing_Egr_Inv")]
    public int IdSucursalIngEgrInv { get; set; }

    [Column("IdNumMovi_Ing_Egr_Inv")]
    [Precision(18, 0)]
    public decimal IdNumMoviIngEgrInv { get; set; }

    [Column("Secuencia_Ing_Egr_Inv")]
    public int SecuenciaIngEgrInv { get; set; }

    public int IdBodega { get; set; }

    [Column("Fecha_Ing_Bod")]
    [MaxLength(6)]
    public DateTime FechaIngBod { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("nom_medida")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomMedida { get; set; }

    [Column("nom_bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBodega { get; set; } = null!;

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    public double Cantidad { get; set; }

    [Column("Costo_uni")]
    public double CostoUni { get; set; }

    [Column("do_porc_des")]
    public double DoPorcDes { get; set; }

    [Column("do_ManejaIva")]
    public bool DoManejaIva { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenCompra { get; set; }
}
