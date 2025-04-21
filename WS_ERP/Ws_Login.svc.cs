using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using System.Net;
using WS_ERP.Info;
using System.Xml;
using Newtonsoft.Json;

namespace WS_ERP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Ws_Login" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Ws_Login.svc o Ws_Login.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Ws_Login : IWs_Login
    {
        seg_usuario_bus Bus_Usuario;

        public Ws_Login()
        {
            Bus_Usuario = new seg_usuario_bus();
        }

        public Response_Info Login(string IdUsuario, string Contrasena)
        {
            Response_Info response = new Response_Info();

            try
            {
                Usuario_Info Info = new Usuario_Info();
                string mensajeError = "";                

                bool consulta = Bus_Usuario.Existe_Usuario(IdUsuario, ref mensajeError);               

                if (consulta)
                {
                    if (mensajeError.Equals(""))
                    {
                        seg_usuario_info Info_Usuario = new seg_usuario_info();
                        Info_Usuario.IdUsuario = IdUsuario;
                        Info_Usuario.Contrasena = Contrasena;

                        if (Bus_Usuario.Validar_Credenciales(Info_Usuario, ref mensajeError))
                        {
                            if (Info_Usuario.CambiarContraseniaSgtSesion == true)
                            {
                                response.CodigoError = HttpStatusCode.Unauthorized.ToString();
                                response.MensajeError = "Se debe cambiar la contasena!";
                            }
                            else
                            {
                                Info_Usuario = Bus_Usuario.Get_Info_Usuario(Info_Usuario.IdUsuario, ref mensajeError);

                                if (Info_Usuario != null)
                                {
                                    Info.IdUsuario = Info_Usuario.IdUsuario;
                                    Info.Contrasena = Info_Usuario.Contrasena;
                                    Info.estado = Info_Usuario.estado;
                                    Info.Nombre = Info_Usuario.Nombre;

                                    response.Data = JsonConvert.SerializeObject(Info);
                                }
                            }
                        }
                        else
                        {
                            response.CodigoError = HttpStatusCode.Unauthorized.ToString();
                            response.MensajeError = "La contraseña ingresada no es la correcta";
                        }

                    }
                    else
                    {
                        response.CodigoError = HttpStatusCode.Unauthorized.ToString();
                        response.MensajeError = "El usuario " + IdUsuario + " no existe";
                    }
                }
                else
                {
                    response.CodigoError = HttpStatusCode.Forbidden.ToString();
                    response.MensajeError = mensajeError;
                }
            }
            catch (Exception ex)
            {
                response.CodigoError = HttpStatusCode.Unauthorized.ToString();
                response.MensajeError = "Error: " + ex.Message;                 
            }

            return response;
        }

        public Response_Info Login_x_Empresa(int IdEmpresa, string IdUsuario, string Contrasena)
        {
            Response_Info response = new Response_Info();

            try
            {
                Usuario_Info Info = new Usuario_Info();
                string mensajeError = "";

                bool consulta = Bus_Usuario.Existe_Usuario(IdUsuario, ref mensajeError);

                if (consulta)
                {
                    if (mensajeError.Equals(""))
                    {
                        tb_Empresa_Bus Bus_Empresa = new tb_Empresa_Bus();
                        List<tb_Empresa_Info> List_Empresa = new List<tb_Empresa_Info>();

                        if (Bus_Empresa.Existe_Usuario_x_Empresa(IdEmpresa, IdUsuario))
                        {
                            seg_usuario_info Info_Usuario = new seg_usuario_info();
                            Info_Usuario.IdUsuario = IdUsuario;
                            Info_Usuario.Contrasena = Contrasena;

                            if (Bus_Usuario.Validar_Credenciales(Info_Usuario, ref mensajeError))
                            {
                                if (Info_Usuario.CambiarContraseniaSgtSesion == true)
                                {
                                    response.CodigoError = HttpStatusCode.Unauthorized.ToString();
                                    response.MensajeError = "Se debe cambiar la contasena!";
                                }
                                else
                                {
                                    Info_Usuario = Bus_Usuario.Get_Info_Usuario(Info_Usuario.IdUsuario, ref mensajeError);

                                    if (Info_Usuario != null)
                                    {
                                        Info.IdEmpresa = IdEmpresa;
                                        Info.IdUsuario = Info_Usuario.IdUsuario;
                                        Info.Contrasena = Info_Usuario.Contrasena;
                                        Info.estado = Info_Usuario.estado;
                                        Info.Nombre = Info_Usuario.Nombre;

                                        response.Data = JsonConvert.SerializeObject(Info);
                                    }
                                }
                            }
                            else
                            {
                                response.CodigoError = HttpStatusCode.Unauthorized.ToString();
                                response.MensajeError = "La contraseña ingresada no es la correcta";
                            }
                        }
                        else
                        {
                            response.CodigoError = HttpStatusCode.Unauthorized.ToString();
                            response.MensajeError = "El usuario " + IdUsuario + " no existe no tiene acceso a la empresa seleccionada";
                        }
                    }
                    else
                    {
                        response.CodigoError = HttpStatusCode.Unauthorized.ToString();
                        response.MensajeError = "El usuario " + IdUsuario + " no existe";
                    }
                }
                else
                {
                    response.CodigoError = HttpStatusCode.Forbidden.ToString();
                    response.MensajeError = mensajeError;
                }
            }
            catch (Exception ex)
            {
                response.CodigoError = HttpStatusCode.Unauthorized.ToString();
                response.MensajeError = "Error: " + ex.Message;
            }

            return response;
        }        
    }
}