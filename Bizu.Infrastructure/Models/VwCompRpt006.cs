using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCompRpt006
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdSolicitudCompra { get; set; }

    [Column("Secuencia_SC")]
    public int SecuenciaSc { get; set; }

    [Column("IdProducto_SC")]
    [Precision(18, 0)]
    public decimal? IdProductoSc { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("NomProducto_SC")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProductoSc { get; set; }

    [Column("do_Cantidad")]
    public double DoCantidad { get; set; }

    [Column("Cantidad_aprobada")]
    public double CantidadAprobada { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprueba { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAprobacion { get; set; }

    [Column("observacion")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUnidadMedida { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    [Column("do_precioCompra")]
    public double? DoPrecioCompra { get; set; }

    [Column("do_porc_des")]
    public double? DoPorcDes { get; set; }

    [Column("do_subtotal")]
    public double? DoSubtotal { get; set; }

    [Column("do_iva")]
    public double? DoIva { get; set; }

    [Column("do_total")]
    public double? DoTotal { get; set; }

    [Column("do_ManejaIva")]
    public bool? DoManejaIva { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacion { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoPreAprobacion { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescrpcionEstadoAprobacion { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DescrpcionEstadoPreAprobacion { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("codPunto_cargo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodPuntoCargo { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Column("nomSolicitante")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSolicitante { get; set; } = null!;
}
