using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCble", "IdTipocbte")]
[Table("ba_Cbte_Ban")]
[Index("IdEmpresa", "IdBanco", Name = "FK_ba_Cbte_Ban_ba_Banco_Cuenta")]
[Index("IdEstadoCbteBanCat", Name = "FK_ba_Cbte_Ban_ba_Catalogo")]
[Index("IdEstadoChequeCat", Name = "FK_ba_Cbte_Ban_ba_Catalogo1")]
[Index("IdEmpresa", "IdTipoFlujo", Name = "FK_ba_Cbte_Ban_ba_TipoFlujo")]
[Index("IdEmpresa", "IdTipoNota", Name = "FK_ba_Cbte_Ban_ba_tipo_nota")]
[Index("IdEmpresa", "IdTipoCbteAnulacion", "IdCbteCbleAnulacion", Name = "FK_ba_Cbte_Ban_ct_cbtecble1")]
[Index("IdEmpresa", "IdPeriodo", Name = "FK_ba_Cbte_Ban_ct_periodo")]
[Index("CbCiudadChq", Name = "FK_ba_Cbte_Ban_tb_ciudad")]
[Index("IdPersonaGiradoA", Name = "FK_ba_Cbte_Ban_tb_persona")]
[Index("IdEmpresa", "IdSucursal", Name = "FK_ba_Cbte_Ban_tb_sucursal")]
[Index("IdEmpresa", "IdTipocbte", "IdCbteCble", "IdBanco", Name = "IX_ba_Cbte_Ban")]
[Index("IdEmpresa", "CbFecha", Name = "idx_cbtecble_IdEmpresa_cb_Fecha")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaCbteBan
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Key]
    public int IdTipocbte { get; set; }

    [Column("Cod_Cbtecble")]
    [StringLength(50)]
    public string CodCbtecble { get; set; } = null!;

    public int IdPeriodo { get; set; }

    public int IdBanco { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("cb_Fecha")]
    public DateOnly CbFecha { get; set; }

    [Column("cb_Observacion")]
    public string CbObservacion { get; set; } = null!;

    [Column("cb_secuencia")]
    [Precision(18, 0)]
    public decimal CbSecuencia { get; set; }

    [Column("cb_Valor")]
    public double CbValor { get; set; }

    [Column("cb_Cheque")]
    [StringLength(50)]
    public string? CbCheque { get; set; }

    [Column("cb_ChequeImpreso")]
    [StringLength(1)]
    public string CbChequeImpreso { get; set; } = null!;

    [Column("cb_FechaCheque")]
    public DateOnly? CbFechaCheque { get; set; }

    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [Column("IdUsuario_Anu")]
    [StringLength(50)]
    public string? IdUsuarioAnu { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(200)]
    public string? MotivoAnulacion { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("IdPersona_Girado_a")]
    [Precision(18, 0)]
    public decimal? IdPersonaGiradoA { get; set; }

    [Column("cb_giradoA")]
    [StringLength(150)]
    public string? CbGiradoA { get; set; }

    [Column("cb_ciudadChq")]
    [StringLength(25)]
    public string? CbCiudadChq { get; set; }

    [Column("IdCbteCble_Anulacion")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleAnulacion { get; set; }

    [Column("IdTipoCbte_Anulacion")]
    public int? IdTipoCbteAnulacion { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    public int? IdTipoNota { get; set; }

    public string? IdTransaccion { get; set; }

    [Column("Por_Anticipo")]
    [StringLength(1)]
    public string? PorAnticipo { get; set; }

    [StringLength(1)]
    public string? PosFechado { get; set; }

    public string? ValorEnLetras { get; set; }

    public int? IdSucursal { get; set; }

    [Column("IdEstado_Cbte_Ban_cat")]
    [StringLength(50)]
    public string? IdEstadoCbteBanCat { get; set; }

    [Column("IdEstado_Preaviso_ch_cat")]
    [StringLength(50)]
    public string? IdEstadoPreavisoChCat { get; set; }

    [Column("IdEstado_cheque_cat")]
    [StringLength(50)]
    public string? IdEstadoChequeCat { get; set; }

    [InverseProperty("BaCbteBan")]
    public virtual ICollection<BaArchivoTransferenciaXPreAvisoCheqDet> BaArchivoTransferenciaXPreAvisoCheqDet { get; set; } = new List<BaArchivoTransferenciaXPreAvisoCheqDet>();

    [ForeignKey("IdEmpresa, IdBanco")]
    [InverseProperty("BaCbteBan")]
    public virtual BaBancoCuenta BaBancoCuenta { get; set; } = null!;

    [InverseProperty("BaCbteBan")]
    public virtual ICollection<BaCajaMovimientoXCbteBanXDeposito> BaCajaMovimientoXCbteBanXDeposito { get; set; } = new List<BaCajaMovimientoXCbteBanXDeposito>();

    [InverseProperty("BaCbteBan")]
    public virtual BaCbteBanDatosTransferencia? BaCbteBanDatosTransferencia { get; set; }

    [ForeignKey("IdEmpresa, IdTipoFlujo")]
    [InverseProperty("BaCbteBan")]
    public virtual BaTipoFlujo? BaTipoFlujo { get; set; }

    [ForeignKey("IdEmpresa, IdTipoNota")]
    [InverseProperty("BaCbteBan")]
    public virtual BaTipoNota? BaTipoNota { get; set; }

    [InverseProperty("BaCbteBan")]
    public virtual ICollection<BaTransferencia> BaTransferenciaBaCbteBan { get; set; } = new List<BaTransferencia>();

    [InverseProperty("BaCbteBanNavigation")]
    public virtual ICollection<BaTransferencia> BaTransferenciaBaCbteBanNavigation { get; set; } = new List<BaTransferencia>();

    [ForeignKey("CbCiudadChq")]
    [InverseProperty("BaCbteBan")]
    public virtual TbCiudad? CbCiudadChqNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteAnulacion, IdCbteCbleAnulacion")]
    [InverseProperty("BaCbteBanCtCbtecble")]
    public virtual CtCbtecble? CtCbtecble { get; set; }

    [ForeignKey("IdEmpresa, IdTipocbte, IdCbteCble")]
    [InverseProperty("BaCbteBanCtCbtecbleNavigation")]
    public virtual CtCbtecble CtCbtecbleNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdPeriodo")]
    [InverseProperty("BaCbteBan")]
    public virtual CtPeriodo CtPeriodo { get; set; } = null!;

    [ForeignKey("IdEstadoCbteBanCat")]
    [InverseProperty("BaCbteBanIdEstadoCbteBanCatNavigation")]
    public virtual BaCatalogo? IdEstadoCbteBanCatNavigation { get; set; }

    [ForeignKey("IdEstadoChequeCat")]
    [InverseProperty("BaCbteBanIdEstadoChequeCatNavigation")]
    public virtual BaCatalogo? IdEstadoChequeCatNavigation { get; set; }

    [ForeignKey("IdPersonaGiradoA")]
    [InverseProperty("BaCbteBan")]
    public virtual TbPersona? IdPersonaGiradoANavigation { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("BaCbteBan")]
    public virtual TbSucursal? TbSucursal { get; set; }
}
