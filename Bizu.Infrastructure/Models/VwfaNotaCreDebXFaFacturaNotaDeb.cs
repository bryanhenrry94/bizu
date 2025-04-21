using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaNotaCreDebXFaFacturaNotaDeb
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtTipoDoc { get; set; }

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

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("nom_Cliente")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCliente { get; set; } = null!;

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_fech_venc")]
    [MaxLength(6)]
    public DateTime? VtFechVenc { get; set; }

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
