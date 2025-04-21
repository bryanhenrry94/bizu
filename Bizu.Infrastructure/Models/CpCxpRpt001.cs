using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProveedor", "IdUsuario")]
[Table("cp_CXP_Rpt001")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpCxpRpt001
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("nom_proveedor")]
    [StringLength(200)]
    public string NomProveedor { get; set; } = null!;

    [Column("Saldo_inicial")]
    public double SaldoInicial { get; set; }

    [Column("DeTINYINT(1)os")]
    public double DeTinyint1Os { get; set; }

    public double Creditos { get; set; }

    public double Saldo { get; set; }

    [Column("descripcion_clas_prove")]
    [StringLength(200)]
    public string DescripcionClasProve { get; set; } = null!;

    public int IdClaseProveedor { get; set; }
}
