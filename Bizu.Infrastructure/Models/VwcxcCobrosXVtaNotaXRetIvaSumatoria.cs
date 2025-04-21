using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcCobrosXVtaNotaXRetIvaSumatoria
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Column("IdBodega_Cbte")]
    public int? IdBodegaCbte { get; set; }

    [Column("IdCbte_vta_nota")]
    [Precision(18, 0)]
    public decimal IdCbteVtaNota { get; set; }

    [Column("dc_ValorPago")]
    public double? DcValorPago { get; set; }

    [Column("dc_TipoDocumento")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DcTipoDocumento { get; set; }
}
