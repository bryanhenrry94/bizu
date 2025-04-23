using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Compras;

namespace Bizu.Infrastructure.Compras
{    
    public class com_ordencompra_local_x_com_solicitud_compra_Data
    {

        public List<com_ordencompra_local_x_com_solicitud_compra_Info> GetList(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                List<com_ordencompra_local_x_com_solicitud_compra_Info> Lista = new List<com_ordencompra_local_x_com_solicitud_compra_Info>();

                EntitiesCompras_GE EntitiesComp = new EntitiesCompras_GE();

                var selec = from q in EntitiesComp.vwcom_ordencompra_local_x_com_solicitud_compra
                            where q.IdEmpresa_oc == IdEmpresa
                            && q.IdSucursal_oc == IdSucursal
                            && q.IdOrdenCompra_oc == IdOrdenCompra
                            select q;

                foreach(var item in selec)
                {
                    com_ordencompra_local_x_com_solicitud_compra_Info Info = new com_ordencompra_local_x_com_solicitud_compra_Info();
                    Info.IdEmpresa_oc = item.IdEmpresa_oc;
                    Info.IdSucursal_oc = item.IdSucursal_oc;
                    Info.IdOrdenCompra_oc = item.IdOrdenCompra_oc;
                    Info.IdEmpresa_sc = item.IdEmpresa_sc;
                    Info.IdSucursal_sc = item.IdSucursal_sc;
                    Info.IdSolicitudCompra_sc = item.IdSolicitudCompra_sc;
                    Info.Secuencia_sc = item.Secuencia_sc;
                    Info.IdProducto = item.IdProducto;
                    Info.Cantidad = item.Cantidad;

                    Lista.Add(Info);
                }

                return Lista;
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
                EntitiesCompras_GE EntitiesComp = new EntitiesCompras_GE();
                             
                foreach (var item in Lista)
                {
                    com_ordencompra_local_x_com_solicitud_compra Address = new com_ordencompra_local_x_com_solicitud_compra();
                    Address.IdEmpresa_oc = item.IdEmpresa_oc;
                    Address.IdSucursal_oc = item.IdSucursal_oc;
                    Address.IdOrdenCompra_oc = item.IdOrdenCompra_oc;
                    Address.IdEmpresa_sc = item.IdEmpresa_sc;
                    Address.IdSucursal_sc = item.IdSucursal_sc;
                    Address.IdSolicitudCompra_sc = item.IdSolicitudCompra_sc;
                    Address.Secuencia_sc = item.Secuencia_sc;
                    Address.Cantidad = item.Cantidad;

                    EntitiesComp.com_ordencompra_local_x_com_solicitud_compra.Add(Address);
                    EntitiesComp.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                mensajeError = ex.Message;
                throw ex;
            }
        }

        public Boolean Eliminar(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {                
                EntitiesCompras_GE EntitiesComp = new EntitiesCompras_GE();

                EntitiesComp.Database.ExecuteSqlCommand("DELETE FROM com_ordencompra_local_x_com_solicitud_compra WHERE IdEmpresa_oc = " + IdEmpresa + " and IdSucursal_oc = " + IdSucursal + " and IdOrdenCompra_oc = " + IdOrdenCompra);
             
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteOC(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                EntitiesCompras_GE context = new EntitiesCompras_GE();

                var query = from q in context.com_ordencompra_local_x_com_solicitud_compra
                            where q.IdEmpresa_oc == IdEmpresa
                            && q.IdSucursal_oc == IdSucursal
                            && q.IdOrdenCompra_oc == IdOrdenCompra
                            select q;

                if (query.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
