using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCompRpt013
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [Column("oc_plazo")]
    public int OcPlazo { get; set; }

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime OcFecha { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("do_Cantidad")]
    public double DoCantidad { get; set; }

    public double CantidadRecibida { get; set; }

    public double Saldo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    [Column("nom_categoria")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCategoria { get; set; } = null!;

    public int IdLinea { get; set; }

    [Column("nom_linea")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomLinea { get; set; } = null!;

    [Column("pr_peso")]
    public double PrPeso { get; set; }

    [Column("do_precioCompra")]
    public double DoPrecioCompra { get; set; }

    [Column("do_subtotal")]
    public double DoSubtotal { get; set; }

    [Column("do_Subtotal_SinDescuento")]
    public double DoSubtotalSinDescuento { get; set; }

    [Column("do_iva")]
    public double DoIva { get; set; }

    [Column("do_total")]
    public double DoTotal { get; set; }

    [Column("do_descuento")]
    public double DoDescuento { get; set; }

    [Column("do_porc_des")]
    public double DoPorcDes { get; set; }

    [Column("pr_contribuyenteEspecial")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrContribuyenteEspecial { get; set; }

    [Column("oc_NumDocumento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcNumDocumento { get; set; } = null!;

    [Column("Usuario_Solicitante")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? UsuarioSolicitante { get; set; }

    [Column("Usuario_Procesa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string UsuarioProcesa { get; set; } = null!;

    [Column("Usuario_Aprueba")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? UsuarioAprueba { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TerminoPago { get; set; } = null!;

    public int DiasTerminoPago { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? UnidadMedidaConsumo { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCentroCosto { get; set; } = null!;

    [Column("Centro_costo")]
    [StringLength(273)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CentroCosto { get; set; }

    [Column("detalle_x_item")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DetalleXItem { get; set; } = null!;

    [Column("oc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcObservacion { get; set; } = null!;

    [Column("IdEstadoAprobacion_cat")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacionCat { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;
}
