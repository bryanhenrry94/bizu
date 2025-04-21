using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTransportista")]
[Table("tb_transportista")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbTransportista
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdTransportista { get; set; }

    [StringLength(25)]
    public string? IdTipoDocumento { get; set; }

    [StringLength(20)]
    public string? Cedula { get; set; }

    [StringLength(500)]
    public string? Nombre { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transaccion")]
    [MaxLength(6)]
    public DateTime? FechaTransaccion { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltModi { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(100)]
    public string? MotivoAnulacion { get; set; }

    [StringLength(20)]
    public string? Placa { get; set; }

    [InverseProperty("TbTransportista")]
    public virtual ICollection<FaGuiaRemision> FaGuiaRemision { get; set; } = new List<FaGuiaRemision>();

    [InverseProperty("TbTransportista")]
    public virtual ICollection<InGuiaXTraspasoBodega> InGuiaXTraspasoBodega { get; set; } = new List<InGuiaXTraspasoBodega>();
}
