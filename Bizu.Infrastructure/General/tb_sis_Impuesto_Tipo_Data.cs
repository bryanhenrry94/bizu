using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class tb_sis_Impuesto_Tipo_Data
    {

        string mensaje = "";

        public List<tb_sis_Impuesto_Tipo_Info> Get_List_impuesto()
        {
            try
            {
                List<tb_sis_Impuesto_Tipo_Info> lst = new List<tb_sis_Impuesto_Tipo_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_sis_impuesto_tipo
                             select q;
                foreach (var item in bancos)
                {
                    tb_sis_Impuesto_Tipo_Info info = new tb_sis_Impuesto_Tipo_Info();

                    info.IdTipoImpuesto = item.idtipoimpuesto;
                    info.nom_tipoImpuesto = item.nom_tipoimpuesto;



                    lst.Add(info);
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_sis_Impuesto_Tipo_Info Get_Info_impuesto(string IdTipoImpuesto)
        {
            try
            {
                tb_sis_Impuesto_Tipo_Info info = new tb_sis_Impuesto_Tipo_Info();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_sis_impuesto_tipo
                             where q.idtipoimpuesto == IdTipoImpuesto
                             select q;
                foreach (var item in bancos)
                {
                    info.IdTipoImpuesto = item.idtipoimpuesto;
                    info.nom_tipoImpuesto = item.nom_tipoimpuesto;
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}