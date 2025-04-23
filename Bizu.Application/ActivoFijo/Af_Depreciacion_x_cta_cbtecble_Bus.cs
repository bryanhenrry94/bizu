using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.ActivoFijo;
using Bizu.Domain.ActivoFijo;

namespace Bizu.Application.ActivoFijo
{
    public class Af_Depreciacion_x_cta_cbtecble_Bus
    {
        Af_Depreciacion_x_cta_cbtecble_Data dataDepre = new Af_Depreciacion_x_cta_cbtecble_Data();

        public Boolean GuardarDB(Af_Depreciacion_x_cta_cbtecble_Info infoCbteCble)
        {
            try
            {
                return dataDepre.GuardarDB(infoCbteCble);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarCbteCble", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_x_cta_cbtecble_Bus) };
            }
        }

        public Af_Depreciacion_x_cta_cbtecble_Info Get_Info_Af_Depreciacion_x_cta_cbtecble(int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion)
        {
            try
            {
                return dataDepre.Get_Info_Af_Depreciacion_x_cta_cbtecble(IdEmpresa, IdDepreciacion, IdTipoDepreciacion);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_Af_Depreciacion_x_cta_cbtecble", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_x_cta_cbtecble_Bus) };
            }
        }

        public Af_Depreciacion_x_cta_cbtecble_Bus()
        {

        }
    }
}
