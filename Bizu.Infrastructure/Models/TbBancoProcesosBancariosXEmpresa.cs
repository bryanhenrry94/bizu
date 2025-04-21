using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProcesoBancarioTipo")]
[Table("tb_banco_procesos_bancarios_x_empresa")]
[Index("IdEmpresa", "IdTipoNota", Name = "FK_tb_banco_procesos_bancarios_x_empresa_ba_tipo_nota")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbBancoProcesosBancariosXEmpresa
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdProceso_bancario_tipo")]
    [StringLength(25)]
    public string IdProcesoBancarioTipo { get; set; } = null!;

    public int IdBanco { get; set; }

    [Column("cod_banco")]
    [StringLength(50)]
    public string CodBanco { get; set; } = null!;

    [Column("Codigo_Empresa")]
    [StringLength(50)]
    public string? CodigoEmpresa { get; set; }

    [Column("Secuencial_detalle_inicial")]
    [Precision(18, 0)]
    public decimal? SecuencialDetalleInicial { get; set; }

    public int? IdTipoNota { get; set; }

    [Column("Se_contabiliza")]
    public bool? SeContabiliza { get; set; }

    [ForeignKey("IdEmpresa, IdTipoNota")]
    [InverseProperty("TbBancoProcesosBancariosXEmpresa")]
    public virtual BaTipoNota? BaTipoNota { get; set; }
}
