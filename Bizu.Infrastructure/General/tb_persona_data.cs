using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using System.Data.Entity.Validation;

namespace Bizu.Infrastructure.General
{
    public class tb_persona_data
    {
        string mensaje = "";
        Boolean val = false;

        public List<tb_persona_Info> Get_List_Persona_x_Tipo(int IdTipoPersona)
        {
            try
            {
                List<tb_persona_Info> lst = new List<tb_persona_Info>();
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectPersona = from C in OEselecEmpresa.tb_persona
                                    where C.idtipopersona == IdTipoPersona
                                    select C;

                foreach (var item in selectPersona)
                {

                    tb_persona_Info Cbt = new tb_persona_Info();
                    Cbt.IdPersona = item.idpersona;
                    Cbt.IdEstadoCivil = item.idestadocivil.Trim();
                    Cbt.CodPersona = item.codpersona;
                    Cbt.IdTipoPersona = item.idtipopersona;
                    Cbt.pe_apellido = item.pe_apellido;
                    Cbt.pe_nombre = item.pe_nombre;
                    Cbt.pe_casilla = item.pe_casilla;
                    Cbt.pe_cedulaRuc = item.pe_cedularuc;
                    Cbt.pe_celular = item.pe_celular;
                    Cbt.pe_correo = item.pe_correo;
                    Cbt.pe_direccion = item.pe_direccion;
                    Cbt.pe_estado = item.pe_estado.Trim();
                    Cbt.pe_fax = item.pe_fax;
                    Cbt.pe_fechaCreacion = item.pe_fechacreacion;
                    Cbt.pe_fechaModificacion = item.pe_fechamodificacion;
                    Cbt.pe_fechaNacimiento = item.pe_fechanacimiento;
                    Cbt.pe_Naturaleza = item.pe_naturaleza.Trim();
                    Cbt.pe_nombreCompleto = item.pe_nombrecompleto.Trim();
                    Cbt.pe_razonSocial = item.pe_razonsocial;
                    Cbt.pe_sexo = item.pe_sexo.Trim();
                    Cbt.pe_telefonoCasa = item.pe_telefonocasa;
                    Cbt.pe_telefonoInter = item.pe_telefonointer;
                    Cbt.pe_telefonoOfic = item.pe_telefonoofic;
                    Cbt.pe_telfono_Contacto = item.pe_telfono_contacto;
                    Cbt.IdTipoDocumento = item.idtipodocumento.Trim();
                    Cbt.pe_UltUsuarioModi = item.pe_ultusuariomodi;
                    Cbt.pe_celularSecundario = item.pe_celularsecundario;
                    Cbt.pe_correo_secundario1 = item.pe_correo_secundario1;
                    Cbt.pe_correo_secundario2 = item.pe_correo_secundario2;
                    Cbt.IdTipoCta_acreditacion_cat = item.idtipocta_acreditacion_cat;
                    Cbt.num_cta_acreditacion = item.num_cta_acreditacion;
                    Cbt.IdBanco_acreditacion = item.idbanco_acreditacion;
                    Cbt.IdTipoDocumento_acreditacion = item.idtipodocumento_acreditacion;
                    Cbt.cedulaRuc_acreditacion = item.cedularuc_acreditacion;
                    Cbt.beneficiario_acreditacion = item.beneficiario_acreditacion;
                    Cbt.correo_acreditacion = item.correo_acreditacion;

                    lst.Add(Cbt);
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_persona_Info> Get_List_Persona()
        {
            try
            {

                List<tb_persona_Info> lM = new List<tb_persona_Info>();
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectPersona = from C in OEselecEmpresa.tb_persona
                                    select C;

                foreach (var item in selectPersona)
                {

                    tb_persona_Info Cbt = new tb_persona_Info();
                    Cbt.IdPersona = item.idpersona;
                    Cbt.IdEstadoCivil = item.idestadocivil.Trim();
                    Cbt.pe_apellido = item.pe_apellido;
                    Cbt.pe_nombre = item.pe_nombre;
                    Cbt.pe_casilla = item.pe_casilla;
                    Cbt.pe_cedulaRuc = item.pe_cedularuc;
                    Cbt.pe_celular = item.pe_celular;
                    Cbt.pe_correo = item.pe_correo;
                    Cbt.pe_direccion = item.pe_direccion;
                    Cbt.pe_estado = item.pe_estado.Trim();
                    Cbt.pe_fax = item.pe_fax;
                    Cbt.pe_fechaCreacion = item.pe_fechacreacion;
                    Cbt.pe_fechaModificacion = item.pe_fechamodificacion;
                    Cbt.pe_fechaNacimiento = item.pe_fechanacimiento;
                    Cbt.pe_Naturaleza = item.pe_naturaleza.Trim();
                    Cbt.pe_nombreCompleto = item.pe_nombrecompleto;
                    Cbt.pe_razonSocial = item.pe_razonsocial;
                    Cbt.pe_sexo = item.pe_sexo.Trim();
                    Cbt.pe_telefonoCasa = item.pe_telefonocasa;
                    Cbt.pe_telefonoInter = item.pe_telefonointer;
                    Cbt.pe_telefonoOfic = item.pe_telefonoofic;
                    Cbt.pe_telfono_Contacto = item.pe_telfono_contacto;
                    Cbt.IdTipoDocumento = item.idtipodocumento.Trim();
                    Cbt.pe_UltUsuarioModi = item.pe_ultusuariomodi;
                    Cbt.pe_celularSecundario = item.pe_celularsecundario;

                    Cbt.pe_correo_secundario1 = item.pe_correo_secundario1;
                    Cbt.pe_correo_secundario2 = item.pe_correo_secundario2;

                    Cbt.IdTipoCta_acreditacion_cat = item.idtipocta_acreditacion_cat;
                    Cbt.num_cta_acreditacion = item.num_cta_acreditacion;
                    Cbt.IdBanco_acreditacion = item.idbanco_acreditacion;
                    Cbt.IdTipoDocumento_acreditacion = item.idtipodocumento_acreditacion;
                    Cbt.cedulaRuc_acreditacion = item.cedularuc_acreditacion;
                    Cbt.beneficiario_acreditacion = item.beneficiario_acreditacion;
                    Cbt.correo_acreditacion = item.correo_acreditacion;

                    lM.Add(Cbt);
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_persona_Info Get_Info_Persona(decimal IdPersona)
        {
            try
            {
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.tb_persona
                                    where C.idpersona == IdPersona
                                    select C;


                tb_persona_Info Cbt = new tb_persona_Info();

                foreach (var item in selectEmpresa)
                {
                    Cbt.IdPersona = item.idpersona;
                    Cbt.IdEstadoCivil = item.idestadocivil.Trim();
                    Cbt.CodPersona = item.codpersona.Trim();
                    Cbt.pe_apellido = item.pe_apellido;
                    Cbt.pe_nombre = item.pe_nombre;
                    Cbt.pe_casilla = item.pe_casilla;
                    Cbt.pe_cedulaRuc = item.pe_cedularuc;
                    Cbt.pe_celular = item.pe_celular;
                    Cbt.pe_correo = item.pe_correo;
                    Cbt.pe_direccion = item.pe_direccion;
                    Cbt.pe_estado = item.pe_estado.Trim();
                    Cbt.pe_fax = item.pe_fax;
                    Cbt.pe_fechaCreacion = item.pe_fechacreacion;
                    Cbt.pe_fechaModificacion = item.pe_fechamodificacion;
                    Cbt.pe_fechaNacimiento = item.pe_fechanacimiento;
                    Cbt.pe_Naturaleza = item.pe_naturaleza.Trim();
                    Cbt.pe_nombreCompleto = item.pe_nombrecompleto;
                    Cbt.pe_razonSocial = item.pe_razonsocial;
                    Cbt.pe_sexo = item.pe_sexo.Trim();
                    Cbt.pe_telefonoCasa = item.pe_telefonocasa;
                    Cbt.pe_telefonoInter = item.pe_telefonointer;
                    Cbt.pe_telefonoOfic = item.pe_telefonoofic;
                    Cbt.pe_telfono_Contacto = item.pe_telfono_contacto;
                    Cbt.IdTipoDocumento = item.idtipodocumento.Trim();
                    Cbt.pe_UltUsuarioModi = item.pe_ultusuariomodi;
                    Cbt.pe_celularSecundario = item.pe_celularsecundario;
                    Cbt.pe_correo_secundario1 = item.pe_correo_secundario1;
                    Cbt.pe_correo_secundario2 = item.pe_correo_secundario2;
                    Cbt.IdTipoCta_acreditacion_cat = item.idtipocta_acreditacion_cat;
                    Cbt.num_cta_acreditacion = item.num_cta_acreditacion;
                    Cbt.IdBanco_acreditacion = item.idbanco_acreditacion;
                    Cbt.IdTipoDocumento_acreditacion = item.idtipodocumento_acreditacion;
                    Cbt.cedulaRuc_acreditacion = item.cedularuc_acreditacion;
                    Cbt.beneficiario_acreditacion = item.beneficiario_acreditacion;
                    Cbt.correo_acreditacion = item.correo_acreditacion;
                }
                return (Cbt);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_persona_Info Get_Info_Persona(string Cedula)
        {
            try
            {
                EntitiesGeneral base_ = new EntitiesGeneral();
                var select_ = from C in base_.tb_persona
                              where C.pe_cedularuc == Cedula
                              select C;

                tb_persona_Info Cbt = new tb_persona_Info();

                foreach (var item in select_)
                {
                    Cbt.IdPersona = item.idpersona;
                    Cbt.IdEstadoCivil = item.idestadocivil.Trim();
                    Cbt.CodPersona = item.codpersona.Trim();
                    Cbt.pe_apellido = item.pe_apellido;
                    Cbt.pe_nombre = item.pe_nombre;
                    Cbt.pe_casilla = item.pe_casilla;
                    Cbt.pe_cedulaRuc = item.pe_cedularuc;
                    Cbt.pe_celular = item.pe_celular;
                    Cbt.pe_celularSecundario = item.pe_celularsecundario;
                    Cbt.pe_correo = item.pe_correo;
                    Cbt.pe_direccion = item.pe_direccion;
                    Cbt.pe_estado = item.pe_estado.Trim();
                    Cbt.pe_fax = item.pe_fax;
                    Cbt.pe_fechaCreacion = item.pe_fechacreacion;
                    Cbt.pe_fechaModificacion = item.pe_fechamodificacion;
                    Cbt.pe_fechaNacimiento = item.pe_fechanacimiento;
                    Cbt.pe_Naturaleza = item.pe_naturaleza.Trim();
                    Cbt.pe_nombreCompleto = item.pe_nombrecompleto;
                    Cbt.pe_razonSocial = item.pe_razonsocial;
                    Cbt.pe_sexo = item.pe_sexo.Trim();
                    Cbt.pe_telefonoCasa = item.pe_telefonocasa;
                    Cbt.pe_telefonoInter = item.pe_telefonointer;
                    Cbt.pe_telefonoOfic = item.pe_telefonoofic;
                    Cbt.pe_telfono_Contacto = item.pe_telfono_contacto;
                    Cbt.IdTipoDocumento = item.idtipodocumento.Trim();
                    Cbt.pe_UltUsuarioModi = item.pe_ultusuariomodi;
                    Cbt.pe_Naturaleza = item.pe_naturaleza;
                    Cbt.pe_correo_secundario1 = item.pe_correo_secundario1;
                    Cbt.pe_correo_secundario2 = item.pe_correo_secundario2;
                    Cbt.IdTipoCta_acreditacion_cat = item.idtipocta_acreditacion_cat;
                    Cbt.num_cta_acreditacion = item.num_cta_acreditacion;
                    Cbt.IdBanco_acreditacion = item.idbanco_acreditacion;
                    Cbt.IdTipoDocumento_acreditacion = item.idtipodocumento_acreditacion;
                    Cbt.cedulaRuc_acreditacion = item.cedularuc_acreditacion;
                    Cbt.beneficiario_acreditacion = item.beneficiario_acreditacion;
                    Cbt.correo_acreditacion = item.correo_acreditacion;
                }

                return (Cbt);
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_persona_Info Get_Info_Persona(string IdTipoDocumento, string CedulaRuc)
        {
            try
            {
                EntitiesGeneral base_ = new EntitiesGeneral();
                var select_ = from C in base_.tb_persona
                              where C.idtipodocumento == IdTipoDocumento
                              && C.pe_cedularuc == CedulaRuc
                              select C;

                tb_persona_Info Cbt = new tb_persona_Info();

                foreach (var item in select_)
                {
                    Cbt.IdPersona = item.idpersona;
                    Cbt.IdEstadoCivil = item.idestadocivil.Trim();
                    Cbt.CodPersona = item.codpersona.Trim();
                    Cbt.pe_apellido = item.pe_apellido;
                    Cbt.pe_nombre = item.pe_nombre;
                    Cbt.pe_casilla = item.pe_casilla;
                    Cbt.pe_cedulaRuc = item.pe_cedularuc;
                    Cbt.pe_celular = item.pe_celular;
                    Cbt.pe_celularSecundario = item.pe_celularsecundario;
                    Cbt.pe_correo = item.pe_correo;
                    Cbt.pe_direccion = item.pe_direccion;
                    Cbt.pe_estado = item.pe_estado.Trim();
                    Cbt.pe_fax = item.pe_fax;
                    Cbt.pe_fechaCreacion = item.pe_fechacreacion;
                    Cbt.pe_fechaModificacion = item.pe_fechamodificacion;
                    Cbt.pe_fechaNacimiento = item.pe_fechanacimiento;
                    Cbt.pe_Naturaleza = item.pe_naturaleza.Trim();
                    Cbt.pe_nombreCompleto = item.pe_nombrecompleto;
                    Cbt.pe_razonSocial = item.pe_razonsocial;
                    Cbt.pe_sexo = item.pe_sexo.Trim();
                    Cbt.pe_telefonoCasa = item.pe_telefonocasa;
                    Cbt.pe_telefonoInter = item.pe_telefonointer;
                    Cbt.pe_telefonoOfic = item.pe_telefonoofic;
                    Cbt.pe_telfono_Contacto = item.pe_telfono_contacto;
                    Cbt.IdTipoDocumento = item.idtipodocumento.Trim();
                    Cbt.pe_UltUsuarioModi = item.pe_ultusuariomodi;
                    Cbt.pe_Naturaleza = item.pe_naturaleza;
                    Cbt.pe_correo_secundario1 = item.pe_correo_secundario1;
                    Cbt.pe_correo_secundario2 = item.pe_correo_secundario2;
                    Cbt.IdTipoCta_acreditacion_cat = item.idtipocta_acreditacion_cat;
                    Cbt.num_cta_acreditacion = item.num_cta_acreditacion;
                    Cbt.IdBanco_acreditacion = item.idbanco_acreditacion;
                    Cbt.IdTipoDocumento_acreditacion = item.idtipodocumento_acreditacion;
                    Cbt.cedulaRuc_acreditacion = item.cedularuc_acreditacion;
                    Cbt.beneficiario_acreditacion = item.beneficiario_acreditacion;
                    Cbt.correo_acreditacion = item.correo_acreditacion;
                }

                return (Cbt);
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(tb_persona_Info info, ref string msgError)
        {
            try
            {
                try
                {
                    using (EntitiesGeneral context = new EntitiesGeneral())
                    {
                        var address = context.tb_persona.FirstOrDefault(minfo => minfo.idpersona == info.IdPersona);
                        if (address != null)
                        {
                            if (info.CodPersona == string.Empty || info.CodPersona == null)
                            { info.CodPersona = info.IdPersona.ToString(); }
                            address.idpersona = info.IdPersona;
                            address.codpersona = (info.CodPersona == null) ? null : info.CodPersona.Trim();
                            address.pe_naturaleza = (info.pe_Naturaleza == null) ? address.pe_naturaleza : info.pe_Naturaleza.Trim();
                            address.pe_nombrecompleto = info.pe_nombre.Trim() + " " + info.pe_apellido.Trim();
                            address.pe_razonsocial = (info.pe_razonSocial == null) ? null : info.pe_razonSocial.Trim();
                            address.pe_apellido = (info.pe_apellido == null) ? null : info.pe_apellido.Trim();
                            address.pe_nombre = (info.pe_nombre == null) ? null : info.pe_nombre.Trim();
                            address.idtipopersona = info.IdTipoPersona;
                            address.idtipodocumento = info.IdTipoDocumento;
                            address.pe_cedularuc = (info.pe_cedulaRuc == null) ? null : info.pe_cedulaRuc.Trim();
                            address.pe_direccion = (info.pe_direccion == null) ? null : info.pe_direccion.Trim();
                            address.pe_telefonocasa = (info.pe_telefonoCasa == null) ? null : info.pe_telefonoCasa.Trim();
                            address.pe_telefonointer = (info.pe_telefonoInter == null) ? null : info.pe_telefonoInter.Trim();
                            address.pe_telefonoofic = (info.pe_telefonoOfic == null) ? null : info.pe_telefonoOfic.Trim();
                            address.pe_telfono_contacto = (info.pe_telfono_Contacto == null) ? null : info.pe_telfono_Contacto.Trim();
                            address.pe_celular = (info.pe_celular == null) ? address.pe_celular : info.pe_celular.Trim();
                            address.pe_celularsecundario = (info.pe_celularSecundario == null) ? null : info.pe_celularSecundario.Trim();
                            address.pe_correo = info.pe_correo == null ? address.pe_correo : info.pe_correo.Trim();
                            address.pe_fax = (info.pe_fax == null) ? null : info.pe_fax.Trim();
                            address.pe_casilla = (info.pe_casilla == null) ? null : info.pe_casilla.Trim();
                            address.pe_sexo = (info.pe_sexo == null) ? null : info.pe_sexo.Trim();
                            address.idestadocivil = info.IdEstadoCivil;
                            address.pe_fechanacimiento = info.pe_fechaNacimiento;
                            address.pe_fechamodificacion = (info.pe_fechaModificacion == null) ? DateTime.Now : info.pe_fechaModificacion;
                            address.pe_ultusuariomodi = info.IdUsuario;
                            address.pe_correo_secundario1 = (info.pe_correo_secundario1 == null || info.pe_correo_secundario1 == "") ? null : info.pe_correo_secundario1.Trim();
                            address.pe_correo_secundario2 = (info.pe_correo_secundario2 == null || info.pe_correo_secundario2 == "") ? null : info.pe_correo_secundario2.Trim();
                            address.idtipocta_acreditacion_cat = (info.IdTipoCta_acreditacion_cat == "") ? null : info.IdTipoCta_acreditacion_cat;
                            address.num_cta_acreditacion = info.num_cta_acreditacion;
                            address.idbanco_acreditacion = (info.IdBanco_acreditacion == 0) ? null : info.IdBanco_acreditacion;
                            address.idtipodocumento_acreditacion = info.IdTipoDocumento_acreditacion;
                            address.cedularuc_acreditacion = info.cedulaRuc_acreditacion;
                            address.beneficiario_acreditacion = info.beneficiario_acreditacion;
                            address.correo_acreditacion = info.correo_acreditacion;

                            context.SaveChanges();
                        }
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificaPersEmpl(tb_persona_Info info)
        {

            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_persona.FirstOrDefault(minfo => minfo.idpersona == info.IdPersona);
                    if (contact != null)
                    {

                        if (info.CodPersona == string.Empty || info.CodPersona == null)
                        { info.CodPersona = info.IdPersona.ToString(); }
                        contact.codpersona = info.CodPersona;
                        contact.idestadocivil = info.IdEstadoCivil.Trim();
                        contact.pe_apellido = info.pe_apellido;
                        contact.pe_nombre = info.pe_nombre;
                        contact.pe_cedularuc = info.pe_cedulaRuc;
                        contact.pe_celular = info.pe_celular;
                        contact.pe_celularsecundario = info.pe_celularSecundario;

                        contact.pe_direccion = info.pe_direccion;
                        contact.pe_estado = info.pe_estado;
                        contact.pe_fechamodificacion = DateTime.Now;
                        contact.pe_fechanacimiento = info.pe_fechaNacimiento;
                        contact.pe_naturaleza = info.pe_Naturaleza.Trim();
                        contact.pe_nombrecompleto = info.pe_nombreCompleto.Trim();
                        contact.pe_sexo = info.pe_sexo.Trim();
                        contact.pe_telfono_contacto = info.pe_telfono_Contacto;

                        contact.idtipodocumento = info.IdTipoDocumento.Trim();
                        contact.pe_ultusuariomodi = info.pe_UltUsuarioModi;


                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(tb_persona_Info info, ref decimal idPersonaOut, ref string msgError)
        {
            try
            {
                decimal idPersona = 0;

                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    EntitiesGeneral EDB = new EntitiesGeneral();
                    var Q = from per in EDB.tb_persona
                            where per.idpersona == info.IdPersona

                            select per;
                    if (Q.ToList().Count == 0)
                    {

                        idPersona = idPersonaOut = getIdPersona();

                        tb_persona address = new tb_persona();

                        if (info.CodPersona == string.Empty || (info.CodPersona == null))
                        {
                            info.CodPersona = idPersona.ToString();
                        }

                        address.idpersona = idPersona;
                        address.codpersona = (info.CodPersona == null) ? null : info.CodPersona.Trim();
                        address.pe_naturaleza = (info.pe_Naturaleza == null) ? null : info.pe_Naturaleza.Trim();
                        address.pe_nombrecompleto = info.pe_nombre.Trim() + " " + info.pe_apellido.Trim();
                        address.pe_razonsocial = (info.pe_razonSocial == null) ? null : info.pe_razonSocial.Trim();
                        address.pe_apellido = (info.pe_apellido == null) ? null : info.pe_apellido.Trim();
                        address.pe_nombre = (info.pe_nombre == null) ? null : info.pe_nombre.Trim();
                        address.idtipopersona = info.IdTipoPersona;
                        address.idtipodocumento = info.IdTipoDocumento;
                        address.pe_cedularuc = (info.pe_cedulaRuc == null) ? null : info.pe_cedulaRuc.Trim();
                        address.pe_direccion = (info.pe_direccion == null) ? null : info.pe_direccion.Trim();

                        address.pe_telefonocasa = (info.pe_telefonoCasa == null) ? null : info.pe_telefonoCasa.Trim();
                        address.pe_telefonointer = (info.pe_telefonoInter == null) ? null : info.pe_telefonoInter.Trim();
                        address.pe_telefonoofic = (info.pe_telefonoOfic == null) ? null : info.pe_telefonoOfic.Trim();
                        address.pe_telfono_contacto = (info.pe_telfono_Contacto == null) ? null : info.pe_telfono_Contacto.Trim();
                        address.pe_celular = (info.pe_celular == null) ? null : info.pe_celular.Trim();
                        address.pe_celularsecundario = (info.pe_celularSecundario == null) ? null : info.pe_celularSecundario.Trim();

                        address.pe_correo = info.pe_correo == null ? "" : info.pe_correo.Trim();
                        address.pe_fax = (info.pe_fax == null) ? null : info.pe_fax.Trim();
                        address.pe_casilla = (info.pe_casilla == null) ? null : info.pe_casilla.Trim();
                        address.pe_sexo = (info.pe_sexo == null) ? null : info.pe_sexo.Trim();// "SEXO_MAS";
                        address.idestadocivil = info.IdEstadoCivil;
                        address.pe_fechanacimiento = info.pe_fechaNacimiento;
                        address.pe_estado = "A";
                        address.pe_fechacreacion = DateTime.Now;
                        address.pe_ultusuariomodi = info.pe_UltUsuarioModi;

                        address.pe_correo_secundario1 = (info.pe_correo_secundario1 == null || info.pe_correo_secundario1 == "") ? null : info.pe_correo_secundario1.Trim();
                        address.pe_correo_secundario2 = (info.pe_correo_secundario2 == null || info.pe_correo_secundario2 == "") ? null : info.pe_correo_secundario2.Trim();

                        address.idtipocta_acreditacion_cat = (info.IdTipoCta_acreditacion_cat == "") ? null : info.IdTipoCta_acreditacion_cat;
                        address.num_cta_acreditacion = info.num_cta_acreditacion;
                        address.idbanco_acreditacion = (info.IdBanco_acreditacion == 0) ? null : info.IdBanco_acreditacion;
                        address.idtipodocumento_acreditacion = info.IdTipoDocumento_acreditacion;
                        address.cedularuc_acreditacion = info.cedulaRuc_acreditacion;
                        address.beneficiario_acreditacion = info.beneficiario_acreditacion;
                        address.correo_acreditacion = info.correo_acreditacion;

                        context.tb_persona.Add(address);

                        context.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    string arreglo = ToString();
                    mensaje = "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:" +
                      eve.Entry.Entity.GetType().Name.ToString() + eve.Entry.State.ToString();

                    foreach (var ve in eve.ValidationErrors)
                    {
                        mensaje = mensaje + "- Property: \"{0}\", Error: \"{1}\"" +
                            ve.PropertyName.ToString() + ve.ErrorMessage;
                    }

                }
                throw new Exception(ex.ToString());               
            }
        }

        public decimal getIdPersona()
        {
            try
            {
                decimal IdPersona;


                EntitiesGeneral OECbtecble = new EntitiesGeneral();

                var selectCbtecble = (from CbtCble in OECbtecble.tb_persona
                                      select CbtCble.idpersona);
                if (selectCbtecble.Count() == 0)
                {
                    IdPersona = 1;

                }
                else
                {
                    var selectCbtecble_ = (from CbtCble in OECbtecble.tb_persona
                                           select CbtCble.idpersona).Max() + 1;
                    IdPersona = selectCbtecble_;

                }

                return IdPersona;

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(tb_persona_Info info, ref string msgError)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_persona.FirstOrDefault(minfo => minfo.idpersona == info.IdPersona);
                    if (contact != null)
                    {
                        contact.pe_estado = "I";
                        contact.fecha_ultanu = DateTime.Now;
                        contact.idusuarioultanu = info.IdUsuarioUltAnu;
                        contact.motivoanulacion = info.MotivoAnulacion;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ExisteCedula(string cedula, ref string mensaje)
        {
            try
            {
                Boolean Existe;

                string scedula;

                scedula = cedula.Trim();
                mensaje = "";
                Existe = false;

                EntitiesGeneral OECbtecble = new EntitiesGeneral();

                var selectCbtecble = from CbtCble in OECbtecble.tb_persona
                                     where CbtCble.pe_cedularuc == scedula
                                     select CbtCble;

                foreach (var item in selectCbtecble)
                {
                    mensaje = mensaje + " " + item.pe_apellido + " " + item.pe_nombre;
                    Existe = true;
                }

                return Existe;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_persona_data() { }

        public Boolean GetExiste(tb_persona_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesGeneral db = new EntitiesGeneral())
                {
                    int cont = (from a in db.tb_persona
                                where a.idpersona == info.IdPersona
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public tb_persona_Info Get_Info_Beneficiario_OP(int IdEmpresa, string IdTipoPersona, int IdPersona, int IdEntidad)
        {
            try
            {
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.vwtb_persona_beneficiario_por_banco_acreditacion
                                    where C.idtipo_persona == IdTipoPersona
                                    && C.identidad == IdEntidad
                                    && C.idpersona == IdPersona
                                    && C.idempresa == IdEmpresa
                                    select C;


                tb_persona_Info Cbt = new tb_persona_Info();

                foreach (var item in selectEmpresa)
                {
                    Cbt.IdPersona = item.idpersona;
                    Cbt.pe_apellido = item.pe_apellido;
                    Cbt.pe_nombre = item.pe_nombre;
                    Cbt.pe_cedulaRuc = item.pe_cedularuc;
                    Cbt.pe_celular = item.pe_celular;

                    Cbt.pe_correo = item.pe_correo;
                    Cbt.pe_direccion = item.pe_direccion;

                    Cbt.pe_Naturaleza = item.pe_naturaleza.Trim();
                    Cbt.pe_nombreCompleto = item.pe_nombrecompleto;
                    Cbt.pe_razonSocial = item.pe_razonsocial;
                    Cbt.pe_apellido = item.pe_apellido;
                    Cbt.pe_nombre = item.pe_nombre;
                    Cbt.IdTipoDocumento = item.idtipodocumento;

                    Cbt.IdTipoCta_acreditacion_cat = item.idtipocta_acreditacion_cat;
                    Cbt.num_cta_acreditacion = item.num_cta_acreditacion;
                    Cbt.IdBanco_acreditacion = Convert.ToInt32(item.idbanco_acreditacion);
                    Cbt.IdTipoDocumento_acreditacion = item.idtipodocumento_acreditacion;
                    Cbt.cedulaRuc_acreditacion = item.cedularuc_acreditacion;
                    Cbt.beneficiario_acreditacion = item.beneficiario_acreditacion;
                    Cbt.correo_acreditacion = item.correo_acreditacion;

                    Cbt.CodigoLegal = item.codigolegal;
                }
                return (Cbt);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}