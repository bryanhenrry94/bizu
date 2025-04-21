using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdArchivoPreavisoCheq", "Secuencia")]
[Table("ba_Archivo_Transferencia_x_PreAviso_Cheq_det")]
[Index("IdEmpresaMvba", "IdCbteCbleMvba", "IdTipocbteMvba", Name = "FK_ba_Archivo_Transferencia_x_PreAviso_Cheq_det_ba_Cbte_Ban")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaArchivoTransferenciaXPreAvisoCheqDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdArchivo_preaviso_cheq")]
    [Precision(18, 0)]
    public decimal IdArchivoPreavisoCheq { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("observacion_det")]
    [StringLength(950)]
    public string ObservacionDet { get; set; } = null!;

    [Column("IdEmpresa_mvba")]
    public int IdEmpresaMvba { get; set; }

    [Column("IdCbteCble_mvba")]
    [Precision(18, 0)]
    public decimal IdCbteCbleMvba { get; set; }

    [Column("IdTipocbte_mvba")]
    public int IdTipocbteMvba { get; set; }

    [ForeignKey("IdEmpresa, IdArchivoPreavisoCheq")]
    [InverseProperty("BaArchivoTransferenciaXPreAvisoCheqDet")]
    public virtual BaArchivoTransferenciaXPreAvisoCheq BaArchivoTransferenciaXPreAvisoCheq { get; set; } = null!;

    [ForeignKey("IdEmpresaMvba, IdCbteCbleMvba, IdTipocbteMvba")]
    [InverseProperty("BaArchivoTransferenciaXPreAvisoCheqDet")]
    public virtual BaCbteBan BaCbteBan { get; set; } = null!;
}
