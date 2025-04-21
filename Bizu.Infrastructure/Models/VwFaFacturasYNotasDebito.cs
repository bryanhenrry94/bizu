using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFaFacturasYNotasDebito
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Tipo { get; set; }

    [Precision(18, 0)]
    public decimal IdCbte { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie1 { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }

    [Column("NumNota_Impresa")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumNotaImpresa { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("fecha")]
    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("no_fecha_venc")]
    [MaxLength(6)]
    public DateTime? NoFechaVenc { get; set; }

    [StringLength(68)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Referencia { get; set; }

    public double? SubTotal { get; set; }

    public double? Iva { get; set; }

    public double? Total { get; set; }
}
