using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_ERP.Info;
using Core.Erp.Info.Obra;
using Core.Erp.Business.Obra;
using Newtonsoft.Json;

namespace WS_ERP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Ws_Obra" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Ws_Obra.svc o Ws_Obra.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Ws_Obra : IWs_Obra
    {
        obr_Proyecto_Bus Bus_Proyecto;

        public Ws_Obra()
        {
            Bus_Proyecto = new obr_Proyecto_Bus();
        }

        public Response_Info Proyecto_GetAll(int IdEmpresa, int IdSucursal)
        {
            Response_Info response = new Response_Info();

            try
            {
                List<Proyecto_Info> Lista = new List<Proyecto_Info>();

                List<obr_Proyecto_Info> List_Proyecto_Info = Bus_Proyecto.Get(IdEmpresa, IdSucursal);

                foreach (var item in List_Proyecto_Info)
                {
                    Proyecto_Info Info = new Proyecto_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdProyecto = item.IdProyecto;
                    Info.Codigo = item.Codigo;
                    Info.Nombre = item.Nombre;
                    Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    Info.IdEstadoCierre = item.IdEstadoCierre;
                    Info.IdCliente = item.IdCliente;
                    Info.IdResidente = item.IdResidente;
                    Info.FechaInicio = item.FechaInicio;
                    Info.FechaFin = item.FechaFin;
                    Info.Observacion = item.Observacion;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.DireccionObra = item.DireccionObra;
                    Info.Correo_obra = item.Correo_obra;
                    Info.IdBodega_Obra = item.IdBodega_Obra;
                    Info.Estado = item.Estado;
                    Info.FechaCreacion = item.FechaCreacion;
                    Info.IdUsuarioCreacion = item.IdUsuarioCreacion;
                    Info.FechaModificacion = item.FechaModificacion;
                    Info.IdUsuarioModificacion = item.IdUsuarioModificacion;
                    Info.FechaAnulacion = item.FechaAnulacion;
                    Info.IdUsuarioAnulacion = item.IdUsuarioAnulacion;
                    Info.MotivoAnulacion = item.MotivoAnulacion;
                    Info.IdUsuarioAprueba = item.IdUsuarioAprueba;
                    Info.FechaAprueba = item.FechaAprueba;

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

        public Response_Info Proyecto_GetAllByIdCliente(int IdEmpresa, int IdSucursal, decimal IdCliente)
        {
            Response_Info response = new Response_Info();

            try
            {
                List<Proyecto_Info> Lista = new List<Proyecto_Info>();

                List<obr_Proyecto_Info> List_Proyecto_Info = Bus_Proyecto.Get(IdEmpresa, IdSucursal, IdCliente);

                foreach (var item in List_Proyecto_Info)
                {
                    Proyecto_Info Info = new Proyecto_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdProyecto = item.IdProyecto;
                    Info.Codigo = item.Codigo;
                    Info.Nombre = item.Nombre;
                    Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    Info.IdEstadoCierre = item.IdEstadoCierre;
                    Info.IdCliente = item.IdCliente;
                    Info.IdResidente = item.IdResidente;
                    Info.FechaInicio = item.FechaInicio;
                    Info.FechaFin = item.FechaFin;
                    Info.Observacion = item.Observacion;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.DireccionObra = item.DireccionObra;
                    Info.Correo_obra = item.Correo_obra;
                    Info.IdBodega_Obra = item.IdBodega_Obra;
                    Info.Estado = item.Estado;
                    Info.FechaCreacion = item.FechaCreacion;
                    Info.IdUsuarioCreacion = item.IdUsuarioCreacion;
                    Info.FechaModificacion = item.FechaModificacion;
                    Info.IdUsuarioModificacion = item.IdUsuarioModificacion;
                    Info.FechaAnulacion = item.FechaAnulacion;
                    Info.IdUsuarioAnulacion = item.IdUsuarioAnulacion;
                    Info.MotivoAnulacion = item.MotivoAnulacion;
                    Info.IdUsuarioAprueba = item.IdUsuarioAprueba;
                    Info.FechaAprueba = item.FechaAprueba;

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