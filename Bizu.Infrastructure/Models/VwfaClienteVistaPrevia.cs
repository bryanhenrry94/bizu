using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaClienteVistaPrevia
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Codigo { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    public int IdSucursal { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [StringLength(6)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoCredito { get; set; } = null!;

    [Column("cl_Cat_crediticia")]
    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ClCatCrediticia { get; set; } = null!;

    [Column("cl_plazo")]
    public int ClPlazo { get; set; }

    [Column("cl_porcentaje_descuento")]
    public double ClPorcentajeDescuento { get; set; }

    [Column("IdCtaCble_cxc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCxc { get; set; }

    [Column("nom_CtaCble_cxc")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCtaCbleCxc { get; set; }

    [Column("IdCtaCble_Anti")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleAnti { get; set; }

    [Column("nom_CtaCble_Anti")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCtaCbleAnti { get; set; }

    [Column("cl_Garante")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ClGarante { get; set; }

    [Column("cl_Cell_Garante")]
    [StringLength(13)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ClCellGarante { get; set; }

    [Column("cl_Mail_Garante")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ClMailGarante { get; set; }

    [Column("cl_observacion")]
    [StringLength(130)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ClObservacion { get; set; } = null!;

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCiudad { get; set; } = null!;

    [Column("Descripcion_Ciudad")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DescripcionCiudad { get; set; }

    [Column("cl_Cupo")]
    public double ClCupo { get; set; }

    [Column("cl_casilla")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ClCasilla { get; set; } = null!;

    [Column("cl_fax")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ClFax { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("Mail_Principal")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string MailPrincipal { get; set; } = null!;

    [Column("Mail_Secundario1")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MailSecundario1 { get; set; }

    [Column("Mail_Secundario2")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MailSecundario2 { get; set; }

    [Column("IdCentroCosto_CXC")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoCxc { get; set; }

    [Column("nom_CentroCosto_CXC")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCostoCxc { get; set; }

    [Column("IdCentroCosto_Anticipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoAnticipo { get; set; }

    [Column("nom_CentroCosto_Anticipo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCostoAnticipo { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_razonSocial")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeRazonSocial { get; set; }

    [Column("pe_apellido")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeApellido { get; set; } = null!;

    [Column("pe_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombre { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("pe_direccion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeDireccion { get; set; } = null!;

    [Column("pe_celular")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCelular { get; set; }

    [Column("pe_correo")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCorreo { get; set; }

    [Column("pe_fax")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeFax { get; set; }

    [Column("pe_casilla")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeCasilla { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdProvincia { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdPais { get; set; }

    [Column("IdCtaCble_cxc_Credito")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCxcCredito { get; set; }

    [Column("es_empresa_relacionada")]
    public bool? EsEmpresaRelacionada { get; set; }
}
