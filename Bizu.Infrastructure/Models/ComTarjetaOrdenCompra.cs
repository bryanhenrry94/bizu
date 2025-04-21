using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("com_tarjeta_orden_compra")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComTarjetaOrdenCompra
{
    public int IdEmpresa { get; set; }

    public int? IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [StringLength(10)]
    public string Tipo { get; set; } = null!;

    [Precision(18, 0)]
    public decimal Cbte { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nom_Proveedor")]
    [StringLength(200)]
    public string NomProveedor { get; set; } = null!;

    [StringLength(50)]
    public string Referencia { get; set; } = null!;

    [Column("Fecha_Documento")]
    public DateOnly FechaDocumento { get; set; }

    [Column("Total_Debe")]
    public double? TotalDebe { get; set; }

    [Column("Total_Haber")]
    public double? TotalHaber { get; set; }

    [Column("Total_Saldo")]
    public double? TotalSaldo { get; set; }

    [Column("Debe_OC")]
    public double DebeOc { get; set; }

    [Column("Haber_OC")]
    public double HaberOc { get; set; }

    [Column("Saldo_OC")]
    public double SaldoOc { get; set; }

    public string Observacion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(25)]
    public string? IdCentroCosto { get; set; }

    public int Nivel { get; set; }

    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;
}
