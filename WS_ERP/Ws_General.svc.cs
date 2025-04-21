using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using WS_ERP.Info;
using Newtonsoft.Json;

namespace WS_ERP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Ws_General" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Ws_General.svc o Ws_General.svc.cs en el Explorador de soluciones e inicie la depuración.

    public class Ws_General : IWs_General
    {
        public Response_Info Transportista_Grabar(Transportista_Info Info) 
        {
            Response_Info response = new Response_Info();

            try
            {
                if (Info == null)
                {
                    throw new Exception("El parametro Info esta vacio");
                }

                tb_transportista_Bus Bus_Transportista = new tb_transportista_Bus();
                tb_transportista_Info Info_Transportista = new tb_transportista_Info();
                decimal IdTransportista = 0;

                Info_Transportista.IdEmpresa = Info.IdEmpresa;
                Info_Transportista.IdTransportista = Info.IdTransportista;
                Info_Transportista.IdTipoDocumento = Info.IdTipoDocumento;
                Info_Transportista.Cedula = Info.Cedula;
                Info_Transportista.Nombre = Info.Nombre;
                Info_Transportista.Estado = Info.Estado;
                Info_Transportista.IdUsuario = Info.IdUsuario;
                Info_Transportista.Fecha_Transaccion = DateTime.Now;
                Info_Transportista.Placa = Info.Placa;

                if (Bus_Transportista.GuardarDB(Info_Transportista, ref IdTransportista))
                {
                    response.Data = "Transportista Id#" + IdTransportista + " registrado con éxito";
                }
            }
            catch (Exception ex)
            {
                response.CodigoError = "2000";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Transportista_Actualizar(Transportista_Info Info)
        {
            Response_Info response = new Response_Info();

            try
            {
                if (Info == null)
                {
                    throw new Exception("El parametro Info esta vacio");
                }

                tb_transportista_Bus Bus_Transportista = new tb_transportista_Bus();
                tb_transportista_Info Info_Transportista = new tb_transportista_Info();

                Info_Transportista = Bus_Transportista.Get_Info_Transportista(Info.IdEmpresa, Info.IdTransportista);

                if (Info_Transportista != null)
                {
                    Info_Transportista.IdEmpresa = Info.IdEmpresa;
                    Info_Transportista.IdTransportista = Info.IdTransportista;
                    Info_Transportista.IdTipoDocumento = Info.IdTipoDocumento;
                    Info_Transportista.Cedula = Info.Cedula;
                    Info_Transportista.Nombre = Info.Nombre;
                    Info_Transportista.Estado = Info.Estado;
                    Info_Transportista.Placa = Info.Placa;
                    Info_Transportista.IdUsuarioUltModi = Info.IdUsuarioUltMod;
                    Info_Transportista.Fecha_UltMod = DateTime.Now;

                    if (Bus_Transportista.ModificarDB(Info_Transportista))
                    {
                        response.Data = "Transportista Id#" + Info_Transportista.IdTransportista + " actualizado con éxito";
                    }
                }
                else
                {
                    throw new Exception("No se encontro transportista con ID#" + Info.IdTransportista);
                }
            }
            catch (Exception ex)
            {
                response.CodigoError = "2000";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Transportista_Anular(int IdEmpresa, decimal IdTransportista, string IdUsuarioAnul, string MotivoAnul)
        {
            Response_Info response = new Response_Info();

            try
            {
                if (IdEmpresa <= 0)
                {
                    throw new Exception("El parametro IdEmpresa no es valido!");
                }

                if (IdTransportista <= 0)
                {
                    throw new Exception("El parametro IdTransportista no es valido!");
                }

                if (IdUsuarioAnul == "")
                {
                    throw new Exception("El parametro IdUsuarioAnul es requerido!");
                }

                if (MotivoAnul == "")
                {
                    throw new Exception("El parametro MotivoAnul es requerido!");
                }

                tb_transportista_Bus Bus_Transportista = new tb_transportista_Bus();
                tb_transportista_Info Info_Transportista = new tb_transportista_Info();

                Info_Transportista = Bus_Transportista.Get_Info_Transportista(IdEmpresa, IdTransportista);

                if (Info_Transportista != null)
                {
                    Info_Transportista.IdUsuarioUltAnu = IdUsuarioAnul;
                    Info_Transportista.MotivoAnulacion = MotivoAnul;
                    Info_Transportista.Fecha_UltAnu = DateTime.Now;

                    if (Bus_Transportista.AnularDB(Info_Transportista))
                    {
                        response.Data = "Transportista ID#" + IdTransportista + " anulado con éxito";
                    }
                }
                else
                {
                    throw new Exception("No se encontro información de transportista con Id#" + IdTransportista);
                }
            }
            catch (Exception ex)
            {
                response.CodigoError = "2000";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Transportista_GetAllByIdEmpresa(int IdEmpresa)
        {
            Response_Info response = new Response_Info();

            try
            {
                List<Transportista_Info> Lista = new List<Transportista_Info>();
                List<tb_transportista_Info> List_Transportista = new List<tb_transportista_Info>();
                tb_transportista_Bus Bus_Transportista = new tb_transportista_Bus();

                List_Transportista = Bus_Transportista.Get_List_transportista(IdEmpresa);

                foreach (var item in List_Transportista)
                {
                    Transportista_Info Info = new Transportista_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdTransportista = item.IdTransportista;
                    Info.IdTipoDocumento = item.IdTipoDocumento;
                    Info.IdPersona = item.IdPersona;
                    Info.Estado = item.Estado;
                    Info.Nombre = item.Nombre;
                    Info.Cedula = item.Cedula;
                    Info.Placa = item.Placa;
                    Info.pe_nombreCompleto = item.pe_nombreCompleto;

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

        public Response_Info Transportista_GetOneByIdTransportista(int IdEmpresa, decimal IdTransportista)
        {
            Response_Info response = new Response_Info();

            try
            {
                Transportista_Info Info = new Transportista_Info();
                tb_transportista_Bus Bus_Transportista = new tb_transportista_Bus();

                tb_transportista_Info Info_Transportista = Bus_Transportista.Get_Info_Transportista(IdEmpresa, IdTransportista);

                if (Info_Transportista != null)
                {
                    Info.IdEmpresa = Info_Transportista.IdEmpresa;
                    Info.IdTransportista = Info_Transportista.IdTransportista;
                    Info.IdTipoDocumento = Info_Transportista.IdTipoDocumento;
                    Info.IdPersona = Info_Transportista.IdPersona;
                    Info.Estado = Info_Transportista.Estado;
                    Info.Nombre = Info_Transportista.Nombre;
                    Info.Cedula = Info_Transportista.Cedula;
                    Info.Placa = Info_Transportista.Placa;
                    Info.pe_nombreCompleto = Info_Transportista.pe_nombreCompleto;
                }

                response.Data = JsonConvert.SerializeObject(Info);
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Get_Ultimo_Talonario_No_Usado(int IdEmpresa, string establecimiento, string puntoemision, string tipodoc, bool Es_Documento_Electronico)
        {
            Response_Info response = new Response_Info();

            try
            {
                Talonario_Info Info = new Talonario_Info();
                tb_sis_Documento_Tipo_Talonario_Bus busTipoDoc = new tb_sis_Documento_Tipo_Talonario_Bus();

                if(puntoemision == "001") puntoemision = "002";

                tb_sis_Documento_Tipo_Talonario_Info DocumentoTalonario_Info = busTipoDoc.Get_Info_Primer_Documento_no_usado(IdEmpresa, establecimiento, puntoemision, tipodoc, Es_Documento_Electronico);

                if (DocumentoTalonario_Info != null)
                {
                    Info.IdEmpresa = DocumentoTalonario_Info.IdEmpresa;
                    Info.CodDocumentoTipo = DocumentoTalonario_Info.CodDocumentoTipo;

                    //************************************************************************
                    //Info.Establecimiento = DocumentoTalonario_Info.Establecimiento;
                    //Info.PuntoEmision = DocumentoTalonario_Info.PuntoEmision;
                    Info.Establecimiento = DocumentoTalonario_Info.PuntoEmision;
                    Info.PuntoEmision = DocumentoTalonario_Info.Establecimiento;

                    //CAMBIADO TEMPORALMENTE POR NO PODER MODIFICAR EL LECTOR DE QR 4-FEB-2020
                    //************************************************************************

                    Info.NumDocumento = DocumentoTalonario_Info.NumDocumento;
                    Info.FechaCaducidad = DocumentoTalonario_Info.FechaCaducidad;
                    Info.Usado = DocumentoTalonario_Info.Usado;
                    Info.Estado = DocumentoTalonario_Info.Estado;
                    Info.IdSucursal = DocumentoTalonario_Info.IdSucursal;
                    Info.NumAutorizacion = DocumentoTalonario_Info.NumAutorizacion;
                    Info.NombreSucursal = DocumentoTalonario_Info.NombreSucursal;
                    Info.NombreEmpresa = DocumentoTalonario_Info.NombreEmpresa;
                    Info.es_Documento_electronico = DocumentoTalonario_Info.es_Documento_electronico;
                }

                response.Data = JsonConvert.SerializeObject(Info);
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info PersonaTipo_GetAll()
        {
            Response_Info response = new Response_Info();

            try
            {
                List<PersonaTipo_Info> Lista = new List<PersonaTipo_Info>();
                tb_persona_tipo_Bus Bus_PersonaTipo = new tb_persona_tipo_Bus();
                List<tb_persona_tipo_Info> List_PersonaTipo = new List<tb_persona_tipo_Info>();

                List_PersonaTipo = Bus_PersonaTipo.Get_List_persona_tipo();

                foreach (var item in List_PersonaTipo)
                {
                    PersonaTipo_Info Info = new PersonaTipo_Info();
                    Info.IdTipo_Persona = item.IdTipo_Persona;
                    Info.Descripcion = item.Descripcion;

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

        public Response_Info Beneficiario_GetAllByIdTipoPersona(int IdEmpresa, string IdTipoPersona)
        {
            Response_Info response = new Response_Info();

            try
            {
                List<Beneficiario_Info> Lista = new List<Beneficiario_Info>();
                vwtb_persona_beneficiario_Bus Bus_Persona_Beneficiario = new vwtb_persona_beneficiario_Bus();
                List<vwtb_persona_beneficiario_Info> list_Beneficiario = new List<vwtb_persona_beneficiario_Info>();                

                list_Beneficiario = Bus_Persona_Beneficiario.Get_List_PersonaBeneficiario(IdEmpresa, IdTipoPersona);

                foreach (var item in list_Beneficiario)
                {
                    Beneficiario_Info Info = new Beneficiario_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdBeneficiario = item.IdBeneficiario;
                    Info.IdTipo_Persona = item.IdTipo_Persona;
                    Info.IdPersona = item.IdPersona;
                    Info.IdEntidad = item.IdEntidad;
                    Info.Codigo = item.Codigo;
                    Info.Nombre = item.Nombre;
                    Info.pr_girar_cheque_a = item.pr_girar_cheque_a;
                    Info.pe_razonSocial = item.pe_razonSocial;
                    Info.pe_cedulaRuc = item.pe_cedulaRuc;
                    Info.pe_Naturaleza = item.pe_Naturaleza;
                    Info.IdCtaCble = item.IdCtaCble;
                    Info.IdCentroCosto = item.IdCentroCosto;
                    Info.IdSubCentroCosto = item.IdSubCentroCosto;
                    Info.secuencial = item.secuencial;
                    Info.NombreCompleto = item.NombreCompleto;
                    Info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                    Info.IdCtaCble_Gasto = item.IdCtaCble_Gasto;
                    Info.Estado = item.Estado;
                    Info.ba_descripcion = item.ba_descripcion;
                    Info.num_cta_acreditacion = item.num_cta_acreditacion;
                    Info.IdTipoCta_acreditacion_cat = item.IdTipoCta_acreditacion_cat;
                    Info.IdTipoDocumento = item.IdTipoDocumento;
                    Info.CodigoLegal = item.CodigoLegal;
                    Info.datosEdhesa = item.datosEdhesa;
                    Info.pe_correo = item.pe_correo;

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

        public Response_Info Persona_GetOneByIdPersona(decimal IdPersona)
        {
            Response_Info response = new Response_Info();

            try
            {
                Persona_Info Info = new Persona_Info();
                tb_persona_bus Bus_Persona = new tb_persona_bus();
                tb_persona_Info Info_Persona = new tb_persona_Info();

                Info_Persona = Bus_Persona.Get_Info_Persona(IdPersona);

                if (Info_Persona != null)
                {
                    Info.IdEmpresa = Info_Persona.IdEmpresa;
                    Info.IdPersona = Info_Persona.IdPersona;
                    Info.CodPersona = Info_Persona.CodPersona;
                    Info.pe_Naturaleza = Info_Persona.pe_Naturaleza;
                    Info.pe_nombreCompleto = Info_Persona.pe_nombreCompleto;
                    Info.pe_razonSocial = Info_Persona.pe_razonSocial;
                    Info.pe_apellido = Info_Persona.pe_apellido;
                    Info.pe_nombre = Info_Persona.pe_nombre;
                    Info.IdTipoPersona = Info_Persona.IdTipoPersona;
                    Info.IdTipoDocumento = Info_Persona.IdTipoDocumento;
                    Info.pe_cedulaRuc = Info_Persona.pe_cedulaRuc;
                    Info.pe_direccion = Info_Persona.pe_direccion;
                    Info.pe_telefonoCasa = Info_Persona.pe_telefonoCasa;
                    Info.pe_telefonoOfic = Info_Persona.pe_telefonoOfic;
                    Info.pe_telefonoInter = Info_Persona.pe_telefonoInter;
                    Info.pe_telfono_Contacto = Info_Persona.pe_telfono_Contacto;
                    Info.pe_celular = Info_Persona.pe_celular;
                    Info.pe_correo = Info_Persona.pe_correo;
                }

                response.Data = JsonConvert.SerializeObject(Info);
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Persona_GetOneByIdentificacion(string IdTipoDocumento, string CedulaRuc)
        {
            Response_Info response = new Response_Info();

            try
            {
                Persona_Info Info = new Persona_Info();
                tb_persona_bus Bus_Persona = new tb_persona_bus();
                tb_persona_Info Info_Persona = new tb_persona_Info();

                Info_Persona = Bus_Persona.Get_Info_Persona(IdTipoDocumento, CedulaRuc);

                if (Info_Persona != null)
                {
                    Info.IdEmpresa = Info_Persona.IdEmpresa;
                    Info.IdPersona = Info_Persona.IdPersona;
                    Info.CodPersona = Info_Persona.CodPersona;
                    Info.pe_Naturaleza = Info_Persona.pe_Naturaleza;
                    Info.pe_nombreCompleto = Info_Persona.pe_nombreCompleto;
                    Info.pe_razonSocial = Info_Persona.pe_razonSocial;
                    Info.pe_apellido = Info_Persona.pe_apellido;
                    Info.pe_nombre = Info_Persona.pe_nombre;
                    Info.IdTipoPersona = Info_Persona.IdTipoPersona;
                    Info.IdTipoDocumento = Info_Persona.IdTipoDocumento;
                    Info.pe_cedulaRuc = Info_Persona.pe_cedulaRuc;
                    Info.pe_direccion = Info_Persona.pe_direccion;
                    Info.pe_telefonoCasa = Info_Persona.pe_telefonoCasa;
                    Info.pe_telefonoOfic = Info_Persona.pe_telefonoOfic;
                    Info.pe_telefonoInter = Info_Persona.pe_telefonoInter;
                    Info.pe_telfono_Contacto = Info_Persona.pe_telfono_Contacto;
                    Info.pe_celular = Info_Persona.pe_celular;
                    Info.pe_correo = Info_Persona.pe_correo;
                }

                response.Data = JsonConvert.SerializeObject(Info);
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Sucursal_GetAllByIdEmpresa(int IdEmpresa)
        {
            Response_Info response = new Response_Info();

            try
            {
                List<Sucursal_Info> Lista = new List<Sucursal_Info>();
                tb_Sucursal_Bus Bus_Sucursal = new tb_Sucursal_Bus();
                List<tb_Sucursal_Info> List_Sucursal = new List<tb_Sucursal_Info>();

                List_Sucursal = Bus_Sucursal.Get_List_Sucursal(IdEmpresa);

                foreach (var item in List_Sucursal)
                {
                    Sucursal_Info Info = new Sucursal_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.Su_Descripcion = item.Su_Descripcion;
                    Info.codigo = item.codigo;
                    Info.Su_CodigoEstablecimiento = item.Su_CodigoEstablecimiento;
                    Info.Su_Ubicacion = item.Su_Ubicacion;
                    Info.Su_Ruc = item.Su_Ruc;
                    Info.Su_JefeSucursal = item.Su_JefeSucursal;
                    Info.Su_Telefonos = item.Su_Telefonos;
                    Info.Su_Direccion = item.Su_Direccion;

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

        public Response_Info Empresa_GetAll()
        {
            Response_Info response = new Response_Info();

            try
            {
                List<Empresa_Info> List_Empresa = new List<Empresa_Info>();
                tb_Empresa_Bus Bus_Empresa = new tb_Empresa_Bus();
                List<tb_Empresa_Info> List_Empresa_Info = new List<tb_Empresa_Info>();
                List_Empresa_Info = Bus_Empresa.Get_List_Empresa();

                foreach (var Info_Empresa in List_Empresa_Info)
                {
                    Empresa_Info Info = new Empresa_Info();
                    Info.IdEmpresa = Info_Empresa.IdEmpresa;
                    Info.codigo = Info_Empresa.codigo;
                    Info.em_nombre = Info_Empresa.em_nombre;
                    Info.em_ruc = Info_Empresa.em_ruc;
                    Info.em_direccion = Info_Empresa.em_direccion;
                    Info.Estado = Info_Empresa.Estado;
                    Info.RazonSocial = Info_Empresa.RazonSocial;
                    Info.NombreComercial = Info_Empresa.nomCuenta;
                    Info.ContribuyenteEspecial = Info_Empresa.ContribuyenteEspecial;

                    List_Empresa.Add(Info);
                }

                response.Data = JsonConvert.SerializeObject(List_Empresa);
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Empresa_GetOneByIdEmpresa(int IdEmpresa)
        {
            Response_Info response = new Response_Info();

            try
            {
                Empresa_Info Info = new Empresa_Info();
                tb_Empresa_Bus Bus_Empresa = new tb_Empresa_Bus();
                tb_Empresa_Info Info_Empresa = new tb_Empresa_Info();
                Info_Empresa = Bus_Empresa.Get_Info_Empresa(IdEmpresa);

                if (Info_Empresa != null)
                {
                    Info = new Empresa_Info();
                    Info.IdEmpresa = Info_Empresa.IdEmpresa;
                    Info.codigo = Info_Empresa.codigo;
                    Info.em_nombre = Info_Empresa.em_nombre;
                    Info.em_ruc = Info_Empresa.em_ruc;
                    Info.em_direccion = Info_Empresa.em_direccion;
                    Info.Estado = Info_Empresa.Estado;
                    Info.RazonSocial = Info_Empresa.RazonSocial;
                    Info.NombreComercial = Info_Empresa.nomCuenta;
                    Info.ContribuyenteEspecial = Info_Empresa.ContribuyenteEspecial;
                }

                response.Data = JsonConvert.SerializeObject(Info);
            }
            catch (Exception ex)
            {
                response.CodigoError = "200";
                response.MensajeError = ex.Message;
            }

            return response;
        }

        public Response_Info Empresa_GetAllByIdUsuario(string IdUsuario)
        {
            Response_Info response = new Response_Info();

            try
            {
                List<Empresa_Info> Lista = new List<Empresa_Info>();
                tb_Empresa_Bus Bus_Empresa = new tb_Empresa_Bus();
                List<tb_Empresa_Info> le = new List<tb_Empresa_Info>();
                le = Bus_Empresa.Get_List_Empresa_x_Usuario(IdUsuario);

                foreach (var item in le)
                {
                    Empresa_Info Info = new Empresa_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.codigo = item.codigo;
                    Info.em_nombre = item.em_nombre;
                    Info.em_ruc = item.em_ruc;
                    Info.em_direccion = item.em_direccion;
                    Info.Estado = item.Estado;
                    Info.RazonSocial = item.RazonSocial;
                    Info.NombreComercial = item.NombreComercial;
                    Info.ContribuyenteEspecial = item.ContribuyenteEspecial;

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

        public Response_Info Bodega_GetAll(int IdEmpresa, int IdSucursal)
        {
            Response_Info response = new Response_Info();

            try
            {
                List<Bodega_Info> Lista = new List<Bodega_Info>();
                List<tb_Bodega_Info> List_Bodega = new List<tb_Bodega_Info>();
                tb_Bodega_Bus Bus_Bodega = new tb_Bodega_Bus();

                List_Bodega = Bus_Bodega.Get_List_Bodega(IdEmpresa, IdSucursal);

                foreach (var item in List_Bodega)
                {
                    Bodega_Info Info = new Bodega_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdBodega = item.IdBodega;
                    Info.IdSucursal = item.IdSucursal;
                    Info.cod_bodega = item.cod_bodega;
                    Info.bo_Descripcion = item.bo_Descripcion;
                    Info.bo_Descripcion2 = item.bo_Descripcion2;
                    Info.cod_punto_emision = item.cod_punto_emision;
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
    }
}
