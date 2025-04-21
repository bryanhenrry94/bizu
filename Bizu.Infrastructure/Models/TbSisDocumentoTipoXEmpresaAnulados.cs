using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "CodDocumentoTipo", "IdTipoDocAnu")]
[Table("tb_sis_Documento_Tipo_x_Empresa_Anulados")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisDocumentoTipoXEmpresaAnulados
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("codDocumentoTipo")]
    [StringLength(20)]
    public string CodDocumentoTipo { get; set; } = null!;

    [Key]
    [Precision(18, 0)]
    public decimal IdTipoDocAnu { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(3)]
    public string Serie1 { get; set; } = null!;

    [StringLength(3)]
    public string Serie2 { get; set; } = null!;

    [StringLength(50)]
    public string Documento { get; set; } = null!;

    [StringLength(50)]
    public string Autorizacion { get; set; } = null!;

    public int IdMotivoAnu { get; set; }

    [StringLength(300)]
    public string? MotivoAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }
}
