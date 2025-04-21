using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Data.Contabilidad
{
    public class ct_dashboard_financiero_Data
    {
        public bool GrabarBD(ct_dashboard_financiero_Info Info)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    ct_dashboard_financiero _dashboard = new ct_dashboard_financiero();
                    _dashboard.IdEmpresa = Info.IdEmpresa;
                    _dashboard.IdUsuario = Info.IdUsuario;
                    _dashboard.anio_fiscal = Info.anio_fiscal;
                    _dashboard.IdMes = Info.IdMes;
                    _dashboard.nomMes = Info.nomMes;
                    _dashboard.liq_razon_circulante = Info.liq_razon_circulante;
                    _dashboard.liq_razon_circulante_objetivo = Info.liq_razon_circulante_objetivo;
                    _dashboard.liq_prueba_acida = Info.liq_prueba_acida;
                    _dashboard.liq_prueba_acida_objetivo = Info.liq_prueba_acida_objetivo;
                    _dashboard.liq_ratio_caja = Info.liq_ratio_caja;
                    _dashboard.liq_dias_de_cobranza = Info.liq_dias_de_cobranza;
                    _dashboard.liq_dias_de_inventario = Info.liq_dias_de_inventario;
                    _dashboard.liq_dias_de_pago = Info.liq_dias_de_pago;
                    _dashboard.liq_rotarion_del_efectivo = Info.liq_rotarion_del_efectivo;
                    _dashboard.liq_rotacion_del_activo = Info.liq_rotacion_del_activo;
                    _dashboard.liq_rotacion_del_activo_objetivo = Info.liq_rotacion_del_activo_objetivo;
                    _dashboard.liq_rotacion_del_activo_fijio = Info.liq_rotacion_del_activo_fijio;
                    _dashboard.liq_rotacion_del_activo_fijio_objetivo = Info.liq_rotacion_del_activo_fijio_objetivo;
                    _dashboard.liq_capital_de_trabajo = Info.liq_capital_de_trabajo;
                    _dashboard.end_pasivo_total_x_patrimonio_total = Info.end_pasivo_total_x_patrimonio_total;
                    _dashboard.end_pasivo_circulante_x_patrimonio_total = Info.end_pasivo_circulante_x_patrimonio_total;
                    _dashboard.end_pasivo_no_circulante_x_patrimonio_total = Info.end_pasivo_no_circulante_x_patrimonio_total;
                    _dashboard.end_pasivo_total_x_activo_total = Info.end_pasivo_total_x_activo_total;
                    _dashboard.end_cobertura_gastos_financieros = Info.end_cobertura_gastos_financieros;
                    _dashboard.end_cobertura_gastos_financieros_objetivo = Info.end_cobertura_gastos_financieros_objetivo;
                    _dashboard.end_cobertura_gastos_fijos = Info.end_cobertura_gastos_fijos;
                    _dashboard.end_cobertura_gastos_fijos_objetivo = Info.end_cobertura_gastos_fijos_objetivo;
                    _dashboard.end_rotacion_inventario = Info.end_rotacion_inventario;
                    _dashboard.end_rotacion_inventario_objetivo = Info.end_rotacion_inventario_objetivo;
                    _dashboard.ren_sobre_la_inversion = Info.ren_sobre_la_inversion;
                    _dashboard.ren_sobre_la_venta = Info.ren_sobre_la_venta;
                    _dashboard.ren_sobre_el_patrimonio = Info.ren_sobre_el_patrimonio;
                    _dashboard.ren_utilidad_accion = Info.ren_utilidad_accion;
                    _dashboard.ren_margen_utilidad_bruta = Info.ren_margen_utilidad_bruta;
                    _dashboard.pasivo_neto = Info.pasivo_neto;
                    _dashboard.patrimonio_neto = Info.patrimonio_neto;

                    context.ct_dashboard_financiero.Add(_dashboard);
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarBD(int IdEmpresa, string IdUsuario)
        {
            try
            {
                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    int iFilasAfectadas = context.Database.ExecuteSqlCommand("DELETE FROM ct_dashboard_financiero WHERE IdEmpresa = {0} AND IdUsuario = {1}", IdEmpresa, IdUsuario);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ct_dashboard_financiero_Info> GetList(int IdEmpresa, string IdUsuario)
        {
            try
            {
                List<ct_dashboard_financiero_Info> lista = new List<ct_dashboard_financiero_Info>();

                using (EntitiesDBConta context = new EntitiesDBConta())
                {
                    var query = from q in context.ct_dashboard_financiero
                                where q.IdEmpresa == IdEmpresa
                                && q.IdUsuario == IdUsuario
                                select q;

                    foreach (var Info in query)
                    {
                        ct_dashboard_financiero_Info _dashboard = new ct_dashboard_financiero_Info();
                        _dashboard.IdEmpresa = Info.IdEmpresa;
                        _dashboard.IdUsuario = Info.IdUsuario;
                        _dashboard.anio_fiscal = Info.anio_fiscal;
                        _dashboard.IdMes = Info.IdMes;
                        _dashboard.nomMes = Info.nomMes;
                        _dashboard.liq_razon_circulante = Info.liq_razon_circulante;
                        _dashboard.liq_razon_circulante_objetivo = Info.liq_razon_circulante_objetivo;
                        _dashboard.liq_prueba_acida = Info.liq_prueba_acida;
                        _dashboard.liq_prueba_acida_objetivo = Info.liq_prueba_acida_objetivo;
                        _dashboard.liq_ratio_caja = Info.liq_ratio_caja;
                        _dashboard.liq_dias_de_cobranza = Info.liq_dias_de_cobranza;
                        _dashboard.liq_dias_de_inventario = Info.liq_dias_de_inventario;
                        _dashboard.liq_dias_de_pago = Info.liq_dias_de_pago;
                        _dashboard.liq_rotarion_del_efectivo = Info.liq_rotarion_del_efectivo;
                        _dashboard.liq_rotacion_del_activo = Info.liq_rotacion_del_activo;
                        _dashboard.liq_rotacion_del_activo_objetivo = Info.liq_rotacion_del_activo_objetivo;
                        _dashboard.liq_rotacion_del_activo_fijio = Info.liq_rotacion_del_activo_fijio;
                        _dashboard.liq_rotacion_del_activo_fijio_objetivo = Info.liq_rotacion_del_activo_fijio_objetivo;
                        _dashboard.liq_capital_de_trabajo = Info.liq_capital_de_trabajo;
                        _dashboard.end_pasivo_total_x_patrimonio_total = Info.end_pasivo_total_x_patrimonio_total;
                        _dashboard.end_pasivo_circulante_x_patrimonio_total = Info.end_pasivo_circulante_x_patrimonio_total;
                        _dashboard.end_pasivo_no_circulante_x_patrimonio_total = Info.end_pasivo_no_circulante_x_patrimonio_total;
                        _dashboard.end_pasivo_total_x_activo_total = Info.end_pasivo_total_x_activo_total;
                        _dashboard.end_cobertura_gastos_financieros = Info.end_cobertura_gastos_financieros;
                        _dashboard.end_cobertura_gastos_financieros_objetivo = Info.end_cobertura_gastos_financieros_objetivo;
                        _dashboard.end_cobertura_gastos_fijos = Info.end_cobertura_gastos_fijos;
                        _dashboard.end_cobertura_gastos_fijos_objetivo = Info.end_cobertura_gastos_fijos_objetivo;
                        _dashboard.end_rotacion_inventario = Info.end_rotacion_inventario;
                        _dashboard.end_rotacion_inventario_objetivo = Info.end_rotacion_inventario_objetivo;
                        _dashboard.ren_sobre_la_inversion = Info.ren_sobre_la_inversion;
                        _dashboard.ren_sobre_la_venta = Info.ren_sobre_la_venta;
                        _dashboard.ren_sobre_el_patrimonio = Info.ren_sobre_el_patrimonio;
                        _dashboard.ren_utilidad_accion = Info.ren_utilidad_accion;
                        _dashboard.ren_margen_utilidad_bruta = Info.ren_margen_utilidad_bruta;
                        _dashboard.pasivo_neto = Info.pasivo_neto;
                        _dashboard.patrimonio_neto = Info.patrimonio_neto;
                        
                        lista.Add(_dashboard);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}