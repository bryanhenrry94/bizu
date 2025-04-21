using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ct_parametro")]
[Index("IdEmpresa", "IdTipoCbteSaldoInicial", Name = "FK_ct_parametro_ct_cbtecble_tipo")]
[Index("IdEmpresa", "IdTipoCbteAsientoCierreAnual", Name = "FK_ct_parametro_ct_cbtecble_tipo1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtParametro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Column("IdTipoCbte_SaldoInicial")]
    public int? IdTipoCbteSaldoInicial { get; set; }

    [Column("IdTipoCbte_AsientoCierre_Anual")]
    public int? IdTipoCbteAsientoCierreAnual { get; set; }

    [Column("P_Se_Muestra_Todas_las_ctas_en_combos")]
    public bool? PSeMuestraTodasLasCtasEnCombos { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteAsientoCierreAnual")]
    [InverseProperty("CtParametroCtCbtecbleTipo")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteSaldoInicial")]
    [InverseProperty("CtParametroCtCbtecbleTipoNavigation")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipoNavigation { get; set; }
}
