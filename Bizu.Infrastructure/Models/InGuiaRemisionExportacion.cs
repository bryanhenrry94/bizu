using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdGuiaRemision")]
[Table("in_GuiaRemision_Exportacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InGuiaRemisionExportacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    [StringLength(15)]
    public string EmbarqueTipo { get; set; } = null!;

    [StringLength(50)]
    public string Ruta { get; set; } = null!;

    [StringLength(50)]
    public string Contenedor { get; set; } = null!;

    [StringLength(50)]
    public string Sello { get; set; } = null!;

    [StringLength(50)]
    public string Vapor { get; set; } = null!;

    [StringLength(50)]
    public string? Embalaje { get; set; }

    public double PesoNeto { get; set; }

    public double PesoBruto { get; set; }

    [Column("Exportador_nombre")]
    [StringLength(200)]
    public string? ExportadorNombre { get; set; }

    [Column("Exportador_direccion")]
    [StringLength(150)]
    public string? ExportadorDireccion { get; set; }

    [Column("Exportador_correo")]
    [StringLength(100)]
    public string? ExportadorCorreo { get; set; }

    [Column("Exportador_telefono")]
    [StringLength(50)]
    public string? ExportadorTelefono { get; set; }

    [Column("Exportador_fax")]
    [StringLength(50)]
    public string? ExportadorFax { get; set; }

    [Column("Comprador_nombre")]
    [StringLength(200)]
    public string? CompradorNombre { get; set; }

    [Column("Comprador_direccion")]
    [StringLength(150)]
    public string? CompradorDireccion { get; set; }

    [Column("Comprador_correo")]
    [StringLength(100)]
    public string? CompradorCorreo { get; set; }

    [Column("Comprador_telefono")]
    [StringLength(50)]
    public string? CompradorTelefono { get; set; }

    [Column("Comprador_fax")]
    [StringLength(50)]
    public string? CompradorFax { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdGuiaRemision")]
    [InverseProperty("InGuiaRemisionExportacion")]
    public virtual InGuiaRemision InGuiaRemision { get; set; } = null!;
}
