using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomSolicitudCompraDetSaldoPendiente
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Sucursal { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdSolicitudCompra { get; set; }

    public int Secuencia { get; set; }

    [Column("fecha")]
    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("plazo")]
    public int Plazo { get; set; }

    [Column("fecha_vtc")]
    [MaxLength(6)]
    public DateTime FechaVtc { get; set; }

    [Column("observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdSolicitante { get; set; }

    [Column("nom_solicitante")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSolicitante { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("do_observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DoObservacion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadMedida { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? UnidadMedida { get; set; }

    [Column("UnidadMedida_Alterno")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? UnidadMedidaAlterno { get; set; }

    [Column("do_Cantidad")]
    public double DoCantidad { get; set; }

    public double? CantidadPedida { get; set; }

    public double? Saldo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    [Column("ca_Categoria")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaCategoria { get; set; } = null!;

    public int IdLinea { get; set; }

    [Column("nom_linea")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomLinea { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("Secuencia_Oferta")]
    public int? SecuenciaOferta { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("IdEmpresa_obr_AsignacionPorcentual")]
    public int? IdEmpresaObrAsignacionPorcentual { get; set; }

    [Column("IdSucursal_obr_AsignacionPorcentual")]
    public int? IdSucursalObrAsignacionPorcentual { get; set; }

    [Column("IdProyecto_obr_AsignacionPorcentual")]
    public int? IdProyectoObrAsignacionPorcentual { get; set; }

    [Column("IdOferta_obr_AsignacionPorcentual")]
    public int? IdOfertaObrAsignacionPorcentual { get; set; }

    [Column("Secuencia_obr_AsignacionPorcentual")]
    public int? SecuenciaObrAsignacionPorcentual { get; set; }
}
