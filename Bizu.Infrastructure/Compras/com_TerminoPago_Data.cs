using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Compras;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;


namespace Bizu.Infrastructure.Compras
{
    public class com_TerminoPago_Data
    {
        string mensaje = "";
        public List<com_TerminoPago_Info> Get_List_TerminoPago()
        {
                List<com_TerminoPago_Info> Lst = new List<com_TerminoPago_Info>();
               EntitiesCompras_GE oEnti = new EntitiesCompras_GE();
            try
            {
                var Query = from q in oEnti.com_TerminoPago
                            select q;
                foreach (var item in Query)
                {
                    com_TerminoPago_Info Obj = new com_TerminoPago_Info();
                    Obj.IdTerminoPago = item.IdTerminoPago;
                    Obj.Descripcion = item.Descripcion;
                    Obj.Estado = item.Estado;
                    Obj.Dias = item.Dias;
                    Lst.Add(Obj);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public string GetId()
        {
            try
            {
                int Id;
                EntitiesCompras_GE OECompras = new EntitiesCompras_GE();
                var select = from q in OECompras.com_TerminoPago
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in OECompras.com_TerminoPago
                                     select q.IdTerminoPago).Count();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                    Id = (Id == 0) ? 1 : Id;
                }
                return Id.ToString();

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

        public Boolean GuardarDB(com_TerminoPago_Info Info)
        {
            try
            {
                using (EntitiesCompras_GE Context = new EntitiesCompras_GE())
                {
                    var Address = new com_TerminoPago();

                    if (Info.IdTerminoPago != "" && Info.IdTerminoPago!="0")
                    {
                        Address.IdTerminoPago = Info.IdTerminoPago;
                    }
                    else
                    {
                        Address.IdTerminoPago = Info.IdTerminoPago = GetId();
                    }
                    
                    Address.Descripcion = Info.Descripcion;
                    Address.Estado = "A";
                    Address.Dias = Info.Dias;
                    //Address.IdUsuario = Info.IdUsuario;
                    //Address.nom_pc = Info.nom_pc;
                    //Address.ip = Info.ip;
                    Context.com_TerminoPago.Add(Address);
                    Context.SaveChanges();
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool ModificarDB(com_TerminoPago_Info info)
        {
            try
            {
                EntitiesCompras_GE context = new EntitiesCompras_GE();
                var contenido = context.com_TerminoPago.FirstOrDefault(var => var.IdTerminoPago == info.IdTerminoPago);
                if (contenido != null)
                {
                    contenido.Descripcion = info.Descripcion;
                    contenido.Dias = info.Dias;
                    contenido.Estado = info.Estado;
                    //contenido.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    //contenido.FechaUltMod = info.FechaUltMod;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }

        }

        public Boolean AnularDB(com_TerminoPago_Info Info)
        {
            try
            {
                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {

                    var contact = context.com_TerminoPago.FirstOrDefault(var => var.IdTerminoPago == Info.IdTerminoPago 
                        );

                    if (contact != null)
                    {
                        contact.Estado = "I";
                        //contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        //contact.Fecha_UltAnu = Info.FechaHoraAnul;
                        //contact.MotiAnula = Info.MotivoAnulacion;
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
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}

