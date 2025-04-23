using Bizu.Infrastructure.Inventario;
using Bizu.Domain.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Application.General;

namespace Bizu.Application.Inventario
{
    public class in_movi_inve_x_ct_cbteCble_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_movi_inve_x_ct_cbteCble_Data Data = new in_movi_inve_x_ct_cbteCble_Data();


        public Boolean GuardarDB(in_movi_inve_x_ct_cbteCble_Info Info)
        {
            try
            {
              return Data.GuardarDB(Info);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(in_movi_inve_x_in_ordencompra_local_Bus) };

            }
        }

        public in_movi_inve_x_ct_cbteCble_Info Get_Info_x_Movi_Inven(int IdEmpresa, int idsucursal, int idbodega, int idmovi_inven_tipo, decimal idNum_Movi)
        {
            try
            {
                return Data.Get_Info_x_Movi_Inven(IdEmpresa, idsucursal, idbodega, idmovi_inven_tipo, idNum_Movi);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Obtener_x_Movi_Inven", ex.Message), ex) { EntityType = typeof(in_movi_inve_x_in_ordencompra_local_Bus) };

                
            }
            
        }

        public in_movi_inve_x_ct_cbteCble_Info Anular_reversar_Diario_x_Movi_Inven
          (int IdEmpresa, int idsucursal, int idbodega, int idmovi_inven_tipo, decimal idNum_Movi, int IdTipoCbteCble_x_anulacion
          , ref decimal IdCbteCble_Reverso, string IdUsuario, DateTime FechaAnulacion)
        {
            try
            {
                return Data.Anular_reversar_Diario_x_Movi_Inven(IdEmpresa, idsucursal, idbodega, idmovi_inven_tipo, idNum_Movi, IdTipoCbteCble_x_anulacion, ref IdCbteCble_Reverso, IdUsuario, FechaAnulacion);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Obtener_x_Movi_Inven", ex.Message), ex) { EntityType = typeof(in_movi_inve_x_in_ordencompra_local_Bus) };

                
            }

            

        }

    }
}
