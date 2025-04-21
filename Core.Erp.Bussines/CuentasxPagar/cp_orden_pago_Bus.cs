using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.Log_Exception;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_orden_pago_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        private cp_orden_pago_Data oData = new cp_orden_pago_Data();

        public bool AnularDB(cp_orden_pago_Info Info)
        {
            bool flag;
            try
            {
                flag = this.oData.AnularDB(Info);
            }
            catch (Exception exception)
            {
                LoggingManager.Logger.Log(LoggingCategory.Error, exception.Message);
                DalException exception2 = new DalException(string.Format("", "AnularDB", exception.Message), exception)
                {
                    EntityType = typeof(cp_orden_pago_Bus)
                };
                throw exception2;
            }
            return flag;
        }

        public bool Eliminar_OrdenPago(int IdEmpresa, decimal IdOrdenPago, ref string mensaje)
        {
            bool flag;
            try
            {
                flag = this.oData.Eliminar_OrdenPago(IdEmpresa, IdOrdenPago, ref mensaje);
            }
            catch (Exception exception)
            {
                LoggingManager.Logger.Log(LoggingCategory.Error, exception.Message);
                DalException exception2 = new DalException(string.Format("", "Eliminar_OrdenPago", exception.Message), exception)
                {
                    EntityType = typeof(cp_orden_pago_Bus)
                };
                throw exception2;
            }
            return flag;
        }

        public cp_orden_pago_Info Get_Info_orden_pago(int IdEmpresa, decimal IdOrdenPago, ref string mensaje)
        {
            cp_orden_pago_Info info;
            try
            {
                info = this.oData.Get_Info_orden_pago(IdEmpresa, IdOrdenPago, ref mensaje);
            }
            catch (Exception exception)
            {
                LoggingManager.Logger.Log(LoggingCategory.Error, exception.Message);
                DalException exception2 = new DalException(string.Format("", "Get_Info_orden_pago", exception.Message), exception)
                {
                    EntityType = typeof(cp_orden_pago_Bus)
                };
                throw exception2;
            }
            return info;
        }

        public List<cp_orden_pago_Info> Get_List_orden_pago(int IdEmpresa, DateTime fechaIni, DateTime fechaFin, ref string mensaje)
        {
            List<cp_orden_pago_Info> list;
            try
            {
                list = this.oData.Get_List_orden_pago(IdEmpresa, fechaIni, fechaFin, ref mensaje);
            }
            catch (Exception exception)
            {
                LoggingManager.Logger.Log(LoggingCategory.Error, exception.Message);
                DalException exception2 = new DalException(string.Format("", "Get_List_orden_pago", exception.Message), exception)
                {
                    EntityType = typeof(cp_orden_pago_Bus)
                };
                throw exception2;
            }
            return list;
        }

        public List<cp_orden_pago_Info> Get_List_orden_pago(int IdEmpresa, DateTime fechaIni, DateTime fechaFin, string IdUsuario, ref string mensaje)
        {
            List<cp_orden_pago_Info> list;
            try
            {
                list = this.oData.Get_List_orden_pago(IdEmpresa, fechaIni, fechaFin, IdUsuario, ref mensaje);
            }
            catch (Exception exception)
            {
                LoggingManager.Logger.Log(LoggingCategory.Error, exception.Message);
                DalException exception2 = new DalException(string.Format("", "Get_List_orden_pago", exception.Message), exception)
                {
                    EntityType = typeof(cp_orden_pago_Bus)
                };
                throw exception2;
            }
            return list;
        }
        
        public List<vwcp_Anticipos_x_NotaCred_Saldo_Info> Get_List_Orden_Pago_Anticipos_con_Saldos_Pagados(int IdEmpresa, decimal IdProveedor, ref string mensaje)
        {
            List<vwcp_Anticipos_x_NotaCred_Saldo_Info> list;
            try
            {
                list = this.oData.Get_List_Orden_Pago_Anticipos_con_Saldos_Pagados(IdEmpresa, IdProveedor, ref mensaje);
            }
            catch (Exception exception)
            {
                LoggingManager.Logger.Log(LoggingCategory.Error, exception.Message);
                DalException exception2 = new DalException(string.Format("", "Get_List_Orden_Pago_Anticipos_Saldos", exception.Message), exception)
                {
                    EntityType = typeof(cp_orden_pago_Bus)
                };
                throw exception2;
            }
            return list;
        }
        
        public Boolean GuardaDB(cp_orden_pago_Info InfoOP, ref decimal Id, ref string mensaje)
        {
            bool flag3;
            try
            {
                bool flag = false;
                if (this.Validar_y_corregir_objeto(InfoOP, ref mensaje))
                {
                    flag = this.oData.GuardaDB(InfoOP, ref Id, ref mensaje);
                }
                flag3 = flag;
            }
            catch (Exception exception)
            {
                LoggingManager.Logger.Log(LoggingCategory.Error, exception.Message);
                DalException exception2 = new DalException(string.Format("", "GrabarDB", exception.Message), exception)
                {
                    EntityType = typeof(cp_orden_pago_Bus)
                };
                throw exception2;
            }
            return flag3;
        }

        public bool Modificar_tipo_flujo(int IdEmpresa, decimal IdOrdenPago, Nullable<decimal> IdTipoFlujo)
        {
            bool flag;
            try
            {
                flag = this.oData.Modificar_tipo_flujo(IdEmpresa, IdOrdenPago, IdTipoFlujo);
            }
            catch (Exception exception)
            {
                LoggingManager.Logger.Log(LoggingCategory.Error, exception.Message);
                DalException exception2 = new DalException(string.Format("", "Modificar_tipo_flujo", exception.Message), exception)
                {
                    EntityType = typeof(cp_orden_giro_Bus)
                };
                throw exception2;
            }
            return flag;
        }
        
        public Boolean ModificarDB(cp_orden_pago_Info Info, ref string mensaje)
        {
            bool flag4;
            try
            {
                bool flag = false;
                cp_orden_pago_det_Bus bus = new cp_orden_pago_det_Bus();
                if (this.Validar_y_corregir_objeto(Info, ref mensaje))
                {
                    flag = this.oData.ModificarDB(Info, ref mensaje);
                    if (flag)
                    {
                        flag = bus.ModificarDB_Forma_Pago(Info.Detalle);
                    }
                }
                flag4 = flag;
            }
            catch (Exception exception)
            {
                LoggingManager.Logger.Log(LoggingCategory.Error, exception.Message);
                DalException exception2 = new DalException(string.Format("", "ModificarDB", exception.Message), exception)
                {
                    EntityType = typeof(cp_orden_pago_Bus)
                };
                throw exception2;
            }
            return flag4;
        }

        public Boolean ModificarDB_FormaPago(cp_orden_pago_Info Info, ref string mensaje)
        {
            bool flag2;
            try
            {
                flag2 = this.oData.ModificarDB_FormaPago(Info, ref mensaje);
            }
            catch (Exception exception)
            {
                LoggingManager.Logger.Log(LoggingCategory.Error, exception.Message);
                DalException exception2 = new DalException(string.Format("", "ModificarDB", exception.Message), exception)
                {
                    EntityType = typeof(cp_orden_pago_Bus)
                };
                throw exception2;
            }
            return flag2;
        }
        
        private Boolean Validar_y_corregir_objeto(cp_orden_pago_Info orden_pago_Info, ref string msg)
        {
            try
            {
                #region 'Validaciones'
                /*--- validaciones */


                if (orden_pago_Info.IdEmpresa <= 0)
                {
                    msg = "Error en la cabecera de fact uno de los PK es <=0";
                    return false;
                }


                if (orden_pago_Info.IdPersona <= 0)
                {
                    msg = "Erro en la cabecera  IdPersona es <=0";
                    return false;
                }

                if (orden_pago_Info.IdTipo_Persona == "")
                {
                    msg = "Erro en la cabecera  IdTipo_Persona en blanco";
                    return false;
                }


                if (orden_pago_Info.Detalle == null)
                {
                    msg = "la OP no tiene detalle ";
                    return false;
                }

                if (orden_pago_Info.Detalle.Count == 0)
                {
                    msg = "la OP no tiene detalle ";
                    return false;
                }

                if (orden_pago_Info.IdFormaPago == "" || orden_pago_Info.IdFormaPago == "Vacio" || orden_pago_Info.IdFormaPago == null)
                {
                    orden_pago_Info.IdFormaPago = "CHEQUE";
                }

                foreach (var item in orden_pago_Info.Detalle)
                {

                    if (item.IdFormaPago == "")
                    {
                        item.IdFormaPago = "CHEQUE";
                    }
                }


                /*--- corrigiendo data */

                #endregion

                return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_y_corregir_objeto", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }
        
    }
}