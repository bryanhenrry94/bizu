using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdBanco")]
[Table("ba_Banco_Cuenta")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ba_Banco_Cuenta_ct_plancta")]
[Index("IdBancoFinanciero", Name = "FK_ba_Banco_Cuenta_tb_banco")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaBancoCuenta
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdBanco { get; set; }

    [Column("ba_descripcion")]
    [StringLength(150)]
    public string BaDescripcion { get; set; } = null!;

    [Column("ba_Tipo")]
    [StringLength(50)]
    public string BaTipo { get; set; } = null!;

    [Column("ba_Num_Cuenta")]
    [StringLength(50)]
    public string BaNumCuenta { get; set; } = null!;

    [Column("ba_Moneda")]
    [StringLength(50)]
    public string BaMoneda { get; set; } = null!;

    [Column("ba_Ultimo_Cheque")]
    [StringLength(50)]
    public string BaUltimoCheque { get; set; } = null!;

    [Column("ba_num_digito_cheq")]
    public int BaNumDigitoCheq { get; set; }

    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

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

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    public byte[]? Reporte { get; set; }

    [Column("ReporteSolo_Cheque")]
    public byte[]? ReporteSoloCheque { get; set; }

    public bool? MostrarVistaPreviaCheque { get; set; }

    [Column("Imprimir_Solo_el_cheque")]
    public bool? ImprimirSoloElCheque { get; set; }

    [Column("IdBanco_Financiero")]
    public int? IdBancoFinanciero { get; set; }

    [InverseProperty("BaBancoCuenta")]
    public virtual ICollection<BaArchivoTransferencia> BaArchivoTransferencia { get; set; } = new List<BaArchivoTransferencia>();

    [InverseProperty("BaBancoCuenta")]
    public virtual ICollection<BaArchivoTransferenciaXPreAvisoCheq> BaArchivoTransferenciaXPreAvisoCheq { get; set; } = new List<BaArchivoTransferenciaXPreAvisoCheq>();

    [InverseProperty("BaBancoCuenta")]
    public virtual ICollection<BaCbteBan> BaCbteBan { get; set; } = new List<BaCbteBan>();

    [InverseProperty("BaBancoCuenta")]
    public virtual ICollection<BaConciliacion> BaConciliacion { get; set; } = new List<BaConciliacion>();

    [InverseProperty("BaBancoCuenta")]
    public virtual BaConfigDisenoCheque? BaConfigDisenoCheque { get; set; }

    [InverseProperty("BaBancoCuenta")]
    public virtual ICollection<BaInversion> BaInversion { get; set; } = new List<BaInversion>();

    [InverseProperty("BaBancoCuenta")]
    public virtual ICollection<BaTalonarioChequesXBanco> BaTalonarioChequesXBanco { get; set; } = new List<BaTalonarioChequesXBanco>();

    [InverseProperty("BaBancoCuenta")]
    public virtual ICollection<BaTransferencia> BaTransferenciaBaBancoCuenta { get; set; } = new List<BaTransferencia>();

    [InverseProperty("BaBancoCuentaNavigation")]
    public virtual ICollection<BaTransferencia> BaTransferenciaBaBancoCuentaNavigation { get; set; } = new List<BaTransferencia>();

    [InverseProperty("BaBancoCuenta")]
    public virtual ICollection<CpOrdenPago> CpOrdenPago { get; set; } = new List<CpOrdenPago>();

    [InverseProperty("BaBancoCuenta")]
    public virtual ICollection<CpOrdenPagoDet> CpOrdenPagoDet { get; set; } = new List<CpOrdenPagoDet>();

    [InverseProperty("BaBancoCuenta")]
    public virtual ICollection<CpParametros> CpParametros { get; set; } = new List<CpParametros>();

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("BaBancoCuenta")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [ForeignKey("IdBancoFinanciero")]
    [InverseProperty("BaBancoCuenta")]
    public virtual TbBanco? IdBancoFinancieroNavigation { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("BaBancoCuenta")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;
}
