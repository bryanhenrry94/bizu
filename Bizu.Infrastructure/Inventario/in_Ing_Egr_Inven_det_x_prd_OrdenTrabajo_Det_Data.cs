using Bizu.Infrastructure;
using Bizu.Domain.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Bizu.Infrastructure.Inventario
{
    public class in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Data
    {
        public List<in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Info> Get_List(int IdEmpresa, int IdSucursal, decimal IdOrdenTrabajo)
        {
            List<in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Info> list = new List<in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Info>();

            try
            {
                using (EntitiesInventario inventario = new EntitiesInventario())
                {
                    var query = from q in inventario.in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det
                                where q.IdEmpresa_ot == IdEmpresa
                                && q.IdSucursal_ot == IdSucursal
                                && q.IdOrdenTrabajo_ot == IdOrdenTrabajo
                                select q;

                    foreach (var det in query)
                    {
                        in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Info item = new in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Info();
                        item.IdEmpresa_inv = det.IdEmpresa_inv;
                        item.IdSucursal_inv = det.IdSucursal_inv;
                        item.IdMovi_inven_tipo_inv = det.IdMovi_inven_tipo_inv;
                        item.IdNumMovi_inv = det.IdNumMovi_inv;
                        item.Secuencia_inv = det.Secuencia_inv;
                        item.IdEmpresa_ot = det.IdEmpresa_ot;
                        item.IdSucursal_ot = det.IdSucursal_ot;
                        item.IdOrdenTrabajo_ot = det.IdOrdenTrabajo_ot;
                        item.Secuencia_ot = det.Secuencia_ot;
                        list.Add(item);
                    }
                }
            }
            catch (Exception exception1)
            {
                throw new Exception(exception1.Message);
            }
            return list;
        }

        public bool GrabarBD(List<in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Info> List_Info, ref string mensaje)
        {
            bool flag;

            try
            {
                using (EntitiesInventario inventario = new EntitiesInventario())
                {
                    foreach (in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_Info info in List_Info)
                    {
                        in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det entity = new in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det
                        {
                            IdEmpresa_inv = info.IdEmpresa_inv,
                            IdSucursal_inv = info.IdSucursal_inv,
                            IdMovi_inven_tipo_inv = info.IdMovi_inven_tipo_inv,
                            IdNumMovi_inv = info.IdNumMovi_inv,
                            Secuencia_inv = info.Secuencia_inv,
                            IdEmpresa_ot = info.IdEmpresa_ot,
                            IdSucursal_ot = info.IdSucursal_ot,
                            IdOrdenTrabajo_ot = info.IdOrdenTrabajo_ot,
                            Secuencia_ot = info.Secuencia_ot
                        };
                        inventario.in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det.Add(entity);
                        inventario.SaveChanges();
                    }
                }
                flag = true;
            }
            catch (Exception exception1)
            {
                throw new Exception(exception1.Message);
            }
            return flag;
        }
    }
}