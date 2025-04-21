using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCble", "IdTipocbte")]
[Table("caj_Caja_Movimiento")]
[Index("IdEmpresa", "IdTipoFlujo", Name = "FK_caj_Caja_Movimiento_ba_TipoFlujo")]
[Index("IdEmpresa", "IdCaja", Name = "FK_caj_Caja_Movimiento_caj_Caja")]
[Index("IdTipoMovi", Name = "FK_caj_Caja_Movimiento_caj_Caja_Movimiento_Tipo")]
[Index("IdEmpresa", "IdTipocbte", "IdCbteCble", Name = "FK_caj_Caja_Movimiento_ct_cbtecble")]
[Index("IdEmpresa", "IdTipocbteAnu", "IdCbteCbleAnu", Name = "FK_caj_Caja_Movimiento_ct_cbtecble1")]
[Index("IdEmpresa", "IdPeriodo", Name = "FK_caj_Caja_Movimiento_ct_periodo")]
[Index("IdPersona", Name = "FK_caj_Caja_Movimiento_tb_persona")]
[Index("IdTipoPersona", Name = "FK_caj_Caja_Movimiento_tb_persona_tipo")]
[Index("IdEmpresa", "IdSucursal", Name = "FK_caj_Caja_Movimiento_tb_sucursal")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajCajaMovimiento
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Key]
    public int IdTipocbte { get; set; }

    public int? IdSucursal { get; set; }

    [StringLength(20)]
    public string CodMoviCaja { get; set; } = null!;

    [Column("cm_Signo")]
    [StringLength(1)]
    public string CmSigno { get; set; } = null!;

    [Column("cm_beneficiario")]
    [StringLength(1000)]
    public string CmBeneficiario { get; set; } = null!;

    [Column("cm_valor")]
    public double CmValor { get; set; }

    public int IdTipoMovi { get; set; }

    [Column("cm_observacion")]
    public string CmObservacion { get; set; } = null!;

    public int IdCaja { get; set; }

    public int IdPeriodo { get; set; }

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

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

    [Column("IdUsuario_Aprueba")]
    [StringLength(50)]
    public string? IdUsuarioAprueba { get; set; }

    [Column("IdCbteCble_Anu")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleAnu { get; set; }

    [Column("IdTipocbte_Anu")]
    public int? IdTipocbteAnu { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    public string? IdTipoPersona { get; set; }

    [Precision(18, 0)]
    public decimal? IdEntidad { get; set; }

    [Precision(18, 0)]
    public decimal? IdPersona { get; set; }

    [Precision(18, 0)]
    public decimal? IdRecibo { get; set; }

    public int? IdPuntoVta { get; set; }

    [InverseProperty("CajCajaMovimiento")]
    public virtual ICollection<BaCajaMovimientoXCbteBanXDeposito> BaCajaMovimientoXCbteBanXDeposito { get; set; } = new List<BaCajaMovimientoXCbteBanXDeposito>();

    [ForeignKey("IdEmpresa, IdTipoFlujo")]
    [InverseProperty("CajCajaMovimiento")]
    public virtual BaTipoFlujo? BaTipoFlujo { get; set; }

    [ForeignKey("IdEmpresa, IdCaja")]
    [InverseProperty("CajCajaMovimiento")]
    public virtual CajCaja CajCaja { get; set; } = null!;

    [InverseProperty("CajCajaMovimiento")]
    public virtual ICollection<CajCajaMovimientoDet> CajCajaMovimientoDet { get; set; } = new List<CajCajaMovimientoDet>();

    [InverseProperty("CajCajaMovimiento")]
    public virtual ICollection<CpConciliacionCaja> CpConciliacionCaja { get; set; } = new List<CpConciliacionCaja>();

    [InverseProperty("CajCajaMovimiento")]
    public virtual ICollection<CpConciliacionCajaDetIngCaja> CpConciliacionCajaDetIngCaja { get; set; } = new List<CpConciliacionCajaDetIngCaja>();

    [InverseProperty("CajCajaMovimiento")]
    public virtual ICollection<CpConciliacionCajaDetXValeCaja> CpConciliacionCajaDetXValeCaja { get; set; } = new List<CpConciliacionCajaDetXValeCaja>();

    [ForeignKey("IdEmpresa, IdTipocbte, IdCbteCble")]
    [InverseProperty("CajCajaMovimientoCtCbtecble")]
    public virtual CtCbtecble CtCbtecble { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipocbteAnu, IdCbteCbleAnu")]
    [InverseProperty("CajCajaMovimientoCtCbtecbleNavigation")]
    public virtual CtCbtecble? CtCbtecbleNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdPeriodo")]
    [InverseProperty("CajCajaMovimiento")]
    public virtual CtPeriodo CtPeriodo { get; set; } = null!;

    [InverseProperty("CajCajaMovimiento")]
    public virtual ICollection<CxcCobroXCajCajaMovimiento> CxcCobroXCajCajaMovimiento { get; set; } = new List<CxcCobroXCajCajaMovimiento>();

    [ForeignKey("IdPersona")]
    [InverseProperty("CajCajaMovimiento")]
    public virtual TbPersona? IdPersonaNavigation { get; set; }

    [ForeignKey("IdTipoMovi")]
    [InverseProperty("CajCajaMovimiento")]
    public virtual CajCajaMovimientoTipo IdTipoMoviNavigation { get; set; } = null!;

    [ForeignKey("IdTipoPersona")]
    [InverseProperty("CajCajaMovimiento")]
    public virtual TbPersonaTipo? IdTipoPersonaNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("CajCajaMovimiento")]
    public virtual TbSucursal? TbSucursal { get; set; }
}
