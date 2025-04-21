using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAprobacion", "Secuencia")]
[Table("cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_det")]
[Index("IdEmpresaIngEgrInv", "IdSucursalIngEgrInv", "IdMoviInvenTipoIngEgrInv", "IdNumMoviIngEgrInv", "SecuenciaIngEgrInv", Name = "cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_inven_det_FK")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpNotaDebCreAprobacionIngBodXOcDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAprobacion { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_Ing_Egr_Inv")]
    public int IdEmpresaIngEgrInv { get; set; }

    [Column("IdSucursal_Ing_Egr_Inv")]
    public int IdSucursalIngEgrInv { get; set; }

    [Column("IdMovi_inven_tipo_Ing_Egr_Inv")]
    public int IdMoviInvenTipoIngEgrInv { get; set; }

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

    [Column("Valor_Iva")]
    public double ValorIva { get; set; }

    public double Total { get; set; }

    [Column("IdCtaCble_Gasto")]
    [StringLength(20)]
    public string IdCtaCbleGasto { get; set; } = null!;

    [Column("IdCtaCble_IVA")]
    [StringLength(20)]
    public string? IdCtaCbleIva { get; set; }

    [Column("IdCentro_Costo_x_Gasto_x_cxp")]
    [StringLength(20)]
    public string? IdCentroCostoXGastoXCxp { get; set; }

    [Column("IdCentroCosto_sub_centro_costo_cxp")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCostoCxp { get; set; }

    [ForeignKey("IdEmpresaIngEgrInv, IdSucursalIngEgrInv, IdMoviInvenTipoIngEgrInv, IdNumMoviIngEgrInv, SecuenciaIngEgrInv")]
    [InverseProperty("CpNotaDebCreAprobacionIngBodXOcDet")]
    public virtual InIngEgrInvenDet InIngEgrInvenDet { get; set; } = null!;
}
