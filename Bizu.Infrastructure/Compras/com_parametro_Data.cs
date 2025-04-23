using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Compras;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Infrastructure.Compras
{
    public class com_parametro_Data
    {

        string mensaje = "";

        public com_parametro_Info Get_Info_parametro(int IdEmpresa)
        {
            try
            {
                List<com_parametro_Info> list = new List<com_parametro_Info>();
                EntitiesCompras_GE oEnti = new EntitiesCompras_GE();
                com_parametro_Info Obj = new com_parametro_Info();
                var Query = from q in oEnti.com_parametro
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdEstadoAprobacion_OC = item.IdEstadoAprobacion_OC;
                    Obj.IdMovi_inven_tipo_OC = item.IdMovi_inven_tipo_OC;
                    Obj.IdEstadoAnulacion_OC = item.IdEstadoAnulacion_OC;
                    Obj.IdMovi_inven_tipo_dev_compra = item.IdMovi_inven_tipo_dev_compra;
                    Obj.IdEstadoAprobacion_SolCompra = item.IdEstadoAprobacion_SolCompra;
                    Obj.IdSucursal_x_Aprob_x_SolComp = Convert.ToInt32(item.IdSucursal_x_Aprob_x_SolComp);
                    Obj.IdEstado_cierre = item.IdEstado_cierre;
                    Obj.default_dias_plazo = item.default_dias_plazo;
                    Obj.default_dias_vencidos = item.default_dias_vencidos;
                    Obj.NotificaAprobacionOC = item.NotificaAprobacionOC;
                    Obj.NotificaAprobacionOCAuto = item.NotificaAprobacionOCAuto;
                }
                return Obj;

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

        public List<com_parametro_Info> Get_List_parametro(int IdEmpresa)
        {
            try
            {

                List<com_parametro_Info> list = new List<com_parametro_Info>();
                EntitiesCompras_GE oEnti = new EntitiesCompras_GE();

                com_parametro_Info Obj = new com_parametro_Info();


                var Query = from q in oEnti.com_parametro
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdEstadoAprobacion_OC = item.IdEstadoAprobacion_OC;
                    Obj.IdMovi_inven_tipo_OC = item.IdMovi_inven_tipo_OC;
                    Obj.IdEstadoAnulacion_OC = item.IdEstadoAnulacion_OC;
                    Obj.IdMovi_inven_tipo_dev_compra = item.IdMovi_inven_tipo_dev_compra;
                    Obj.IdEstadoAprobacion_SolCompra = item.IdEstadoAprobacion_SolCompra;
                    Obj.IdSucursal_x_Aprob_x_SolComp = Convert.ToInt32(item.IdSucursal_x_Aprob_x_SolComp);
                    Obj.IdEstado_cierre = item.IdEstado_cierre;
                    Obj.default_dias_plazo = item.default_dias_plazo;
                    Obj.default_dias_vencidos = item.default_dias_vencidos;
                    Obj.NotificaAprobacionOC = item.NotificaAprobacionOC;
                    Obj.NotificaAprobacionOCAuto = item.NotificaAprobacionOCAuto;

                    list.Add(Obj);

                }
                return list;

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

        public Boolean GuardarDB(com_parametro_Info Info, ref string msg)
        {
            try
            {
                using (EntitiesCompras_GE Context = new EntitiesCompras_GE())
                {
                    var Address = new com_parametro();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdEstadoAprobacion_OC = Info.IdEstadoAprobacion_OC;
                    Address.IdMovi_inven_tipo_OC = Info.IdMovi_inven_tipo_OC;
                    Address.IdEstadoAnulacion_OC = Info.IdEstadoAnulacion_OC;
                    Address.IdMovi_inven_tipo_dev_compra = Info.IdMovi_inven_tipo_dev_compra;
                    Address.IdEstadoAprobacion_SolCompra = Info.IdEstadoAprobacion_SolCompra;
                    Address.IdSucursal_x_Aprob_x_SolComp = Info.IdSucursal_x_Aprob_x_SolComp;
                    Address.IdEstado_cierre = Info.IdEstado_cierre;
                    Address.default_dias_plazo = Info.default_dias_plazo;
                    Address.default_dias_vencidos = Info.default_dias_vencidos;
                    Address.NotificaAprobacionOC = Info.NotificaAprobacionOC;
                    Address.NotificaAprobacionOCAuto = Info.NotificaAprobacionOCAuto;

                    Context.com_parametro.Add(Address);
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(com_parametro_Info Info, ref string msg)
        {
            try
            {

                using (EntitiesCompras_GE context = new EntitiesCompras_GE())
                {
                    var contact = context.com_parametro.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa);
                    if (contact != null)
                    {
                        contact.IdEmpresa = Info.IdEmpresa;
                        contact.IdEstadoAprobacion_OC = Info.IdEstadoAprobacion_OC;
                        contact.IdMovi_inven_tipo_OC = Info.IdMovi_inven_tipo_OC;
                        contact.IdEstadoAnulacion_OC = Info.IdEstadoAnulacion_OC;
                        contact.IdMovi_inven_tipo_dev_compra = Info.IdMovi_inven_tipo_dev_compra;
                        contact.IdEstadoAprobacion_SolCompra = Info.IdEstadoAprobacion_SolCompra;
                        contact.IdSucursal_x_Aprob_x_SolComp = Info.IdSucursal_x_Aprob_x_SolComp;
                        contact.IdEstado_cierre = Info.IdEstado_cierre;
                        contact.default_dias_plazo = Info.default_dias_plazo;
                        contact.default_dias_vencidos = Info.default_dias_vencidos;
                        contact.NotificaAprobacionOC = Info.NotificaAprobacionOC;
                        contact.NotificaAprobacionOCAuto = Info.NotificaAprobacionOCAuto;

                        context.SaveChanges();
                        msg = "Se ha procedido a modificar el registro exitosamente";
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
                mensaje = ex.ToString();

                msg = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public com_parametro_Data()
        {

        }
    }
}
