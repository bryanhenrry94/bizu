using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;

namespace Bizu.Application.Facturacion
{
    public class vwFa_Documentos_x_Relacionar_NC_ND_Bus
    {
        vwFa_Documentos_x_Relacionar_NC_ND_Data data = new vwFa_Documentos_x_Relacionar_NC_ND_Data();

        public List<vwFa_Documentos_x_Relacionar_NC_ND_Info> Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo(int IdEmpresa, int IdSucursal, decimal IdCliente)
        {
            try
            {
                return data.Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo(IdEmpresa, IdSucursal, IdCliente);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo", ex.Message), ex) { EntityType = typeof(vwFa_Documentos_x_Relacionar_NC_ND_Bus) };
            }

        }

        public List<vwFa_Documentos_x_Relacionar_NC_ND_Info> Get_List_Cobros_CredDeb_Conciliados(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                return data.Get_List_Cobros_CredDeb_Conciliados(IdEmpresa, IdSucursal, IdBodega, IdNota);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "get_List_Cobros_CredDeb_Conciliados", ex.Message), ex) { EntityType = typeof(vwFa_Documentos_x_Relacionar_NC_ND_Bus) };
          
            }
        }

    }
}
