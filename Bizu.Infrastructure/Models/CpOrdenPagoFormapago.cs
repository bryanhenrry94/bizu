using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_orden_pago_formapago")]
[Index("IdTipoMoviCaj", Name = "FK_cp_orden_pago_formapago_caj_Caja_Movimiento_Tipo")]
[Index("IdTipoTransaccion", Name = "FK_cp_orden_pago_formapago_cp_trans_a_generar_x_FormaPago_OP")]
[Index("CodModulo", Name = "FK_cp_orden_pago_formapago_tb_modulo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenPagoFormapago
{
    [Key]
    [StringLength(20)]
    public string IdFormaPago { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [StringLength(20)]
    public string? IdTipoTransaccion { get; set; }

    [StringLength(20)]
    public string? CodModulo { get; set; }

    [Column("IdTipoMovi_caj")]
    public int? IdTipoMoviCaj { get; set; }

    [ForeignKey("CodModulo")]
    [InverseProperty("CpOrdenPagoFormapago")]
    public virtual TbModulo? CodModuloNavigation { get; set; }

    [InverseProperty("IdFormaPagoNavigation")]
    public virtual ICollection<CpOrdenPago> CpOrdenPago { get; set; } = new List<CpOrdenPago>();

    [InverseProperty("IdFormaPagoNavigation")]
    public virtual ICollection<CpOrdenPagoDet> CpOrdenPagoDet { get; set; } = new List<CpOrdenPagoDet>();

    [ForeignKey("IdTipoMoviCaj")]
    [InverseProperty("CpOrdenPagoFormapago")]
    public virtual CajCajaMovimientoTipo? IdTipoMoviCajNavigation { get; set; }

    [ForeignKey("IdTipoTransaccion")]
    [InverseProperty("CpOrdenPagoFormapago")]
    public virtual CpTransAGenerarXFormaPagoOp? IdTipoTransaccionNavigation { get; set; }
}
