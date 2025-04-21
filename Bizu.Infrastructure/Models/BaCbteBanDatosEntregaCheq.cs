using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCble", "IdTipocbte")]
[Table("ba_Cbte_Ban_Datos_Entrega_cheq")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaCbteBanDatosEntregaCheq
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Key]
    public int IdTipocbte { get; set; }

    [StringLength(13)]
    public string Cedula { get; set; } = null!;

    [StringLength(100)]
    public string Nombres { get; set; } = null!;

    [StringLength(13)]
    public string Apellidos { get; set; } = null!;

    [StringLength(250)]
    public string? NotaEntrega { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaTransac { get; set; }

    [StringLength(25)]
    public string IdUsuario { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaEntrega { get; set; }

    [Column(TypeName = "blob")]
    public byte[]? Foto { get; set; }
}
