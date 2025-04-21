using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;

namespace Core.Erp.Business.Compras
{
    public class com_solicitud_compra_det_x_com_ordencompra_local_det_Bus
    {
        com_solicitud_compra_det_x_com_ordencompra_local_det_Data Data = new com_solicitud_compra_det_x_com_ordencompra_local_det_Data();

        public List<com_solicitud_compra_det_x_com_ordencompra_local_det_Info> GetList() 
        {
            try
            {
                return Data.GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
