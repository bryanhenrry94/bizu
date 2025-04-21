using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinPrtTransferencia
{
    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("dt_cantidad")]
    public double DtCantidad { get; set; }

    [Column("pr_stock")]
    public double PrStock { get; set; }

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdTransferencia { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursalOrigen { get; set; }

    public int IdBodegaOrigen { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SucursalDestino { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BodegaDestinno { get; set; } = null!;

    public int Expr1 { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [Column("em_logo")]
    public byte[]? EmLogo { get; set; }

    [Column("em_direccion")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmDireccion { get; set; } = null!;

    [Column("em_telefonos")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EmTelefonos { get; set; }

    [Column("IdCtaCble_Inventario")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleInventario { get; set; }

    [Column("IdCentro_Costo_Inventario")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoInventario { get; set; }

    [Column("IdCentro_Costo_Costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoCosto { get; set; }

    [Column("IdCtaCble_Gasto_x_cxp")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleGastoXCxp { get; set; }

    [Column("IdCentroCosto_x_Gasto_x_cxp")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoXGastoXCxp { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_inv")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCostoInv { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_cost")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCostoCost { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_cxp")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCostoCxp { get; set; }

    [Column("IdCtaCble_Inven")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleInven { get; set; }

    [Column("IdCtaCble_Costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCosto { get; set; }

    [Column("IdCtaCble_CosBaseIva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCosBaseIva { get; set; }

    [Column("IdCtaCble_CosBase0")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCosBase0 { get; set; }

    [Column("IdCtaCble_VenIva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleVenIva { get; set; }

    [Column("IdCtaCble_Ven0")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleVen0 { get; set; }

    [Column("IdCtaCble_DesIva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleDesIva { get; set; }

    [Column("IdCtaCble_Des0")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleDes0 { get; set; }

    [Column("IdCtaCble_DevIva")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleDevIva { get; set; }

    [Column("IdCtaCble_Dev0")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleDev0 { get; set; }

    [Column("IdCtaCble_Vta")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleVta { get; set; }
}
