using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdBanco", "IdEstadoRegCat", "IdEstadoRegBancario")]
[Table("tb_banco_estado_reg__resp_bancaria")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbBancoEstadoRegRespBancaria
{
    [Key]
    public int IdBanco { get; set; }

    [Key]
    [Column("IdEstado_Reg_cat")]
    [StringLength(10)]
    public string IdEstadoRegCat { get; set; } = null!;

    [Key]
    [Column("IdEstado_Reg_Bancario")]
    [StringLength(50)]
    public string IdEstadoRegBancario { get; set; } = null!;

    [Column("observacion")]
    [StringLength(50)]
    public string Observacion { get; set; } = null!;

    [Column("Genera_anulacion")]
    public bool? GeneraAnulacion { get; set; }

    [ForeignKey("IdBanco")]
    [InverseProperty("TbBancoEstadoRegRespBancaria")]
    public virtual TbBanco IdBancoNavigation { get; set; } = null!;
}
