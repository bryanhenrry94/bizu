using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Application.General;
using Bizu.Domain.General;


namespace Bizu.Application.Facturacion
{
    public class fa_factura_x_ct_cbtecble_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_factura_x_ct_cbtecble_Data data = new fa_factura_x_ct_cbtecble_Data();

        public fa_factura_x_ct_cbtecble_Info Get_info_fa_factura_x_ct_cbtecble(int IdEmpresa, int IdSucuersal, int IdBodega, decimal IdCbteVta, Cl_Enumeradores.eMotivo_Diario_x_Vta Motivo)
        {
            try
            {
                return data.Get_info_fa_factura_x_ct_cbtecble(IdEmpresa, IdSucuersal, IdBodega, IdCbteVta, Motivo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Obtener", ex.Message), ex) { EntityType = typeof(fa_factura_x_ct_cbtecble_Bus) };
            }
           
        }
        
    }
}
