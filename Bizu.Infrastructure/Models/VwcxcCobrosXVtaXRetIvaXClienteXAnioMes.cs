using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcCobrosXVtaXRetIvaXClienteXAnioMes
{
    public int IdEmpresa { get; set; }

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("Valor_ret")]
    public double? ValorRet { get; set; }

    [Column("IdAnioRT")]
    public long? IdAnioRt { get; set; }

    public long? IdMes { get; set; }
}
