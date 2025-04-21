using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwActfRpt010
{
    public int IdEmpresa { get; set; }

    public int IdCambioUbicacion { get; set; }

    public int IdActivoFijo { get; set; }

    [Column("Af_Nombre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfNombre { get; set; } = null!;

    public int IdActijoFijoTipo { get; set; }

    [Column("Af_Descripcion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfDescripcion { get; set; } = null!;

    [Column("IdSucursal_Actu")]
    public int? IdSucursalActu { get; set; }

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SucActual { get; set; } = null!;

    [Column("IdSucursal_Ant")]
    public int? IdSucursalAnt { get; set; }

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SucAnterior { get; set; } = null!;

    [Column("IdTipoCatalogo_Ubicacion_Actu")]
    [StringLength(35)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoCatalogoUbicacionActu { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string UbiActual { get; set; } = null!;

    [Column("IdTipoCatalogo_Ubicacion_Ant")]
    [StringLength(35)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoCatalogoUbicacionAnt { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string UbiAnterior { get; set; } = null!;

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string MotivoCambio { get; set; } = null!;

    [MaxLength(6)]
    public DateTime FechaCambio { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }
}
