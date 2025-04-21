using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_ERP.Info;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Produccion_Edehsa;
using Core.Erp.Business.Produccion_Edehsa;
using System.Net;
using Newtonsoft.Json;

namespace WS_ERP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Ws_Inventario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Ws_Inventario.svc o Ws_Inventario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Ws_Inventario : IWs_Inventario
    {
        public Response_Info Get_All_MotivoGuia(int IdEmpresa)
        {
            Response_Info response = new Response_Info();

            try
            {
                List<GuiaRemisionMotivo_Info> Lista = new List<GuiaRemisionMotivo_Info>();
                List<in_GuiaRemision_Motivo_Info> List_Motivo_Guia = new List<in_GuiaRemision_Motivo_Info>();
                in_GuiaRemision_Motivo_Bus Bus_GuiaRemision_Motivo = new in_GuiaRemision_Motivo_Bus();

                List_Motivo_Guia = Bus_GuiaRemision_Motivo.Get_List_motivo(IdEmpresa);

                foreach (var item in List_Motivo_Guia)
                {
                    GuiaRemisionMotivo_Info Info = new GuiaRemisionMotivo_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdMotivo = item.IdMotivo;
                    Info.Codigo = item.Codigo;
                    Info.Descripcion = item.Descripcion;
                    Info.Estado = item.Estado;

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

        public Response_Info Get_Producto_By_CodBarra(int IdEmpresa, int IdSucursal, int IdBodega, string codigo_barra)
        {
            Response_Info response = new Response_Info();

            try
            {
                Producto_Info Info = new Producto_Info();
                in_producto_Bus Bus_Producto = new in_producto_Bus();
                in_Producto_Info Info_Producto_Bodega = new in_Producto_Info();

                Info_Producto_Bodega = Bus_Producto.Get_Producto_modulo_x_inventario(IdEmpresa, IdSucursal, IdBodega, codigo_barra);

                if (Info_Producto_Bodega != null)
                {
                    Info.IdEmpresa = Info_Producto_Bodega.IdEmpresa;
                    Info.IdProducto = Info_Producto_Bodega.IdProducto;
                    Info.pr_codigo = Info_Producto_Bodega.pr_codigo;
                    Info.pr_descripcion = Info_Producto_Bodega.pr_descripcion;
                    Info.pr_descripcion_2 = Info_Producto_Bodega.pr_descripcion_2;
                    Info.pr_codigo_barra = Info_Producto_Bodega.pr_codigo_barra;
                    Info.pr_costo_promedio = Info_Producto_Bodega.pr_costo_promedio;
                    Info.pr_peso = Info_Producto_Bodega.pr_peso;
                    Info.pr_stock = Info_Producto_Bodega.pr_stock;
                    Info.pr_Disponible = Info_Producto_Bodega.pr_Disponible;
                    Info.IdUnidadMedida = Info_Producto_Bodega.IdUnidadMedida;
                    Info.IdUnidadMedida_Consumo = Info_Producto_Bodega.IdUnidadMedida_Consumo;

                    in_Producto_Info Info_Producto = new in_Producto_Info();
                    Info_Producto = Bus_Producto.Get_info_Product(Info_Producto_Bodega.IdEmpresa, Info_Producto_Bodega.IdProducto);

                    if (Info_Producto != null)
                    {

                        Info.IdProductoTipo = Info_Producto.IdProductoTipo;
                        Info.pr_observacion = Info_Producto.pr_observacion;
                        Info.IdCategoria = Info_Producto.IdCategoria;
                        Info.IdLinea = Info_Producto.IdLinea;
                        Info.IdGrupo = Info_Producto.IdGrupo;
                        Info.IdSubGrupo = Info_Producto.IdSubGrupo;
                    }

                    prd_OrdenTaller_Info Info_OrdenTaller = new prd_OrdenTaller_Info();
                    prd_OrdenTaller_Bus Bus_OrdenTaller = new prd_OrdenTaller_Bus();

                    Info_OrdenTaller = Bus_OrdenTaller.Get_OT_By_IdProducto(IdEmpresa, IdSucursal, Info.IdProducto);

                    if (Info_OrdenTaller != null)
                    {
                        Info.pr_peso = Info_OrdenTaller.PesoUnitario;

                        prd_OrdenTaller_Ubicacion_Bus Bus_Ubicacion_OT = new prd_OrdenTaller_Ubicacion_Bus();
                        List<prd_OrdenTaller_Ubicacion_Info> List_Ubicacion = new List<prd_OrdenTaller_Ubicacion_Info>();

                        List_Ubicacion = Bus_Ubicacion_OT.Get_List(Info_OrdenTaller.IdEmpresa, Info_OrdenTaller.IdSucursal, Info_OrdenTaller.IdOrdenTaller);

                        foreach (var item in List_Ubicacion)
                        {
                            Info.Ubicacion1 = item.Ubicacion1;
                            Info.Ubicacion2 = item.Ubicacion2;
                        }
                    }

                    response.Data = JsonConvert.SerializeObject(Info);
                }
                else
                {
                    response.CodigoError = HttpStatusCode.NoContent.ToString();
                    response.MensajeError = "Producto no existe para la bodega seleccionada!";
                }
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Get_Producto_By_IdProducto(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto)
        {
            Response_Info response = new Response_Info();

            try
            {
                Producto_Info Info = new Producto_Info();
                in_producto_Bus Bus_Producto = new in_producto_Bus();
                in_Producto_Info Info_Producto_Bodega = new in_Producto_Info();

                Info_Producto_Bodega = Bus_Producto.Get_Producto_X_Bodega(IdEmpresa, IdSucursal, IdBodega, IdProducto);

                if (Info_Producto_Bodega != null)
                {
                    Info.IdEmpresa = Info_Producto_Bodega.IdEmpresa;
                    Info.IdProducto = Info_Producto_Bodega.IdProducto;
                    Info.pr_codigo = Info_Producto_Bodega.pr_codigo;
                    Info.pr_descripcion = Info_Producto_Bodega.pr_descripcion;
                    Info.pr_descripcion_2 = Info_Producto_Bodega.pr_descripcion_2;
                    Info.pr_codigo_barra = Info_Producto_Bodega.pr_codigo_barra;
                    Info.pr_costo_promedio = Info_Producto_Bodega.pr_costo_promedio;
                    Info.pr_peso = Info_Producto_Bodega.pr_peso;
                    Info.pr_stock = Info_Producto_Bodega.pr_stock;
                    Info.pr_Disponible = Info_Producto_Bodega.pr_Disponible;
                    Info.IdUnidadMedida = Info_Producto_Bodega.IdUnidadMedida;
                    Info.IdUnidadMedida_Consumo = Info_Producto_Bodega.IdUnidadMedida_Consumo;

                    in_Producto_Info Info_Producto = new in_Producto_Info();
                    Info_Producto = Bus_Producto.Get_info_Product(Info_Producto_Bodega.IdEmpresa, Info_Producto_Bodega.IdProducto);

                    if (Info_Producto != null)
                    {

                        Info.IdProductoTipo = Info_Producto.IdProductoTipo;
                        Info.pr_observacion = Info_Producto.pr_observacion;
                        Info.IdCategoria = Info_Producto.IdCategoria;
                        Info.IdLinea = Info_Producto.IdLinea;
                        Info.IdGrupo = Info_Producto.IdGrupo;
                        Info.IdSubGrupo = Info_Producto.IdSubGrupo;
                    }

                    prd_OrdenTaller_Info Info_OrdenTaller = new prd_OrdenTaller_Info();
                    prd_OrdenTaller_Bus Bus_OrdenTaller = new prd_OrdenTaller_Bus();

                    Info_OrdenTaller = Bus_OrdenTaller.Get_OT_By_IdProducto(IdEmpresa, IdSucursal, Info.IdProducto);

                    if (Info_OrdenTaller != null)
                    {
                        Info.pr_peso = Info_OrdenTaller.PesoUnitario;

                        prd_OrdenTaller_Ubicacion_Bus Bus_Ubicacion_OT = new prd_OrdenTaller_Ubicacion_Bus();
                        List<prd_OrdenTaller_Ubicacion_Info> List_Ubicacion = new List<prd_OrdenTaller_Ubicacion_Info>();

                        List_Ubicacion = Bus_Ubicacion_OT.Get_List(Info_OrdenTaller.IdEmpresa, Info_OrdenTaller.IdSucursal, Info_OrdenTaller.IdOrdenTaller);

                        foreach (var item in List_Ubicacion)
                        {
                            Info.Ubicacion1 = item.Ubicacion1;
                            Info.Ubicacion2 = item.Ubicacion2;
                        }
                    }

                    response.Data = JsonConvert.SerializeObject(Info);
                }
                else
                {
                    response.CodigoError = HttpStatusCode.NoContent.ToString();
                    response.MensajeError = "Producto no existe para la bodega seleccionada!";
                }
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Grabar_GuiaRemision(GuiaRemision_Info Info)
        {
            Response_Info response = new Response_Info();

            try
            {
                string MensajeError = "";

                in_GuiaRemision_Bus Bus_GuiaRemision = new in_GuiaRemision_Bus();
                in_GuiaRemision_Info Info_GuiaRemision = new in_GuiaRemision_Info();

                //CABECERA DE GUIA
                #region cabecera
                Info_GuiaRemision.IdEmpresa = Info.IdEmpresa;
                Info_GuiaRemision.IdSucursal = Info.IdSucursal;
                Info_GuiaRemision.IdGuiaRemision = Info.IdGuiaRemision;
                Info_GuiaRemision.IdBodega = Info.IdBodega;
                Info_GuiaRemision.FechaEmision = Convert.ToDateTime(Info.FechaEmision);
                Info_GuiaRemision.FechaTrasladoIni = Convert.ToDateTime(Info.FechaTrasladoIni);
                Info_GuiaRemision.FechaTrasladoFin = Convert.ToDateTime(Info.FechaTrasladoFin);
                Info_GuiaRemision.Serie1 = Info.Serie1;
                Info_GuiaRemision.Serie2 = Info.Serie2;
                Info_GuiaRemision.NumDocumento = Info.NumDocumento;
                Info_GuiaRemision.IdTipo_Persona = Info.IdTipo_Persona;
                Info_GuiaRemision.IdEntidad = Info.IdEntidad;
                Info_GuiaRemision.IdCentroCosto = Info.IdCentroCosto;
                Info_GuiaRemision.Origen = Info.Origen;
                Info_GuiaRemision.Destino = Info.Destino;
                Info_GuiaRemision.Observacion = Info.Observacion;
                Info_GuiaRemision.IdMotivo = Info.IdMotivo;
                Info_GuiaRemision.Estado = Info.Estado;
                Info_GuiaRemision.IdUsuarioCreacion = Info.IdUsuarioCreacion;
                Info_GuiaRemision.FechaCreacion = Convert.ToDateTime(Info.FechaCreacion);
                Info_GuiaRemision.IdTransportista = Info.IdTransportista;
                Info_GuiaRemision.Placa = Info.Placa;
                Info_GuiaRemision.Ruta = Info.Ruta;
                Info_GuiaRemision.Correo = Info.Correo;

                #endregion

                //DETALLE DE GUIA
                #region detalle guia
                foreach (var item in Info.GuiaRemision_Det)
                {
                    in_GuiaRemision_Det_Info Info_Det = new in_GuiaRemision_Det_Info();
                    Info_Det.IdEmpresa = item.IdEmpresa;
                    Info_Det.IdSucursal = item.IdSucursal;
                    Info_Det.IdGuiaRemision = item.IdGuiaRemision;
                    Info_Det.Secuencia = item.Secuencia;
                    Info_Det.IdProducto = item.IdProducto;
                    Info_Det.Codigo = item.Codigo;
                    Info_Det.Descripcion = item.Descripcion;
                    Info_Det.Detalle_x_Item = item.Detalle_x_Item;
                    Info_Det.IdCentroCosto = item.IdCentroCosto;
                    Info_Det.Peso = item.Peso;
                    Info_Det.Cantidad = item.Cantidad;
                    Info_Det.IdUnidadMedida = item.IdUnidadMedida;
                    Info_Det.Cantidad_sinConversion = item.Cantidad_sinConversion;
                    Info_Det.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;

                    Info_GuiaRemision.in_GuiaRemision_Det.Add(Info_Det);
                }
                #endregion

                if (!Bus_GuiaRemision.GrabarDB(Info_GuiaRemision, ref MensajeError))
                {
                    response.CodigoError = HttpStatusCode.Forbidden.ToString();
                    response.MensajeError = MensajeError;
                }
                else
                {
                    Info.IdGuiaRemision = Info_GuiaRemision.IdGuiaRemision;
                }

                response.Data = JsonConvert.SerializeObject(Info_GuiaRemision);
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Get_All_GuiaRemision(int IdEmpresa, string FechaIni, string FechaFin)
        {
            Response_Info response = new Response_Info();

            try
            {
                List<GuiaRemision_Info> Lista = new List<GuiaRemision_Info>();
                List<in_GuiaRemision_Info> List_GuiaRemision = new List<in_GuiaRemision_Info>();
                in_GuiaRemision_Bus Bus_GuiaRemision = new in_GuiaRemision_Bus();

                DateTime dFechaIni = Convert.ToDateTime(FechaIni);
                DateTime dFechaFin = Convert.ToDateTime(FechaFin);

                List_GuiaRemision = Bus_GuiaRemision.Get_List(IdEmpresa, dFechaIni, dFechaFin);

                foreach (var item in List_GuiaRemision)
                {
                    GuiaRemision_Info Info = new GuiaRemision_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdGuiaRemision = item.IdGuiaRemision;
                    Info.IdBodega = item.IdBodega;
                    Info.FechaEmision = Convert.ToString(item.FechaEmision);
                    Info.FechaTrasladoIni = Convert.ToString(item.FechaTrasladoIni);
                    Info.FechaTrasladoFin = Convert.ToString(item.FechaTrasladoFin);
                    Info.Serie1 = item.Serie1;
                    Info.Serie2 = item.Serie2;
                    Info.NumDocumento = item.NumDocumento;
                    Info.IdTipo_Persona = item.IdTipo_Persona;
                    Info.IdEntidad = item.IdEntidad;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.Origen = item.Origen;
                    Info.Destino = item.Destino;
                    Info.Observacion = item.Observacion;
                    Info.IdMotivo = item.IdMotivo;
                    Info.Estado = item.Estado;
                    Info.IdUsuarioCreacion = item.IdUsuarioCreacion;
                    Info.FechaCreacion = Convert.ToString(item.FechaCreacion);
                    Info.IdTransportista = item.IdTransportista;
                    Info.Placa = item.Placa;
                    Info.Ruta = item.Ruta;
                    Info.Correo = item.Correo;

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

        public Response_Info Generar_XML_GuiaRemision(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            Response_Info response = new Response_Info();

            try
            {
                string mensaje = "";
                in_GuiaRemision_Bus Bus_GuiaRemision = new in_GuiaRemision_Bus();
                in_GuiaRemision_Info Info_GuiaRemision = new in_GuiaRemision_Info();

                if (Bus_GuiaRemision.Generar_Guardar_Xml_Guia(IdEmpresa, IdSucursal, IdGuiaRemision, ref mensaje))
                {
                    in_Parametro_Bus Bus_Inventario = new in_Parametro_Bus();
                    in_Parametro_Info Info_Parametro = new in_Parametro_Info();
                    string RutaDescarga = "";

                    Info_Parametro = Bus_Inventario.Get_Info_Parametro(IdEmpresa);

                    if (Info_Parametro != null)
                    {
                        RutaDescarga = Info_Parametro.pa_ruta_descarga_xml_guia_elct;
                    }

                    mensaje = "xml generado con éxito en la ruta " + RutaDescarga;
                }

                response.Data = mensaje;
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Validar_Stock(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, double dCantidad)
        {
            Response_Info response = new Response_Info();

            try
            {
                in_GuiaRemision_Bus Bus_GuiaRemision = new in_GuiaRemision_Bus();

                response.Data = Bus_GuiaRemision.Validar_Stock(IdEmpresa, IdSucursal, IdBodega, IdProducto, dCantidad);
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Get_GuiaRemision(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            Response_Info response = new Response_Info();

            try
            {
                in_GuiaRemision_Bus Bus_GuiaRemision = new in_GuiaRemision_Bus();
                in_GuiaRemision_Det_Bus Bus_GuiaRemision_Det = new in_GuiaRemision_Det_Bus();
                in_GuiaRemision_Info Info = new in_GuiaRemision_Info();
                GuiaRemision_Info GuiaRemision = new GuiaRemision_Info();

                Info = Bus_GuiaRemision.Get_GuiaRemision(IdEmpresa, IdSucursal, IdGuiaRemision);

                if (Info != null)
                {
                    GuiaRemision.IdEmpresa = Info.IdEmpresa;
                    GuiaRemision.IdSucursal = Info.IdSucursal;
                    GuiaRemision.IdGuiaRemision = Info.IdGuiaRemision;
                    GuiaRemision.IdBodega = Info.IdBodega;
                    GuiaRemision.FechaEmision = Convert.ToString(Info.FechaEmision);
                    GuiaRemision.FechaTrasladoIni = Convert.ToString(Info.FechaTrasladoIni);
                    GuiaRemision.FechaTrasladoFin = Convert.ToString(Info.FechaTrasladoFin);
                    GuiaRemision.Serie1 = Info.Serie1;
                    GuiaRemision.Serie2 = Info.Serie2;
                    GuiaRemision.NumDocumento = Info.NumDocumento;
                    GuiaRemision.IdTipo_Persona = Info.IdTipo_Persona;
                    GuiaRemision.IdEntidad = Info.IdEntidad;
                    GuiaRemision.IdCentroCosto = Info.IdCentroCosto;
                    GuiaRemision.Origen = Info.Origen;
                    GuiaRemision.Destino = Info.Destino;
                    GuiaRemision.Observacion = Info.Observacion;
                    GuiaRemision.IdMotivo = Info.IdMotivo;
                    GuiaRemision.Estado = Info.Estado;
                    GuiaRemision.IdUsuarioCreacion = Info.IdUsuarioCreacion;
                    GuiaRemision.FechaCreacion = Convert.ToString(Info.FechaCreacion);
                    GuiaRemision.IdTransportista = Info.IdTransportista;
                    GuiaRemision.Placa = Info.Placa;
                    GuiaRemision.Ruta = Info.Ruta;
                    GuiaRemision.Correo = Info.Correo;
                    GuiaRemision.CedulaRuc = Info.pe_cedulaRuc;
                    GuiaRemision.GuiaRemision_Det = new List<GuiaRemision_Det_Info>();
                    GuiaRemision.CodigoError = "";
                    GuiaRemision.MensajeError = "";
                    GuiaRemision.Options = "";                    
                    
                    Info.in_GuiaRemision_Det = Bus_GuiaRemision_Det.Get_List(Info.IdEmpresa, Info.IdSucursal, Info.IdGuiaRemision);

                    foreach (var item in Info.in_GuiaRemision_Det)
                    {
                        GuiaRemision_Det_Info Info_Det = new GuiaRemision_Det_Info();
                        Info_Det.IdEmpresa = item.IdEmpresa;
                        Info_Det.IdSucursal = item.IdSucursal;
                        Info_Det.IdGuiaRemision = item.IdGuiaRemision;
                        Info_Det.Secuencia = item.Secuencia;
                        Info_Det.IdProducto = item.IdProducto;
                        Info_Det.Codigo = item.Codigo;
                        Info_Det.Descripcion = item.Descripcion;
                        Info_Det.Detalle_x_Item = item.Detalle_x_Item;
                        Info_Det.Peso = item.Peso;
                        Info_Det.Cantidad = item.Cantidad;
                        Info_Det.IdUnidadMedida = item.IdUnidadMedida;
                        Info_Det.Cantidad_sinConversion = item.Cantidad_sinConversion;
                        Info_Det.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                        Info_Det.IdCentroCosto = item.IdCentroCosto;

                        GuiaRemision.GuiaRemision_Det.Add(Info_Det);
                    }
                }
                else
                {
                    throw new Exception("No se encontro informacion en la base de datos!");
                }

                response.Data = JsonConvert.SerializeObject(GuiaRemision);
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