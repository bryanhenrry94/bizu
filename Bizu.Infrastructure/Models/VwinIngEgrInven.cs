using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinIngEgrInven
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    public int? IdBodega { get; set; }

    [Column("signo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Signo { get; set; } = null!;

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodMoviInven { get; set; } = null!;

    [Column("cm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacion { get; set; } = null!;

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnulacion { get; set; }

    [Column("IdMotivo_oc")]
    public int? IdMotivoOc { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltModi { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdusuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [Column("nom_bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomBodega { get; set; }

    [Column("cod_tipo_inv")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoInv { get; set; } = null!;

    [Column("nom_tipo_inv")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoInv { get; set; } = null!;

    [Column("signo_tipo_inv")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SignoTipoInv { get; set; } = null!;

    [Column("nom_motivo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomMotivo { get; set; }

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAproba { get; set; }

    [Column("nom_EstadoAproba")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomEstadoAproba { get; set; }

    [Column("Desc_mov_inv")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DescMovInv { get; set; }

    [Column("IdEstadoDespacho_cat")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoDespachoCat { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenCompra { get; set; }

    [Column("Fecha_registro")]
    [MaxLength(6)]
    public DateTime? FechaRegistro { get; set; }

    [Precision(18, 0)]
    public decimal? IdResponsable { get; set; }

    [Column("co_factura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CoFactura { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [Column("IdEstado_cierre")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoCierre { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    [Column("numGuia")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumGuia { get; set; }

    public bool? EsDocumentoAutorizado { get; set; }

    [Column("numDocumento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Column("Num_Requerimiento")]
    [Precision(18, 0)]
    public decimal? NumRequerimiento { get; set; }
}
