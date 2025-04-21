using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxcRpt013
{
    public int IdEmpresa { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdCobro { get; set; }

    [Column("Fecha_cobro")]
    [MaxLength(6)]
    public DateTime FechaCobro { get; set; }

    [Column("Fecha_Retencion")]
    [MaxLength(6)]
    public DateTime FechaRetencion { get; set; }

    [Column("Num_Retencion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCobroTipo { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("nom_cliente")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCliente { get; set; } = null!;

    [Column("ruc_ced")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string RucCed { get; set; } = null!;

    public double? PorcentajeRet { get; set; }

    [Column("Base_RIva")]
    public double? BaseRiva { get; set; }

    [Column("Base_RFte")]
    public double? BaseRfte { get; set; }

    [Column("Valor_Ret")]
    public double? ValorRet { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("num_factura")]
    [StringLength(24)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumFactura { get; set; }

    [Column("Fecha_Fact")]
    [MaxLength(6)]
    public DateTime FechaFact { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtTipoDoc { get; set; }

    [Column("Tipo_Retencion")]
    [StringLength(7)]
    public string TipoRetencion { get; set; } = null!;

    [Column("nomTipo_Retencion")]
    [StringLength(26)]
    public string NomTipoRetencion { get; set; } = null!;

    [Column("nomTipoCobro")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoCobro { get; set; } = null!;
}
