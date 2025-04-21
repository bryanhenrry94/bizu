using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaNotaCreDebXFaFacturaNotaDebSinCobros
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

    [Precision(18, 0)]
    public decimal? IdCobro { get; set; }
}
