using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaPuntoVta
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    public int IdPuntoVta { get; set; }

    [Column("cod_PuntoVta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodPuntoVta { get; set; } = null!;

    [Column("nom_PuntoVta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomPuntoVta { get; set; } = null!;

    [Column("estado")]
    public bool Estado { get; set; }

    public int? IdBodega { get; set; }
}
