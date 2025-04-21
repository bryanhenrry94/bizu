using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdInversion")]
[Table("ba_Inversion")]
[Index("IdEmpresa", "IdBanco", Name = "FK_ba_Inversion_ba_Banco_Cuenta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaInversion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdInversion { get; set; }

    [Column("Cod_Inversion")]
    [StringLength(50)]
    public string CodInversion { get; set; } = null!;

    public int IdBanco { get; set; }

    public DateOnly Fecha { get; set; }

    public int Plazo { get; set; }

    [Column("Fecha_Vct")]
    public DateOnly FechaVct { get; set; }

    public double Monto { get; set; }

    public double Tasa { get; set; }

    [Column("Por_Retencion")]
    public double PorRetencion { get; set; }

    [Column("Valor_retencion")]
    public double ValorRetencion { get; set; }

    public double Otros { get; set; }

    [Column("Tasa_interes")]
    public double TasaInteres { get; set; }

    [Column("Valor_interes")]
    public double ValorInteres { get; set; }

    public double Capital { get; set; }

    [Column("Total_recibir")]
    public double TotalRecibir { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [ForeignKey("IdEmpresa, IdBanco")]
    [InverseProperty("BaInversion")]
    public virtual BaBancoCuenta BaBancoCuenta { get; set; } = null!;
}
