using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpProveedorVistaPrevia
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Column("pr_codigo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [Column("pr_girar_cheque_a")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrGirarChequeA { get; set; }

    [Column("pr_contribuyenteEspecial")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrContribuyenteEspecial { get; set; }

    [Column("pr_plazo")]
    public int? PrPlazo { get; set; }

    [Column("representante_legal")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? RepresentanteLegal { get; set; }

    [Column("pr_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrEstado { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCiudad { get; set; } = null!;

    [Column("pr_nacionalidad")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNacionalidad { get; set; }

    [Column("contacto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Contacto { get; set; }

    [Column("responsable")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Responsable { get; set; }

    [Column("pe_Naturaleza")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNaturaleza { get; set; } = null!;

    [Column("pe_razonSocial")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeRazonSocial { get; set; }

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

    [Column("IdCtaCble_CXP")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCxp { get; set; }

    [Column("nom_CtaCble_CXP")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCtaCbleCxp { get; set; }

    [Column("IdCtaCble_Gasto")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleGasto { get; set; }

    [Column("nom_CtaCble_Gasto")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCtaCbleGasto { get; set; }

    [Column("IdCtaCble_Anticipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleAnticipo { get; set; }

    [Column("nom_CtaCble_Anticipo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCtaCbleAnticipo { get; set; }

    public int IdClaseProveedor { get; set; }

    [Column("nom_ClaseProveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomClaseProveedor { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoServicio { get; set; } = null!;

    [Column("nom_TipoServicio")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoServicio { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoGasto { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Nombre { get; set; }

    [Column("nom_ubicacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomUbicacion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosot { get; set; }

    [Column("nom_Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCosto { get; set; }

    [Column("pe_celular")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCelular { get; set; }

    [Column("pe_correo")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCorreo { get; set; }

    [Column("comentario")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Comentario { get; set; }

    [Column("codigoSRI_ICE_Predeter")]
    public int? CodigoSriIcePredeter { get; set; }

    [Column("nom_SRI_ICE_Predeter")]
    [StringLength(350)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSriIcePredeter { get; set; }

    [Column("codigoSRI_101_Predeter")]
    public int? CodigoSri101Predeter { get; set; }

    [Column("nom_SRI_101_Predeter")]
    [StringLength(350)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSri101Predeter { get; set; }

    [Column("idCredito_Predeter")]
    public int? IdCreditoPredeter { get; set; }

    [Column("nom_Credito_Predeter")]
    [StringLength(350)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCreditoPredeter { get; set; }

    [Column("pe_fax")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeFax { get; set; }

    [Column("pe_casilla")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCasilla { get; set; }

    [Column("pe_telefonoCasa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeTelefonoCasa { get; set; }

    [Column("pe_telefonoOfic")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeTelefonoOfic { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoCivil { get; set; } = null!;

    [Column("pe_fechaNacimiento")]
    [MaxLength(6)]
    public DateTime? PeFechaNacimiento { get; set; }

    [Column("pe_apellido")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeApellido { get; set; } = null!;

    [Column("pe_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombre { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdPais { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdProvincia { get; set; }

    [Column("es_empresa_relacionada")]
    public bool? EsEmpresaRelacionada { get; set; }
}
