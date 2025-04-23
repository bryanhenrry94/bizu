using Bizu.Infrastructure.Inventario;
using Bizu.Domain.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.Inventario
{
    public class in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Bus
    {
        in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Data oData = new in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Data();

        public bool GuardarDB(in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public bool GuardarDB(List<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info> info)
        {
            try
            {
                foreach (var item in info)
                {
                    if (!oData.GuardarDB(item))
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public bool EliminarDB(in_transferencia_Info info)
        {
            try
            {
                return oData.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }

        public List<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info> Get_list_trans_x_guia(int IdEmpresa, decimal IdGuia)
        {
            try
            {
                return oData.Get_list_trans_x_guia(IdEmpresa, IdGuia);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };
            }
        }
    }
}
