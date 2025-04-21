using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinGuiaRemisionDetConSaldoXIngAInven
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    public int Secuencia { get; set; }

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoPersona { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdEntidad { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    public DateOnly FechaEmision { get; set; }

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Origen { get; set; } = null!;

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Destino { get; set; } = null!;

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    public int IdMotivo { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Codigo { get; set; } = null!;

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    public double Cantidad { get; set; }

    [Column("Cantidad_sinConversion")]
    public double? CantidadSinConversion { get; set; }

    public double? Peso { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(11)]
    public string IdEstadoRecepcion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    public int? IdProyecto { get; set; }

    [Column("Fecha_ing_bod")]
    [MaxLength(6)]
    public DateTime? FechaIngBod { get; set; }

    [Column("cm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CmObservacion { get; set; }

    [Column("cantidad_ing_a_Inven")]
    public double? CantidadIngAInven { get; set; }

    [Column("cantidad_ingresada")]
    public double? CantidadIngresada { get; set; }

    [Column("IdEstado_cierre")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoCierre { get; set; } = null!;

    [Column("IdUnidadMedida_Consumo")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedidaConsumo { get; set; } = null!;

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string UnidadMedida { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadMedida { get; set; }

    [Column("IdUnidadMedida_sinConversion")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadMedidaSinConversion { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie1 { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [StringLength(18)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumGuia { get; set; }

    public int? IdBodega { get; set; }

    [Column("Detalle_x_Item")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DetalleXItem { get; set; }

    public int IdProductoTipo { get; set; }
}
