using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwGeTbSisDocumentoTipoTalonario
{
    public int IdEmpresa { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodDocumentoTipo { get; set; } = null!;

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Establecimiento { get; set; } = null!;

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PuntoEmision { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumDocumento { get; set; } = null!;

    [MaxLength(6)]
    public DateTime? FechaCaducidad { get; set; }

    public bool? Usado { get; set; }

    public int IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }

    [Column("es_Documento_Electronico")]
    public bool? EsDocumentoElectronico { get; set; }
}
