using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdEmpleado", "IdNominaTipo", "IdNominaTipoLiqui", "IdPeriodo", "NomPc", "IdUsuario")]
[Table("tbROL_NominaGeneral")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbRolNominaGeneral
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdEmpleado { get; set; }

    [Key]
    [Column("IdNomina_Tipo")]
    public int IdNominaTipo { get; set; }

    [Key]
    [Column("IdNomina_TipoLiqui")]
    public int IdNominaTipoLiqui { get; set; }

    [Key]
    public int IdPeriodo { get; set; }

    [Key]
    [Column("nom_pc")]
    [StringLength(50)]
    public string NomPc { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [StringLength(200)]
    public string NomEmpleado { get; set; } = null!;

    public int IdDivision { get; set; }

    [StringLength(100)]
    public string NomDivision { get; set; } = null!;

    public int IdDepartamento { get; set; }

    [StringLength(100)]
    public string NomDepartamento { get; set; } = null!;

    [StringLength(10)]
    public string? IdRubroIng1 { get; set; }

    [Column("NRubroIng1")]
    [StringLength(10)]
    public string? NrubroIng1 { get; set; }

    public double? ValorIng1 { get; set; }

    [StringLength(10)]
    public string? IdRubroIng2 { get; set; }

    [Column("NRubroIng2")]
    [StringLength(10)]
    public string? NrubroIng2 { get; set; }

    public double? ValorIng2 { get; set; }

    [StringLength(10)]
    public string? IdRubroIng3 { get; set; }

    [Column("NRubroIng3")]
    [StringLength(10)]
    public string? NrubroIng3 { get; set; }

    public double? ValorIng3 { get; set; }

    [StringLength(10)]
    public string? IdRubroIng4 { get; set; }

    [Column("NRubroIng4")]
    [StringLength(10)]
    public string? NrubroIng4 { get; set; }

    public double? ValorIng4 { get; set; }

    [StringLength(10)]
    public string? IdRubroIng5 { get; set; }

    [Column("NRubroIng5")]
    [StringLength(10)]
    public string? NrubroIng5 { get; set; }

    public double? ValorIng5 { get; set; }

    [StringLength(10)]
    public string? IdRubroIng6 { get; set; }

    [Column("NRubroIng6")]
    [StringLength(10)]
    public string? NrubroIng6 { get; set; }

    public double? ValorIng6 { get; set; }

    [StringLength(10)]
    public string? IdRubroIng7 { get; set; }

    [Column("NRubroIng7")]
    [StringLength(10)]
    public string? NrubroIng7 { get; set; }

    public double? ValorIng7 { get; set; }

    [StringLength(10)]
    public string? IdRubroIng8 { get; set; }

    [Column("NRubroIng8")]
    [StringLength(10)]
    public string? NrubroIng8 { get; set; }

    public double? ValorIng8 { get; set; }

    [StringLength(10)]
    public string? IdRubroIng9 { get; set; }

    [Column("NRubroIng9")]
    [StringLength(10)]
    public string? NrubroIng9 { get; set; }

    public double? ValorIng9 { get; set; }

    [StringLength(10)]
    public string? IdRubroIng10 { get; set; }

    [Column("NRubroIng10")]
    [StringLength(10)]
    public string? NrubroIng10 { get; set; }

    public double? ValorIng10 { get; set; }

    public double? TotalIng { get; set; }

    [StringLength(10)]
    public string? IdRubroEgr1 { get; set; }

    [Column("NRubroEgr1")]
    [StringLength(10)]
    public string? NrubroEgr1 { get; set; }

    public double? ValorEgr1 { get; set; }

    [StringLength(10)]
    public string? IdRubroEgr2 { get; set; }

    [Column("NRubroEgr2")]
    [StringLength(10)]
    public string? NrubroEgr2 { get; set; }

    public double? ValorEgr2 { get; set; }

    [StringLength(10)]
    public string? IdRubroEgr3 { get; set; }

    [Column("NRubroEgr3")]
    [StringLength(10)]
    public string? NrubroEgr3 { get; set; }

    public double? ValorEgr3 { get; set; }

    [StringLength(10)]
    public string? IdRubroEgr4 { get; set; }

    [Column("NRubroEgr4")]
    [StringLength(10)]
    public string? NrubroEgr4 { get; set; }

    public double? ValorEgr4 { get; set; }

    [StringLength(10)]
    public string? IdRubroEgr5 { get; set; }

    [Column("NRubroEgr5")]
    [StringLength(10)]
    public string? NrubroEgr5 { get; set; }

    public double? ValorEgr5 { get; set; }

    [StringLength(10)]
    public string? IdRubroEgr6 { get; set; }

    [Column("NRubroEgr6")]
    [StringLength(10)]
    public string? NrubroEgr6 { get; set; }

    public double? ValorEgr6 { get; set; }

    [StringLength(10)]
    public string? IdRubroEgr7 { get; set; }

    [Column("NRubroEgr7")]
    [StringLength(10)]
    public string? NrubroEgr7 { get; set; }

    public double? ValorEgr7 { get; set; }

    [StringLength(10)]
    public string? IdRubroEgr8 { get; set; }

    [Column("NRubroEgr8")]
    [StringLength(10)]
    public string? NrubroEgr8 { get; set; }

    public double? ValorEgr8 { get; set; }

    [StringLength(10)]
    public string? IdRubroEgr9 { get; set; }

    [Column("NRubroEgr9")]
    [StringLength(10)]
    public string? NrubroEgr9 { get; set; }

    public double? ValorEgr9 { get; set; }

    [StringLength(10)]
    public string? IdRubroEgr10 { get; set; }

    [Column("NRubroEgr10")]
    [StringLength(10)]
    public string? NrubroEgr10 { get; set; }

    public double? ValorEgr10 { get; set; }

    public double? TotalEgr { get; set; }

    public double? Total { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }
}
