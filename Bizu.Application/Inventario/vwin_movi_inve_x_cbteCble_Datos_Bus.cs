using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Bizu.Domain.Inventario;
using Bizu.Infrastructure.Inventario;
using Bizu.Domain.General;
using Bizu.Application.General;


namespace Bizu.Application.Inventario
{
  public  class vwin_movi_inve_x_cbteCble_Datos_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        vwin_movi_inve_x_cbteCble_Datos_Data odata = new vwin_movi_inve_x_cbteCble_Datos_Data();

        public List<vwin_movi_inve_x_cbteCble_Datos_Info> Get_List_vwin_movi_inve_x_cbteCble_Datos
            (int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string Tipo_ing_egr, string Tipo_Contabilizado)
        {
            try
            {
                return odata.Get_List_vwin_movi_inve_x_cbteCble_Datos(IdEmpresa, FechaIni, FechaFin, Tipo_ing_egr, Tipo_Contabilizado);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultarInfo", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };

            }
        }

        public List<vwin_movi_inve_x_cbteCble_Datos_Info> Get_List_vwin_movi_inve_x_cbteCble_Datos_No_Contabilizados(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,
            string Tipo_ing_egr)
        {
            {
                try
                {
                    return odata.Get_List_vwin_movi_inve_x_cbteCble_Datos_No_Contabilizados(IdEmpresa, FechaIni, FechaFin, Tipo_ing_egr);
                }
                catch (Exception ex)
                {
                    Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                    throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultarInfo", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };

                }
            }
        }
    }
}
