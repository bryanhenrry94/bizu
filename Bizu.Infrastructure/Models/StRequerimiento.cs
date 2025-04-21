using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "RequerimientoTipo", "IdRequerimiento")]
[Table("st_Requerimiento")]
[Index("IdEstadoRequerimiento", Name = "FK_st_Requerimiento_st_Catalogo")]
[Index("IdPrioridad", Name = "FK_st_Requerimiento_st_Catalogo1")]
[Index("IdEmpresa", "IdSucursal", "IdTecnico", Name = "FK_st_Requerimiento_st_Tecnico")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class StRequerimiento
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int RequerimientoTipo { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdRequerimiento { get; set; }

    [StringLength(25)]
    public string IdPrioridad { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    [StringLength(25)]
    public string IdUsuarioSolicita { get; set; } = null!;

    [StringLength(25)]
    public string IdEstadoRequerimiento { get; set; } = null!;

    public int IdTecnico { get; set; }

    [StringLength(300)]
    public string Observacion { get; set; } = null!;

    [StringLength(300)]
    public string? Solucion { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(25)]
    public string IdUsuario { get; set; } = null!;

    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(25)]
    public string IdUsuarioUltMod { get; set; } = null!;

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(25)]
    public string? IdUsuarioUltAnu { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(50)]
    public string? MotivoUltAnu { get; set; }

    [ForeignKey("IdEstadoRequerimiento")]
    [InverseProperty("StRequerimientoIdEstadoRequerimientoNavigation")]
    public virtual StCatalogo IdEstadoRequerimientoNavigation { get; set; } = null!;

    [ForeignKey("IdPrioridad")]
    [InverseProperty("StRequerimientoIdPrioridadNavigation")]
    public virtual StCatalogo IdPrioridadNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdTecnico")]
    [InverseProperty("StRequerimiento")]
    public virtual StTecnico StTecnico { get; set; } = null!;
}
