using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaNotaCreDebSri
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CreDeb { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodNota { get; set; } = null!;

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie1 { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("no_fecha")]
    [MaxLength(6)]
    public DateTime NoFecha { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NaturalezaNota { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string RazonSocial { get; set; } = null!;

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreComercial { get; set; } = null!;

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ContribuyenteEspecial { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ObligadoAllevarConta { get; set; } = null!;

    [Column("em_ruc")]
    [StringLength(13)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmRuc { get; set; } = null!;

    [Column("em_direccion")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmDireccion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("Su_Direccion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SuDireccion { get; set; }

    [Column("cl_RazonSocial")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ClRazonSocial { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoDocumento { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("pe_correo")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCorreo { get; set; }

    [Column("NumNota_Impresa")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumNotaImpresa { get; set; }

    [Column("num_Factura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumFactura { get; set; }

    [Column("fecha_fact")]
    [MaxLength(6)]
    public DateTime FechaFact { get; set; }

    [Column("obser_fact", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ObserFact { get; set; } = null!;

    [Column("obser_Nota", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ObserNota { get; set; } = null!;

    [Column("nc_Motivo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NcMotivo { get; set; }

    [Column("tipo_doc_aplicado")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoDocAplicado { get; set; } = null!;

    public int? IdTipoNota { get; set; }
}
