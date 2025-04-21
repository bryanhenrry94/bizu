using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdClaseProveedor")]
[Table("cp_proveedor_clase")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpProveedorClase
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdClaseProveedor { get; set; }

    [Column("cod_clase_proveedor")]
    [StringLength(25)]
    public string CodClaseProveedor { get; set; } = null!;

    [Column("descripcion_clas_prove")]
    [StringLength(100)]
    public string DescripcionClasProve { get; set; } = null!;

    [Column("IdCtaCble_Anticipo")]
    [StringLength(20)]
    public string? IdCtaCbleAnticipo { get; set; }

    [Column("IdCtaCble_gasto")]
    [StringLength(20)]
    public string? IdCtaCbleGasto { get; set; }

    [Column("IdCtaCble_CXP")]
    [StringLength(20)]
    public string? IdCtaCbleCxp { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(20)]
    public string? IdUsuarioAnu { get; set; }

    [StringLength(150)]
    public string? MotivoAnu { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltModi { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnu { get; set; }

    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltModi { get; set; }

    [InverseProperty("CpProveedorClase")]
    public virtual ICollection<CpProveedor> CpProveedor { get; set; } = new List<CpProveedor>();
}
