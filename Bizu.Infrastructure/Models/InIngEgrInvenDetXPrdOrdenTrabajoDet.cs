using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaInv", "IdSucursalInv", "IdMoviInvenTipoInv", "IdNumMoviInv", "SecuenciaInv", "IdEmpresaOt", "IdSucursalOt", "IdOrdenTrabajoOt", "SecuenciaOt")]
[Table("in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InIngEgrInvenDetXPrdOrdenTrabajoDet
{
    [Key]
    [Column("IdEmpresa_inv")]
    public int IdEmpresaInv { get; set; }

    [Key]
    [Column("IdSucursal_inv")]
    public int IdSucursalInv { get; set; }

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

    [Key]
    [Column("IdEmpresa_ot")]
    public int IdEmpresaOt { get; set; }

    [Key]
    [Column("IdSucursal_ot")]
    public int IdSucursalOt { get; set; }

    [Key]
    [Column("IdOrdenTrabajo_ot")]
    [Precision(18, 0)]
    public decimal IdOrdenTrabajoOt { get; set; }

    [Key]
    [Column("Secuencia_ot")]
    public int SecuenciaOt { get; set; }
}
