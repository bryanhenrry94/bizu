using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwtbEmpresaXUsuario
{
    public int IdEmpresa { get; set; }

    [Column("codigo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Codigo { get; set; } = null!;

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string RazonSocial { get; set; } = null!;

    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreComercial { get; set; } = null!;

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ContribuyenteEspecial { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ObligadoAllevarConta { get; set; } = null!;

    [Column("em_ruc")]
    [StringLength(13)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmRuc { get; set; } = null!;

    [Column("em_gerente")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EmGerente { get; set; }

    [Column("em_contador")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EmContador { get; set; }

    [Column("em_rucContador")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EmRucContador { get; set; }

    [Column("em_telefonos")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EmTelefonos { get; set; }

    [Column("em_notificacion")]
    public int? EmNotificacion { get; set; }

    [Column("em_direccion")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmDireccion { get; set; } = null!;

    [Column("em_tel_int")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EmTelInt { get; set; }

    [Column("em_logo")]
    public byte[]? EmLogo { get; set; }

    [Column("em_fondo")]
    public byte[]? EmFondo { get; set; }

    [Column("em_fechaInicioContable")]
    [MaxLength(6)]
    public DateTime EmFechaInicioContable { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("em_fechaInicioActividad")]
    [MaxLength(6)]
    public DateTime? EmFechaInicioActividad { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    [Column("cod_entidad_dinardap")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodEntidadDinardap { get; set; }

    [Column("em_Email_Contacto")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EmEmailContacto { get; set; }

    [Column("Sitio_Web")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? SitioWeb { get; set; }

    [Column("em_fax")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EmFax { get; set; }

    [Column("em_Email")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EmEmail { get; set; }
}
