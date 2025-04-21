using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdDocumentoTalonario")]
[Table("tb_sis_Documento_Registros_x_Talonario")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisDocumentoRegistrosXTalonario
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(150)]
    public string IdDocumentoTalonario { get; set; } = null!;

    [StringLength(20)]
    public string CodDocumentoTipo { get; set; } = null!;

    [StringLength(3)]
    public string Serie1 { get; set; } = null!;

    [StringLength(3)]
    public string Serie2 { get; set; } = null!;

    [StringLength(50)]
    public string NumDocumento { get; set; } = null!;

    [StringLength(150)]
    public string NumAutorizacion { get; set; } = null!;

    [StringLength(50)]
    public string NumDocIni { get; set; } = null!;

    [StringLength(50)]
    public string NumDocFin { get; set; } = null!;

    [StringLength(1)]
    public string Utilizado { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(250)]
    public string? TransaccionRelacionada { get; set; }
}
