using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomOrdencompraLocalDetGe
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("do_Cantidad")]
    public double DoCantidad { get; set; }

    [Column("do_precioCompra")]
    public double DoPrecioCompra { get; set; }

    [Column("do_porc_des")]
    public double DoPorcDes { get; set; }

    [Column("do_descuento")]
    public double DoDescuento { get; set; }

    [Column("do_precioFinal")]
    public double DoPrecioFinal { get; set; }

    [Column("do_subtotal")]
    public double DoSubtotal { get; set; }

    [Column("do_iva")]
    public double DoIva { get; set; }

    [Column("do_total")]
    public double DoTotal { get; set; }

    [Column("do_ManejaIva")]
    public bool DoManejaIva { get; set; }

    [Column("do_Costeado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DoCosteado { get; set; } = null!;

    [Column("do_peso")]
    public double DoPeso { get; set; }

    [Column("do_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DoObservacion { get; set; } = null!;

    [Column("Tiene_Movi_Inven")]
    [StringLength(1)]
    public string TieneMoviInven { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("nom_sub_centro_costo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSubCentroCosto { get; set; }

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime OcFecha { get; set; }

    [Column("oc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcObservacion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    public int? IdMotivo { get; set; }

    [Column("nom_motivo_OC")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomMotivoOc { get; set; }

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("nom_medida")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomMedida { get; set; }

    [Column("IdUnidadMedida_Consumo")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedidaConsumo { get; set; } = null!;

    [Column("Por_Iva")]
    public double PorIva { get; set; }

    [Column("IdCod_Impuesto")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCodImpuesto { get; set; } = null!;

    [Precision(10, 0)]
    public decimal? IdSolicitud { get; set; }

    [Column("ID_Departamento")]
    [Precision(18, 0)]
    public decimal? IdDepartamento { get; set; }

    [Column("Nom_Departamento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomDepartamento { get; set; }

    [Column("ID_Solicitante")]
    [Precision(18, 0)]
    public decimal? IdSolicitante { get; set; }

    [Column("Nom_Solicitante")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSolicitante { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }
}
