using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_persona")]
[Index("IdTipoDocumento", Name = "FK_tb_persona_tb_Catalogo2")]
[Index("IdEstadoCivil", Name = "FK_tb_persona_tb_Catalogo3")]
[Index("PeSexo", Name = "FK_tb_persona_tb_Catalogo4")]
[Index("PeNaturaleza", Name = "FK_tb_persona_tb_Catalogo5")]
[Index("IdTipoCtaAcreditacionCat", Name = "FK_tb_persona_tb_Catalogo6")]
[Index("IdBancoAcreditacion", Name = "FK_tb_persona_tb_banco")]
[Index("PeCedulaRuc", Name = "IX_tb_persona")]
[Index("IdPersona", Name = "IX_tb_persona_1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbPersona
{
    [Key]
    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [StringLength(20)]
    public string CodPersona { get; set; } = null!;

    [Column("pe_Naturaleza")]
    [StringLength(25)]
    public string PeNaturaleza { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_razonSocial")]
    [StringLength(150)]
    public string? PeRazonSocial { get; set; }

    [Column("pe_apellido")]
    [StringLength(100)]
    public string PeApellido { get; set; } = null!;

    [Column("pe_nombre")]
    [StringLength(100)]
    public string PeNombre { get; set; } = null!;

    public int IdTipoPersona { get; set; }

    [StringLength(25)]
    public string IdTipoDocumento { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("pe_direccion")]
    [StringLength(150)]
    public string PeDireccion { get; set; } = null!;

    [Column("pe_telefonoCasa")]
    [StringLength(50)]
    public string? PeTelefonoCasa { get; set; }

    [Column("pe_telefonoOfic")]
    [StringLength(50)]
    public string? PeTelefonoOfic { get; set; }

    [Column("pe_telefonoInter")]
    [StringLength(50)]
    public string? PeTelefonoInter { get; set; }

    [Column("pe_telfono_Contacto")]
    [StringLength(50)]
    public string? PeTelfonoContacto { get; set; }

    [Column("pe_celular")]
    [StringLength(50)]
    public string? PeCelular { get; set; }

    [Column("pe_correo")]
    [StringLength(100)]
    public string? PeCorreo { get; set; }

    [Column("pe_fax")]
    [StringLength(50)]
    public string? PeFax { get; set; }

    [Column("pe_casilla")]
    [StringLength(50)]
    public string? PeCasilla { get; set; }

    [Column("pe_sexo")]
    [StringLength(25)]
    public string PeSexo { get; set; } = null!;

    [StringLength(25)]
    public string IdEstadoCivil { get; set; } = null!;

    [Column("pe_fechaNacimiento")]
    [MaxLength(6)]
    public DateTime? PeFechaNacimiento { get; set; }

    [Column("pe_estado")]
    [StringLength(1)]
    public string PeEstado { get; set; } = null!;

    [Column("pe_fechaCreacion")]
    [MaxLength(6)]
    public DateTime? PeFechaCreacion { get; set; }

    [Column("pe_fechaModificacion")]
    [MaxLength(6)]
    public DateTime? PeFechaModificacion { get; set; }

    [Column("pe_UltUsuarioModi")]
    [StringLength(50)]
    public string? PeUltUsuarioModi { get; set; }

    [Column("pe_celularSecundario")]
    [StringLength(50)]
    public string? PeCelularSecundario { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(100)]
    public string? MotivoAnulacion { get; set; }

    [Column("pe_correo_secundario1")]
    [StringLength(100)]
    public string? PeCorreoSecundario1 { get; set; }

    [Column("pe_correo_secundario2")]
    [StringLength(100)]
    public string? PeCorreoSecundario2 { get; set; }

    [Column("IdTipoCta_acreditacion_cat")]
    [StringLength(25)]
    public string? IdTipoCtaAcreditacionCat { get; set; }

    [Column("num_cta_acreditacion")]
    [StringLength(50)]
    public string? NumCtaAcreditacion { get; set; }

    [Column("IdBanco_acreditacion")]
    public int? IdBancoAcreditacion { get; set; }

    [Column("IdTipoDocumento_acreditacion")]
    [StringLength(25)]
    public string? IdTipoDocumentoAcreditacion { get; set; }

    [Column("cedulaRuc_acreditacion")]
    [StringLength(50)]
    public string? CedulaRucAcreditacion { get; set; }

    [Column("beneficiario_acreditacion")]
    [StringLength(200)]
    public string? BeneficiarioAcreditacion { get; set; }

    [Column("correo_acreditacion")]
    [StringLength(200)]
    public string? CorreoAcreditacion { get; set; }

    [InverseProperty("IdPersonaGiradoANavigation")]
    public virtual ICollection<BaCbteBan> BaCbteBan { get; set; } = new List<BaCbteBan>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<CajCajaMovimiento> CajCajaMovimiento { get; set; } = new List<CajCajaMovimiento>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<CpOrdenPago> CpOrdenPago { get; set; } = new List<CpOrdenPago>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<CpProveedor> CpProveedor { get; set; } = new List<CpProveedor>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<FaCliente> FaCliente { get; set; } = new List<FaCliente>();

    [ForeignKey("IdBancoAcreditacion")]
    [InverseProperty("TbPersona")]
    public virtual TbBanco? IdBancoAcreditacionNavigation { get; set; }

    [ForeignKey("IdEstadoCivil")]
    [InverseProperty("TbPersonaIdEstadoCivilNavigation")]
    public virtual TbCatalogo IdEstadoCivilNavigation { get; set; } = null!;

    [ForeignKey("IdTipoCtaAcreditacionCat")]
    [InverseProperty("TbPersonaIdTipoCtaAcreditacionCatNavigation")]
    public virtual TbCatalogo? IdTipoCtaAcreditacionCatNavigation { get; set; }

    [ForeignKey("IdTipoDocumento")]
    [InverseProperty("TbPersonaIdTipoDocumentoNavigation")]
    public virtual TbCatalogo IdTipoDocumentoNavigation { get; set; } = null!;

    [ForeignKey("PeNaturaleza")]
    [InverseProperty("TbPersonaPeNaturalezaNavigation")]
    public virtual TbCatalogo PeNaturalezaNavigation { get; set; } = null!;

    [ForeignKey("PeSexo")]
    [InverseProperty("TbPersonaPeSexoNavigation")]
    public virtual TbCatalogo PeSexoNavigation { get; set; } = null!;

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<TbContacto> TbContacto { get; set; } = new List<TbContacto>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<TbPersonaDireccion> TbPersonaDireccion { get; set; } = new List<TbPersonaDireccion>();
}
