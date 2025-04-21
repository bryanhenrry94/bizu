using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tbSys_Ge_Comparativo_Modulo_vs_Contas")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSysGeComparativoModuloVsContas
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Column("cod_sucu")]
    [StringLength(10)]
    public string? CodSucu { get; set; }

    public int? IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal? IdCbteVta { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    public string? VtTipoDoc { get; set; }

    [Column("vt_serie1")]
    [StringLength(3)]
    public string? VtSerie1 { get; set; }

    [Column("vt_serie2")]
    [StringLength(3)]
    public string? VtSerie2 { get; set; }

    [Column("vt_NumFactura")]
    [StringLength(20)]
    public string? VtNumFactura { get; set; }

    [Precision(18, 0)]
    public decimal? IdCliente { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    public string? PeNombreCompleto { get; set; }

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_Observacion")]
    public string VtObservacion { get; set; } = null!;

    [Column("DeTINYINT(1)o_Vta")]
    public double? DeTinyint1OVta { get; set; }

    [Column("Credito_Vta")]
    public double? CreditoVta { get; set; }

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime? CbFecha { get; set; }

    [Column("cb_Observacion")]
    public string? CbObservacion { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [Column("DeTINYINT(1)o_Conta")]
    public double? DeTinyint1OConta { get; set; }

    [Column("Credito_Conta")]
    public double CreditoConta { get; set; }

    [Column("pc_Cuenta")]
    [StringLength(150)]
    public string? PcCuenta { get; set; }

    [Column("IdEmpresa_ct")]
    public int? IdEmpresaCt { get; set; }

    [Column("IdTipoCbte_ct")]
    public int? IdTipoCbteCt { get; set; }

    [Column("IdCbteCble_ct")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCt { get; set; }

    [Column("secuencia")]
    public int? Secuencia { get; set; }

    [Column("TIPO")]
    [StringLength(10)]
    public string Tipo { get; set; } = null!;

    [Column("referencia")]
    [StringLength(143)]
    public string? Referencia { get; set; }
}
