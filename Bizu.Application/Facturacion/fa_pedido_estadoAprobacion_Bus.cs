using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Application.General;


namespace Bizu.Application.Facturacion
{
    public class fa_pedido_estadoAprobacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<fa_pedido_estadoAprobacion_Info> Get_List_EstadoAprobacion()
        {
            try
            {
                fa_pedido_estadoAprobacion_Data data = new fa_pedido_estadoAprobacion_Data();
                return data.Get_List_EstadoAprobacion();

            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Lista_EstadoAprobacion", ex.Message), ex) { EntityType = typeof(fa_pedido_estadoAprobacion_Bus) };
            }
        }

        public fa_pedido_estadoAprobacion_Bus() { }
    }
}
