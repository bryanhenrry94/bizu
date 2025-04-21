using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_banco")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbBanco
{
    [Key]
    public int IdBanco { get; set; }

    [Column("ba_descripcion")]
    [StringLength(100)]
    public string BaDescripcion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(10)]
    public string CodigoLegal { get; set; } = null!;

    public bool TieneFormatoTransferencia { get; set; }

    [InverseProperty("IdBancoFinancieroNavigation")]
    public virtual ICollection<BaBancoCuenta> BaBancoCuenta { get; set; } = new List<BaBancoCuenta>();

    [InverseProperty("IdBancoAcreditacionNavigation")]
    public virtual ICollection<CpProveedor> CpProveedor { get; set; } = new List<CpProveedor>();

    [InverseProperty("IdBancoNavigation")]
    public virtual ICollection<CxcCobro> CxcCobro { get; set; } = new List<CxcCobro>();

    [InverseProperty("IdBancoNavigation")]
    public virtual ICollection<TbBancoEstadoRegRespBancaria> TbBancoEstadoRegRespBancaria { get; set; } = new List<TbBancoEstadoRegRespBancaria>();

    [InverseProperty("IdBancoAcreditacionNavigation")]
    public virtual ICollection<TbPersona> TbPersona { get; set; } = new List<TbPersona>();
}
