using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPeriodo")]
[Table("ct_periodo")]
[Index("IdanioFiscal", Name = "FK_ct_periodo_ct_anio_fiscal")]
[Index("PeMes", Name = "FK_ct_periodo_tb_mes")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtPeriodo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdPeriodo { get; set; }

    public int IdanioFiscal { get; set; }

    [Column("pe_mes")]
    public int PeMes { get; set; }

    [Column("pe_FechaIni", TypeName = "datetime")]
    public DateTime PeFechaIni { get; set; }

    [Column("pe_FechaFin", TypeName = "datetime")]
    public DateTime PeFechaFin { get; set; }

    [Column("pe_cerrado")]
    [StringLength(1)]
    public string PeCerrado { get; set; } = null!;

    [Column("pe_estado")]
    [StringLength(1)]
    public string? PeEstado { get; set; }

    [InverseProperty("CtPeriodo")]
    public virtual ICollection<AfDepreciacion> AfDepreciacion { get; set; } = new List<AfDepreciacion>();

    [InverseProperty("CtPeriodo")]
    public virtual ICollection<BaCbteBan> BaCbteBan { get; set; } = new List<BaCbteBan>();

    [InverseProperty("CtPeriodo")]
    public virtual ICollection<BaConciliacion> BaConciliacion { get; set; } = new List<BaConciliacion>();

    [InverseProperty("CtPeriodo")]
    public virtual ICollection<CajCajaMovimiento> CajCajaMovimiento { get; set; } = new List<CajCajaMovimiento>();

    [InverseProperty("CtPeriodo")]
    public virtual ICollection<CpConciliacionCaja> CpConciliacionCaja { get; set; } = new List<CpConciliacionCaja>();

    [InverseProperty("CtPeriodo")]
    public virtual ICollection<CtCbtecble> CtCbtecble { get; set; } = new List<CtCbtecble>();

    [InverseProperty("CtPeriodo")]
    public virtual ICollection<CtPeriodoXTbModulo> CtPeriodoXTbModulo { get; set; } = new List<CtPeriodoXTbModulo>();

    [InverseProperty("CtPeriodo")]
    public virtual ICollection<CtSaldoxCuentas> CtSaldoxCuentas { get; set; } = new List<CtSaldoxCuentas>();

    [InverseProperty("CtPeriodo")]
    public virtual ICollection<CtSaldoxCuentasMovi> CtSaldoxCuentasMovi { get; set; } = new List<CtSaldoxCuentasMovi>();

    [InverseProperty("CtPeriodo")]
    public virtual ICollection<FaFactura> FaFactura { get; set; } = new List<FaFactura>();

    [InverseProperty("CtPeriodo")]
    public virtual ICollection<FaGuiaRemision> FaGuiaRemision { get; set; } = new List<FaGuiaRemision>();

    [ForeignKey("IdEmpresa")]
    [InverseProperty("CtPeriodo")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdanioFiscal")]
    [InverseProperty("CtPeriodo")]
    public virtual CtAnioFiscal IdanioFiscalNavigation { get; set; } = null!;

    [ForeignKey("PeMes")]
    [InverseProperty("CtPeriodo")]
    public virtual TbMes PeMesNavigation { get; set; } = null!;
}
