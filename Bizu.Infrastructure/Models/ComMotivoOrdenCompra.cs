using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMotivo")]
[Table("com_Motivo_Orden_Compra")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComMotivoOrdenCompra
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdMotivo { get; set; }

    [Column("Cod_Motivo")]
    [StringLength(20)]
    public string CodMotivo { get; set; } = null!;

    [StringLength(250)]
    public string Descripcion { get; set; } = null!;

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAnul { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(250)]
    public string? MotivoAnulacion { get; set; }

    [InverseProperty("ComMotivoOrdenCompra")]
    public virtual ICollection<ComOrdencompraLocal> ComOrdencompraLocal { get; set; } = new List<ComOrdencompraLocal>();

    [InverseProperty("ComMotivoOrdenCompra")]
    public virtual ICollection<InIngEgrInven> InIngEgrInven { get; set; } = new List<InIngEgrInven>();
}
