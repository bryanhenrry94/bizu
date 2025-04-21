using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt036
{
    [Column("re_tipoRet")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReTipoRet { get; set; } = null!;

    [Column("IdCodigo_SRI")]
    public int IdCodigoSri { get; set; }

    [Column("cod_Impuesto_SRI")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodImpuestoSri { get; set; } = null!;

    [StringLength(350)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Impuesto { get; set; } = null!;

    [Column("Base_IVA")]
    public double? BaseIva { get; set; }

    [Column("Base_IVA0")]
    public double? BaseIva0 { get; set; }

    public double? Base { get; set; }

    [Column("Valor_Retencion")]
    public double? ValorRetencion { get; set; }
}
