using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Inventario;
using Bizu.Domain.Inventario;
using Bizu.Application.General;

namespace Bizu.Application.Inventario
{
    public class in_Parametro_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_Parametro_Data oData = new in_Parametro_Data();

        public Boolean ModificarDB(in_Parametro_Info inf, int IdEmpresa)
        {
            try
            {
                return oData.ModificarDB(inf, IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(in_Parametro_Bus) };

            }
        }
        
        public in_Parametro_Info Get_Info_Parametro(int IdEmpresa)
        {
            try
            {
                in_Parametro_Info oinfo = new in_Parametro_Info();


               oinfo= oData.Get_Info_Parametro(IdEmpresa);
               return oinfo;

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerParametros", ex.Message), ex) { EntityType = typeof(in_Parametro_Bus) };
            }
        }
    }
}
