using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_ERP.Info;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Newtonsoft.Json;

namespace WS_ERP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Ws_Facturacion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Ws_Facturacion.svc o Ws_Facturacion.svc.cs en el Explorador de soluciones e inicie la depuración.

    public class Ws_Facturacion : IWs_Facturacion
    {
        public Response_Info Cliente_GetOneByIdCliente(int IdEmpresa, decimal IdCliente)
        {
            fa_cliente_Obra_Bus Bus_Cliente_Obra = new fa_cliente_Obra_Bus();

            Response_Info response = new Response_Info();

            try
            {
                List<Cliente_Obra_Info> Lista = new List<Cliente_Obra_Info>();

                List<fa_cliente_Obra_Info> List_Proyecto_Info = Bus_Cliente_Obra.Get_Info(IdEmpresa, IdCliente);

                foreach (var item in List_Proyecto_Info)
                {
                    Cliente_Obra_Info Info = new Cliente_Obra_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCliente = item.IdCliente;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.FechaIni = item.FechaIni;
                    Info.FechaFin = item.FechaFin;
                    Info.DireccionObra = item.DireccionObra;
                    Info.CorreoObra = item.CorreoObra;
                    Info.IdEstadoObra = item.IdEstadoObra;

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

        public Response_Info Cliente_GetOneByIdEstadoObra(int IdEmpresa, decimal IdCliente, string IdEstadoObra)
        {
            fa_cliente_Obra_Bus Bus_Cliente_Obra = new fa_cliente_Obra_Bus();

            Response_Info response = new Response_Info();

            try
            {
                List<Cliente_Obra_Info> Lista = new List<Cliente_Obra_Info>();

                List<fa_cliente_Obra_Info> List_Proyecto_Info = Bus_Cliente_Obra.Get_Info_x_Estado(IdEmpresa, IdCliente, IdEstadoObra);

                foreach (var item in List_Proyecto_Info)
                {
                    Cliente_Obra_Info Info = new Cliente_Obra_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCliente = item.IdCliente;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.FechaIni = item.FechaIni;
                    Info.FechaFin = item.FechaFin;
                    Info.DireccionObra = item.DireccionObra;
                    Info.CorreoObra = item.CorreoObra;
                    Info.IdEstadoObra = item.IdEstadoObra;

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