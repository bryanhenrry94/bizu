using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_orden_pago_x_empleado_x_nomina_x_periodo_Data
    {
        public Boolean GuardarDB(cp_orden_pago_x_empleado_x_nomina_x_periodo_Info info, ref string mensaje)
        {
            try
            {
                    using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                    {
                        cp_orden_pago_x_empleado_x_nomina_x_periodo Address = new cp_orden_pago_x_empleado_x_nomina_x_periodo();

                        Address.IdEmpresa = info.IdEmpresa;
                        Address.IdOrdenPago = info.IdOrdenPago;
                        Address.IdPersona = info.IdPersona;
                        Address.IdEmpleado = info.IdEmpleado;
                        Address.IdNomina_Tipo = info.IdNomina_Tipo;
                        Address.IdNomina_TipoLiqui = info.IdNomina_TipoLiqui;
                        Address.IdPeriodo = info.IdPeriodo;
                        Address.IdTipoFlujo = info.IdTipoFlujo;
                        Address.IdTipo_op = info.IdTipo_op;
                        Address.Valor = info.Valor;
                        Address.Estado = "A";

                        Context.cp_orden_pago_x_empleado_x_nomina_x_periodo.Add(Address);
                        Context.SaveChanges();
                    }
                
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                //string mensaje_error = "";
                string arreglo = ToString();
                foreach (var inf in ex.EntityValidationErrors)
                {
                    foreach (var info_validaciones in inf.ValidationErrors)
                    {
                        mensaje = "Propiedad: " + info_validaciones.PropertyName + " Mensaje: " + info_validaciones.ErrorMessage + "\n";
                    }
                }
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool ModificarDB(cp_orden_pago_x_empleado_x_nomina_x_periodo_Info info, ref string mensaje)
        {
            try
            {
                EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                var contenido = context.cp_orden_pago_x_empleado_x_nomina_x_periodo.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdOrdenPago == info.IdOrdenPago 
                    && var.IdEmpleado == info.IdEmpleado && var.IdPersona == info.IdPersona 
                    && var.IdNomina_Tipo == info.IdNomina_Tipo && var.IdNomina_TipoLiqui == info.IdNomina_TipoLiqui && var.IdPeriodo == info.IdPeriodo);
                if (contenido != null)
                {
                    contenido.IdNomina_Tipo = info.IdNomina_Tipo;
                    contenido.IdNomina_TipoLiqui = info.IdNomina_TipoLiqui;
                    contenido.IdPeriodo = info.IdPeriodo;
                    //contenido.IdUsuarioUltMod = info.IdUsuarioUltMod;
                    //contenido.FechaUltMod = info.FechaUltMod;
                    //contenido.MotiAnula = info.MotiAnula;
                    context.SaveChanges();
                }
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                //string mensaje_error = "";
                string arreglo = ToString();
                foreach (var inf in ex.EntityValidationErrors)
                {
                    foreach (var info_validaciones in inf.ValidationErrors)
                    {
                        mensaje = "Propiedad: " + info_validaciones.PropertyName + " Mensaje: " + info_validaciones.ErrorMessage + "\n";
                    }
                }
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        //public Boolean AnularDB(fa_catalogo_Info Info, ref string msjError)
        //{
        //    try
        //    {
        //        using (EntitiesFacturacion context = new EntitiesFacturacion())
        //        {
        //            var contact = context.fa_catalogo.FirstOrDefault(var => var.IdCatalogo == Info.IdCatalogo && var.IdCatalogo_tipo == Info.IdCatalogo_tipo);

        //            if (contact != null)
        //            {
        //                contact.Estado = "I";
        //                contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
        //                contact.Fecha_UltAnu = Info.Fecha_UltAnu;
        //                contact.MotiAnula = Info.MotiAnula;
        //                context.SaveChanges();
        //            }
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
        //        mensaje = ex.ToString();
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        msjError = mensaje;
        //        throw new Exception(ex.ToString());
        //    }
        //}




    }
}
