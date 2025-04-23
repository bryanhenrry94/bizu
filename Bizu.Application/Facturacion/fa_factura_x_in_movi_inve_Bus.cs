using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;
using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
    public class fa_factura_x_in_movi_inve_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_factura_x_in_movi_inve_Data data = new fa_factura_x_in_movi_inve_Data();

        public List<fa_factura_x_in_movi_inve_Info> Get_List_fa_factura_x_in_movi_inve(fa_factura_x_in_movi_inve_Info inf)
        {
            try
            {
                return data.Get_List_fa_factura_x_in_movi_inve(inf);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "traerinfo", ex.Message), ex) { EntityType = typeof(fa_factura_x_in_movi_inve_Bus) };
            }
     
        }
        
        public Boolean GuardarDB(fa_factura_x_in_movi_inve_Info info,ref string mensajeE)
        {
            try
            {
                return data.GuardarDB(info, ref mensajeE ); 
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_factura_x_in_movi_inve_Bus) };
                
            }
            
        }

        public fa_factura_x_in_movi_inve_Info Get_Info_RelacionMoviInven_x_Factura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                return data.Get_Info_fa_factura_x_in_movi_inve_x_Factura_(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };

            }
        }
    }
}
