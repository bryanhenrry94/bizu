using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoOp")]
[Table("cp_orden_pago_tipo_x_empresa")]
[Index("IdTipoOp", Name = "FK_cp_orden_pago_tipo_x_empresa_cp_orden_pago_tipo")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_cp_orden_pago_tipo_x_empresa_ct_centro_costo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_cp_orden_pago_tipo_x_empresa_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenPagoTipoXEmpresa
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdTipo_op")]
    [StringLength(20)]
    public string IdTipoOp { get; set; } = null!;

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdTipoCbte_OP")]
    public int? IdTipoCbteOp { get; set; }

    [Column("IdTipoCbte_OP_anulacion")]
    public int? IdTipoCbteOpAnulacion { get; set; }

    [StringLength(10)]
    public string? IdEstadoAprobacion { get; set; }

    [Column("Buscar_FactxPagar")]
    [StringLength(1)]
    public string? BuscarFactxPagar { get; set; }

    [Column("IdCtaCble_Credito")]
    [StringLength(20)]
    public string? IdCtaCbleCredito { get; set; }

    [Column("Dispara_Alerta")]
    public bool? DisparaAlerta { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CpOrdenPagoTipoXEmpresa")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CpOrdenPagoTipoXEmpresa")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdTipoOp")]
    [InverseProperty("CpOrdenPagoTipoXEmpresa")]
    public virtual CpOrdenPagoTipo IdTipoOpNavigation { get; set; } = null!;
}
