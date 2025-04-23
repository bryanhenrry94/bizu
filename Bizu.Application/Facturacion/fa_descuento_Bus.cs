using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.Facturacion
{
    public class fa_descuento_Bus
    {
        fa_descuento_Data da = new fa_descuento_Data();

        public List<fa_descuento_Info> Get_Lista_Descuento(int IdEmpresa, ref string mensaje)
        {
            try
            {
                return da.Get_Lista_Descuento(IdEmpresa, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Lista_Descuento", ex.Message), ex) { EntityType = typeof(fa_descuento_Bus) };
            }
        }

        public Boolean GrabarBD(fa_descuento_Info Info, ref string mensaje)
        {
            try
            {
                return da.GrabarBD(Info, ref mensaje);
            }

            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(fa_descuento_Bus) };
            }

        }

        public Boolean ModificarBD(fa_descuento_Info Info, ref string mensaje)
        {
            try
            {
                return da.ModificarBD(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarBD", ex.Message), ex) { EntityType = typeof(fa_descuento_Bus) };
            }
        }


        public Boolean AnularBD(fa_descuento_Info Info, ref string mensaje)
        {
            try
            {
                return da.AnularBD(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularBD", ex.Message), ex) { EntityType = typeof(fa_descuento_Bus) };
            }
        }
    }
}
