using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaInv", "IdSucursalInv", "IdBodegaInv", "IdMoviInvenTipoInv", "IdNumMoviInv", "SecuenciaInv")]
[Table("in_spSys_inv_Reversar_aprobacion_in_movi_inven")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InSpSysInvReversarAprobacionInMoviInven
{
    [Key]
    [Column("IdEmpresa_inv")]
    public int IdEmpresaInv { get; set; }

    [Key]
    [Column("IdSucursal_inv")]
    public int IdSucursalInv { get; set; }

    [Key]
    [Column("IdBodega_inv")]
    public int IdBodegaInv { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo_inv")]
    public int IdMoviInvenTipoInv { get; set; }

    [Key]
    [Column("IdNumMovi_inv")]
    [Precision(18, 0)]
    public decimal IdNumMoviInv { get; set; }

    [Key]
    [Column("Secuencia_inv")]
    public int SecuenciaInv { get; set; }
}
