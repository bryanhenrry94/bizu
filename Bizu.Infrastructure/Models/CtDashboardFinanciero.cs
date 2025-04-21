using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdUsuario", "AnioFiscal", "IdMes")]
[Table("ct_dashboard_financiero")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtDashboardFinanciero
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(25)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    [Column("anio_fiscal")]
    public int AnioFiscal { get; set; }

    [Key]
    public int IdMes { get; set; }

    [Column("nomMes")]
    [StringLength(100)]
    public string NomMes { get; set; } = null!;

    [Column("liq_razon_circulante")]
    public double? LiqRazonCirculante { get; set; }

    [Column("liq_razon_circulante_objetivo")]
    public double? LiqRazonCirculanteObjetivo { get; set; }

    [Column("liq_prueba_acida")]
    public double? LiqPruebaAcida { get; set; }

    [Column("liq_prueba_acida_objetivo")]
    public double? LiqPruebaAcidaObjetivo { get; set; }

    [Column("liq_ratio_caja")]
    public double? LiqRatioCaja { get; set; }

    [Column("liq_dias_de_cobranza")]
    public double? LiqDiasDeCobranza { get; set; }

    [Column("liq_dias_de_inventario")]
    public double? LiqDiasDeInventario { get; set; }

    [Column("liq_dias_de_pago")]
    public double? LiqDiasDePago { get; set; }

    [Column("liq_rotarion_del_efectivo")]
    public double? LiqRotarionDelEfectivo { get; set; }

    [Column("liq_rotacion_del_activo")]
    public double? LiqRotacionDelActivo { get; set; }

    [Column("liq_rotacion_del_activo_objetivo")]
    public double? LiqRotacionDelActivoObjetivo { get; set; }

    [Column("liq_rotacion_del_activo_fijio")]
    public double? LiqRotacionDelActivoFijio { get; set; }

    [Column("liq_rotacion_del_activo_fijio_objetivo")]
    public double? LiqRotacionDelActivoFijioObjetivo { get; set; }

    [Column("liq_capital_de_trabajo")]
    public double? LiqCapitalDeTrabajo { get; set; }

    [Column("end_pasivo_total_x_patrimonio_total")]
    public double? EndPasivoTotalXPatrimonioTotal { get; set; }

    [Column("end_pasivo_circulante_x_patrimonio_total")]
    public double? EndPasivoCirculanteXPatrimonioTotal { get; set; }

    [Column("end_pasivo_no_circulante_x_patrimonio_total")]
    public double? EndPasivoNoCirculanteXPatrimonioTotal { get; set; }

    [Column("end_pasivo_total_x_activo_total")]
    public double? EndPasivoTotalXActivoTotal { get; set; }

    [Column("end_cobertura_gastos_financieros")]
    public double? EndCoberturaGastosFinancieros { get; set; }

    [Column("end_cobertura_gastos_financieros_objetivo")]
    public double? EndCoberturaGastosFinancierosObjetivo { get; set; }

    [Column("end_cobertura_gastos_fijos")]
    public double? EndCoberturaGastosFijos { get; set; }

    [Column("end_cobertura_gastos_fijos_objetivo")]
    public double? EndCoberturaGastosFijosObjetivo { get; set; }

    [Column("end_rotacion_inventario")]
    public double? EndRotacionInventario { get; set; }

    [Column("end_rotacion_inventario_objetivo")]
    public double? EndRotacionInventarioObjetivo { get; set; }

    [Column("ren_sobre_la_inversion")]
    public double? RenSobreLaInversion { get; set; }

    [Column("ren_sobre_la_venta")]
    public double? RenSobreLaVenta { get; set; }

    [Column("ren_sobre_el_patrimonio")]
    public double? RenSobreElPatrimonio { get; set; }

    [Column("ren_utilidad_accion")]
    public double? RenUtilidadAccion { get; set; }

    [Column("ren_margen_utilidad_bruta")]
    public double? RenMargenUtilidadBruta { get; set; }

    [Column("pasivo_neto")]
    public double? PasivoNeto { get; set; }

    [Column("patrimonio_neto")]
    public double? PatrimonioNeto { get; set; }
}
