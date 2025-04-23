using Bizu.Infrastructure.Caja;
using Bizu.Domain.Caja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.Caja
{
    public class caj_catalogo_Bus
    {
        caj_catalogo_Data data = new caj_catalogo_Data();

        public List<caj_catalogo_Info> Lista_catalogo()
        {
            try
            {
                return data.Lista_catalogo();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Lista_Catalogo", ex.Message), ex) { EntityType = typeof(caj_catalogo_Bus) };
            }
        }

        public List<caj_catalogo_Info> Lista_catalogo(string IdCatalogo_cj_tipo)
        {
            try
            {
                return data.Lista_catalogo(IdCatalogo_cj_tipo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Lista_Catalogo", ex.Message), ex) { EntityType = typeof(caj_catalogo_Bus) };
            }
        }
    }
}
