using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdOrdenPago")]
[Table("cp_orden_pago")]
[Index("IdEmpresa", "IdBanco", Name = "FK_cp_orden_pago_ba_Banco_Cuenta")]
[Index("IdFormaPago", Name = "FK_cp_orden_pago_cp_orden_pago_formapago")]
[Index("IdTipoOp", Name = "FK_cp_orden_pago_cp_orden_pago_tipo")]
[Index("IdPersona", Name = "FK_cp_orden_pago_tb_persona")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenPago
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenPago { get; set; }

    public string Observacion { get; set; } = null!;

    [Column("IdTipo_op")]
    [StringLength(20)]
    public string IdTipoOp { get; set; } = null!;

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    public string? IdTipoPersona { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Precision(18, 0)]
    public decimal? IdEntidad { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [StringLength(10)]
    public string IdEstadoAprobacion { get; set; } = null!;

    [StringLength(20)]
    public string IdFormaPago { get; set; } = null!;

    [Column("Fecha_Pago")]
    public DateOnly FechaPago { get; set; }

    public int? IdBanco { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(150)]
    public string? MotivoAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [ForeignKey("IdEmpresa, IdBanco")]
    [InverseProperty("CpOrdenPago")]
    public virtual BaBancoCuenta? BaBancoCuenta { get; set; }

    [InverseProperty("CpOrdenPago")]
    public virtual ICollection<CajCajaMovimientoDet> CajCajaMovimientoDet { get; set; } = new List<CajCajaMovimientoDet>();

    [InverseProperty("CpOrdenPago")]
    public virtual ICollection<CpConciliacionCaja> CpConciliacionCaja { get; set; } = new List<CpConciliacionCaja>();

    [InverseProperty("CpOrdenPago")]
    public virtual ICollection<CpOrdenPagoDet> CpOrdenPagoDet { get; set; } = new List<CpOrdenPagoDet>();

    [InverseProperty("CpOrdenPago")]
    public virtual ICollection<CpOrdenPagoXEmpleadoXNominaXPeriodo> CpOrdenPagoXEmpleadoXNominaXPeriodo { get; set; } = new List<CpOrdenPagoXEmpleadoXNominaXPeriodo>();

    [ForeignKey("IdFormaPago")]
    [InverseProperty("CpOrdenPago")]
    public virtual CpOrdenPagoFormapago IdFormaPagoNavigation { get; set; } = null!;

    [ForeignKey("IdPersona")]
    [InverseProperty("CpOrdenPago")]
    public virtual TbPersona IdPersonaNavigation { get; set; } = null!;

    [ForeignKey("IdTipoOp")]
    [InverseProperty("CpOrdenPago")]
    public virtual CpOrdenPagoTipo IdTipoOpNavigation { get; set; } = null!;
}
