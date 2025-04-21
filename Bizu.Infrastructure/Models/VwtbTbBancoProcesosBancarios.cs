using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwtbTbBancoProcesosBancarios
{
    public int IdEmpresa { get; set; }

    [Column("IdProceso_bancario_tipo")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdProcesoBancarioTipo { get; set; } = null!;

    public int IdBanco { get; set; }

    [Column("cod_banco")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodBanco { get; set; } = null!;

    [Column("Codigo_Empresa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodigoEmpresa { get; set; }

    [Column("Iniciales_Archivo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string InicialesArchivo { get; set; } = null!;

    [Column("nom_proceso_bancario")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProcesoBancario { get; set; } = null!;

    [Column("Secuencial_detalle_inicial")]
    [Precision(18, 0)]
    public decimal? SecuencialDetalleInicial { get; set; }

    public int? IdTipoNota { get; set; }

    [Column("Se_contabiliza")]
    public bool? SeContabiliza { get; set; }

    [Column("Tipo_Proc")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoProc { get; set; }
}
