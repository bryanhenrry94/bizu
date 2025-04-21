using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCajTalonarioRecibo
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdRecibo { get; set; }

    public int IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    public int IdPuntoVta { get; set; }

    [Column("nom_PuntoVta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomPuntoVta { get; set; } = null!;

    [Column("Su_CodigoEstablecimiento")]
    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SuCodigoEstablecimiento { get; set; }

    [Column("cod_PuntoVta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodPuntoVta { get; set; } = null!;

    [Column("Num_Recibo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumRecibo { get; set; } = null!;

    public bool Usado { get; set; }

    public bool Estado { get; set; }
}
