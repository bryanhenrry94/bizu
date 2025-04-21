using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Academico
{
    public class Aca_Rubro_x_fa_descuento_Bus
    {
        Aca_Rubro_x_fa_descuento_Data odata = new Aca_Rubro_x_fa_descuento_Data();

        public List<Aca_Rubro_x_fa_descuento_Info> Get_Lista(int IdInstitucion, int IdRubro, int IdEmpresa, decimal IdDescuento)
        {
            try
            {
                return odata.Get_Lista(IdInstitucion, IdRubro, IdEmpresa, IdDescuento);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(Aca_Rubro_x_fa_descuento_Bus) };
            }   
        }

        public bool GuardarDB(Aca_Rubro_x_fa_descuento_Info info, ref string mensaje)
        {
            try
            {
                return odata.GuardarDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(Aca_Rubro_x_fa_descuento_Bus) };
            }   
        }
        public bool EliminarBD(Aca_Rubro_x_fa_descuento_Info info, ref string mensaje)
        {
            try
            {
                return odata.EliminarBD(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(Aca_Rubro_x_fa_descuento_Bus) };
            }   
        }
        public bool GuardarDB(List<Aca_Rubro_x_fa_descuento_Info> lst, ref string mensaje)
        {
            try
            {
                return odata.GuardarDB(lst, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(Aca_Rubro_x_fa_descuento_Bus) };
            }   
        }

        public bool AnularDB(Aca_Rubro_x_fa_descuento_Info info, ref string msj)
        {
            try
            {
                return odata.AnularDB(info, ref msj);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(Aca_Rubro_x_fa_descuento_Bus) };
            }   
        }

    }
}
