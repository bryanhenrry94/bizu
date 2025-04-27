using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class tb_sis_Documento_Tipo_Data
    {
        string mensaje = "";

        public List<tb_sis_Documento_Tipo_Info> Get_List_Documento_Tipo()
        {
            try
            {
                List<tb_sis_Documento_Tipo_Info> Lst = new List<tb_sis_Documento_Tipo_Info>();
                using (EntitiesGeneral General = new EntitiesGeneral())
                {
                    var Consutar = from q in General.tb_sis_documento_tipo
                                   select q;
                    foreach (var item in Consutar)
                    {
                        tb_sis_Documento_Tipo_Info info = new tb_sis_Documento_Tipo_Info();
                        info.codDocumentoTipo = item.coddocumentotipo;
                        info.descripcion = item.descripcion;
                        info.estado = item.estado;
                        info.Posicion = item.posicion;
                        Lst.Add(info);
                    }
                }
                return Lst;
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

        public List<tb_sis_Documento_Tipo_Info> Get_List_Documento_Tipo(int IdEmpresa)
        {
            try
            {
                List<tb_sis_Documento_Tipo_Info> Lst = new List<tb_sis_Documento_Tipo_Info>();
                using (EntitiesGeneral General = new EntitiesGeneral())
                {
                    var Consutar = from q in General.tb_sis_documento_tipo
                                   join o in General.tb_sis_documento_tipo_x_empresa
                                   on q.coddocumentotipo equals o.coddocumentotipo
                                   where o.idempresa == IdEmpresa
                                   select q;
                    foreach (var item in Consutar)
                    {
                        tb_sis_Documento_Tipo_Info info = new tb_sis_Documento_Tipo_Info();
                        info.codDocumentoTipo = item.coddocumentotipo;
                        info.descripcion = item.descripcion;
                        info.estado = item.estado;
                        info.Posicion = item.posicion;
                        Lst.Add(info);
                    }
                }
                return Lst;
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

        public List<tb_sis_Documento_Tipo_Info> Get_List_Documento_Tipo_ApareceTalonario(int IdEmpresa)
        {
            try
            {
                List<tb_sis_Documento_Tipo_Info> Lst = new List<tb_sis_Documento_Tipo_Info>();
                using (EntitiesGeneral General = new EntitiesGeneral())
                {
                    var Consutar = from q in General.tb_sis_documento_tipo
                                   join o in General.tb_sis_documento_tipo_x_empresa
                                   on q.coddocumentotipo equals o.coddocumentotipo
                                   where o.idempresa == IdEmpresa
                                   && o.aparecetalonario == "S"
                                   select q;
                    foreach (var item in Consutar)
                    {
                        tb_sis_Documento_Tipo_Info info = new tb_sis_Documento_Tipo_Info();
                        info.codDocumentoTipo = item.coddocumentotipo;
                        info.descripcion = item.descripcion;
                        info.estado = item.estado;
                        info.Posicion = item.posicion;
                        Lst.Add(info);
                    }
                }
                return Lst;
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

        public String Get_Documento_Tipo(string CodTipoDocu)
        {
            try
            {
                using (EntitiesGeneral General = new EntitiesGeneral())
                {
                    var espe = from q in General.tb_sis_documento_tipo
                               where q.coddocumentotipo == CodTipoDocu
                               select q;
                    string descripcion = "";
                    foreach (var item in espe)
                    {
                        descripcion = item.descripcion;
                    }
                    return descripcion;
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

    }
}