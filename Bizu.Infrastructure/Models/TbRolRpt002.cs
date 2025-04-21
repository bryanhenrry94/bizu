using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdEmpleado", "IdPeriodo", "IdRubro", "IdNominaTipo", "IdNominaTipoLiqui", "IdNovedad", "SecuenciaNovedad", "IdPrestamo", "NunCouta", "IdUsuario", "NomPc", "Secuencia")]
[Table("tbROL_Rpt002")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbRolRpt002
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdEmpleado { get; set; }

    [Key]
    public int IdPeriodo { get; set; }

    [Key]
    [StringLength(20)]
    public string IdRubro { get; set; } = null!;

    [Key]
    [Column("IdNomina_Tipo")]
    public int IdNominaTipo { get; set; }

    [Key]
    [Column("IdNomina_TipoLiqui")]
    public int IdNominaTipoLiqui { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNovedad { get; set; }

    [Key]
    public int SecuenciaNovedad { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPrestamo { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal NunCouta { get; set; }

    public int? IdDepartamento { get; set; }

    public double Valor { get; set; }

    [Key]
    [StringLength(30)]
    public string IdUsuario { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    public string PeNombreCompleto { get; set; } = null!;

    [StringLength(60)]
    public string? Departamento { get; set; }

    [Column("pe_FechaFin", TypeName = "datetime")]
    public DateTime PeFechaFin { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    public string EmNombre { get; set; } = null!;

    [Key]
    [Column("nom_pc")]
    [StringLength(50)]
    public string NomPc { get; set; } = null!;

    [Column("ru_descripcion")]
    [StringLength(50)]
    public string RuDescripcion { get; set; } = null!;

    [Column("ru_tipo")]
    [StringLength(1)]
    public string RuTipo { get; set; } = null!;

    [Column("dias_trabajo")]
    public int? DiasTrabajo { get; set; }

    [Column("dias_vacaciones")]
    public int? DiasVacaciones { get; set; }

    [Column("dias_maternidad")]
    public int? DiasMaternidad { get; set; }

    [Column("totIng")]
    public double? TotIng { get; set; }

    [Column("totEgr")]
    public double? TotEgr { get; set; }

    [Column("totalNeto")]
    public double? TotalNeto { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [StringLength(20)]
    public string? OrgCopy { get; set; }
}
