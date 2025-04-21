using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdUsuario", "Nretencion", "NomPc", "IdSecuenciaReten", "TipoRetencion", "Ndocumento")]
[Table("tbCXP_Rpt004")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCxpRpt004
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    [Column("NRetencion")]
    [StringLength(50)]
    public string Nretencion { get; set; } = null!;

    [Key]
    [Column("nom_pc")]
    [StringLength(50)]
    public string NomPc { get; set; } = null!;

    [Key]
    public int IdSecuenciaReten { get; set; }

    [Key]
    [StringLength(5)]
    public string TipoRetencion { get; set; } = null!;

    [Key]
    [Column("NDocumento")]
    [StringLength(50)]
    public string Ndocumento { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("fechaRetencion")]
    public DateOnly FechaRetencion { get; set; }

    [StringLength(150)]
    public string Proveedor { get; set; } = null!;

    public double BaseRetencion { get; set; }

    public double ValorRetencion { get; set; }

    [Column("CodigoSRI")]
    [StringLength(50)]
    public string CodigoSri { get; set; } = null!;
}
