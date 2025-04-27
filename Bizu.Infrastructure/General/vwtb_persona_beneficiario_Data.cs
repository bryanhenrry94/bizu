using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class vwtb_persona_beneficiario_Data
    {
        string mensaje = "";
        public List<vwtb_persona_beneficiario_Info> Get_List_PersonaBeneficiario(int IdEmpresa)
        {
            try
            {
                List<vwtb_persona_beneficiario_Info> lM = new List<vwtb_persona_beneficiario_Info>();
                EntitiesGeneral OEUs = new EntitiesGeneral();

                var selectBeneficiario = from selec in OEUs.vwtb_persona_beneficiario
                                         where selec.idempresa == IdEmpresa
                                         select selec;

                foreach (var item in selectBeneficiario)
                {
                    vwtb_persona_beneficiario_Info info = new vwtb_persona_beneficiario_Info();
                    info.IdEmpresa = item.idempresa;
                    info.IdBeneficiario = item.idbeneficiario;
                    info.IdTipo_Persona = item.idtipo_persona;
                    info.IdPersona = item.idpersona;
                    info.IdEntidad = item.identidad;
                    info.Codigo = item.codigo;
                    info.Nombre = item.nombre;
                    info.pr_girar_cheque_a = item.pr_girar_cheque_a;
                    info.pe_razonSocial = item.pe_razonsocial;
                    info.pe_cedulaRuc = item.pe_cedularuc;
                    info.pe_Naturaleza = item.pe_naturaleza;
                    info.IdCtaCble = item.idctacble;
                    info.NombreCompleto = "[" + info.IdTipo_Persona + "]" + "[" + item.identidad + "]" + "[" + item.nombre + "]";
                    info.IdCtaCble_Anticipo = item.idctacble_anticipo;
                    info.IdCtaCble_Gasto = item.idctacble_gasto;
                    info.Estado = item.estado;

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<vwtb_persona_beneficiario_Info> Get_List_PersonaBeneficiario(int IdEmpresa, string IdTipo_Persona)
        {
            try
            {
                if (IdTipo_Persona == "TODOS")
                {
                    IdTipo_Persona = "";
                }


                List<vwtb_persona_beneficiario_Info> lM = new List<vwtb_persona_beneficiario_Info>();
                EntitiesGeneral OEUs = new EntitiesGeneral();
                var selectBeneficiario = from selec in OEUs.vwtb_persona_beneficiario
                                         where selec.idempresa == IdEmpresa
                                         && selec.idtipo_persona.Contains(IdTipo_Persona)
                                         select selec;

                foreach (var item in selectBeneficiario)
                {
                    vwtb_persona_beneficiario_Info info = new vwtb_persona_beneficiario_Info();
                    info.IdEmpresa = item.idempresa;
                    info.IdBeneficiario = item.idbeneficiario;
                    info.IdTipo_Persona = item.idtipo_persona;
                    info.IdPersona = item.idpersona;
                    info.IdEntidad = item.identidad;
                    info.Codigo = item.codigo;
                    info.Nombre = item.nombre;
                    info.pr_girar_cheque_a = item.pr_girar_cheque_a;
                    info.pe_razonSocial = item.pe_razonsocial;
                    info.pe_cedulaRuc = item.pe_cedularuc;
                    info.pe_Naturaleza = item.pe_naturaleza;
                    info.IdCtaCble = item.idctacble;
                    info.NombreCompleto = "[" + info.IdTipo_Persona + "]" + "[" + item.identidad + "]" + "[" + item.nombre + "]";
                    info.IdCtaCble_Anticipo = item.idctacble_anticipo;
                    info.IdCtaCble_Gasto = item.idctacble_gasto;
                    info.Estado = item.estado;

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public vwtb_persona_beneficiario_Info Get_Info_PersonaBeneficiario(int IdEmpresa, decimal IdEntidad, string IdTipo_Persona)
        {
            try
            {
                vwtb_persona_beneficiario_Info info = new vwtb_persona_beneficiario_Info();
                EntitiesGeneral OEUser = new EntitiesGeneral();

                var selectBeneficiario = from selec in OEUser.vwtb_persona_beneficiario
                                         where selec.idempresa == IdEmpresa
                                         && selec.identidad == IdEntidad
                                         && selec.idtipo_persona == IdTipo_Persona
                                         select selec;

                foreach (var item in selectBeneficiario)
                {
                    info.IdEmpresa = item.idempresa;
                    info.IdBeneficiario = item.idbeneficiario;
                    info.IdTipo_Persona = item.idtipo_persona;
                    info.IdPersona = item.idpersona;
                    info.IdEntidad = item.identidad;
                    info.Codigo = item.codigo;
                    info.Nombre = item.nombre;
                    info.pr_girar_cheque_a = item.pr_girar_cheque_a;
                    info.pe_razonSocial = item.pe_razonsocial;
                    info.pe_cedulaRuc = item.pe_cedularuc;
                    info.pe_Naturaleza = item.pe_naturaleza;
                    info.IdCtaCble = item.idctacble;
                    info.NombreCompleto = "[" + info.IdTipo_Persona + "]" + "[" + item.identidad + "]" + "[" + item.nombre + "]";
                    info.IdCtaCble_Anticipo = item.idctacble_anticipo;
                    info.IdCtaCble_Gasto = item.idctacble_gasto;
                    info.Estado = item.estado;
                }

                return (info);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<vwtb_persona_beneficiario_Info> Get_List_Datos_Beneficiarios(int IdEmpresa)
        {
            List<vwtb_persona_beneficiario_Info> lM = new List<vwtb_persona_beneficiario_Info>();

            try
            {
                EntitiesGeneral OEUs = new EntitiesGeneral();
                {
                    lM = (from q in OEUs.vwtb_persona_beneficiario_por_banco_acreditacion
                          where q.idempresa == IdEmpresa

                          select new vwtb_persona_beneficiario_Info
                          {
                              IdEmpresa = q.idempresa,
                              IdEntidad = q.identidad,
                              IdPersona = q.idpersona,
                              IdTipo_Persona = q.idtipo_persona,
                              pe_cedulaRuc = q.pe_cedularuc,
                              ba_descripcion = q.ba_descripcion,
                              IdTipoDocumento = q.idtipodocumento,
                              CodigoLegal = q.codigolegal,
                              num_cta_acreditacion = q.num_cta_acreditacion,
                              IdTipoCta_acreditacion_cat = q.idtipocta_acreditacion_cat
                          }).ToList();
                }

                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}