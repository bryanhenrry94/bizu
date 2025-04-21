using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpAprobacionIngBodXOcDet
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdAprobacion { get; set; }

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

    public double Cantidad { get; set; }

    [Column("Costo_uni")]
    public double CostoUni { get; set; }

    public double Descuento { get; set; }

    public double SubTotal { get; set; }

    public double PorIva { get; set; }

    [Column("valor_Iva")]
    public double ValorIva { get; set; }

    public double Total { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [Column("IdCtaCble_Gasto")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCbleGasto { get; set; } = null!;

    [Column("IdCtaCble_IVA")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleIva { get; set; }

    [Column("IdCentro_Costo_x_Gasto_x_cxp")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoXGastoXCxp { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_cxp")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCostoCxp { get; set; }

    [Column("IdMovi_inven_tipo_Ing_Egr_Inv")]
    public int IdMoviInvenTipoIngEgrInv { get; set; }
}
