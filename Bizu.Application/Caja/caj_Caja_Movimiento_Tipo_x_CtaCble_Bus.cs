using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Caja;
using Bizu.Infrastructure.Caja;
using Bizu.Application.General;

namespace Bizu.Application.Caja
{
    public class caj_Caja_Movimiento_Tipo_x_CtaCble_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        caj_Caja_Movimiento_Tipo_x_CtaCble_Data data = new caj_Caja_Movimiento_Tipo_x_CtaCble_Data();

        public Boolean GrabarDB(List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info> Lst)
        {
            try
            {
                  return data.GrabarDB(Lst);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_x_CtaCble_Bus) };
            }

        }

        public List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info> Get_List(int idEmpresa)
        {
            try
            {
                return data.Get_List(idEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List", ex.Message), ex) { EntityType = typeof(caj_Caja_Movimiento_Tipo_x_CtaCble_Bus) };
            }
        }

         public caj_Caja_Movimiento_Tipo_x_CtaCble_Bus(){}
    }
}
