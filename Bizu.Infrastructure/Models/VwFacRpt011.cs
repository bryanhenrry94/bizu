using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFacRpt011
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdDevolucion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodDevolucion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("numDocumento")]
    [StringLength(48)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("pe_telefonoCasa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeTelefonoCasa { get; set; }

    [Column("pe_direccion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeDireccion { get; set; } = null!;

    [Column("Ve_Vendedor")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VeVendedor { get; set; }

    [Column("dv_fecha")]
    [MaxLength(6)]
    public DateTime DvFecha { get; set; }

    [Column("dv_Observacion")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DvObservacion { get; set; } = null!;

    [Column("dv_interes")]
    public double DvInteres { get; set; }

    [Column("dv_cantidad")]
    public double DvCantidad { get; set; }

    [Column("dv_valor")]
    public double DvValor { get; set; }

    [Column("dv_subtotal")]
    public double DvSubtotal { get; set; }

    [Column("dv_iva")]
    public double DvIva { get; set; }

    [Column("dv_total")]
    public double DvTotal { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("nombreProducto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreProducto { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("valorFlete")]
    public double ValorFlete { get; set; }
}
