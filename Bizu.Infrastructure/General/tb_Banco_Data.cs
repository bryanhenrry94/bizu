using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Infrastructure.General
{
    public class tb_Banco_Data
    {
        string mensaje = "";

        public List<tb_banco_Info> Get_List_Banco() 
        {
            try
            {
                List<tb_banco_Info> lst = new List<tb_banco_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var bancos = from q in oEnti.tb_banco
                             select q;

                foreach (var item in bancos)
                {
                    tb_banco_Info info = new tb_banco_Info();

                    info.IdBanco = item.idbanco;
                    info.ba_descripcion = item.ba_descripcion;
                    info.Estado = item.estado;
                    info.CodigoLegal = item.codigolegal;
                    info.TieneFormatoTransferencia = item.tieneformatotransferencia;
                    lst.Add(info);   
                }
                return lst;
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

        public tb_banco_Info Get_Info_Banco(int IdBanco)
        {
            try
            {
                tb_banco_Info info = new tb_banco_Info();
                EntitiesGeneral oEnti = new EntitiesGeneral();
                
                var bancos = from q in oEnti.tb_banco
                             where q.idbanco == IdBanco
                             select q;
                foreach (var item in bancos)
                {                   
                    info.IdBanco = item.idbanco;
                    info.ba_descripcion = item.ba_descripcion;
                    info.Estado = item.estado;
                    info.CodigoLegal = item.codigolegal;
                    info.TieneFormatoTransferencia = item.tieneformatotransferencia;                    
                }
                return info;
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

        public int getId()
        {
            int Id = 0;
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = from q in context.tb_banco
                                  select q;

                    if (contact.ToList().Count < 1)
                    {
                        Id = 1;
                    }
                    else
                    {
                        var contact1 = (from q in context.tb_banco
                                        select q.idbanco).Max();
                        Id = Convert.ToInt32(contact1.ToString()) + 1;
                    }
                }
                return Id;
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

        public Boolean GrabarDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = new tb_banco();
                    address.idbanco = Info.IdBanco = getId();
                    address.ba_descripcion = Info.ba_descripcion;
                    address.estado = Info.Estado;
                    address.codigolegal = Info.CodigoLegal;
                    address.tieneformatotransferencia = Convert.ToBoolean(Info.TieneFormatoTransferencia);
                    context.tb_banco.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido grabar el Banco #: " + address.idbanco.ToString() + " exitosamente.";
                    resultado = true;
                }
                return resultado;
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

        public Boolean ActualizarDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                bool resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = context.tb_banco.FirstOrDefault(v => v.idbanco == Info.IdBanco);
                    if (address != null)
                    {
                        address.ba_descripcion = Info.ba_descripcion;
                        address.estado = Info.Estado;
                        address.codigolegal = Info.CodigoLegal;
                        address.tieneformatotransferencia = Convert.ToBoolean(Info.TieneFormatoTransferencia);
                        context.SaveChanges();
                        msg = "Se ha modificado el Banco #: " + address.idbanco.ToString() + " exitosamente.";
                        resultado = true;
                    }
                }
                return resultado;
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

        public Boolean AnulaDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                Boolean resultado = false;
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var address = context.tb_banco.FirstOrDefault(q => q.idbanco == Info.IdBanco);
                    if (address != null)
                    {
                        address.estado = "I";
                        context.SaveChanges();
                        msg = "Se ha procedido anular el Banco #: " + Info.IdBanco.ToString() + " exitosamente.";
                        resultado = true;
                    }
                }
                return resultado;
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
    }
}
