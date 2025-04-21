using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpNotaDebCre
{
    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Nota")]
    [Precision(18, 0)]
    public decimal IdCbteCbleNota { get; set; }

    [Column("IdTipoCbte_Nota")]
    public int IdTipoCbteNota { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DebCre { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    public int IdSucursal { get; set; }

    [Column("cn_fecha")]
    public DateOnly CnFecha { get; set; }

    [Column("cn_serie1")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnSerie1 { get; set; }

    [Column("cn_serie2")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnSerie2 { get; set; }

    [Column("cn_Nota")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnNota { get; set; }

    [Column("Fecha_contable")]
    public DateOnly? FechaContable { get; set; }

    [Column("cn_observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CnObservacion { get; set; } = null!;

    [Column("cn_subtotal_iva")]
    public double CnSubtotalIva { get; set; }

    [Column("cn_subtotal_siniva")]
    public double CnSubtotalSiniva { get; set; }

    [Column("cn_baseImponible")]
    public double CnBaseImponible { get; set; }

    [Column("cn_Por_iva")]
    public double CnPorIva { get; set; }

    [Column("cn_valoriva")]
    public double CnValoriva { get; set; }

    [Column("IdCod_ICE")]
    public int? IdCodIce { get; set; }

    [Column("cn_Ice_base")]
    public double CnIceBase { get; set; }

    [Column("cn_Ice_por")]
    public double CnIcePor { get; set; }

    [Column("cn_Ice_valor")]
    public double CnIceValor { get; set; }

    [Column("cn_Serv_por")]
    public double CnServPor { get; set; }

    [Column("cn_Serv_valor")]
    public double CnServValor { get; set; }

    [Column("cn_BaseSeguro")]
    [Precision(18, 2)]
    public decimal CnBaseSeguro { get; set; }

    [Column("cn_total")]
    [Precision(18, 2)]
    public decimal CnTotal { get; set; }

    [Column("cn_vaCoa")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CnVaCoa { get; set; } = null!;

    [Column("cn_Autorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnAutorizacion { get; set; }

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoServicio { get; set; }

    [Column("IdCtaCble_Acre")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleAcre { get; set; }

    [Column("IdCtaCble_IVA")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleIva { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Ip { get; set; } = null!;

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("IdCbteCble_Anulacion")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleAnulacion { get; set; }

    [Column("IdTipoCbte_Anulacion")]
    public int? IdTipoCbteAnulacion { get; set; }

    [Column("cn_tipoLocacion")]
    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnTipoLocacion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdIden_credito")]
    public int? IdIdenCredito { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PagoLocExt { get; set; }

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PaisPago { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ConvenioTributacion { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PagoSujetoRetencion { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    public double Saldo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoNota { get; set; } = null!;

    [Column("cn_Fecha_vcto")]
    public DateOnly CnFechaVcto { get; set; }

    [Column("cn_Autorizacion_Imprenta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnAutorizacionImprenta { get; set; }

    [Column("cn_num_doc_modificado")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CnNumDocModificado { get; set; }

    [Column("fecha_autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [Column("cod_nota")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodNota { get; set; }

    public double MontoAplicado { get; set; }

    [Column("pr_codigo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [Column("cod_clase_proveedor")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodClaseProveedor { get; set; } = null!;

    [Column("descripcion_clas_prove")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescripcionClasProve { get; set; } = null!;

    public int IdClaseProveedor { get; set; }
}
