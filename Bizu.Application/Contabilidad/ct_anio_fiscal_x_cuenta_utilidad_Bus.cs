using Bizu.Infrastructure.Contabilidad;
using Bizu.Domain.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.Contabilidad
{
    public class ct_anio_fiscal_x_cuenta_utilidad_Bus
    {
        ct_anio_fiscal_x_cuenta_utilidad_Data oData = new ct_anio_fiscal_x_cuenta_utilidad_Data();
        public ct_anio_fiscal_x_cuenta_utilidad_Info Get_Info_anioF_x_Cta(int Idempresa, int IdanioFiscal, ref string mensaje)
        {
            try
            {
                return oData.Get_Info_anioF_x_Cta(Idempresa, IdanioFiscal, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Lista_anioF_x_Cta", ex.Message), ex) { EntityType = typeof(ct_anio_fiscal_x_cuenta_utilidad_Bus) };
            }
        }



        public bool GuardarDB(ct_anio_fiscal_x_cuenta_utilidad_Info Info, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ct_anio_fiscal_x_cuenta_utilidad_Bus) };
            }
        }

        public bool ModificarDB(ct_anio_fiscal_x_cuenta_utilidad_Info Info, ref string mensaje)
        {
            try
            {
                return oData.ModificiarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_anio_fiscal_x_cuenta_utilidad_Bus) };
            }
        }


        public bool ModificiarDB_CbteCierre(ct_anio_fiscal_x_cuenta_utilidad_Info Info, ref string mensaje)
        {
            try
            {
                return oData.ModificiarDB_CbteCierre(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_anio_fiscal_x_cuenta_utilidad_Bus) };
            }

        }
    }
}
