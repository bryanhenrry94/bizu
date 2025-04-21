using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdDevInven", "Secuencia")]
[Table("in_devolucion_inven_det")]
[Index("IdEmpresaMoviInv", "IdSucursalMoviInv", "IdBodegaMoviInv", "IdMoviInvenTipoMoviInv", "IdNumMoviMoviInv", "SecuenciaMoviInv", Name = "FK_in_devolucion_inven_det_in_movi_inve_detalle")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InDevolucionInvenDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdDev_Inven")]
    [Precision(18, 0)]
    public decimal IdDevInven { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_movi_inv")]
    public int IdEmpresaMoviInv { get; set; }

    [Column("IdSucursal_movi_inv")]
    public int IdSucursalMoviInv { get; set; }

    [Column("IdBodega_movi_inv")]
    public int IdBodegaMoviInv { get; set; }

    [Column("IdMovi_inven_tipo_movi_inv")]
    public int IdMoviInvenTipoMoviInv { get; set; }

    [Column("IdNumMovi_movi_inv")]
    [Precision(18, 0)]
    public decimal IdNumMoviMoviInv { get; set; }

    [Column("Secuencia_movi_inv")]
    public int SecuenciaMoviInv { get; set; }

    [Column("cantidad_devuelta")]
    public double CantidadDevuelta { get; set; }

    [Column("cantidad_a_devolver")]
    public double CantidadADevolver { get; set; }

    [Column("cantidad_egresada")]
    public double CantidadEgresada { get; set; }

    [ForeignKey("IdEmpresa, IdDevInven")]
    [InverseProperty("InDevolucionInvenDet")]
    public virtual InDevolucionInven InDevolucionInven { get; set; } = null!;

    [ForeignKey("IdEmpresaMoviInv, IdSucursalMoviInv, IdBodegaMoviInv, IdMoviInvenTipoMoviInv, IdNumMoviMoviInv, SecuenciaMoviInv")]
    [InverseProperty("InDevolucionInvenDet")]
    public virtual InMoviInveDetalle InMoviInveDetalle { get; set; } = null!;
}
