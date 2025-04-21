using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Data.Contabilidad
{
   public  class ct_Tipo_costo_Data
    {

	
       public ct_Tipo_costo_Data()
       {

       }

       public List<ct_Tipo_costo_Info> Get_list_Tipo_costo(int IdEmpresa)
       {
           try
           {
               List<ct_Tipo_costo_Info> Lista = new List<ct_Tipo_costo_Info>();

               using (EntitiesDBConta Context = new EntitiesDBConta())
               {
                   var lst = from q in Context.ct_Tipo_costo
                             where q.IdEmpresa == IdEmpresa
                             select q;

                   foreach (var item in lst)
                   {
                       ct_Tipo_costo_Info info = new ct_Tipo_costo_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdTipo_Costo = item.IdTipo_Costo;
                       info.nom_tipo_Costo = item.nom_tipo_Costo;
                       info.estado = Convert.ToBoolean(item.estado);
                       info.orden = item.orden;
                       info.nom_tipo_Costo2 = "[" + Convert.ToString(item.IdTipo_Costo) + "] " + item.nom_tipo_Costo;
                       Lista.Add(info);
                   }
               }

               return Lista;
           }
           catch (Exception ex)
           {
               //string mensaje = "";
               //string arreglo = ToString();
               //tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               //tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
               //                    "", "", "", "", DateTime.Now);

               //oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               //mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }


    }
}
