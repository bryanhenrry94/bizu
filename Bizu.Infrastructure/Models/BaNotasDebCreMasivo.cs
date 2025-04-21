using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTransaccion", "IdEmpresaCb", "IdCbteCbleCb", "IdTipocbteCb")]
[Table("ba_notasDebCre_masivo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaNotasDebCreMasivo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdTransaccion { get; set; }

    [Key]
    [Column("IdEmpresa_cb")]
    public int IdEmpresaCb { get; set; }

    [Key]
    [Column("IdCbteCble_cb")]
    [Precision(18, 0)]
    public decimal IdCbteCbleCb { get; set; }

    [Key]
    [Column("IdTipocbte_cb")]
    public int IdTipocbteCb { get; set; }

    [Column("Deb_Cred")]
    [StringLength(1)]
    public string DebCred { get; set; } = null!;

    [Column("fecha")]
    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(50)]
    public string? Observacion { get; set; }

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    public string Ip { get; set; } = null!;
}
