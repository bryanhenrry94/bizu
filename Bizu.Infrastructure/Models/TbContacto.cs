using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdContacto")]
[Table("tb_contacto")]
[Index("IdCiudad", Name = "FK_tb_contacto_tb_ciudad")]
[Index("IdNacionalidad", Name = "FK_tb_contacto_tb_pais")]
[Index("IdPais", Name = "FK_tb_contacto_tb_pais1")]
[Index("IdPersona", Name = "FK_tb_contacto_tb_persona")]
[Index("IdProvincia", Name = "FK_tb_contacto_tb_provincia")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbContacto
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdContacto { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [StringLength(51)]
    public string CodContacto { get; set; } = null!;

    [StringLength(150)]
    public string Organizacion { get; set; } = null!;

    [StringLength(150)]
    public string Cargo { get; set; } = null!;

    [Column("Mostrar_como")]
    [StringLength(250)]
    public string MostrarComo { get; set; } = null!;

    [Column("Fecha_alta")]
    [MaxLength(6)]
    public DateTime FechaAlta { get; set; }

    [Column("Fecha_Ult_Contacto")]
    [MaxLength(6)]
    public DateTime FechaUltContacto { get; set; }

    [StringLength(25)]
    public string IdCiudad { get; set; } = null!;

    [StringLength(10)]
    public string IdNacionalidad { get; set; } = null!;

    public string Notas { get; set; } = null!;

    [Column("Pagina_Web")]
    [StringLength(150)]
    public string PaginaWeb { get; set; } = null!;

    [Column("Codigo_postal")]
    [StringLength(50)]
    public string CodigoPostal { get; set; } = null!;

    [Column("foto")]
    public byte[]? Foto { get; set; }

    [StringLength(50)]
    public string? UsuarioCreacion { get; set; }

    [StringLength(50)]
    public string? UsuarioModificacion { get; set; }

    [StringLength(50)]
    public string? UsuarioAnulacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaCreacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaModificacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [StringLength(150)]
    public string? MotivoAnulacion { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(10)]
    public string? IdPais { get; set; }

    [StringLength(25)]
    public string? IdProvincia { get; set; }

    [InverseProperty("TbContacto")]
    public virtual ICollection<CpProveedorContactos> CpProveedorContactos { get; set; } = new List<CpProveedorContactos>();

    [InverseProperty("TbContacto")]
    public virtual ICollection<FaClienteContactos> FaClienteContactos { get; set; } = new List<FaClienteContactos>();

    [ForeignKey("IdCiudad")]
    [InverseProperty("TbContacto")]
    public virtual TbCiudad IdCiudadNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TbContacto")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdNacionalidad")]
    [InverseProperty("TbContactoIdNacionalidadNavigation")]
    public virtual TbPais IdNacionalidadNavigation { get; set; } = null!;

    [ForeignKey("IdPais")]
    [InverseProperty("TbContactoIdPaisNavigation")]
    public virtual TbPais? IdPaisNavigation { get; set; }

    [ForeignKey("IdPersona")]
    [InverseProperty("TbContacto")]
    public virtual TbPersona IdPersonaNavigation { get; set; } = null!;

    [ForeignKey("IdProvincia")]
    [InverseProperty("TbContacto")]
    public virtual TbProvincia? IdProvinciaNavigation { get; set; }
}
