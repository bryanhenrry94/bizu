using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAprobacion")]
[Table("cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpNotaDebCreAprobacionIngBodXOc
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAprobacion { get; set; }

    [MaxLength(6)]
    public DateTime FechaAprobacion { get; set; }

    [Column("IdEmpresa_Nota")]
    public int? IdEmpresaNota { get; set; }

    [Column("IdCbteCble_Nota")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleNota { get; set; }

    [Column("IdTipoCbte_Nota")]
    public int? IdTipoCbteNota { get; set; }

    [Column("Subtotal_iva")]
    public double SubtotalIva { get; set; }

    [Column("Subtotal_siniva")]
    public double SubtotalSiniva { get; set; }

    public double Descuento { get; set; }

    public double BaseImponible { get; set; }

    [Column("Por_iva")]
    public double PorIva { get; set; }

    [Column("Valor_iva")]
    public double ValorIva { get; set; }

    public double Total { get; set; }
}
