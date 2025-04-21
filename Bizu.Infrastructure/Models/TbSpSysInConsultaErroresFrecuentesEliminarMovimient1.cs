using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdMoviInvenTipo", "IdNumMovi", "IdUsuario")]
[Table("tb_spSys_in_consulta_errores_frecuentes_eliminar_movimient1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSpSysInConsultaErroresFrecuentesEliminarMovimient1
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("IdEmpresa_ct")]
    public int? IdEmpresaCt { get; set; }

    [Column("IdTipoCbte_ct")]
    public int? IdTipoCbteCt { get; set; }

    [Column("IdCbteCble_ct")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCt { get; set; }

    [Column("IdEmpresa_anu")]
    public int? IdEmpresaAnu { get; set; }

    [Column("IdTipoCbte_anu")]
    public int? IdTipoCbteAnu { get; set; }

    [Column("IdCbteCble_anu")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleAnu { get; set; }
}
