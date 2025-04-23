using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Inventario;
using Bizu.Infrastructure.Inventario;

namespace Bizu.Application.Inventario
{
    public class in_GuiaRemision_Exportacion_Bus
    {
        in_GuiaRemision_Exportacion_Data Data = new in_GuiaRemision_Exportacion_Data();

        public Boolean Existe(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                return Data.Existe(IdEmpresa, IdSucursal, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarDB(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                return Data.EliminarDB(IdEmpresa, IdSucursal, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean GrabarDB(in_GuiaRemision_Exportacion_Info Info)
        {
            try
            {                
                return Data.GrabarDB(Info);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public in_GuiaRemision_Exportacion_Info Get_Info(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                return Data.Get_Info(IdEmpresa, IdSucursal, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
    }
}
