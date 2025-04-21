using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_Conexion_DBFacturacion_Electronica")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbConexionDbfacturacionElectronica
{
    [Key]
    public int IdEmpresa { get; set; }

    [Column("Tipo_BaseDatos")]
    [StringLength(50)]
    public string? TipoBaseDatos { get; set; }

    [StringLength(50)]
    public string? Servidor { get; set; }

    public int? Puerto { get; set; }

    public bool? AutenticacionWindows { get; set; }

    [StringLength(50)]
    public string? Usuario { get; set; }

    [StringLength(50)]
    public string? Contrasena { get; set; }

    [Column("Nombre_BaseDatos")]
    [StringLength(50)]
    public string? NombreBaseDatos { get; set; }

    [Column("Cadena_Conexion")]
    [StringLength(150)]
    public string? CadenaConexion { get; set; }

    [Column("Script_ComprobantesRecibidos")]
    public string? ScriptComprobantesRecibidos { get; set; }
}
