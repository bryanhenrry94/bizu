using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaNotaCreDebXFaFacturaNotaDebXNc
{
    [Column("IdEmpresa_nt")]
    public int IdEmpresaNt { get; set; }

    [Column("IdSucursal_nt")]
    public int IdSucursalNt { get; set; }

    [Column("IdBodega_nt")]
    public int IdBodegaNt { get; set; }

    [Column("IdNota_nt")]
    [Precision(18, 0)]
    public decimal IdNotaNt { get; set; }

    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_fac_nd_doc_mod")]
    public int IdEmpresaFacNdDocMod { get; set; }

    [Column("IdSucursal_fac_nd_doc_mod")]
    public int IdSucursalFacNdDocMod { get; set; }

    [Column("IdBodega_fac_nd_doc_mod")]
    public int IdBodegaFacNdDocMod { get; set; }

    [Column("IdCbteVta_fac_nd_doc_mod")]
    [Precision(18, 0)]
    public decimal IdCbteVtaFacNdDocMod { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtTipoDoc { get; set; } = null!;

    [Column("Valor_Aplicado")]
    public double ValorAplicado { get; set; }

    [Column("fecha_cruce")]
    public DateOnly FechaCruce { get; set; }

    [Column("vt_serie1")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtSerie1 { get; set; }

    [Column("vt_serie2")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtSerie2 { get; set; }

    [Column("vt_NumFactura")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtNumFactura { get; set; }

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_fech_venc")]
    [MaxLength(6)]
    public DateTime? VtFechVenc { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("nom_Cliente")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCliente { get; set; } = null!;

    [Column("vt_Observacion", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtObservacion { get; set; } = null!;

    [Column("vt_total")]
    public double? VtTotal { get; set; }

    [Column("num_doc")]
    [StringLength(51)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDoc { get; set; }
}
