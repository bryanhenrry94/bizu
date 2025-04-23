using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.General;
using Bizu.Domain.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.Facturacion
{
    
    public class fa_cliente_contactos_Bus
    {
        fa_cliente_contactos_Data Data = new fa_cliente_contactos_Data();

        public Boolean GuardarDB(fa_cliente_contactos_Info Info, ref string msjError)
        {
            try
            {
                return Data.GuardarDB(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "fa_cliente_tipo_Bus", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public Boolean GuardarDB(List<fa_cliente_contactos_Info> Lista, ref string mensaje)
        {
            try
            {
                return Data.GuardarDB(Lista, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "fa_cliente_tipo_Bus", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdCliente, ref string msg)
        {
            try
            {
                return Data.EliminarDB(IdEmpresa,IdCliente, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "fa_cliente_tipo_Bus", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public bool ExisteCliente(int idEmpresa, decimal idCliente, decimal idContacto, ref string mensaje)
        {
            try
            {
                return Data.ExisteCliente(idEmpresa, idCliente, idContacto, ref mensaje);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteCliente", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public List<tb_contacto_Info> Get_List_Contactos_x_Clientes(int IdEmpresa, decimal Idcliente)
        {
            try
            {
                return Data.Get_List_Contactos_x_Clientes(IdEmpresa,Idcliente);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteCliente", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

    }

}
