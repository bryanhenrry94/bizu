using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxCobrar
{
    public class cxc_cobro_tipo_x_cobros_Docxc_Bus
    {
        
        cxc_cobro_tipo_x_cobros_Docxc_Data data = new cxc_cobro_tipo_x_cobros_Docxc_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<cxc_cobro_tipo_x_cobros_Docxc_Info> ObtenerLista(ref string mensaje)
        {
            try
            {
                return data.Get_List_cobro_tipo_x_cobros_Docxc(ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerLista", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_x_cobros_Docxc_Bus) };
            }
        }

        public List<cxc_cobro_tipo_Info> ObtenerListaDescripcion()
        {
            try
            {
                return data.Get_List_cobro_tipo();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerListaDescripcion", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_x_cobros_Docxc_Bus) };
            }
        }

        public Boolean Modificar(cxc_cobro_tipo_x_cobros_Docxc_Info Info)
        {
           
            try
            {
                return data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_x_cobros_Docxc_Bus) };
            }
        }

        public Boolean Guardar(cxc_cobro_tipo_x_cobros_Docxc_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_x_cobros_Docxc_Bus) };
            }
        }

        public Boolean GuardarLista(List<cxc_cobro_tipo_x_cobros_Docxc_Info> lst)
        {
            try
            {
                foreach (cxc_cobro_tipo_x_cobros_Docxc_Info item in lst)
                {
                     data.GuardarDB(item);
                }
                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarLista", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_x_cobros_Docxc_Bus) };
            }
        }

        public Boolean Eliminar(cxc_cobro_tipo_x_cobros_Docxc_Info Info)
        {
            try
            {

                return data.EliminarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Eliminar", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_x_cobros_Docxc_Bus) };
            }
        }

        public Boolean EliminarLista(List<cxc_cobro_tipo_x_cobros_Docxc_Info> lst)
        {
            try
            {
                foreach (cxc_cobro_tipo_x_cobros_Docxc_Info item in lst)
                {
                    data.EliminarDB(item);
                }
                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarLista", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_x_cobros_Docxc_Bus) };
            }
        }

    }
}
