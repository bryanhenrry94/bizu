using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

namespace Core.Erp.Business.Inventario
{
    public class in_GuiaRemision_Det_Bus
    {
        in_GuiaRemision_Det_Data Data = new in_GuiaRemision_Det_Data();

        public List<in_GuiaRemision_Det_Info> Get_List(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                return Data.Get_List(IdEmpresa, IdSucursal, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<in_GuiaRemision_Det_Info> Get_List_Guia_x_in_GuiaRemision_Det(int idempresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                return Data.Get_List_Guia_x_in_GuiaRemision_Det(idempresa, IdSucursal, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Guia_x_in_GuiaRemision_Det", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_det_Bus) };

            }
        }
    }
}
