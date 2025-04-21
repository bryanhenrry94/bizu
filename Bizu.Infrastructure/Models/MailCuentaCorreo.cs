using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCuenta")]
[Table("mail_Cuenta_Correo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class MailCuentaCorreo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(50)]
    public string IdCuenta { get; set; } = null!;

    [StringLength(250)]
    public string Nombre { get; set; } = null!;

    [Column("Direccion_Correo")]
    [StringLength(150)]
    public string DireccionCorreo { get; set; } = null!;

    [Column("Enviar_copia_correo_oculta")]
    public bool EnviarCopiaCorreoOculta { get; set; }

    [Column("Cuenta_Correo_Copia")]
    [StringLength(150)]
    public string? CuentaCorreoCopia { get; set; }

    [Column("Servidor_Correo")]
    [StringLength(150)]
    public string ServidorCorreo { get; set; } = null!;

    [Column("Tipo_Conexion")]
    [StringLength(25)]
    public string TipoConexion { get; set; } = null!;

    public int Puerto { get; set; }

    [StringLength(150)]
    public string? Usuario { get; set; }

    [StringLength(50)]
    public string? Contrasena { get; set; }

    [Column("Cuenta_Predeterminada")]
    public bool CuentaPredeterminada { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;
}
