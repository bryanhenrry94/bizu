using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdCbteVta", "IdTerminoPago", "Secuencia")]
[Table("fa_factura_x_fa_TerminoPago")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFacturaXFaTerminoPago
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Key]
    [StringLength(20)]
    public string IdTerminoPago { get; set; } = null!;

    [Key]
    public int Secuencia { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("Fecha_vct")]
    [MaxLength(6)]
    public DateTime FechaVct { get; set; }

    [Column("Dias_Plazo")]
    public int DiasPlazo { get; set; }

    [Column("Por_Distribucion")]
    public double PorDistribucion { get; set; }

    public double Valor { get; set; }
}
