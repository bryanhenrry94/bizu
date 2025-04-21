using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("fa_guia_remision_x_prd_Despacho")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaGuiaRemisionXPrdDespacho
{
    [Column("IdEmpresa_guia")]
    public int IdEmpresaGuia { get; set; }

    [Column("IdSucursal_guia")]
    public int IdSucursalGuia { get; set; }

    [Column("IdBodega_guia")]
    public int IdBodegaGuia { get; set; }

    [Column("IdGuiaRemision_guia")]
    [Precision(18, 0)]
    public decimal IdGuiaRemisionGuia { get; set; }

    [Column("IdEmpresa_des")]
    public int IdEmpresaDes { get; set; }

    [Column("IdSucursal_des")]
    public int IdSucursalDes { get; set; }

    [Column("IdCentroCosto_des")]
    [StringLength(20)]
    public string IdCentroCostoDes { get; set; } = null!;

    [Column("IdDespacho_des")]
    [Precision(18, 0)]
    public decimal IdDespachoDes { get; set; }
}
