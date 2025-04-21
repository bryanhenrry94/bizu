using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdNota")]
[Table("fa_notaCreDeb_Edehsa")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaNotaCreDebEdehsa
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    public int IdNota { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdOferta { get; set; }

    public int? IdPlanilla { get; set; }

    [StringLength(20)]
    public string IdCentroCosto { get; set; } = null!;

    [Column("estado")]
    public bool Estado { get; set; }

    [StringLength(25)]
    public string? UsuarioCreacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(25)]
    public string? UsuarioModificacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaModificacion { get; set; }

    [StringLength(25)]
    public string? UsuarioAnulacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [StringLength(150)]
    public string? MotivoAnulacion { get; set; }
}
