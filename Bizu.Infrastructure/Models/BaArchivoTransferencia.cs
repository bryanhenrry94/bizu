using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdArchivo")]
[Table("ba_Archivo_Transferencia")]
[Index("IdEmpresa", "IdBanco", Name = "FK_ba_Archivo_Transferencia_ba_Banco_Cuenta")]
[Index("IdEstadoArchivoCat", Name = "FK_ba_Archivo_Transferencia_ba_Catalogo")]
[Index("IdMotivoArchivoCat", Name = "FK_ba_Archivo_Transferencia_ba_Catalogo1")]
[Index("IdProcesoBancario", Name = "FK_ba_Archivo_Transferencia_tb_banco_procesos_bancarios_tipo")]
[Index("IdEmpresa", "IdArchivo", "IdBanco", "IdProcesoBancario", Name = "IX_ba_Archivo_Transferencia")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaArchivoTransferencia
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdArchivo { get; set; }

    [Column("cod_archivo")]
    [StringLength(50)]
    public string? CodArchivo { get; set; }

    public int IdBanco { get; set; }

    [Column("IdOrden_Bancaria")]
    [StringLength(50)]
    public string? IdOrdenBancaria { get; set; }

    [Column("IdProceso_bancario")]
    [StringLength(25)]
    public string IdProcesoBancario { get; set; } = null!;

    [Column("Origen_Archivo")]
    [StringLength(50)]
    public string OrigenArchivo { get; set; } = null!;

    [Column("Cod_Empresa")]
    [StringLength(30)]
    public string CodEmpresa { get; set; } = null!;

    [Column("Nom_Archivo")]
    [StringLength(200)]
    public string NomArchivo { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public byte[] Archivo { get; set; } = null!;

    public bool Estado { get; set; }

    [Column("IdEstadoArchivo_cat")]
    [StringLength(50)]
    public string IdEstadoArchivoCat { get; set; } = null!;

    [Column("IdMotivoArchivo_cat")]
    [StringLength(50)]
    public string? IdMotivoArchivoCat { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(200)]
    public string Observacion { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("Nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [StringLength(25)]
    public string? Ip { get; set; }

    [Column("Motivo_anulacion")]
    [StringLength(100)]
    public string? MotivoAnulacion { get; set; }

    [Column("Fecha_Proceso")]
    [MaxLength(6)]
    public DateTime? FechaProceso { get; set; }

    public bool? Contabilizado { get; set; }

    [InverseProperty("BaArchivoTransferencia")]
    public virtual ICollection<BaArchivoTransferenciaDet> BaArchivoTransferenciaDet { get; set; } = new List<BaArchivoTransferenciaDet>();

    [ForeignKey("IdEmpresa, IdBanco")]
    [InverseProperty("BaArchivoTransferencia")]
    public virtual BaBancoCuenta BaBancoCuenta { get; set; } = null!;

    [ForeignKey("IdEstadoArchivoCat")]
    [InverseProperty("BaArchivoTransferenciaIdEstadoArchivoCatNavigation")]
    public virtual BaCatalogo IdEstadoArchivoCatNavigation { get; set; } = null!;

    [ForeignKey("IdMotivoArchivoCat")]
    [InverseProperty("BaArchivoTransferenciaIdMotivoArchivoCatNavigation")]
    public virtual BaCatalogo? IdMotivoArchivoCatNavigation { get; set; }

    [ForeignKey("IdProcesoBancario")]
    [InverseProperty("BaArchivoTransferencia")]
    public virtual TbBancoProcesosBancariosTipo IdProcesoBancarioNavigation { get; set; } = null!;
}
