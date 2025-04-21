using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomSolicitudCompraDet
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdSolicitudCompra { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [Column("do_Cantidad")]
    public double DoCantidad { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProducto { get; set; }

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

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadMedida { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }

    [Column("Nom_Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCosto { get; set; }

    [Column("Nom_SubCentroCosto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSubCentroCosto { get; set; }

    [Column("cod_producto")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodProducto { get; set; }

    [Column("nom_producto_princ")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProductoPrinc { get; set; }

    [Column("pr_stock")]
    public double PrStock { get; set; }

    [Column("ocd_IdOrdenCompra")]
    [MaxLength(0)]
    public byte[]? OcdIdOrdenCompra { get; set; }

    [Column("ocd_IdEmpresa")]
    [MaxLength(0)]
    public byte[]? OcdIdEmpresa { get; set; }

    [Column("ocd_IdSucursal")]
    [MaxLength(0)]
    public byte[]? OcdIdSucursal { get; set; }

    [Column("fecha")]
    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAprobacion { get; set; }

    [Column("nom_Sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSucursal { get; set; }

    [Column("nom_Unidad")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomUnidad { get; set; }

    [Column("do_observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DoObservacion { get; set; }

    [Precision(18, 0)]
    public decimal? IdRubro { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdOferta { get; set; }

    [Column("Secuencia_Oferta")]
    public int? SecuenciaOferta { get; set; }

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
