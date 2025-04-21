using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaClientesContactos
{
    [Column("IdEmpresa_cli")]
    public int IdEmpresaCli { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdContacto { get; set; }

    [StringLength(51)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodContacto { get; set; } = null!;

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Cargo { get; set; } = null!;

    [Column("Mostrar_como")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string MostrarComo { get; set; } = null!;

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Notas { get; set; } = null!;

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Organizacion { get; set; } = null!;

    [Column("Pagina_Web")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PaginaWeb { get; set; } = null!;

    [Column("Codigo_postal")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodigoPostal { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("pe_apellido")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeApellido { get; set; } = null!;

    [Column("pe_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombre { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoDocumento { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("pe_direccion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeDireccion { get; set; } = null!;

    [Column("pe_telefonoCasa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeTelefonoCasa { get; set; }

    [Column("pe_celular")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCelular { get; set; }

    [Column("pe_correo")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCorreo { get; set; }

    [Column("pe_sexo")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeSexo { get; set; } = null!;

    [Column("pe_fechaNacimiento")]
    [MaxLength(6)]
    public DateTime? PeFechaNacimiento { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Column("Fecha_alta")]
    [MaxLength(6)]
    public DateTime FechaAlta { get; set; }

    [Column("Fecha_Ult_Contacto")]
    [MaxLength(6)]
    public DateTime FechaUltContacto { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdPais { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Nombre { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdProvincia { get; set; }

    [Column("Descripcion_Prov")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DescripcionProv { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCiudad { get; set; }

    [Column("Descripcion_Ciudad")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DescripcionCiudad { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdNacionalidad { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Nacionalidad { get; set; }

    [Column("pe_razonSocial")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeRazonSocial { get; set; }

    [Column("pe_Naturaleza")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNaturaleza { get; set; } = null!;
}
