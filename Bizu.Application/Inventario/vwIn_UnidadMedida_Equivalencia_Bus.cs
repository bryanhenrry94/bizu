using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Inventario;
using Bizu.Infrastructure.Inventario;

namespace Bizu.Application.Inventario
{
    public class vwIn_UnidadMedida_Equivalencia_Bus
    {
        vwIn_UnidadMedida_Equivalencia_Data dataUni = new vwIn_UnidadMedida_Equivalencia_Data();

        public List<vwIn_UnidadMedida_Equivalencia_Info> Get_List_UnidadMedida_Equivalencia(string IdUnidadMedida)
        {
            try
            {
                return dataUni.Get_List_UnidadMedida_Equivalencia(IdUnidadMedida);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "get_LstUnidadEquivalencia", ex.Message), ex) { EntityType = typeof(vwIn_UnidadMedida_Equivalencia_Bus) };

            }
        }

        public List<vwIn_UnidadMedida_Equivalencia_Info> Get_List_UnidadMedida_Equivalencia_x_Uni_Consumo(string IdUnidadConsumo)
        {
            try
            {
                return dataUni.Get_List_UnidadMedida_Equivalencia_x_Uni_Consumo(IdUnidadConsumo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "get_LstUnidadConsumo", ex.Message), ex) { EntityType = typeof(vwIn_UnidadMedida_Equivalencia_Bus) };

            }
        }

        public vwIn_UnidadMedida_Equivalencia_Bus()
        {

        }
    }
}
