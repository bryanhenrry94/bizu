using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tbROL_Rpt003")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbRolRpt003
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdPrestamo { get; set; }

    [Column("IdNomina_Tipo")]
    public int IdNominaTipo { get; set; }

    [Column("nomi_descripcion")]
    [StringLength(50)]
    public string? NomiDescripcion { get; set; }

    [Precision(18, 0)]
    public decimal IdEmpleado { get; set; }

    [Column("pe_nombre")]
    [StringLength(100)]
    public string PeNombre { get; set; } = null!;

    [Column("pe_apellido")]
    [StringLength(100)]
    public string PeApellido { get; set; } = null!;

    [StringLength(10)]
    public string IdRubro { get; set; } = null!;

    [Column("ru_descripcion")]
    [StringLength(50)]
    public string? RuDescripcion { get; set; }

    [Column("IdEmpleado_Aprueba")]
    [Precision(18, 0)]
    public decimal IdEmpleadoAprueba { get; set; }

    [Column("pe_nombre_apru")]
    [StringLength(100)]
    public string PeNombreApru { get; set; } = null!;

    [Column("pe_apellido_apru")]
    [StringLength(100)]
    public string PeApellidoApru { get; set; } = null!;

    [Column("codigo")]
    [StringLength(10)]
    public string Codigo { get; set; } = null!;

    [Column("ca_descripcion")]
    [StringLength(250)]
    public string? CaDescripcion { get; set; }

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public double? MontoSol { get; set; }

    public double? TasaInteres { get; set; }

    public int NumCuotas { get; set; }

    [Column("cod_pago")]
    [StringLength(10)]
    public string CodPago { get; set; } = null!;

    [Column("peri_pago")]
    [StringLength(250)]
    public string? PeriPago { get; set; }

    [Column("Fecha_PriPago")]
    [MaxLength(6)]
    public DateTime FechaPriPago { get; set; }

    [StringLength(250)]
    public string? Observacion { get; set; }

    public double? TotalPrestado { get; set; }

    public double? TotalCobrado { get; set; }

    public double? SaldoPrestado { get; set; }

    public int NumCuotaDet { get; set; }

    public double? SaldoInicial { get; set; }

    public double? Interes { get; set; }

    public double? AbonoCapital { get; set; }

    public double? TotalCuota { get; set; }

    public double? Saldo { get; set; }

    [MaxLength(6)]
    public DateTime FechaPago { get; set; }

    [StringLength(10)]
    public string EstadoPago { get; set; } = null!;

    [Column("Observacion_det")]
    [StringLength(250)]
    public string? ObservacionDet { get; set; }

    [Column("Estado_Det")]
    [StringLength(1)]
    public string EstadoDet { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [Column("nom_pc")]
    [StringLength(50)]
    public string NomPc { get; set; } = null!;
}
