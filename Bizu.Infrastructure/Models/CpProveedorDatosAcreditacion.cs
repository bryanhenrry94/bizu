using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProveedor", "Secuencia")]
[Table("cp_proveedor_datos_acreditacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpProveedorDatosAcreditacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Key]
    public int Secuencia { get; set; }

    public int? IdBanco { get; set; }

    [StringLength(25)]
    public string? IdTipoCuenta { get; set; }

    [StringLength(50)]
    public string? NumeroCuenta { get; set; }

    [StringLength(25)]
    public string? IdTipoIdentificacion { get; set; }

    [StringLength(50)]
    public string? Identificacion { get; set; }

    [StringLength(200)]
    public string? Beneficiario { get; set; }

    [StringLength(200)]
    public string? Correo { get; set; }

    public bool? Predefinida { get; set; }
}
