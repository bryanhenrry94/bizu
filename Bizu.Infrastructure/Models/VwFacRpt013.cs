using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFacRpt013
{
    public int IdEmpresa { get; set; }

    [Column("nom_empresa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEmpresa { get; set; } = null!;

    public int IdSucursal { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("nom_cliente")]
    [StringLength(201)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCliente { get; set; } = null!;

    [Column("Cedula_Ruc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CedulaRuc { get; set; } = null!;

    [Column("fecha")]
    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(149)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Documento { get; set; }

    public double? Debito { get; set; }

    public double Credito { get; set; }

    public long Saldo { get; set; }

    [Column("vt_Observacion", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtObservacion { get; set; } = null!;
}
