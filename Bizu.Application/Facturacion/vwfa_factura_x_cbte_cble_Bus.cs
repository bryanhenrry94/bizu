using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Application.General;


namespace Bizu.Application.Facturacion
{
   public class vwfa_factura_x_cbte_cble_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwfa_factura_x_cbte_cble_Data Data = new vwfa_factura_x_cbte_cble_Data();

        public List<vwfa_factura_x_cbte_cble_Info> Get_List_factura_x_cbte_cble(int IdEmpresa, DateTime Fecha_Ini, DateTime Fecha_Fin, bool Mostar_no_contabilizado)
       {
            try
            {
                return Data.Get_List_factura_x_cbte_cble(IdEmpresa, Fecha_Ini, Fecha_Fin, Mostar_no_contabilizado);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_catalogo_Bus) };
            }

        }

    }
}
