using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Inventario;
using Bizu.Infrastructure.Inventario;
using Bizu.Application.General;

namespace Bizu.Application.Inventario
{
   public class vwin_categoria_lin_gr_subgr_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwin_categoria_lin_gr_subgr_Data oData = new vwin_categoria_lin_gr_subgr_Data();

        public List<vwin_categoria_lin_gr_subgr_Info> Get_List_in_categoria_lin_gr_subg(int IdEmpresa)
       {
           try
           {
               return oData.Get_List_in_categoria_lin_gr_subgr(IdEmpresa);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerList_lin_gr_subgr", ex.Message), ex) { EntityType = typeof(vwin_categoria_lin_gr_subgr_Bus) };

             
           }

       }


    }
}
