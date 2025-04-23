using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using Bizu.Domain.SeguridadAcceso;
using Bizu.Infrastructure.SeguridadAcceso;


namespace Bizu.Application.SeguridadAcceso
{
   public class seg_Usuario_x_Empresa_Bus
    {
       seg_Usuario_x_Empresa_Data Odata = new seg_Usuario_x_Empresa_Data();



       public List<seg_Usuario_x_Empresa_info> Get_List_seg_Usuario_x_Empresa(string IdUsuario)
       {
           try
           {

               return Odata.Get_List_Usuario_x_Empresa(IdUsuario);

           }
           catch (Exception ex)
           {
               string mensaje = "";
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);

           }
       }
       
    }
}
