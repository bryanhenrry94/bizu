using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinTransferenciaDetXInGuiaXTraspasoBodegaDet
{
    [Column("IdEmpresa_trans")]
    public int IdEmpresaTrans { get; set; }

    [Column("IdSucursalOrigen_trans")]
    public int IdSucursalOrigenTrans { get; set; }

    [Column("codigo")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Codigo { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("IdBodegaOrigen_trans")]
    public int IdBodegaOrigenTrans { get; set; }

    [Column("cod_bodega")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodBodega { get; set; }

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Column("IdTransferencia_trans")]
    [Precision(18, 0)]
    public decimal IdTransferenciaTrans { get; set; }

    [Column("Secuencia_trans")]
    public int SecuenciaTrans { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("IdEmpresa_guia")]
    public int IdEmpresaGuia { get; set; }

    [Column("IdGuia_guia")]
    [Precision(18, 0)]
    public decimal IdGuiaGuia { get; set; }

    [Column("Secuencia_guia")]
    public int SecuenciaGuia { get; set; }
}
