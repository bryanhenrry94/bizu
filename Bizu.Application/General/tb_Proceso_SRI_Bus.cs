using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Application.General;
using Bizu.Infrastructure.General;
using Bizu.Domain.class_sri.FacturaV2;
using Bizu.Domain.class_sri.NotaCredito;
using Bizu.Domain.CuentasxCobrar;

namespace Bizu.Application.General
{
    public class tb_Proceso_SRI_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        tb_Proceso_SRI_Data odata = new tb_Proceso_SRI_Data();

        string mensaje = "";
        public factura Deserializar_factura_SRI(string path, ref string numAutorizacion, ref DateTime fechAutoriza, ref string mensaje)
        {
            try
            {
                return odata.Deserializar_factura_SRI(path, ref numAutorizacion, ref fechAutoriza, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Deserializar_factura_SRI", ex.Message), ex) { EntityType = typeof(tb_Proceso_SRI_Bus) };
            }


        }

        public factura Deserializar_factura_SRI_xml(string xml, ref string numAutorizacion, ref DateTime fechAutoriza, ref string mensaje)
        {
            try
            {
                return odata.Deserializar_factura_SRI_xml(xml, ref numAutorizacion, ref fechAutoriza, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Deserializar_factura_SRI", ex.Message), ex) { EntityType = typeof(tb_Proceso_SRI_Bus) };
            }


        }

        public vwcxc_cobros_x_vta_nota_x_Ret_Info Deserializar_factura_SRI_Poli(string path, ref string numAutorizacion, ref DateTime fechAutoriza, ref string mensaje)
        {
            try
            {
                return odata.Deserializar_factura_SRI_Poli(path, ref numAutorizacion, ref fechAutoriza, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Deserializar_factura_SRI", ex.Message), ex) { EntityType = typeof(tb_Proceso_SRI_Bus) };
            }


        }

        public notaCredito Deserializar_NotaCredito_SRI(string path, ref string numAutorizacion, ref DateTime fechAutoriza)
        {
            try
            {
                return odata.Deserializar_NotaCredito_SRI(path, ref numAutorizacion, ref fechAutoriza);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Deserializar_NotaCredito_SRI", ex.Message), ex) { EntityType = typeof(tb_Proceso_SRI_Bus) };

            }


        }

        public notaCredito Deserializar_NotaCredito_SRI_xml(string xml, ref string numAutorizacion, ref DateTime fechAutoriza, ref string mensaje)
        {
            try
            {
                return odata.Deserializar_NotaCredito_SRI_xml(xml, ref numAutorizacion, ref fechAutoriza, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Deserializar_NotaCredito_SRI", ex.Message), ex) { EntityType = typeof(tb_Proceso_SRI_Bus) };
            }
        }
    }
}