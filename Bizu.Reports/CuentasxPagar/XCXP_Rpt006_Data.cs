using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt006_Data
    {
        public List<XCXP_Rpt006_Info> consultar_data(int IdEmpresa, decimal IdCbteCble_Nota, ref List<XCXP_Rpt006_Info_Resumen> list_Resumen_ret, ref string mensaje)
        {
            try
            {
                List<XCXP_Rpt006_Info> listadedatos = new List<XCXP_Rpt006_Info>();
                using (EntitiesCXP_General facturaProvee = new EntitiesCXP_General())
                {
                    var select = from h in facturaProvee.vwCXP_Rpt006
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdCbteCble_Nota == IdCbteCble_Nota
                                 select h;
                    foreach (var item in select)
                    {
                        XCXP_Rpt006_Info itemInfo = new XCXP_Rpt006_Info();
                        itemInfo.clave = item.clave;
                        itemInfo.cn_Nota = item.clave;
                        itemInfo.dc_Observacion = item.cn_serie1 + "-" + item.cn_serie2 + "-" + item.cn_Nota + " " + item.dc_Observacion;
                        itemInfo.dc_Valor = item.dc_Valor;
                        itemInfo.DebCre = item.DebCre;
                        itemInfo.Detalle = item.Detalle;
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.IdCbteCble_Nota = item.IdCbteCble_Nota;
                        itemInfo.IdCtaCble = item.IdCtaCble;
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdProveedor = item.IdProveedor;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdTipoCbte_Nota = item.IdTipoCbte_Nota;
                        itemInfo.IdTipoNota = item.IdTipoNota;
                        itemInfo.nom_Cuenta = item.nom_Cuenta;
                        itemInfo.nom_Proveedor = item.nom_Proveedor;
                        itemInfo.nom_Sucursal = item.nom_Sucursal;
                        itemInfo.nom_TipoCbte = item.nom_TipoCbte;
                        itemInfo.Nombre = item.Nombre;
                        itemInfo.secuencia = item.secuencia;
                        itemInfo.nom_punto_cargo = item.nom_punto_cargo;
                        itemInfo.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;

                        //itemInfo.valor_debe = Convert.ToDouble(item.valor_debe);
                        //itemInfo.valor_haber = Convert.ToDouble(item.valor_haber);

                        itemInfo.debe = item.valor_debe == 0 ? "" : Convert.ToString(item.valor_debe);
                        itemInfo.haber = item.valor_haber == 0 ? "" : Convert.ToString(item.valor_haber);
                        itemInfo.em_nombre = item.em_nombre;
                        listadedatos.Add(itemInfo);
                    }
                }

                //Nuevo Inicio
                list_Resumen_ret = new List<XCXP_Rpt006_Info_Resumen>();

                var TdebitosxCta = from Cb in listadedatos
                                   group Cb by new { Cb.IdEmpresa, Cb.IdCbteCble_Nota, Cb.IdTipoCbte_Nota }
                                       into grouping
                                       select new { 
                                           grouping.Key.IdEmpresa, 
                                           grouping.Key.IdCbteCble_Nota,
                                           grouping.Key.IdTipoCbte_Nota};

                foreach (var item in TdebitosxCta)
                {
                    
                    List<cp_orden_pago_cancelaciones_Info> lista_PagoCance;
                    
                    cp_orden_pago_cancelaciones_Data CanData = new cp_orden_pago_cancelaciones_Data();
                    cp_orden_giro_Data ogiroData = new cp_orden_giro_Data();

                    lista_PagoCance = new List<cp_orden_pago_cancelaciones_Info>(CanData.Get_list_Cancelacion_x_Pagos(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdTipoCbte_Nota), Convert.ToDecimal(item.IdCbteCble_Nota), ref mensaje));

                    if (lista_PagoCance.Count() > 0)
                    {
                        foreach (var item1 in lista_PagoCance)
                        {
                            cp_orden_giro_Info ogiroInfo = new cp_orden_giro_Info();
                            XCXP_Rpt006_Info_Resumen InfoR = new XCXP_Rpt006_Info_Resumen();
                            ogiroInfo.IdEmpresa = item1.IdEmpresa;
                            ogiroInfo.IdCbteCble_Ogiro = Convert.ToDecimal(item1.IdCbteCble_cxp);
                            ogiroInfo.IdTipoCbte_Ogiro = Convert.ToInt32(item1.IdTipoCbte_cxp);

                            ogiroInfo = ogiroData.Get_Info_orden_giro(ogiroInfo);

                            InfoR.IdOrdenPago = Convert.ToInt32(item1.IdOrdenPago_op);
                            InfoR.IdFactura = Convert.ToString(ogiroInfo.IdCbteCble_Ogiro);
                            InfoR.FacturaModificada = ogiroInfo.co_serie + "-" + ogiroInfo.co_factura;
                            InfoR.Valor_Factura = item1.MontoAplicado;

                            list_Resumen_ret.Add(InfoR);

                        }
                    }                                     
                }

                //Nuevo Fin

                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt006_Info>();
            }
        }
    }
}
