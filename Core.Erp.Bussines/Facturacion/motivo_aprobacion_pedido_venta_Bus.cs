using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Data.Facturacion;

namespace Core.Erp.Business.Facturacion
{
    public class motivo_aprobacion_pedido_venta_Bus
    {
        motivo_aprobacion_pedido_venta_Data data = new motivo_aprobacion_pedido_venta_Data();

        public Boolean GrabarDB(motivo_aprobacion_pedido_venta_Info info)
        {
            try
            {
                Boolean Result = false;

                Result = data.GrabarDB(info);
                    
                return Result;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public List<motivo_aprobacion_pedido_venta_Info> Get_Info_Motivo(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                List<motivo_aprobacion_pedido_venta_Info> ListMotivo = new List<motivo_aprobacion_pedido_venta_Info>();

                ListMotivo = data.Get_Info_Motivo(IdEmpresa, IdCliente);

                return ListMotivo;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public motivo_aprobacion_pedido_venta_Info Get_Info(int IdEmpresa, decimal IdMotivo)
        {
            try
            {
                motivo_aprobacion_pedido_venta_Info infoMotivo = new motivo_aprobacion_pedido_venta_Info();

                infoMotivo = data.Get_Info(IdEmpresa, IdMotivo);

                return infoMotivo;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }
    }
}
