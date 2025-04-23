using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.ActivoFijo;
using Bizu.Domain.ActivoFijo;

namespace Bizu.Application.ActivoFijo
{
    public class Af_CambioUbicacion_Activo_Bus
    {
        Af_CambioUbicacion_Activo_Data dataCambio = new Af_CambioUbicacion_Activo_Data();
        Af_Activo_fijo_Data dataActivo = new Af_Activo_fijo_Data();

        public Boolean GuardarDB(Af_CambioUbicacion_Activo_Info Info, ref int IdCambioUbicacion, ref string msjError)
        {
            try
            {
                if (dataCambio.GuardarDB(Info, ref IdCambioUbicacion, ref  msjError))
                    return dataActivo.ModificarUbicacion(Info, ref msjError);
                else
                    return false;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Af_CambioUbicacion_Activo_Bus) };
            }
        }

        public Af_CambioUbicacion_Activo_Info Get_Info_CambioUbicacion(int IdEmpresa, int IdCambioUbicacion)
        {
            try
            {
                return dataCambio.Get_Info_CambioUbicacion(IdEmpresa, IdCambioUbicacion);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_CambioUbicacion", ex.Message), ex) { EntityType = typeof(Af_CambioUbicacion_Activo_Bus) };
            }
        }

        public Af_CambioUbicacion_Activo_Bus()
        {

        }
    }
}