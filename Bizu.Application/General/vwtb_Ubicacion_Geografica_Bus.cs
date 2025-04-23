using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Application.General
{
    public class vwtb_Ubicacion_Geografica_Bus
    {
        vwtb_Ubicacion_Geografica_Data data_Ubi = new vwtb_Ubicacion_Geografica_Data();

        public List<vwtb_Ubicacion_Geografica_Info> Get_List_Ubicacion_Geo()
        {
            try
            {
                return data_Ubi.Get_List_Ubicacion_Geo();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "get_Lst_UbicacionGeo", ex.Message), ex) { EntityType = typeof(vwtb_Ubicacion_Geografica_Bus) };
           
            }
        }


        public vwtb_Ubicacion_Geografica_Bus()
        {

        }
    }
}
