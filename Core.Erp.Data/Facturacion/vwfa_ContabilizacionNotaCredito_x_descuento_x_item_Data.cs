using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class vwfa_ContabilizacionNotaCredito_x_descuento_x_item_Data
    {
        public List<vwfa_ContabilizacionNotaCredito_x_descuento_x_item_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                List<vwfa_ContabilizacionNotaCredito_x_descuento_x_item_Info> Lista = new List<vwfa_ContabilizacionNotaCredito_x_descuento_x_item_Info>();

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.vwfa_ContabilizacionNotaCredito_x_descuento_x_item
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdBodega == IdBodega
                              && q.IdNota == IdNota
                              select q;

                    foreach (var item in lst)
                    {
                        vwfa_ContabilizacionNotaCredito_x_descuento_x_item_Info info = new vwfa_ContabilizacionNotaCredito_x_descuento_x_item_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdNota = item.IdNota;
                        info.de_IdCtaCble = item.de_IdCtaCble;                        
                        info.sc_iva = item.sc_iva;
                        info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info.IdPunto_Cargo = item.IdPunto_Cargo;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.sc_descUni = item.sc_descUni;
                        info.sc_descTotal = item.sc_descTotal;                        

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
