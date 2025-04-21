using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAprobacion", "Secuencia")]
[Table("cp_Aprobacion_Ing_Bod_x_OC_det")]
[Index("IdEmpresa", "IdCentroCostoXGastoXCxp", "IdCentroCostoSubCentroCostoCxp", Name = "FK_cp_Aprobacion_Ing_Bod_x_OC_det_ct_centro_costo_sub_centro_c24")]
[Index("IdEmpresa", "IdCtaCbleGasto", Name = "FK_cp_Aprobacion_Ing_Bod_x_OC_det_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleIva", Name = "FK_cp_Aprobacion_Ing_Bod_x_OC_det_ct_plancta1")]
[Index("IdEmpresaIngEgrInv", "IdSucursalIngEgrInv", "IdMoviInvenTipoIngEgrInv", "IdNumMoviIngEgrInv", "SecuenciaIngEgrInv", Name = "FK_cp_Aprobacion_Ing_Bod_x_OC_det_in_Ing_Egr_Inven_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpAprobacionIngBodXOcDet
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

    [Column("IdMovi_inven_tipo_Ing_Egr_Inv")]
    public int IdMoviInvenTipoIngEgrInv { get; set; }

    [ForeignKey("IdEmpresa, IdAprobacion")]
    [InverseProperty("CpAprobacionIngBodXOcDet")]
    public virtual CpAprobacionIngBodXOc CpAprobacionIngBodXOc { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCostoXGastoXCxp")]
    [InverseProperty("CpAprobacionIngBodXOcDet")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCostoXGastoXCxp, IdCentroCostoSubCentroCostoCxp")]
    [InverseProperty("CpAprobacionIngBodXOcDet")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleGasto")]
    [InverseProperty("CpAprobacionIngBodXOcDetCtPlancta")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCtaCbleIva")]
    [InverseProperty("CpAprobacionIngBodXOcDetCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdEmpresaIngEgrInv, IdSucursalIngEgrInv, IdMoviInvenTipoIngEgrInv, IdNumMoviIngEgrInv, SecuenciaIngEgrInv")]
    [InverseProperty("CpAprobacionIngBodXOcDet")]
    public virtual InIngEgrInvenDet InIngEgrInvenDet { get; set; } = null!;
}
