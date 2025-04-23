using Bizu.Infrastructure.Inventario;
using Bizu.Domain.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Application.General;

namespace Bizu.Application.Inventario
{
    public class SpIn_DispInventario_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        SpIn_DispInventario_Data data = new SpIn_DispInventario_Data();
        public List<SpIn_DispInventario_Info> Get_List_In_DispInventario(Nullable<DateTime> Fecha, Nullable<int> IdSucursal, Nullable<int> IdBodega, int IdEmpresa, string Categorias, string IdUsuario)
        {
            try
            {
            return data.Get_List_In_DispInventario(Fecha, IdSucursal, IdBodega, IdEmpresa, Categorias, IdUsuario);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(SpIn_DispInventario_Bus) };

            }
          
        }
    }
}
