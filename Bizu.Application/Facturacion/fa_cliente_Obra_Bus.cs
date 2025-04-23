using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;

namespace Bizu.Application.Facturacion
{
    public class fa_cliente_Obra_Bus
    {
        fa_cliente_Obra_Data Data = new fa_cliente_Obra_Data();

        public bool GrabarDB(List<fa_cliente_Obra_Info> Info, ref string mensaje)
        {
            try
            {
                return Data.GrabarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<fa_cliente_Obra_Info> Get_Info_x_Estado(int IdEmpresa, decimal IdCliente, string IdEstadoObra)
        {
            try
            {
                return Data.Get_Info_x_Estado(IdEmpresa, IdCliente, IdEstadoObra);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<fa_cliente_Obra_Info> Get_Info(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                return Data.Get_Info(IdEmpresa, IdCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public fa_cliente_Obra_Info Get_Info(int IdEmpresa, decimal IdCliente, string IdCentroCosto)
        {
            try
            {
                return Data.Get_Info(IdEmpresa, IdCliente, IdCentroCosto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<fa_cliente_Obra_Info> Get_List(int IdEmpresa, string IdCentroCosto)
        {
            try
            {
                return Data.Get_List(IdEmpresa, IdCentroCosto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                return Data.EliminarDB(IdEmpresa, IdCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
