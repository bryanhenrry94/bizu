using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdArchivoPreavisoCheq")]
[Table("ba_Archivo_Transferencia_x_PreAviso_Cheq")]
[Index("IdEmpresa", "IdBanco", Name = "FK_ba_Archivo_Transferencia_x_PreAviso_Cheq_ba_Banco_Cuenta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaArchivoTransferenciaXPreAvisoCheq
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdArchivo_preaviso_cheq")]
    [Precision(18, 0)]
    public decimal IdArchivoPreavisoCheq { get; set; }

    [Column("cod_Archivo_preaviso_cheq")]
    [StringLength(50)]
    public string CodArchivoPreavisoCheq { get; set; } = null!;

    public int IdBanco { get; set; }

    [Column("Nom_Archivo")]
    [StringLength(50)]
    public string NomArchivo { get; set; } = null!;

    public string Observacion { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public bool Estado { get; set; }

    [Column("Fecha_Proceso")]
    [MaxLength(6)]
    public DateTime FechaProceso { get; set; }

    public byte[]? Archivo { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("Nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [StringLength(50)]
    public string? Ip { get; set; }

    [Column("Motivo_anulacion")]
    [StringLength(50)]
    public string? MotivoAnulacion { get; set; }

    [InverseProperty("BaArchivoTransferenciaXPreAvisoCheq")]
    public virtual ICollection<BaArchivoTransferenciaXPreAvisoCheqDet> BaArchivoTransferenciaXPreAvisoCheqDet { get; set; } = new List<BaArchivoTransferenciaXPreAvisoCheqDet>();

    [ForeignKey("IdEmpresa, IdBanco")]
    [InverseProperty("BaArchivoTransferenciaXPreAvisoCheq")]
    public virtual BaBancoCuenta BaBancoCuenta { get; set; } = null!;
}
