using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Contabilidad
{
    public class ct_dashboard_financiero_Info
    {
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public int anio_fiscal { get; set; }
        public int IdMes { get; set; }
        public string nomMes { get; set; }
        public Nullable<double> liq_razon_circulante { get; set; }
        public Nullable<double> liq_razon_circulante_objetivo { get; set; }
        public Nullable<double> liq_prueba_acida { get; set; }
        public Nullable<double> liq_prueba_acida_objetivo { get; set; }
        public Nullable<double> liq_ratio_caja { get; set; }
        public Nullable<double> liq_dias_de_cobranza { get; set; }
        public Nullable<double> liq_dias_de_inventario { get; set; }
        public Nullable<double> liq_dias_de_pago { get; set; }
        public Nullable<double> liq_rotarion_del_efectivo { get; set; }
        public Nullable<double> liq_rotacion_del_activo { get; set; }
        public Nullable<double> liq_rotacion_del_activo_objetivo { get; set; }
        public Nullable<double> liq_rotacion_del_activo_fijio { get; set; }
        public Nullable<double> liq_rotacion_del_activo_fijio_objetivo { get; set; }
        public Nullable<double> liq_capital_de_trabajo { get; set; }
        public Nullable<double> end_pasivo_total_x_patrimonio_total { get; set; }
        public Nullable<double> end_pasivo_circulante_x_patrimonio_total { get; set; }
        public Nullable<double> end_pasivo_no_circulante_x_patrimonio_total { get; set; }
        public Nullable<double> end_pasivo_total_x_activo_total { get; set; }
        public Nullable<double> end_cobertura_gastos_financieros { get; set; }
        public Nullable<double> end_cobertura_gastos_financieros_objetivo { get; set; }
        public Nullable<double> end_cobertura_gastos_fijos { get; set; }
        public Nullable<double> end_cobertura_gastos_fijos_objetivo { get; set; }
        public Nullable<double> end_rotacion_inventario { get; set; }
        public Nullable<double> end_rotacion_inventario_objetivo { get; set; }
        public Nullable<double> ren_sobre_la_inversion { get; set; }
        public Nullable<double> ren_sobre_la_venta { get; set; }
        public Nullable<double> ren_sobre_el_patrimonio { get; set; }
        public Nullable<double> ren_utilidad_accion { get; set; }
        public Nullable<double> ren_margen_utilidad_bruta { get; set; }
        public Nullable<double> pasivo_neto { get; set; }
        public Nullable<double> patrimonio_neto { get; set; }
    }
}
