using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tmp_XROL_Rpt024")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TmpXrolRpt024
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdPrestamo { get; set; }

    [Precision(18, 0)]
    public decimal IdEmpleado { get; set; }

    [StringLength(50)]
    public string CedulaRuc { get; set; } = null!;

    [StringLength(200)]
    public string NombreCompleto { get; set; } = null!;

    public int IdDepartamento { get; set; }

    [StringLength(150)]
    public string NomDepartamento { get; set; } = null!;

    [Column("IdNomina_Tipo")]
    public int IdNominaTipo { get; set; }

    [StringLength(50)]
    public string NominaDescripcion { get; set; } = null!;

    [StringLength(1)]
    public string EstadoPrestamo { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public double MontoSol { get; set; }

    public double TasaInteres { get; set; }

    public double TotalPrestamo { get; set; }

    public int NumCuotas { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;

    public int NumCuota { get; set; }

    public double SaldoInicial { get; set; }

    public double Interes { get; set; }

    public double AbonoCapital { get; set; }

    public double TotalCuota { get; set; }

    public double Saldo { get; set; }

    [MaxLength(6)]
    public DateTime FechaPago { get; set; }

    [StringLength(10)]
    public string EstadoPago { get; set; } = null!;

    public double Canceladas { get; set; }

    public double Pendientes { get; set; }

    [StringLength(250)]
    public string ObservacionCuota { get; set; } = null!;

    [StringLength(50)]
    public string RubroDescripcion { get; set; } = null!;

    [StringLength(50)]
    public string CodigoEmpleado { get; set; } = null!;

    [Column("pe_apellido")]
    [StringLength(100)]
    public string PeApellido { get; set; } = null!;

    [Column("pe_nombre")]
    [StringLength(100)]
    public string PeNombre { get; set; } = null!;

    [Column("IdMotivo_Prestamo")]
    [StringLength(10)]
    public string IdMotivoPrestamo { get; set; } = null!;

    [StringLength(250)]
    public string MotivoPrestamo { get; set; } = null!;

    [StringLength(5)]
    public string IdUsuario { get; set; } = null!;
}
