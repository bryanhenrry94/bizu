using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class tb_sis_Documento_Tipo_x_Empresa_Data
    {
        string mensaje = "";

        public List<tb_sis_Documento_Tipo_x_Empresa_Info> Get_List_sis_Documento_Tipo_x_Empresa(int IdEmpresa)
        {
            try
            {
                List<tb_sis_Documento_Tipo_x_Empresa_Info> lst = new List<tb_sis_Documento_Tipo_x_Empresa_Info>();
                tb_sis_Documento_Tipo_x_Empresa_Info Info;
                EntitiesGeneral context = new EntitiesGeneral();
                var address = from q in context.tb_sis_documento_tipo_x_empresa
                              where q.idempresa == IdEmpresa
                              orderby q.posicion
                              select q;

                foreach (var item in address)
                {
                    Info = new tb_sis_Documento_Tipo_x_Empresa_Info();
                    Info.IdEmpresa = item.idempresa;
                    Info.codDocumentoTipo = item.coddocumentotipo;
                    Info.ApareceComboFac_TipoFact = item.aparececombofac_tipofact;
                    Info.ApareceComboFac_Import = item.aparececombofac_import;
                    Info.ApareceTalonario = item.aparecetalonario;
                    Info.Descripcion = item.descripcion;
                    Info.Posicion = item.posicion;
                    Info.ApareceCombo_FileReporte = item.aparececombo_filereporte;
                    lst.Add(Info);
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

        public Boolean GuardarDB(List<tb_sis_Documento_Tipo_x_Empresa_Info> lst)
        {
            try
            {

                EntitiesGeneral context = new EntitiesGeneral();


                foreach (var Info in lst)
                {
                    if (ValidarSiExiste(Info.codDocumentoTipo, Info.IdEmpresa))
                    {
                        var address = new tb_sis_documento_tipo_x_empresa();
                        address.idempresa = Info.IdEmpresa;
                        address.coddocumentotipo = Info.codDocumentoTipo.Trim();
                        address.aparececombofac_tipofact = Info.ApareceComboFac_TipoFact.Trim();
                        address.aparececombofac_import = Info.ApareceComboFac_Import.Trim();
                        address.aparecetalonario = Info.ApareceTalonario.Trim();
                        address.descripcion = Info.Descripcion.Trim();
                        address.posicion = Info.Posicion;
                        address.aparececombo_filereporte = Info.ApareceCombo_FileReporte;

                        context.tb_sis_documento_tipo_x_empresa.Add(address);
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

        public Boolean ModificarDB(tb_sis_Documento_Tipo_x_Empresa_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var address = context.tb_sis_documento_tipo_x_empresa.FirstOrDefault(var => var.coddocumentotipo == Info.codDocumentoTipo && var.idempresa == Info.IdEmpresa);
                if (address != null)
                {
                    address.aparececombofac_import = Info.ApareceComboFac_Import;
                    address.aparececombofac_tipofact = Info.ApareceComboFac_TipoFact;
                    address.aparecetalonario = Info.ApareceTalonario;
                    address.descripcion = Info.Descripcion;
                    address.posicion = Info.Posicion;
                    address.aparececombo_filereporte = Info.ApareceCombo_FileReporte;
                    context.SaveChanges();
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

        public Boolean GuardarDB(tb_sis_Documento_Tipo_x_Empresa_Info Info)
        {
            try
            {

                EntitiesGeneral context = new EntitiesGeneral();
                var address = new tb_sis_documento_tipo_x_empresa();
                address.idempresa = Info.IdEmpresa;
                address.coddocumentotipo = Info.codDocumentoTipo;
                address.aparececombofac_tipofact = Info.ApareceComboFac_TipoFact;
                address.aparececombofac_import = Info.ApareceComboFac_Import;
                address.aparecetalonario = Info.ApareceTalonario;
                address.descripcion = Info.Descripcion;
                address.posicion = Info.Posicion;
                address.aparececombo_filereporte = Info.ApareceCombo_FileReporte;
                context.tb_sis_documento_tipo_x_empresa.Add(address);
                context.SaveChanges();
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

        public Boolean ValidarSiExiste(string codDocumentoTipo, int IdEmpresa)
        {
            bool ret = false;
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var address = from q in context.tb_sis_documento_tipo_x_empresa
                              where q.coddocumentotipo == codDocumentoTipo && q.idempresa == IdEmpresa
                              select q;

                if (address.ToList().Count > 0)
                {
                    ret = false;
                }
                else
                {
                    ret = true;
                }

                return ret;
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

        public Boolean EliminarDB(tb_sis_Documento_Tipo_x_Empresa_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var address = context.tb_sis_documento_tipo_x_empresa.FirstOrDefault(var => var.coddocumentotipo == Info.codDocumentoTipo && var.idempresa == Info.IdEmpresa);
                if (address != null)
                {
                    context.tb_sis_documento_tipo_x_empresa.Remove(address);
                    context.SaveChanges();
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

        public Boolean EliminarDB(List<tb_sis_Documento_Tipo_x_Empresa_Info> lst)
        {
            try
            {

                EntitiesGeneral context = new EntitiesGeneral();
                foreach (var item in lst)
                {
                    var address = context.tb_sis_documento_tipo_x_empresa.FirstOrDefault(var => var.idempresa == item.IdEmpresa);
                    if (address != null)
                    {
                        context.tb_sis_documento_tipo_x_empresa.Remove(address);
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
    }
}