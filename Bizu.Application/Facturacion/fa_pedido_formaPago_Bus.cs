using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
    public class fa_pedido_formaPago_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        

        public Boolean GuardarDB(List<fa_factura_x_fa_TerminoPago_Info> Lista)
        {
            try
            {
                    return false;
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_pedido_formaPago_Bus) };
            }
        }

        public List<fa_factura_x_fa_TerminoPago_Info> ConsultaEspecifica(int IdEmpresa, int IdSucursal, int IdBodega, decimal Idtransaccion)
        {
            try
            {
                return new List<fa_factura_x_fa_TerminoPago_Info>();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaEspecifica", ex.Message), ex) { EntityType = typeof(fa_pedido_formaPago_Bus) };
          
            }
        }
    }
}
