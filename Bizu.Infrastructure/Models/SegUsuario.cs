using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("seg_usuario")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegUsuario
{
    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    public string? Contrasena { get; set; }

    [Column("estado")]
    [StringLength(1)]
    public string? Estado { get; set; }

    [Column("Fecha_Transaccion")]
    [MaxLength(6)]
    public DateTime? FechaTransaccion { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltModi { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(100)]
    public string? MotivoAnulacion { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }

    public bool? ExigirDirectivaContrasenia { get; set; }

    public bool? CambiarContraseniaSgtSesion { get; set; }

    public int? IdDepartamento { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<SegMenuXEmpresaXUsuario> SegMenuXEmpresaXUsuario { get; set; } = new List<SegMenuXEmpresaXUsuario>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<SegUsuarioXEmpresa> SegUsuarioXEmpresa { get; set; } = new List<SegUsuarioXEmpresa>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<SegUsuarioXTbSisReporte> SegUsuarioXTbSisReporte { get; set; } = new List<SegUsuarioXTbSisReporte>();
}
