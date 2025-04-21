using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaOpBaArchivoTransferenciaDet
{
    [Column("Valor_a_pagar")]
    public double ValorAPagar { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodPersona { get; set; } = null!;

    [Column("pe_Naturaleza")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNaturaleza { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_apellido")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeApellido { get; set; } = null!;

    [Column("pe_razonSocial")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeRazonSocial { get; set; }

    [Column("pe_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombre { get; set; } = null!;

    public int IdTipoPersona { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoDocumento { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Column("Fecha_Pago")]
    public DateOnly FechaPago { get; set; }

    public bool Estado { get; set; }

    [Column("IdEstadoRegistro_cat")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoRegistroCat { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacion { get; set; } = null!;

    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdArchivo { get; set; }

    [Column("IdProceso_bancario")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdProcesoBancario { get; set; } = null!;

    public int Secuencia { get; set; }

    [Column("IdEmpresa_OP")]
    public int? IdEmpresaOp { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenPago { get; set; }

    [Column("Secuencia_OP")]
    public int? SecuenciaOp { get; set; }

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoPersona1 { get; set; }

    [Precision(18, 0)]
    public decimal? IdEntidad { get; set; }
}
