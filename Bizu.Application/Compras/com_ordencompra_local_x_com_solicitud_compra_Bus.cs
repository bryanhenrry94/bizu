using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Compras;
using Bizu.Infrastructure.Compras;

namespace Bizu.Application.Compras
{
    public class com_ordencompra_local_x_com_solicitud_compra_Bus
    {
        com_ordencompra_local_x_com_solicitud_compra_Data Data = new com_ordencompra_local_x_com_solicitud_compra_Data();

        public List<com_ordencompra_local_x_com_solicitud_compra_Info> GetList(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                return Data.GetList(IdEmpresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Eliminar(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                return Data.Eliminar(IdEmpresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Grabar(List<com_ordencompra_local_x_com_solicitud_compra_Info> Lista, ref string mensajeError)
        {
            try
            {
                return Data.Grabar(Lista, ref mensajeError);
            }
            catch (Exception ex)
            {
                mensajeError = ex.Message;
                throw ex;
            }
        }

        public bool ExisteOC(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                return this.Data.ExisteOC(IdEmpresa, IdSucursal, IdOrdenCompra);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
