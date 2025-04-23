using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Application.General;


namespace Bizu.Application.Facturacion
{
   public class fa_formaPago_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_formaPago_Data Data = new fa_formaPago_Data();



        public List<fa_formaPago_Info> Get_List_fa_formaPago()
        {
            try
            {

                return Data.Get_List_fa_formaPago();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_formaPago_Bus) };
                
            }
        }

        public Boolean GuardarDB(fa_formaPago_Info Info, ref string msjError)
        {
            try
            {
                return Data.GuardarDB(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_formaPago_Bus) };
            }
        }

        public bool ModificarDB(fa_formaPago_Info info, ref string msjError)
        {
            try
            {
                return Data.ModificarDB(info, ref msjError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_formaPago_Bus) };
            }
        }


    }
}
