using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCompRpt001Ge
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("oc_NumDocumento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcNumDocumento { get; set; } = null!;

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Tipo { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTerminoPago { get; set; } = null!;

    public int Plazo { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public double Flete { get; set; }

    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdSolicitante { get; set; }

    [Precision(18, 0)]
    public decimal IdComprador { get; set; }

    [Precision(18, 0)]
    public decimal? IdDepartamento { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("cantidad")]
    public double Cantidad { get; set; }

    [Column("precio")]
    public double Precio { get; set; }

    [Column("por_desc")]
    public double PorDesc { get; set; }

    [Column("valor_descuento")]
    public double ValorDescuento { get; set; }

    [Column("subtotal")]
    public double Subtotal { get; set; }

    [Column("iva")]
    public double Iva { get; set; }

    [Column("total")]
    public double Total { get; set; }

    [Column("peso")]
    public double Peso { get; set; }

    [Column("cod_producto")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodProducto { get; set; } = null!;

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Column("sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Sucursal { get; set; } = null!;

    [Column("empresa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Empresa { get; set; } = null!;

    [Column("ruc_empresa")]
    [StringLength(13)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string RucEmpresa { get; set; } = null!;

    [Column("logo_empresa")]
    public byte[]? LogoEmpresa { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Column("ced_ruc_provee")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CedRucProvee { get; set; } = null!;

    [Column("direc_provee")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DirecProvee { get; set; } = null!;

    [Column("telef_provee")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TelefProvee { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomUnidad { get; set; }

    [Column("Nom_comprador")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomComprador { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("nom_centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCosto { get; set; }

    [Column("nom_sub_centro_costo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSubCentroCosto { get; set; }

    [Column("Detalle_x_Items")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DetalleXItems { get; set; } = null!;

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }

    [Column("em_direccion")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmDireccion { get; set; } = null!;

    [Column("nom_solicitante")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSolicitante { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    [Column("Nom_TerminoPago")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTerminoPago { get; set; } = null!;

    [Column("departamento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Departamento { get; set; } = null!;

    [Column("nom_EstadoCierre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEstadoCierre { get; set; } = null!;

    public int? NumSolicitud { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Naturaleza { get; set; }

    [Column("pr_contribuyenteEspecial")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrContribuyenteEspecial { get; set; }
}
