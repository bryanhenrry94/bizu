using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Compras;

namespace Bizu.Infrastructure.Compras
{
    public class com_solicitud_compra_det_x_com_ordencompra_local_det_Data
    {
        public List<com_solicitud_compra_det_x_com_ordencompra_local_det_Info> GetList()
        {
            try
            {
                List<com_solicitud_compra_det_x_com_ordencompra_local_det_Info> Lista = new List<com_solicitud_compra_det_x_com_ordencompra_local_det_Info>();

                //EntitiesCompras EntitiesCompra = new EntitiesCompras();

                //var selec = from q in EntitiesCompra.com_solicitud_compra_det_x_com_ordencompra_local_det
                //            select q;

                //foreach (var item in selec)
                //{
                //    com_solicitud_compra_det_x_com_ordencompra_local_det_Info Info = new com_solicitud_compra_det_x_com_ordencompra_local_det_Info();
                //    Info.IdEmpresa_oc = item.IdEmpresa_oc;
                //    Info.IdSucursal_oc = item.IdSucursal_oc;
                //    Info.IdOrdenCompra_oc = item.IdOrdenCompra_oc;
                //    Info.Secuencia_oc = item.Secuencia_oc;
                //    Info.IdEmpresa_sc = item.IdEmpresa_sc;
                //    Info.IdSucursal_sc = item.IdSucursal_sc;
                //    Info.IdSolicitudCompra_sc = item.IdSolicitudCompra_sc;
                //    Info.Secuencia_sc = item.Secuencia_sc;
                //    Info.Cantidad = item.Cantidad;

                //    Lista.Add(Info);
                //}

                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
