using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdMoviInvenTipo", "IdListadoMppreasingado", "IdNumMovi", "CodObraPreasignada")]
[Table("com_ListadoMaterialesDisponibles_PreAsignado_a_Obra")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComListadoMaterialesDisponiblesPreAsignadoAObra
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Key]
    [Column("IdListadoMPPreasingado")]
    [Precision(18, 0)]
    public decimal IdListadoMppreasingado { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Key]
    [Column("CodObra_preasignada")]
    [StringLength(20)]
    public string CodObraPreasignada { get; set; } = null!;

    [MaxLength(6)]
    public DateTime FechaReg { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string Usuario { get; set; } = null!;

    [StringLength(50)]
    public string Motivo { get; set; } = null!;

    [Column("lm_Observacion")]
    [StringLength(500)]
    public string? LmObservacion { get; set; }
}
