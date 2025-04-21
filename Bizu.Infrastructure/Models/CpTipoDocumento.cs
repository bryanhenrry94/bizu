using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_TipoDocumento")]
[Index("CodTipoDocumento", Name = "IX_cp_TipoDocumento")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpTipoDocumento
{
    [Key]
    [StringLength(5)]
    public string CodTipoDocumento { get; set; } = null!;

    [StringLength(10)]
    public string Codigo { get; set; } = null!;

    [StringLength(250)]
    public string Descripcion { get; set; } = null!;

    public int Orden { get; set; }

    [Column("DeclaraSRI")]
    [StringLength(1)]
    public string DeclaraSri { get; set; } = null!;

    [Column("CodSRI")]
    [StringLength(5)]
    public string? CodSri { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string? GeneraRetencion { get; set; }

    [Column("Codigo_Secuenciales_Transaccion")]
    [StringLength(250)]
    public string? CodigoSecuencialesTransaccion { get; set; }

    [Column("Sustento_Tributario")]
    [StringLength(250)]
    public string? SustentoTributario { get; set; }
}
