using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class tb_sis_Documento_Tipo_Talonario_Data
    {
        string mensajeErrorLog = "";
        string mensaje = "";

        public List<tb_sis_Documento_Tipo_Talonario_Info> Get_List_DocTipoxSecTalonario(int IdEmpresa)
        {
            try
            {
                List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                var q = from A in OEGeneral.vwge_tb_sis_documento_tipo_talonario
                        where A.idempresa == IdEmpresa
                        select A;
                foreach (var item in q)
                {
                    tb_sis_Documento_Tipo_Talonario_Info info = new tb_sis_Documento_Tipo_Talonario_Info();
                    info.IdEmpresa = item.idempresa;
                    info.CodDocumentoTipo = item.coddocumentotipo;
                    info.PuntoEmision = item.puntoemision;
                    info.NumDocumento = item.numdocumento;
                    info.Establecimiento = item.establecimiento;
                    info.FechaCaducidad = item.fechacaducidad;
                    info.Usado = Convert.ToBoolean(item.usado);
                    info.Estado = item.estado;
                    info.IdSucursal = item.idsucursal;
                    info.NumAutorizacion = item.numautorizacion;
                    info.NombreSucursal = item.su_descripcion;
                    info.NombreEmpresa = item.em_nombre;
                    info.es_Documento_electronico = Convert.ToBoolean(item.es_documento_electronico);

                    lm.Add(info);
                }
                return lm;
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

        public List<tb_sis_Documento_Tipo_Talonario_Info> Get_List_Docu_Tipo_Talonario_x_TipoDocu(int IdEmpresa, string TipoDocu, bool Es_Documento_Electronico)
        {
            try
            {
                List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                var q = from A in OEGeneral.vwge_tb_sis_documento_tipo_talonario
                        where A.idempresa == IdEmpresa && A.coddocumentotipo == TipoDocu
                        && A.es_documento_electronico == Es_Documento_Electronico
                        select A;
                foreach (var item in q)
                {
                    tb_sis_Documento_Tipo_Talonario_Info info = new tb_sis_Documento_Tipo_Talonario_Info();
                    info.IdEmpresa = item.idempresa;
                    info.CodDocumentoTipo = item.coddocumentotipo;
                    info.PuntoEmision = item.puntoemision;
                    info.NumDocumento = item.numdocumento;
                    info.Establecimiento = item.establecimiento;
                    info.FechaCaducidad = item.fechacaducidad;
                    info.Usado = Convert.ToBoolean(item.usado);
                    info.Estado = item.estado;
                    info.IdSucursal = item.idsucursal;
                    info.NumAutorizacion = item.numautorizacion;
                    info.NombreSucursal = item.su_descripcion;
                    info.NombreEmpresa = item.em_nombre;
                    info.es_Documento_electronico = Convert.ToBoolean(item.es_documento_electronico);

                    lm.Add(info);
                }
                return lm;
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

        public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Ult_Documento(int IdEmpresa, string puntoemision, string establecimiento, string tipodoc)
        {
            try
            {
                tb_sis_Documento_Tipo_Talonario_Info Info = new tb_sis_Documento_Tipo_Talonario_Info();

                List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                var q = (from A in OEGeneral.tb_sis_documento_tipo_talonario
                         where A.idempresa == IdEmpresa
                         && A.puntoemision == puntoemision
                         && A.coddocumentotipo == tipodoc
                         && A.establecimiento == establecimiento
                         && A.estado == "A"
                         select A.numdocumento).Max();

                string UltRegistro = "";

                if (q == null)
                {
                    UltRegistro = "000000000";
                }
                else
                {
                    UltRegistro = q.ToString();
                }

                var querry = from A in OEGeneral.tb_sis_documento_tipo_talonario
                             where A.idempresa == IdEmpresa
                             && A.puntoemision == puntoemision
                             && A.coddocumentotipo == tipodoc
                             && A.establecimiento == establecimiento
                             && A.numdocumento == UltRegistro
                             select A;

                if (querry != null)
                {
                    foreach (var item in querry)
                    {
                        Info.IdEmpresa = item.idempresa;
                        Info.IdSucursal = item.idsucursal;
                        Info.CodDocumentoTipo = item.coddocumentotipo;
                        Info.Establecimiento = item.establecimiento;
                        Info.Estado = item.estado;
                        Info.FechaCaducidad = item.fechacaducidad;
                        Info.NumAutorizacion = item.numautorizacion;
                        Info.NumDocumento = item.numdocumento;
                        Info.PuntoEmision = item.puntoemision;
                        Info.Usado = item.usado;
                        Info.es_Documento_electronico = Convert.ToBoolean(item.es_documento_electronico);
                    }
                }
                else
                {
                    Info.IdEmpresa = IdEmpresa;
                    Info.IdSucursal = 0;
                    Info.CodDocumentoTipo = tipodoc;
                    Info.Establecimiento = establecimiento;
                    Info.Estado = "A";
                    Info.FechaCaducidad = DateTime.Now;
                    Info.NumAutorizacion = "0000000000000";
                    Info.NumDocumento = "000000000";
                    Info.PuntoEmision = puntoemision;
                    Info.Usado = false;
                }

                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
                throw new Exception(ex.ToString());
            }
        }

        public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Documento_Tipo_Talonario(int IdEmpresa, string tipodoc, string establecimiento, string puntoemision, string NumDocumento)
        {
            try
            {
                tb_sis_Documento_Tipo_Talonario_Info Info = new tb_sis_Documento_Tipo_Talonario_Info();

                List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();


                var querry = from A in OEGeneral.tb_sis_documento_tipo_talonario
                             where A.idempresa == IdEmpresa
                             && A.establecimiento == establecimiento
                             && A.puntoemision == puntoemision
                             && A.coddocumentotipo == tipodoc
                             && A.numdocumento == NumDocumento
                             select A;

                if (querry != null)
                {
                    foreach (var item in querry)
                    {
                        Info.IdEmpresa = item.idempresa;
                        Info.IdSucursal = item.idsucursal;
                        Info.CodDocumentoTipo = item.coddocumentotipo;
                        Info.Establecimiento = item.establecimiento;
                        Info.Estado = item.estado;
                        Info.FechaCaducidad = item.fechacaducidad;
                        Info.NumAutorizacion = item.numautorizacion;
                        Info.NumDocumento = item.numdocumento;
                        Info.PuntoEmision = item.puntoemision;
                        Info.Usado = item.usado;
                        Info.es_Documento_electronico = Convert.ToBoolean(item.es_documento_electronico);
                    }
                }

                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
                throw new Exception(ex.ToString());
            }
        }

        public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Ult_Documento_no_usado(int IdEmpresa, string puntoemision, string establecimiento, string tipodoc, bool Es_Documento_Electronico)
        {
            try
            {

                //if (establecimiento == null) { establecimiento = "001";}

                tb_sis_Documento_Tipo_Talonario_Info Info = new tb_sis_Documento_Tipo_Talonario_Info();

                List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                var q = (from A in OEGeneral.tb_sis_documento_tipo_talonario
                         where A.idempresa == IdEmpresa
                         //&& A.PuntoEmision == puntoemision 
                         && A.coddocumentotipo == tipodoc
                         && A.establecimiento == establecimiento
                         && A.es_documento_electronico == Es_Documento_Electronico
                         && A.usado == false
                         && A.estado == "A"
                         select A.numdocumento).Max();
                if (q != null)
                {
                    string UltRegistro = q.ToString();
                    var querry = from A in OEGeneral.tb_sis_documento_tipo_talonario
                                 where A.idempresa == IdEmpresa
                                 //&& A.PuntoEmision == puntoemision 
                                 && A.coddocumentotipo == tipodoc
                                 && A.establecimiento == establecimiento
                                 && A.usado == false
                                 && A.numdocumento == UltRegistro
                                 select A;

                    foreach (var item in querry)
                    {
                        Info.IdEmpresa = item.idempresa;
                        Info.IdSucursal = item.idsucursal;
                        Info.CodDocumentoTipo = item.coddocumentotipo;
                        Info.Establecimiento = item.establecimiento;
                        Info.Estado = item.estado;
                        Info.FechaCaducidad = item.fechacaducidad;
                        Info.NumAutorizacion = item.numautorizacion;
                        Info.NumDocumento = item.numdocumento;
                        Info.PuntoEmision = item.puntoemision;
                        Info.Usado = item.usado;
                        Info.es_Documento_electronico = Convert.ToBoolean(item.es_documento_electronico);
                    }
                }

                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Verificar_NumTalonario(int IdEmpresa, string codDocuTipo, string establecimiento, string puntoEmision, string numDocumento, ref string mensaje)
        {
            try
            {
                Boolean Existe;
                mensaje = "";
                Existe = false;

                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                var consulta = from A in OEGeneral.tb_sis_documento_tipo_talonario
                               where A.idempresa == IdEmpresa
                               && A.puntoemision == puntoEmision
                               && A.coddocumentotipo == codDocuTipo
                               && A.establecimiento == establecimiento
                               && A.numdocumento == numDocumento

                               select A;

                foreach (var item in consulta)
                {
                    Existe = true;
                }

                if (Existe == false)
                {
                    mensaje = "El número de Documento : " + establecimiento + " - " + puntoEmision + " - " + numDocumento + ". No existe en la Base de Datos ";

                }

                return Existe;
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

        public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Primer_Documento_no_usado(int IdEmpresa, string establecimiento, string puntoemision, string tipodoc, bool Es_Documento_Electronico, bool Considerar_punto_emision)
        {
            try
            {

                tb_sis_Documento_Tipo_Talonario_Info Info = new tb_sis_Documento_Tipo_Talonario_Info();
                List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                string q;
                IQueryable<tb_sis_documento_tipo_talonario> querry;

                if (!Considerar_punto_emision)
                {
                    q = (from A in OEGeneral.tb_sis_documento_tipo_talonario
                         where A.idempresa == IdEmpresa
                         && A.coddocumentotipo == tipodoc
                         && A.establecimiento == establecimiento
                         && A.es_documento_electronico == Es_Documento_Electronico
                         && A.usado == false
                         && A.estado == "A"

                         select A.numdocumento).Min();
                    if (q != null)
                    {
                        string UltRegistro = q.ToString();

                        querry = from A in OEGeneral.tb_sis_documento_tipo_talonario
                                 where A.idempresa == IdEmpresa
                                 && A.coddocumentotipo == tipodoc
                                 && A.establecimiento == establecimiento
                                 && A.usado == false
                                 && A.numdocumento == UltRegistro
                                 select A;

                        foreach (var item in querry)
                        {
                            Info.IdEmpresa = item.idempresa;
                            Info.IdSucursal = item.idsucursal;
                            Info.CodDocumentoTipo = item.coddocumentotipo;
                            Info.Establecimiento = item.establecimiento;
                            Info.Estado = item.estado;
                            Info.FechaCaducidad = item.fechacaducidad;
                            Info.NumAutorizacion = item.numautorizacion;
                            Info.NumDocumento = item.numdocumento;
                            Info.PuntoEmision = item.puntoemision;
                            Info.Usado = item.usado;
                            Info.es_Documento_electronico = Convert.ToBoolean(item.es_documento_electronico);
                        }
                    }
                }
                else
                {
                    q = (from A in OEGeneral.tb_sis_documento_tipo_talonario
                         where A.idempresa == IdEmpresa
                         && A.coddocumentotipo == tipodoc
                         && A.establecimiento == establecimiento
                         && A.puntoemision == puntoemision
                         && A.es_documento_electronico == Es_Documento_Electronico
                         && A.usado == false
                         && A.estado == "A"
                         select A.numdocumento).Min();

                    if (q != null)
                    {
                        string UltRegistro = q.ToString();


                        querry = from A in OEGeneral.tb_sis_documento_tipo_talonario
                                 where A.idempresa == IdEmpresa
                                 && A.coddocumentotipo == tipodoc
                                 && A.establecimiento == establecimiento
                                 && A.puntoemision == puntoemision
                                 && A.usado == false
                                 && A.numdocumento == UltRegistro
                                 select A;

                        foreach (var item in querry)
                        {
                            Info.IdEmpresa = item.idempresa;
                            Info.IdSucursal = item.idsucursal;
                            Info.CodDocumentoTipo = item.coddocumentotipo;
                            Info.Establecimiento = item.establecimiento;
                            Info.Estado = item.estado;
                            Info.FechaCaducidad = item.fechacaducidad;
                            Info.NumAutorizacion = item.numautorizacion;
                            Info.NumDocumento = item.numdocumento;
                            Info.PuntoEmision = item.puntoemision;
                            Info.Usado = item.usado;
                            Info.es_Documento_electronico = Convert.ToBoolean(item.es_documento_electronico);
                        }
                    }
                }

                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Guardar(tb_sis_Documento_Tipo_Talonario_Info Info)
        {

            try
            {
                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var lst = from q in Context.tb_sis_documento_tipo_talonario
                              where q.idempresa == Info.IdEmpresa
                              && q.coddocumentotipo == Info.CodDocumentoTipo
                              && q.establecimiento == Info.Establecimiento
                              && q.puntoemision == Info.PuntoEmision
                              && q.numdocumento == Info.NumDocumento
                              select q;

                    if (lst.Count() == 0)
                    {
                        var Address = new tb_sis_documento_tipo_talonario();
                        Address.idempresa = Info.IdEmpresa;
                        Address.coddocumentotipo = Info.CodDocumentoTipo;
                        Address.establecimiento = Info.Establecimiento;
                        Address.puntoemision = Info.PuntoEmision;
                        Address.numdocumento = Info.NumDocumento;
                        Address.fechacaducidad = Convert.ToDateTime(Info.FechaCaducidad);
                        Address.usado = Info.Usado;
                        Address.estado = "A";
                        Address.idsucursal = Info.IdSucursal;
                        Address.numautorizacion = Info.NumAutorizacion;
                        Address.es_documento_electronico = Info.es_Documento_electronico;
                        Context.tb_sis_documento_tipo_talonario.Add(Address);
                        Context.SaveChanges();
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

        public Boolean Modificar(tb_sis_Documento_Tipo_Talonario_Info Info)
        {
            try
            {

                using (EntitiesGeneral Context = new EntitiesGeneral())
                {

                    var Address = Context.tb_sis_documento_tipo_talonario.FirstOrDefault(cot => cot.idempresa == Info.IdEmpresa && cot.coddocumentotipo == Info.CodDocumentoTipo && cot.idsucursal == Info.IdSucursal && cot.numdocumento == Info.NumDocumento);
                    if (Address != null)
                    {
                        Address.coddocumentotipo = Info.CodDocumentoTipo;
                        Address.establecimiento = Info.Establecimiento;
                        Address.puntoemision = Info.PuntoEmision;
                        Address.numdocumento = Info.NumDocumento;
                        Address.fechacaducidad = Convert.ToDateTime(Info.FechaCaducidad);
                        Address.usado = Info.Usado;
                        Address.estado = Info.Estado;
                        Address.numautorizacion = Info.NumAutorizacion;
                        Address.es_documento_electronico = Info.es_Documento_electronico;
                        Context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_Estado_Usado(tb_sis_Documento_Tipo_Talonario_Info Info, ref string mensajeError)
        {
            try
            {

                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var Address = Context.tb_sis_documento_tipo_talonario.FirstOrDefault(cot => cot.idempresa == Info.IdEmpresa && cot.coddocumentotipo == Info.CodDocumentoTipo && cot.establecimiento == Info.Establecimiento && cot.puntoemision == Info.PuntoEmision && cot.numdocumento == Info.NumDocumento);
                    if (Address != null)
                    {
                        Address.usado = true;
                        Context.SaveChanges();
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
                mensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Documento_talonario_esta_Usado(tb_sis_Documento_Tipo_Talonario_Info Info, ref string mensajeError, ref string mensajeDocumentoDupli)
        {
            try
            {
                List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
                EntitiesGeneral OEGeneral = new EntitiesGeneral();

                var q = (from A in OEGeneral.tb_sis_documento_tipo_talonario
                         where A.idempresa == Info.IdEmpresa
                         && A.puntoemision == Info.PuntoEmision
                         && A.coddocumentotipo == Info.CodDocumentoTipo
                         && A.establecimiento == Info.Establecimiento
                         && A.numdocumento == Info.NumDocumento
                         && A.usado == true
                         select A);

                if (q.Count() > 0)
                {
                    mensajeDocumentoDupli = "El numero de documento ya se encuentra en uso";
                    return true;
                }
                else
                {
                    mensajeDocumentoDupli = "";
                    return false;
                }

            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
                mensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_sis_Documento_Tipo_Talonario_Info Verificar_DocumentoElectronico(int IdEmpresa, string codDocuTipo, string establecimiento, string puntoEmision, string numDocumento, tb_sis_Documento_Tipo_Talonario_Info Info, ref string mensaje)
        {
            try
            {

                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                var consulta = from A in OEGeneral.vwge_tb_sis_documento_tipo_talonario
                               where A.puntoemision == puntoEmision
                               && A.coddocumentotipo == codDocuTipo
                               && A.establecimiento == establecimiento
                               && A.numdocumento == numDocumento
                               && A.idempresa == IdEmpresa
                               select A;

                foreach (var item in consulta)
                {
                    Info.Establecimiento = item.establecimiento;
                    Info.PuntoEmision = item.puntoemision;
                    Info.NumDocumento = item.numdocumento;
                    Info.es_Documento_electronico = (bool)item.es_documento_electronico;
                }
                return Info;
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

        public List<tb_sis_Documento_Tipo_Talonario_Info> Get_List_Doc_disponible(int IdEmpresa, string puntoemision, string establecimiento, string tipodoc, bool Es_Documento_Electronico)
        {

            try
            {

                List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();

                EntitiesGeneral OEGeneral = new EntitiesGeneral();
                var querry = (from A in OEGeneral.tb_sis_documento_tipo_talonario
                              where A.idempresa == IdEmpresa
                              && A.coddocumentotipo == tipodoc
                              && A.establecimiento == establecimiento
                              && A.puntoemision == puntoemision
                              && A.es_documento_electronico == Es_Documento_Electronico
                              && A.usado == false
                              select A);

                foreach (var item in querry)
                {
                    tb_sis_Documento_Tipo_Talonario_Info Info = new tb_sis_Documento_Tipo_Talonario_Info();

                    Info.IdEmpresa = item.idempresa;
                    Info.IdSucursal = item.idsucursal;
                    Info.CodDocumentoTipo = item.coddocumentotipo;
                    Info.Establecimiento = item.establecimiento;
                    Info.Estado = item.estado;
                    Info.FechaCaducidad = item.fechacaducidad;
                    Info.NumAutorizacion = item.numautorizacion;
                    Info.NumDocumento = item.numdocumento;
                    Info.PuntoEmision = item.puntoemision;
                    Info.Usado = item.usado;
                    Info.es_Documento_electronico = Convert.ToBoolean(item.es_documento_electronico);
                    lm.Add(Info);
                }

                return lm;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Modificar_Estado_Usado(int IdEmpresa, string CodDocumentoTipo, string Establecimiento, string PuntoEmision, string NumDocumento, ref string mensajeError)
        {
            try
            {

                using (EntitiesGeneral Context = new EntitiesGeneral())
                {
                    var Address = Context.tb_sis_documento_tipo_talonario.FirstOrDefault(cot => cot.idempresa == IdEmpresa && cot.coddocumentotipo == CodDocumentoTipo && cot.establecimiento == Establecimiento && cot.puntoemision == PuntoEmision && cot.numdocumento == NumDocumento);
                    if (Address != null)
                    {
                        Address.usado = true;
                        Context.SaveChanges();
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
                mensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }    
    }
}