using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdDevInven")]
[Table("in_devolucion_inven")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InDevolucionInven
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdDev_Inven")]
    [Precision(18, 0)]
    public decimal IdDevInven { get; set; }

    [Column("cod_Dev_Inven")]
    [StringLength(50)]
    public string CodDevInven { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("Devuelve_toda_tran")]
    public bool DevuelveTodaTran { get; set; }

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("IdSucursal_movi_inven")]
    public int IdSucursalMoviInven { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltModi { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    public string? IdusuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [Column("observacion")]
    [StringLength(300)]
    public string? Observacion { get; set; }

    [StringLength(300)]
    public string? MotivoAnulacion { get; set; }

    [InverseProperty("InDevolucionInven")]
    public virtual ICollection<InDevolucionInvenDet> InDevolucionInvenDet { get; set; } = new List<InDevolucionInvenDet>();
}
