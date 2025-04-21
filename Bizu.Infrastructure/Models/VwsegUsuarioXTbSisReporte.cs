using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwsegUsuarioXTbSisReporte
{
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodReporte { get; set; } = null!;

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Nombre { get; set; } = null!;

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreCorto { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Modulo { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VistaRpt { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Formulario { get; set; } = null!;

    [Column("Class_NomReporte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ClassNomReporte { get; set; }

    [Column("nom_Asembly")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomAsembly { get; set; }

    public int Orden { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Observacion { get; set; }

    public int? VersionActual { get; set; }

    [Column("Tipo_Balance")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoBalance { get; set; }

    [Column("SQuery")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Squery { get; set; }

    [Column("Class_Info")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ClassInfo { get; set; }

    [Column("Class_Bus")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ClassBus { get; set; }

    [Column("Class_Data")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ClassData { get; set; } = null!;

    [Column("IdGrupo_Reporte")]
    public int? IdGrupoReporte { get; set; }

    [Column("se_Muestra_Admin_Reporte")]
    public sbyte? SeMuestraAdminReporte { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }

    [Column("Store_proce_rpt")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? StoreProceRpt { get; set; }

    [Column("Disenio_reporte")]
    public byte[]? DisenioReporte { get; set; }

    [Column("esta_en_base")]
    public long EstaEnBase { get; set; }
}
