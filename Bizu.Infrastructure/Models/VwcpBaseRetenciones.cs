using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpBaseRetenciones
{
    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    public DateOnly Fecha { get; set; }

    [Column("BASE_IVA")]
    public double BaseIva { get; set; }

    [Column("BASE_IVA0")]
    public double BaseIva0 { get; set; }

    [Column("BASE")]
    public double Base { get; set; }

    [Column("IdCodigo_SRI")]
    public int IdCodigoSri { get; set; }

    [Column("re_tipoRet")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReTipoRet { get; set; } = null!;

    [Column("re_valor_retencion")]
    public double ReValorRetencion { get; set; }
}
