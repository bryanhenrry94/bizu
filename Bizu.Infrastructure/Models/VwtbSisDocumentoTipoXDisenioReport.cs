using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwtbSisDocumentoTipoXDisenioReport
{
    public int IdEmpresa { get; set; }

    [Column("codDocumentoTipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodDocumentoTipo { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    [Column("File_Disenio_Reporte")]
    public byte[]? FileDisenioReporte { get; set; }

    [Column("ApareceCombo_FileReporte")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ApareceComboFileReporte { get; set; } = null!;
}
