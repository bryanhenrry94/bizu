using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_ERP.Info;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Newtonsoft.Json;

namespace WS_ERP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Ws_Contabilidad" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Ws_Contabilidad.svc o Ws_Contabilidad.svc.cs en el Explorador de soluciones e inicie la depuración.

    public class Ws_Contabilidad : IWs_Contabilidad
    {
        public Response_Info CentroCosto_GetAll(int IdEmpresa)
        {
            Response_Info response = new Response_Info();

            List<CentroCosto_Info> Lista = new List<CentroCosto_Info>();
            string MensajeError = "";

            try
            {
                List<ct_Centro_costo_Info> List_CentroCosto = new List<ct_Centro_costo_Info>();
                ct_Centro_costo_Bus Bus_CentroCosto = new ct_Centro_costo_Bus();

                List_CentroCosto = Bus_CentroCosto.Get_list_Centro_Costo(IdEmpresa, ref MensajeError);

                foreach (var item in List_CentroCosto)
                {
                    CentroCosto_Info Info = new CentroCosto_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.Centro_costo = item.Centro_costo;
                    Info.Centro_costo2 = item.Centro_costo2;

                    Lista.Add(Info);
                }

                response.Data = JsonConvert.SerializeObject(Lista);
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }
    }
}