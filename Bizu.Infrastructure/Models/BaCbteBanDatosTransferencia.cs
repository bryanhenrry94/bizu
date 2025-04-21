using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCble", "IdTipocbte")]
[Table("ba_Cbte_Ban_Datos_Transferencia")]
[Index("IdProcesoBancario", Name = "FK_ba_Cbte_Ban_Datos_Transferencia_tb_banco_procesos_bancarios6")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaCbteBanDatosTransferencia
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Key]
    public int IdTipocbte { get; set; }

    [Column("IdProceso_bancario")]
    [StringLength(25)]
    public string IdProcesoBancario { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCbteCble, IdTipocbte")]
    [InverseProperty("BaCbteBanDatosTransferencia")]
    public virtual BaCbteBan BaCbteBan { get; set; } = null!;

    [ForeignKey("IdProcesoBancario")]
    [InverseProperty("BaCbteBanDatosTransferencia")]
    public virtual TbBancoProcesosBancariosTipo IdProcesoBancarioNavigation { get; set; } = null!;
}
